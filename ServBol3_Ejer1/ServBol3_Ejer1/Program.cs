using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServBol3_Ejer1
{
    class Program
    {
        public static  bool apagar = false;

        static void Main(string[] args)
        {
       
            while (!apagar)
            {
                IPEndPoint ie = new IPEndPoint(IPAddress.Any, 135);

            using (Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                try
                {
                    s.Bind(ie);

                }
                catch (SocketException e) when (e.ErrorCode == (int)SocketError.AddressAlreadyInUse)
                {
                    try
                    {
                        ie = new IPEndPoint(IPAddress.Any, 10823);
                        s.Bind(ie);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("server ocupado vuelva mas tarde");
                            Console.ReadLine();
                        apagar = true;
                    }

                }
                    try
                    {
                        s.Listen(10);
                        Console.WriteLine($"Server listening at port:{ie.Port}");


                        Socket sClient = s.Accept();
                        IPEndPoint ieCliente = (IPEndPoint)sClient.RemoteEndPoint;
                        Console.WriteLine("Client connected:{0} at port {1}", ieCliente.Address, ieCliente.Port);

                        using (NetworkStream ns = new NetworkStream(sClient))
                        using (StreamReader sr = new StreamReader(ns))
                        using (StreamWriter sw = new StreamWriter(ns))
                        {
                            string welcome = "Bienvenido a Residente Entrometido Sin Intereses Demasiado Elevado eN Ti (R.E.S.I.D.E.N.T Server)";
                            sw.WriteLine(welcome);
                            sw.Flush();

                            string msg = "";
                            try
                            {
                                msg = sr.ReadLine();
                                if (msg != null)
                                {
                                    msg = msg.ToUpper();
                                    Console.WriteLine(msg);
                                    switch (msg)
                                    {
                                        case "HORA":
                                            sw.WriteLine(DateTime.Now.ToString("HH:mm:ss"), System.Globalization.DateTimeFormatInfo.InvariantInfo);
                                            sw.Flush();
                                            break;
                                        case "FECHA":
                                            sw.WriteLine(DateTime.Now.Day + "\\" + DateTime.Now.Month + "\\" + DateTime.Now.Year);
                                            sw.Flush();
                                            break;
                                        case "TODO":
                                            sw.WriteLine(DateTime.Now);
                                            sw.Flush();
                                            break;
                                        case "APAGAR":
                                            sw.WriteLine("server Apagado");
                                            apagar = true;
                                            break;
                                        default:
                                            Console.WriteLine("No disppongo de ese comando Alváro/Curro/Óscar");
                                            sw.WriteLine("No disppongo de ese comando Alváro/Curro/Óscar");
                                            sw.Flush();
                                            break;
                                    }
                                }
                            }
                            catch (IOException e)
                            {
                                msg = null;
                            }
                        }
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }
    }
}
