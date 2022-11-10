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
            int basketballwahlen = 0;
            int eichhoernchenwahlen = 0;
            int reifenwechselwahlen = 0 ;
            int fussballwahlen = 0;
            int singenwahlen = 0;
            int tanzenwahlen = 0;
            int naehenwahlen = 0;
            string path = @"TextFile1.txt";
            using StreamReader streamReader = new StreamReader(path);
            string[] temp = streamReader.ReadToEnd().Split(";");
            List<string> emails = new List<string>();
            List<string> firstchoices = new List<string>();
            List<string> secondchoices = new List<string>();
            List<string> thirdchoices = new List<string>();
            List<string> choices = new List<string>();
            string[] availablechoices = { "Basketball", "Eichhörnchenjagd", "Reifenwechsel", "Fussball", "Singen", "Tanzen", "Nähen" };
            int numbero = 0;
            foreach (string k in temp)
            {
                numbero++;
                if (numbero > 4)
                {
                    numbero = 1;
                }
                if (numbero == 1)
                {
                    emails.Add(k);
                }
                else if (numbero == 2)
                {
                    firstchoices.Add(k);
                }
                else if (numbero == 3)
                {
                    secondchoices.Add(k);
                }
                else if (numbero == 4)
                {
                   thirdchoices.Add(k); 
                }
            }
            for (int i = 0; i < emails.Count; i++)
            {
                if (firstchoices[i] == "Basketball")
                {
                    basketballwahlen++;
                }
                else if (firstchoices[i] == "Eichhörnchenjagd")
                {
                    eichhoernchenwahlen++;
                }
                else if (firstchoices[i] == "Singen")
                {
                    singenwahlen++;
                }
                else if (firstchoices[i] == "Tanzen")
                {
                    tanzenwahlen++;
                }
                else if (firstchoices[i] == "Nähen")
                {
                    naehenwahlen++;
                }
                else if (firstchoices[i] == "Fussball")
                {
                    fussballwahlen++;
                }
                else if (firstchoices[i] == "Reifenwechsel")
                {
                    reifenwechselwahlen++;
                }
                if (secondchoices[i] == "Basketball")
                {
                    basketballwahlen++;
                }
                else if (secondchoices[i] == "Eichhörnchenjagd")
                {
                    eichhoernchenwahlen++;
                }
                else if (secondchoices[i] == "Singen")
                {
                    singenwahlen++;
                }
                else if (secondchoices[i] == "Tanzen")
                {
                    tanzenwahlen++;
                }
                else if (secondchoices[i] == "Nähen")
                {
                    naehenwahlen++;
                }
                else if (secondchoices[i] == "Fussball")
                {
                    fussballwahlen++;
                }
                else if (secondchoices[i] == "Reifenwechsel")
                {
                    reifenwechselwahlen++;
                }
                if (thirdchoices[i] == "Basketball")
                {
                    basketballwahlen++;
                }
                else if (thirdchoices[i] == "Eichhörnchenjagd")
                {
                    eichhoernchenwahlen++;
                }
                else if (thirdchoices[i] == "Singen")
                {
                    singenwahlen++;
                }
                else if (thirdchoices[i] == "Tanzen")
                {
                    tanzenwahlen++;
                }
                else if (thirdchoices[i] == "Nähen")
                {
                    naehenwahlen++;
                }
                else if (thirdchoices[i] == "Fussball")
                {
                    fussballwahlen++;
                }
                else if (thirdchoices[i] == "Reifenwechsel")
                {
                    reifenwechselwahlen++;
                }
            }
            //Test
            for (int i = 0; i < emails.Count; i++)
            {
                Console.WriteLine(emails[i] + " = " + firstchoices[i]);
            }
        }
    }
}