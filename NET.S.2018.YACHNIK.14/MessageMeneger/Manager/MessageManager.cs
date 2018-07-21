using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    /// <summary>
    /// Message Manager
    /// </summary>
    public class MessageManager : IObservable
    {
        #region Private fields
        private MessageInfo mailInfo; // информация о сообщении

        private List<IObserver> observers;
        #endregion

        #region Properties
        /// <summary>
        /// get time of waiting message
        /// </summary>
        public int TimeLeft { get; set; }
        #endregion

        #region Public Api
        /// <summary>
        /// ctr for MessageManager with 0 parametrs
        /// </summary>
        public MessageManager()
        {
            observers = new List<IObserver>();
            mailInfo = new MessageInfo();
        }

        /// <summary>
        /// ctr for MessageManager with 1 parametrs
        /// </summary>
        public MessageManager(int time)
        {
            if(time <= 0)
            {
                throw new ArgumentException(nameof(time));
            }

            observers = new List<IObserver>();
            mailInfo = new MessageInfo();
            TimeLeft = time;
        }

        /// <summary>
        /// Method for adding observer in List of Observers
        /// </summary>
        /// <param name="observer">class of Iobserver</param>
        /// <exception cref="ArgumentException">if Observer null</exception>
        public void Register(IObserver observer)
        {
            if(observer == null)
            {
                throw new ArgumentException(nameof(observer));
            }

            observers.Add(observer);
        }

        /// <summary>
        /// Method for removing observer from List of Observers
        /// </summary>
        /// <param name="observer">class of Iobserver</param>
        /// <exception cref="ArgumentException">if Observer null</exception>
        public void Unregister(IObserver observer)
        {
            if (observer == null)
            {
                throw new ArgumentException(nameof(observer));
            }

            observers.Remove(observer);
        }

        /// <summary>
        /// method for notify Observers abot event
        /// </summary>
        public void Notify()
        {
            foreach (IObserver o in observers)
            {
                o.Update(this, mailInfo);
            }
        }

        /// <summary>
        /// Method for creating Message
        /// </summary>
        /// <param name="from">city from</param>
        /// <param name="to">city to</param>
        /// <param name="subject">subject</param>
        public void SimulateNewMessage(string from, string to, string subject)
        {
            mailInfo.From = from;
            mailInfo.To = to;
            mailInfo.Subject = subject;
            mailInfo.Time = this.TimeLeft;
            StartCountdown();
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Method for starting countdown of Message dispatch
        /// </summary>
        private void StartCountdown()
        {
            int time = TimeLeft;
            while(TimeLeft > 0)
            {
                TimeTick();
            }

            TimeLeft = time;
            this.Notify();
        }

        /// <summary>
        /// 1 itteration of countdouwn
        /// </summary>
        private void TimeTick()
        {
            this.TimeLeft -= 1;
            System.Threading.Thread.Sleep(1000);
        }

        #endregion
    }
}
