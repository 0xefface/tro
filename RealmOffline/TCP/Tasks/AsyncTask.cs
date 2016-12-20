using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Tcp.Base;

namespace RealmOffline.Tcp.Tasks
{
    public abstract class AsyncTask : IDisposable
    {
        #region Fields and Properties
        private ClientBase _tcpClient;
        /// <summary>
        /// Our TcpClient we are speaking with
        /// </summary>
        public ClientBase TcpClient
        {
            get { return _tcpClient; }
            private set { _tcpClient = value; }
        }
        #endregion
        // Need many more delegates, i want to add a few task based async calls
        #region Byte Task Delegates
        private delegate byte[] GenerateReplyFromPacket(ClientBase client, byte[] packet);
        private GenerateReplyFromPacket GenerateServerReply;
        private GenerateReplyFromPacket GenerateClientReply;
        #endregion
        #region ClientTasks Constructors
        public AsyncTask(ClientBase client)
        {
            this._tcpClient = client;
            this.GenerateServerReply = new GenerateReplyFromPacket(ProcessServerPacket);
            this.GenerateClientReply = new GenerateReplyFromPacket(ProcessClientPacket);
        }
        #endregion
        #region Byte array tasks
        /// <summary>
        /// The actual codeblock executed asynchronously
        /// all functions run in this code block execute
        /// in it's own seperate thread, and will be
        /// responsible for breaking down a server packet
        /// and generating a reply from it.
        /// </summary>
        /// <param name="client">the remote client we will be talking with</param>
        /// <param name="packet">the packet we process to figure out our reply</param>
        /// <returns>a reply to given packet, if any</returns>
        public virtual byte[] ProcessServerPacket(ClientBase client, byte[] packet)
        {
            // Override these, and remove the base.Process
            // Because we dont want it ruturning anything from here
            return null;
        }
        /// <summary>
        /// The actual codeblock executed asynchronously
        /// all functions run in this code block execute
        /// in it's own seperate thread, and will be
        /// responsible for breaking down a client packet
        /// and generating a reply from it.
        /// </summary>
        /// <param name="client">the remote client we will be talking with</param>
        /// <param name="packet">the packet we process to figure out our reply</param>
        /// <returns>a reply to given packet, if any</returns>
        public virtual byte[] ProcessClientPacket(ClientBase client, byte[] packet)
        {
            // Override these, and remove the base.Process
            // Because we dont want it ruturning anything from here
            return null;
        }
        /// <summary>
        /// Begins executing the set function byte task
        /// (ProcessServerPacket), asynchronously and
        /// then returns the result to a AsyncCallback
        /// </summary>
        /// <param name="client">the client we are speaking to</param>
        /// <param name="packet">the packet the client sent</param>
        /// <param name="callback">the asynchronous callback to send our result too</param>
        public void AsyncServerByteTask(ClientBase client, byte[] packet, AsyncCallback callback)
        {
            var reply = this.GenerateServerReply.BeginInvoke(client, packet, callback, this);
        }
        /// <summary>
        /// Begins executing the set function byte task
        /// (ProcessClientPacket), asynchronously and
        /// then returns the result to a AsyncCallback
        /// </summary>
        /// <param name="client">the server we are speaking to</param>
        /// <param name="packet">the packet the server sent</param>
        /// <param name="callback">the asynchronous callback to send our result too</param>
        public void AsyncClientByteTask(ClientBase client, byte[] packet, AsyncCallback callback)
        {
            var reply = this.GenerateClientReply.BeginInvoke(client, packet, callback, this);
        }
        /// <summary>
        /// Gets our endinvoke responce for a server
        /// working with a packet sent from client
        /// this will get the byte result as a packet
        /// to reply with.
        /// </summary>
        /// <param name="result">an asynchronous result</param>
        /// <returns>a packet ready to be sent to reply to client</returns>
        public byte[] GetServerReply(IAsyncResult result)
        {
            return this.GenerateServerReply.EndInvoke(result);
        }
        /// <summary>
        /// Gets our endinvoke responce for a client
        /// working with a packet sent from a server
        /// this will get the byte result as a packet
        /// to reply with.
        /// </summary>
        /// <param name="result">an asynchronous result</param>
        /// <returns>a packet ready to be sent to reply to server</returns>
        public byte[] GetClientReply(IAsyncResult result)
        {
            return this.GenerateClientReply.EndInvoke(result);
        }
        #endregion
        public void Dispose()
        {
            // We just allow normal Garbage Collection
        }
    }
}
