using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SERVBol3_Ejer3
{
    class Program
    {
        //  static Cliente client = new Cliente();
        private static readonly object l = new object();
        static List<Cliente> clientecitos = new List<Cliente>();

        static void hiloCliente(object trueCliente)
        {
            Cliente cliente;
            string mensaje;
            string userName = "";
            bool apagar = false;
            Socket socket = (Socket)trueCliente;

            IPEndPoint ieCliente = (IPEndPoint)socket.RemoteEndPoint;
            Console.WriteLine("Connected with client {0} at port {1}", ieCliente.Address, ieCliente.Port);

            using (NetworkStream ns = new NetworkStream(socket))
            using (StreamReader sr = new StreamReader(ns))
            using (StreamWriter sw = new StreamWriter(ns))
            {

                string welcome = "Welcome to this great Thing";
                sw.WriteLine(welcome);
                sw.Flush();

                sw.WriteLine("Inserte un nombre de usuario por fi :C");
                sw.Flush();
                userName = sr.ReadLine();

                Console.WriteLine(userName + "    " + socket + "          " + ieCliente);
                cliente = ClienteShokan(userName, socket, ieCliente);
                clientecitos.Add(cliente);

                cliente.Mensaje = sw;
                
              if (userName != null)
                {
                    foreach (Cliente conectado in clientecitos)
                    {
                        conectado.Mensaje.WriteLine("{0}@{1};{2} se ha conectado", userName, ieCliente.Address, ieCliente.Port);
                        conectado.Mensaje.Flush();
                    }
                }
                while (!apagar)
                {
                    try
                    {
                        //mensaje = sr.ReadLine();
                        //sw.WriteLine(mensaje);
                        mensaje = sr.ReadLine();

                        if (mensaje != null)
                        {
                            lock (l)
                            {
                                switch (mensaje)
                                {
                                    case "#salir":
                                        Salir();
                                        break;
                                    case "#lista":
                                        foreach (Cliente nombre in clientecitos)
                                        {
                                            Console.WriteLine(clientecitos.Count());
                                            sw.WriteLine(nombre.UserName + " Conectado");
                                            sw.Flush();
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("{0} dice: {1}", ieCliente.Address, mensaje);
                                        foreach (Cliente mesage in clientecitos)
                                        {
                                           
                                           if (sw != mesage.Mensaje)
                                           {
                                                 mesage.Mensaje.WriteLine("{0}@{1} dice: {2}", cliente.UserName,
                                                                          cliente.Ip, mensaje);
                                                 mesage.Mensaje.Flush();
                                           }
                                        }
                                        break;
                                }
                            }
                        }
                        else
                        {
                            Salir();
                        }
                    }
                    catch (IOException)
                    {
                        break;
                    }
                }
                Console.WriteLine("Finished Connection with {0}: {1}", ieCliente.Address, ieCliente.Port);
            }
            void Salir()
            {
                //Console.WriteLine(clientecitos.Count());
                for (int i = clientecitos.Count - 1; i >= 0; i--)
                {
                    if (ieCliente.Port == clientecitos[i].Ip.Port)
                    {
                        foreach (Cliente clientesale in clientecitos)
                        {
                            clientesale.Mensaje.WriteLine("{0}@{1} se desconecto",clientecitos[i].UserName,clientecitos[i].Ip.Address);
                            clientesale.Mensaje.Flush();
                        }
                        clientecitos[i].Socket.Close();
                        clientecitos[i].Mensaje.Close();
                        clientecitos.RemoveAt(i);
                        //Console.WriteLine(clientecitos.Count());
                    }
                }
                apagar = true;
            }
            socket.Close();
        }
        static Cliente ClienteShokan(string name, Socket socket, IPEndPoint ipendPoint)
        {
            return new Cliente(name, socket, ipendPoint);
        }
        static void Main(string[] args)
        {
            //   Cliente trueCliente = new Cliente();
            IPEndPoint ie = new IPEndPoint(IPAddress.Any, 10823);
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            s.Bind(ie);
            s.Listen(10);
            Console.WriteLine("Server waiting at port {0}", ie.Port);
            while (true)
            {
                //   trueCliente.Socket = s.Accept();
                Socket cliente = s.Accept();
                Thread hilo = new Thread(hiloCliente);
                hilo.Start(cliente);
            }
        }
    }
}
