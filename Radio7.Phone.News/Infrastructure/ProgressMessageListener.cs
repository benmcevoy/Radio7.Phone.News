using GalaSoft.MvvmLight.Messaging;
using Radio7.Phone.News.Messages;

namespace Radio7.Phone.News.Infrastructure
{
    public class ProgressMessageListener
    {
        private readonly IMessenger _messenger;

        public ProgressMessageListener(IMessenger messenger)
        {
            _messenger = messenger;
            _messenger.Register<ProgressMessage>(this, ProcessProgressMessage);
        }

        private void ProcessProgressMessage(ProgressMessage progressMessage)
        {
            if (progressMessage.IsFinished)
            {
                ProgressHelper.ClearMessage();
            }
            else
            {
                ProgressHelper.SetMessage(progressMessage.Message);
            }
        }
    }
}
