using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace RealmOffline.Packets
{
    public class ServerObject
    {
        /// <summary>
        /// Mysql generated ID
        /// </summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// server name
        /// </summary>
        public virtual string Name { get; set; }
        /// <summary>
        /// Ip in string form 0.0.0.0 is ll ips
        /// </summary>
        public virtual string Address { get; set; }
        /// <summary>
        /// Port
        /// </summary>
        public virtual int Port { get; set; }
        /// <summary>
        /// Place in server list
        /// </summary>
        public virtual int WorldIndex { get; set; }
        public string LoggedOnPlayerCount = "0";
        public string Up = "Down";
        private IPEndPoint Server { get; set; }
        private TcpClient Socket { get; set; }

        public ServerObject()
        {
        }
        public void GetServerData()
        {
            if (!string.IsNullOrEmpty(this.Address) && this.Port > 0)
            {
                Server = new IPEndPoint(IPAddress.Parse(this.Address), this.Port);
                Socket = new TcpClient();
                Socket.BeginConnect(Server.Address, Server.Port, new AsyncCallback(BeginConnect), Socket);
            }
        }
        private void BeginConnect(IAsyncResult result)
        {
            try
            {
                NetworkStream networkStream = this.Socket.GetStream();

                byte[] buffer = new byte[this.Socket.ReceiveBufferSize];
                networkStream.BeginRead(buffer, 0, buffer.Length, ReadCallback, buffer);
            }
            catch (Exception) {  }
        }
        private void ReadCallback(IAsyncResult result)
        {
            bool readagain = true;
            NetworkStream networkStream = null;

            try
            {

                networkStream =  this.Socket.GetStream();

            }

            catch (Exception) {  } // Closed connection

            // Console.WriteLine("{0} : {1}.", ex.Message, ex.StackTrace); return; }     

            byte[] buffer = result.AsyncState as byte[];
            int read = networkStream.EndRead(result);
            byte[] data = new byte[read];
            Array.Copy(buffer, 0, data, 0, data.Length);
            //string data = ASCIIEncoding.ASCII.GetString(buffer, 0, buffer.Length );

            //Do something with the data object here.

            Console.WriteLine("Packet {0} in size", data.Length);

            PacketReader r = new PacketReader(data);
            r.ReadInt32(); // pck len
            int pckid = r.ReadInt32(); // id
            switch (pckid)
            {
                case 0xE6:
                    {
                        // We got a How many players are on
                         this.LoggedOnPlayerCount = r.ReadString16();
                         this.Up = "Up";
                         Console.WriteLine("Was told {0} Players are on me", this.LoggedOnPlayerCount);
                         readagain = false;
                    }
                    break;
                default:
                    {
                        // Ask for players
                        PacketWriter w = new PacketWriter(0xE6);
                        byte[] p = w.ToArray();
                        Socket.Client.Send(p);
                    }
                    break;
            }
            //Then start reading from the network again.

            if (readagain)
                networkStream.BeginRead(buffer, 0, buffer.Length, ReadCallback, buffer);
            else Socket.Close();

        }
    }
}
