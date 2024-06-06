<?php

$host = $_POST['host'] ?? null;
$port = $_POST['port'] ?? null;
$rawAmount = $_POST['amount'] ?? null;
$delay = isset($_POST['delay']) ? intval($_POST['delay']) : 100000; 

$amount = is_null($rawAmount) ? null : number_format((float)$rawAmount, 2, '.', '');

header('Content-Type: application/json');


$socket = socket_create(AF_INET, SOCK_STREAM, 0);
socket_set_option($socket, SOL_SOCKET, SO_RCVTIMEO, ['sec' => $timeout, 'usec' => 0]);
try {
    $conected = @socket_connect($socket, $host, $port);
    if (!$conected) {
        throw new Exception("Failed to connect to the socket: " . socket_strerror(socket_last_error()));
    }

    // PingDevice
    $data = "\0{\"method\":\"PingDevice\",\"step\":0}\0";
    socket_write($socket, $data, strlen($data));
usleep($delay);
    while (true) {
       
       $responsePing = socket_read($socket, 1024);
       if ($responsePing === false) {
        break;
        }

       if ($responsePing === '') {
        break;
        }

if (strpos($responsePing, "\0") !== false) {
 break;
        
}


    }
    
    //usleep($delay);
   

    // GetTerminalInfo
    $data = "\0{\"method\":\"GetTerminalInfo\",\"step\":0}\0";
    socket_write($socket, $data, strlen($data));
usleep($delay);
    while (true) {
       $responseInfo = socket_read($socket, 1024);

if ($responseInfo === false) {
        break;
        }

       if ($responseInfo === '') {
        break;
        }
if (strpos($responseInfo, "\0") !== false) {
 break;
        
}

    }
    
    //usleep($delay);
    

} catch (\Throwable $th) {
    echo "{\"is_conected\": false}";
    exit();
}

if (!$amount) {
    echo "{\"is_conected\": true}";
    exit();
}



if ($amount) {
    $timeout = 30; 
    

    $data = "\0{ \"method\": \"Purchase\",\"step\": 0,\"params\": {\"amount\": \"$amount\",\"discount\": \"\",\"merchantId\":\"0\",\"facepay\": \"false\" }}\0";
    socket_write($socket, $data, strlen($data));

    $response = '';
    $start_time = time();

    while (true) {


        $buffer = socket_read($socket, 1024);
        if ($buffer === false) {
            break;
        }

        $response .= $buffer;
       
        if (strpos($response, "\0") !== false && strpos($response, "Purchase") !== false) {
       
            $res = substr($response, 0, -1); 

            echo $res;

            break;
        }

        if ((time() - $start_time) >= $timeout) {
            echo "Timeout occurred while waiting for response.\n";
            break;
        }

        usleep($delay);

    }
}
?>
