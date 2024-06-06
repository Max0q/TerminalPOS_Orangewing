using System;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace TerminalPOS_Orangewing
{
    public class PHPServer
    {
        private string _phpPath = @"C:\RedwingStudio\AirnurPOS\php\php.exe";
        private int _port = 8080;
        private Process _phpProcess;
        public event EventHandler<stringEventArgs> serverState;

        public void Start()
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = _phpPath,
                Arguments = $"-S localhost:{_port} -t C:\\RedwingStudio\\AirnurPOS\\php",
                UseShellExecute = false,
                CreateNoWindow = true
            };

            _phpProcess = Process.Start(psi);
            serverState?.Invoke(this, new stringEventArgs("   | PHP Server started successful"));
        }

        public void Stop()
        {
            if (_phpProcess != null && !_phpProcess.HasExited)
            {
                _phpProcess.Kill();
                serverState?.Invoke(this, new stringEventArgs("   | PHP Server stopped successful"));
            }
        }
    }
}
