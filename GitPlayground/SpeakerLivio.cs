namespace GitPlayground
{
    internal class SpeakerLivio : ISpeaker
    {
        public SpeakerLivio()
        {
        }

        string ISpeaker.Name => "Livio";

        string ISpeaker.Message => "Hi everyone , I'm so happy to be in Bangalore.";
    }
}