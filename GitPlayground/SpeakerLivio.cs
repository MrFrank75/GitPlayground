﻿namespace GitPlayground
{
    internal class SpeakerLivio : ISpeaker
    {
        public SpeakerLivio()
        {
        }

        string ISpeaker.Name => "Livio";

        string ISpeaker.Message => " Hi guys, I hope you are enjoying GIT. This workshop might help us to understand more (hopefully)...";
    }
}