using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace yy
{
    class Program
    {
        private readonly static object l = new object();

        static bool apagar = false;
        
        static void HiloCliente(object socket)
        {
            Socket clienteSocket = (Socket)socket;
            IPEndPoint clienteEndPoint = (IPEndPoint)clienteSocket.RemoteEndPoint;
            string mensaje = "";
            string ruta = "C:\\Users\\Oscar\\Desktop\\ficherosEjer5";
            string records = "C:\\Users\\Oscar\\Desktop\\ficherosEjer5\\records.txt";
            string[] lista = { };
            string[] sendAlgo = { };
            char[] letras = { };
            string palabraJuego = "";

            Console.WriteLine("Client connected:{0} at port {1}", clienteEndPoint.Address, clienteEndPoint.Port);

            using (NetworkStream ns = new NetworkStream(clienteSocket))
            using (StreamReader sr = new StreamReader(ns))
            using (StreamWriter sw = new StreamWriter(ns))
            {
                sw.WriteLine("Welcome to the shitest server");
                sw.Flush();

                sw.WriteLine("Escribe a que archivo quieres acceder");
                sw.Flush();
                do
                {
                    mensaje = sr.ReadLine();
                    if (mensaje != null)
                    {
                        ruta = ruta + "\\" + mensaje;
                        if (File.Exists(ruta))
                        {
                            lock (l)
                            {
                                using (StreamReader reader = new StreamReader(ruta))
                                {
                                    lista = reader.ReadToEnd().Split(' ', '\r', '\n', '\t', ';');
                                }
                            }
                        }
                        else
                        {
                            sw.WriteLine("El fichero no exitse");
                            sw.Flush();
                            ruta = "C:\\Users\\Oscar\\Desktop\\ficherosEjer5";
                        }
                    }

                } while (!File.Exists(ruta));

                while (!apagar)
                {
                    try
                    {
                        sw.WriteLine("Comandos: getword,sendword (palabra),getrecord,sendrecord (record),closeserver");
                        sw.Flush();
                        mensaje = sr.ReadLine();

                        if (mensaje.ToLower().StartsWith("sendrecord"))
                        {
                            sendAlgo = mensaje.Split(' ');
                            if (sendAlgo.Length == 3)
                            {
                                if (sendAlgo[2].Length > 3)
                                {
                                    sw.WriteLine("El nombre debe tener 3 caracteres");
                                }
                                else
                                {
                                    mensaje = sendAlgo[0];
                                }

                            }
                        }

                        if (mensaje.ToLower().StartsWith("sendword"))
                        {
                            sendAlgo = mensaje.Split(' ');

                            if (sendAlgo.Length == 2)
                            {
                                mensaje = sendAlgo[0];
                            }
                        }

                        if (mensaje != null)
                        {
                            switch (mensaje.ToLower())
                            {
                                case "getword":
                                    Random rand = new Random();
                                    int valor = rand.Next(0, lista.Length + 1);
                                    if (lista[valor].Length >= 3)
                                    {
                                        palabraJuego = lista[valor].ToLower();
                                    }

                                    sw.Write("Let´s the play begin\r\n");
                                    sw.Flush();
                                    sw.Write(palabraJuego + "\r\n");
                                    sw.Flush();
                                    do
                                    {
                                        mensaje = sr.ReadLine();
                                        letras = mensaje.ToCharArray();
                                        for (int i = 0; i < letras.Length; i++)
                                        {
                                            if (mensaje != palabraJuego)
                                            {
                                                if (mensaje.Contains(letras[i]))
                                                {
                                                    sw.Write("The word contains: " + letras[i] + "\r\n");
                                                }
                                            }
                                        }
                                    } while (mensaje != palabraJuego);
                                    sw.Write("You win\r\n");

                                    break;
                                case "sendword":
                                    lock (l)
                                    {
                                        using (StreamWriter fileWritter = new StreamWriter(ruta, true))
                                        {
                                            fileWritter.Write("\t" + sendAlgo[1]);
                                            fileWritter.Flush();
                                        }
                                    }
                                    break;
                                case "getrecord":
                                    lock (l)
                                    {
                                        using (StreamReader fileReader = new StreamReader(records))
                                        {
                                            sw.WriteLine(fileReader.ReadToEnd());
                                            sw.Flush();
                                        }
                                    }
                                    break;
                                case "sendrecord":
                                    lock (l)
                                    {
                                        using (StreamWriter filewriter = new StreamWriter(records, true))
                                        {
                                            filewriter.WriteLine(sendAlgo[1] + "\t" + sendAlgo[2] + "\t" + clienteEndPoint.Address.ToString());
                                            filewriter.Flush();
                                            sw.WriteLine(sendAlgo[1] + "\t" + sendAlgo[2] + "\t" + clienteEndPoint.Address.ToString());
                                            sw.Flush();
                                        }
                                    }
                                    break;
                                case "closserver":
                                    apagar = true;
                                    break;
                                default:
                                    sw.WriteLine("Comando inexistente");
                                    sw.Flush();
                                    break;
                            }
                        }
                    }
                    catch (IOException w)
                    {
                        break;
                    }
                }
            }
            clienteSocket.Close();
        }

        static void Main(string[] args)
        {
            int port = 10823;

            while (!apagar)
            {
                IPEndPoint ie = new IPEndPoint(IPAddress.Any, port);
                using (Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
                {
                    try
                    {
                        s.Bind(ie);
                    }
                    catch (SocketException e) when (e.ErrorCode == (int)SocketError.AddressAlreadyInUse)
                    {
                        port++;
                        ie = new IPEndPoint(IPAddress.Any, port);
                        s.Bind(ie);
                    }
                    s.Listen(10);
                    Console.WriteLine($"Server listening at port: {ie.Port}");

                    while (!apagar)
                    {
                        Socket cliente = s.Accept();
                        Thread hilo = new Thread(HiloCliente);
                        hilo.Start(cliente);
                    }
                }
            }
        }
    }
}
