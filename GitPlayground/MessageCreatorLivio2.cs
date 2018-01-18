namespace GitPlayground
{
    internal class MessageCreatorLivio2 : IMessageCreator
    {
        public MessageCreatorLivio2()
        {
        }

        string IMessageCreator.Name => "Livio 2";

        string IMessageCreator.Message => " I also would like to add that GIT is great";
    }
}