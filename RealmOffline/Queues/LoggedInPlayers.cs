using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Base;
using RealmOffline.Accounts;

namespace RealmOffline.Queues
{
    public class LoggedInPlayers : TimedQueue<Account>
    {
        public LoggedInPlayers()
            : base(5000)
        {
            //this.StartQueue();
        }
        public override void ProcessItem(object ob)
        {
            var acct = this.DequeueItem(false);
            if (acct != null)
            {
                if (acct.Socket.TcpSocket == null)
                {
                    Console.WriteLine("Socket is null");
                }
                if (acct.IntervalTimer != null && acct.Socket.TcpSocket != null)
                {
                    string remoteEndpoint = string.Empty;
                    try { remoteEndpoint = acct.Socket.TcpSocket.RemoteEndPoint.ToString(); }
                    catch (ObjectDisposedException)
                    {
                        // We are disposed so remove us
                        TryRemove(acct);
                        remoteEndpoint = string.Empty;
                    }
                   // Console.WriteLine("Item Queing {0}:{1}:{2} For {3}",
                      //  acct.IntervalTimer.Elapsed.Minutes, acct.IntervalTimer.Elapsed.Seconds,
                       // acct.IntervalTimer.Elapsed.Milliseconds, remoteEndpoint);

                    if (acct.IntervalTimer.Elapsed.Minutes > 2 ||
                        !acct.Socket.TcpSocket.Connected)//!acct.Socket.TcpSocket.Connected)
                    {
                        // Then we need to free its resources
                        TryRemove(acct);

                        // Force a client disconnect

                    }
                }
                else Console.WriteLine("Timer is null for {0}", acct.Socket.TcpSocket.RemoteEndPoint);
            }
        }
        private bool TryRemove(Account acct)
        {
            try
            {
                ServerGlobals.ClearAccount(acct, true);
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return false; }
        }
    }
}
