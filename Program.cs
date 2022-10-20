using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SocketClient
{
    class Program
    {
        static void Main(string[] args)
        {
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);
                socket.Connect(endPoint);

                Console.WriteLine("Conectado ao SocketServer...");
                Console.Write("Insira uma mensagem: ");

                string info = Console.ReadLine();
                byte[] infoEnviar = Encoding.Default.GetBytes(info);
                socket.Send(infoEnviar, 0, infoEnviar.Length, SocketFlags.None);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Não foi possivel conectar ao servidor: {ex}");
            }
            finally
            {
                //socket.Close();
            }

            //Console.WriteLine("Precione uma tecla para fechar...");
            //Console.ReadLine();
            
            



        }
    }
}
