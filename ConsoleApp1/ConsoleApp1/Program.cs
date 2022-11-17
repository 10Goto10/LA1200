namespace ConsoleApp1
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.IO;
    using System.Net.Http.Headers;

    internal class Program
    {
        static void Main(string[] args)
        {
            int basktballplayers = 0;
            int Squirrelhunters = 0;
            int tirechangers = 0;
            int footballplayers = 0;
            int singers = 0;
            int dancers = 0;
            int knitters = 0;
            string path = @"TextFile1.txt";
            using StreamReader streamReader = new StreamReader(path);
            string[] temp = streamReader.ReadToEnd().Split(";");
            List<string> emails = new List<string>();
            List<string> firstchoices = new List<string>();
            List<string> secondchoices = new List<string>();
            List<string> thirdchoices = new List<string>();
            List<string> choices = new List<string>();
            string[] availablechoices = { "Basketball", "Eichhörnchenjagd", "Reifenwechsel", "Fussball", "Singen", "Tanzen", "Nähen" };
            int j = 0;
            foreach (string k in temp)
            {
                j++;
                if (j > 4)
                {
                    j = 1;
                }
                if (j == 1)
                {
                    emails.Add(k);
                }
                else if (j == 2)
                {
                    firstchoices.Add(k);
                }
                else if (j == 3)
                {
                    secondchoices.Add(k);
                }
                else if (j == 4)
                {
                    thirdchoices.Add(k);
                }
            }
            for (int i = 0; i < emails.Count; i++)
            {
                if (firstchoices[i] == "Basketball")
                {
                    basktballplayers++;
                }
                else if (firstchoices[i] == "Eichhörnchenjagd")
                {
                    Squirrelhunters++;
                }
                else if (firstchoices[i] == "Singen")
                {
                    singers++;
                }
                else if (firstchoices[i] == "Tanzen")
                {
                    dancers++;
                }
                else if (firstchoices[i] == "Nähen")
                {
                    knitters++;
                }
                else if (firstchoices[i] == "Fussball")
                {
                    footballplayers++;
                }
                else if (firstchoices[i] == "Reifenwechsel")
                {
                    tirechangers++;
                }
                if (secondchoices[i] == "Basketball")
                {
                    basktballplayers++;
                }
                else if (secondchoices[i] == "Eichhörnchenjagd")
                {
                    Squirrelhunters++;
                }
                else if (secondchoices[i] == "Singen")
                {
                    singers++;
                }
                else if (secondchoices[i] == "Tanzen")
                {
                    dancers++;
                }
                else if (secondchoices[i] == "Nähen")
                {
                    knitters++;
                }
                else if (secondchoices[i] == "Fussball")
                {
                    footballplayers++;
                }
                else if (secondchoices[i] == "Reifenwechsel")
                {
                    tirechangers++;
                }
                if (thirdchoices[i] == "Basketball")
                {
                    basktballplayers++;
                }
                else if (thirdchoices[i] == "Eichhörnchenjagd")
                {
                    Squirrelhunters++;
                }
                else if (thirdchoices[i] == "Singen")
                {
                    singers++;
                }
                else if (thirdchoices[i] == "Tanzen")
                {
                    dancers++;
                }
                else if (thirdchoices[i] == "Nähen")
                {
                    knitters++;
                }
                else if (thirdchoices[i] == "Fussball")
                {
                    footballplayers++;
                }
                else if (thirdchoices[i] == "Reifenwechsel")
                {
                    tirechangers++;
                }
            }
            //Test
            for (int i = 0; i < emails.Count; i++)
            {
                Console.WriteLine(emails[j] + " = " + firstchoices[i]);
            }
        }
    }
}
