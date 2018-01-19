﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitPlayground
{
    class Program
    {
        private static List<ISpeaker> messageCreators;

        static void Main(string[] args)
        {

            messageCreators = new List<ISpeaker>();
            messageCreators.Add(new SpeakerLivio());
            messageCreators.Add(new SpeakerJohn());
            messageCreators.Add(new SpeakerMark());
            messageCreators.Add(new SpeakerAlex());
            messageCreators.Add(new SpeakerOliver());

            Console.WriteLine("Hello World!!!");


            foreach (var messageCreator in messageCreators)
            {
                Console.WriteLine(string.Format("Message from the creator:{0}. Message says:{1}", messageCreator.Name, messageCreator.Message));
            }

            Console.WriteLine("Now press a key to continue...there isn't much else");
            Console.ReadKey();
        }
    }
}
