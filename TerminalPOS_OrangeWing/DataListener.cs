using System;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace TerminalPOS_Orangewing
{
    public class DataListener
    {
        public event EventHandler<stringEventArgs> ExternalAmount;
        private const int _port = 12345;
        private readonly RoundTextBox _logTextBox;
        private Socket _serverSocket;

        public DataListener(RoundTextBox textBox)
        {
            _logTextBox = textBox;
        }

        public void StartServer()
        {
            try
            {
                _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, _port);
                _serverSocket.Bind(localEndPoint);
                _serverSocket.Listen(10);
                _serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), _serverSocket);
            }
            catch (Exception ex)
            {
                ShowErrorMessageBox(ex.Message);
            }
        }

        private void AcceptCallback(IAsyncResult ar)
        {
            try
            {
                Socket listener = (Socket)ar.AsyncState;
                Socket handler = listener.EndAccept(ar);

                byte[] buffer = new byte[1024];
                int bytesRead = handler.Receive(buffer);
                string receivedData = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                _logTextBox.Invoke((MethodInvoker)delegate {
                    ExternalAmount?.Invoke(this, new stringEventArgs(receivedData));
                });

                handler.Shutdown(SocketShutdown.Both);
                handler.Close();

                _serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), _serverSocket);
            }
            catch (Exception ex)
            {
                ShowErrorMessageBox(ex.Message);
            }
        }

        private void ShowErrorMessageBox(string message)
        {
            _logTextBox.Invoke((MethodInvoker)delegate {
                MessageBox.Show($"Error: {message}");
            });
        }
    }
}
