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
        private static readonly object l = new object();
        static List<StreamWriter> reido = new List<StreamWriter>();

        static string UserName()
        {

            return "";
        }
        static void hiloCliente(object socket)
        {
            string mensaje;
            bool apagar = false;
            Socket cliente = (Socket)socket;
       

            IPEndPoint ieCliente = (IPEndPoint)cliente.RemoteEndPoint;
            Console.WriteLine("Connected with client {0} at port {1}", ieCliente.Address, ieCliente.Port);

            using (NetworkStream ns = new NetworkStream(cliente))
            using (StreamReader sr = new StreamReader(ns))
            using (StreamWriter sw = new StreamWriter(ns))
            {
                string welcome = "Welcome to this great Thing";
                sw.WriteLine(welcome);
                sw.Flush();
                reido.Add(sw);

                while (!apagar)
                {
                    try
                    {
                        mensaje = sr.ReadLine();
                        sw.WriteLine(mensaje);
                        sw.Flush();

                        if (mensaje != null)
                        {
                            lock (l)
                            {
                                switch (mensaje)
                                {
                                    case "#salir":
                                        apagar = true;
                                        break;
                                    case "#lista":
                                        break;
                                    default:
                                        Console.WriteLine("{0} dice: {1}", ieCliente.Address, mensaje);
                                        foreach (StreamWriter mensajeDeUsuario in reido)
                                        {
                                            if (sw != mensajeDeUsuario)
                                            {
                                                mensajeDeUsuario.WriteLine("{0} dice: {1}",ieCliente.Address,mensaje);
                                                mensajeDeUsuario.Flush();
                                            }
                                        }
                                        break;
                                }
                            }
                        }
                    }
                    catch (IOException)
                    {
                        break;
                    }
                }
                Console.WriteLine("Finished Connection with {0}: {1}", ieCliente.Address, ieCliente.Port);
            }
            cliente.Close();
        }
        static void Main(string[] args)
        {
            IPEndPoint ie = new IPEndPoint(IPAddress.Any, 10823);
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            s.Bind(ie);
            s.Listen(10);
            Console.WriteLine("Server waiting at port {0}", ie.Port);
            while (true)
            {
                Socket cliente = s.Accept();
                Thread hilo = new Thread(hiloCliente);
                hilo.Start(cliente);
            }
        }
    }
}
