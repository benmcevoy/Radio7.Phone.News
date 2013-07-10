namespace Radio7.Phone.News.Messages
{
    public class ProgressMessage
    {
        public ProgressMessage()
        {
            IsFinished = true;
        }

        public ProgressMessage(string message)
        {
            Message = message;
            IsFinished = false;
        }

        public string Message { get; set; }

        public bool IsFinished { get; set; }
    }
}
