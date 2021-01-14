using HttpServer;
using System;

namespace HttpServerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpListener httpListener = HttpListener.Create(System.Net.IPAddress.Any,8885);
            httpListener.RequestReceived += HttpListener_RequestReceived;
            httpListener.Start(1024);
            Console.Read();
        }

        private static void HttpListener_RequestReceived(object sender, RequestEventArgs e)
        {
            e.Response.WriteBody("ok");
        }
    }
}
