namespace GitPlayground
{
    internal class SpeakerLivio : ISpeaker
    {
        public SpeakerLivio()
        {
        }

        string ISpeaker.Name => "Livio";

        string ISpeaker.Message => " Hi guys, I hope you are enjoying GIT. I'm sure Marcos already got it all.";
    }
}