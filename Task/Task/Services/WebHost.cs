using System.Net;

namespace HomeTask.Services
{
    internal class WebHost
    {

        private short _port;
        private HttpListener _listener;

        public WebHost(short port)
        {
            _port = port;
        }

        public void Run()
        {
            _listener = new HttpListener();
            _listener.Prefixes.Add($"http://localhost:{_port}/");

            _listener.Start();

            while (true)
            {
                var context = _listener.GetContext();

                _ = Task.(() => { RequestHandle(context); });
            }
        }
    }
}
