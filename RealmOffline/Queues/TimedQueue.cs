using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealmOffline.Queues
{
    /// <summary>
    /// A queue for running operations on an object
    /// this queue can hold any object, and is marked
    /// as abstract because we do not use it directly,
    /// we must inherit this in a class we create to
    /// specifically handle a type of object, for example
    /// we create this queue to handle peoples ages
    /// when we set the queue we set a time interval 
    /// in which to process an item contained in the list,
    /// so every 2 milliseconds we call a function =>
    /// void ProcessItem(object ob) this function
    /// must be overridden and the first action in it
    /// is to Dequeue an item and then perform the 
    /// class specfic work on it.
    /// EX: int age = AgeQueue.DequeueItem();
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class TimedQueue<T> : System.Collections.CollectionBase, IDisposable
    {
        #region Properties and Fields
        /// <summary>
        /// The timer used to empty the queue
        /// </summary>
        private System.Threading.Timer _timer { get; set; }
        /// <summary>
        /// Totalitems this queue has processed
        /// </summary>
        public int TotalItemsDeQueued { get; private set; }
        /// <summary>
        /// Our wait time between queue actions
        /// </summary>
        public int QueueTimer { get; private set; }
        /// <summary>
        /// If the queue is paused
        /// </summary>
        public bool IsQueuePaused { get; private set; }
        /// <summary>
        /// Returns if ths queue has been disposed
        /// </summary>
        public bool IsDisposed { get; private set; }
        /// <summary>
        /// Delegate to handle errors
        /// </summary>
        /// <param name="e"></param>
        delegate void OnErrorReceived(Exception e);
        /// <summary>
        /// Event thrown when a error occurs
        /// </summary>
        event OnErrorReceived OnErrorEvent;
        #endregion
        #region Constructors
        /// <summary>
        /// Creates a timed queue that runs a operation
        /// on the contents every 1 milliseconds. 
        /// </summary>
        public TimedQueue()
        {
            this.Initialize(1);
        }
        /// <summary>
        /// Creates a timed queue that runs a operation
        /// on the contents every (queueWaitTimer) milliseconds.
        /// </summary>
        /// <param name="queueWaitTimer">in milliseconds 1000 = 1 second</param>
        public TimedQueue(int queueWaitTimer)
        {
            this.Initialize(queueWaitTimer);
        }
        /// <summary>
        /// Init's our list with default values
        /// </summary>
        /// <param name="queueWaitTimer">the time elay between processing in milliseconds</param>
        private void Initialize(int queueWaitTimer)
        {
            this.IsQueuePaused = true; // Start in paused state
            this.IsDisposed = false;
            this.TotalItemsDeQueued = 0;
            this.QueueTimer = queueWaitTimer;
            this.OnErrorEvent += new OnErrorReceived(OnError);
        }
        #endregion
        #region Queue Functions
        /// <summary>
        /// Changes the interval that this queue
        /// runs operations on it's contents.
        /// </summary>
        /// <param name="milliseconds">the interval in millisconds 1000 = 1 second</param>
        public void ChangeInterval(int milliseconds)
        {
            this.QueueTimer = milliseconds;
            try { _timer.Change(0, milliseconds); }
            catch (Exception ex) { OnErrorEvent(ex); }
        }
        /// <summary>
        /// Starts our Queue timer
        /// </summary>
        public void StartQueue()
        {
            try { _timer = new System.Threading.Timer(ProcessItem, null, 0, this.QueueTimer); }
            catch (Exception ex) { OnErrorEvent(ex); }
        }
        /// <summary>
        /// Pauses our queue's operations
        /// </summary>
        public void PauseQueue()
        {
            try { _timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite); }
            catch (Exception ex) { OnErrorEvent(ex); }
            this.IsQueuePaused = true;
        }
        /// <summary>
        /// Restarts our queue using the current requested 
        /// time delay
        /// </summary>
        public void ReStartQueue()
        {
            if (this._timer == null) { this.StartQueue(); }
            else
                this.ChangeInterval(this.QueueTimer);
            this.IsQueuePaused = false;
        }
        /// <summary>
        /// Stops our queue from processing any more
        /// of it's contents.
        /// </summary>
        public void StopQueue()
        {
            if (this._timer != null)
            {
                this.PauseQueue();
            }
        }
        /// <summary>
        /// Clears all contents from our queue
        /// </summary>
        public void PurgeQueue()
        {
            try
            {
                lock (List)
                {
                    List.Clear();
                }
            }
            catch (Exception ex) { OnErrorEvent(ex); }
        }
        /// <summary>
        /// Places a object into our queue.
        /// </summary>
        /// <param name="value">the object to add</param>
        public void QueueItem(T value)
        {
            try
            {
                lock (List)
                {
                    List.Add(value);
                }
            }
            catch (Exception ex) { OnErrorEvent(ex); return; }
            // If for some reason we are paused, restart us
            // we have an item to process now
            if (this.IsQueuePaused)
                ReStartQueue();
        }
        /// <summary>
        /// Gets the first object from our list
        /// removes the item from the list and
        /// then returns it to you for processing.
        /// </summary>
        /// <param name="remove">By default removes item from queue, false negates this action</param>
        /// <returns>the first item in our list.</returns>
        public T DequeueItem(bool remove = true)
        {
            // Return the first item
            if (List.Count >= 1)
            {
                T item = default(T);
                try
                {
                    lock (List)
                    {
                        item = (T)List[0];
                        if (remove) { List.Remove(List[0]); }
                    }
                }
                catch (Exception ex) { OnErrorEvent(ex); return item; }
                this.TotalItemsDeQueued++;
                return item;
            }
            else
                return default(T);
        }
        /// <summary>
        /// Returns the position in list of the object
        /// will return -1 if any errors
        /// </summary>
        /// <param name="value">the object to find the position of</param>
        /// <returns>the items position in list</returns>
        public int QueuePosition(T value)
        {
            if (List.Count >= 0) { return -1; } // No items in list
            try { return List.IndexOf(value); }
            catch { return -1; }
        }
        /// <summary>
        /// Gets item at position index
        /// </summary>
        /// <param name="index">the index</param>
        /// <returns>the object located</returns>
        public T this[int index]
        {
            get 
            {
                return (T)this.List[index];
            }
        }
        public bool Contains(T value)
        {
            bool found = false;
            foreach (T item in List)
                if (item.Equals(value)) { found = true; }
            return found;
        }
        #endregion
        #region (Needed) Overridable Functions
        /// <summary>
        /// Processes a item from the list
        /// and removes it.
        /// You MUST override this in order
        /// to process any queueitems.
        /// </summary>
        /// <param name="ob">Useless object, required by timer.</param>
        public virtual void ProcessItem(object ob) { }
        /// <summary>
        /// Thrown when a error is processed
        /// </summary>
        /// <param name="e">the error</param>
        public virtual void OnError(Exception e) { }
        #endregion
        #region Dispose()
        /// <summary>
        /// Disposes this object
        /// </summary>
        public void Dispose()
        {
            // Lock and clear our list
            this.StopQueue();
            this.PurgeQueue();
            this.IsDisposed = true;
        }
        #endregion
    }
}
