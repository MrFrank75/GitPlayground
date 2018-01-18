namespace GitPlayground
{
    internal class MessageCreatorLivio : IMessageCreator
    {
        public MessageCreatorLivio()
        {
        }

        string IMessageCreator.Name => "Livio";

        string IMessageCreator.Message => " Hi guys, I hope you are enjoying GIT";
    }
}