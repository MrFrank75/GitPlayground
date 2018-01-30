namespace GitPlayground
{
    internal class SpeakerMark : ISpeaker
    {
        public SpeakerMark()
        {
        }

        string ISpeaker.Name => "Mark";

        string ISpeaker.Message => " Hello everyone, I m in bangalore and weather is great.";
    }
}