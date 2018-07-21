using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manager;

namespace Observers
{
    /// <summary>
    /// class for User
    /// </summary>
    public class User : IObserver
    {
        private IObservable messageManager;

        #region Public Api
        /// <summary>
        /// ctr of user with 1 parametr
        /// </summary>
        /// <param name="observable">object on which observe the changing</param>
        public User(IObservable observable)
        {
            messageManager = observable;
            messageManager.Register(this);
        }

        /// <summary>
        /// Method for update User
        /// </summary>
        /// <param name="sender">object on which observe the changing</param>
        /// <param name="messageInfo">class with adding information</param>
        public void Update(IObservable sender, MessageInfo messageInfo)
        {
            Console.WriteLine("Paging User mail message:");
            Console.WriteLine($"From = {messageInfo.From}, To = {messageInfo.To}, Subject = {messageInfo.Subject}, Time = {messageInfo.Time}");
        }

        /// <summary>
        /// Method for unregister subscription
        /// </summary>
        public void StopMessage()
        {
            messageManager.Unregister(this);
        }

        #endregion
    }

    /// <summary>
    /// class for Administrator
    /// </summary>
    public class Administrator : IObserver
    {
        private IObservable messageManager;

        #region Public Api
        /// <summary>
        /// ctr of admin with 1 parametr
        /// </summary>
        /// <param name="observable">object on which observe the changing</param>
        public Administrator(IObservable observable)
        {
            messageManager = observable;
            messageManager.Register(this);
        }

        /// <summary>
        /// Method for update admin
        /// </summary>
        /// <param name="sender">object on which observe the changing</param>
        /// <param name="messageInfo">class with adding information</param>
        public void Update(IObservable sender, MessageInfo messageInfo)
        {
            Console.WriteLine("Paging Administrator mail message:");
            Console.WriteLine($"From = {messageInfo.From}, To = {messageInfo.To}, Subject = {messageInfo.Subject}, Time = {messageInfo.Time}");
        }

        /// <summary>
        /// Method for unregister subscription
        /// </summary>
        public void StopMessage()
        {
            messageManager.Unregister(this);
        }

        #endregion
    }
}
