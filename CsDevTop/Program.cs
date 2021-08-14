using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace CsDevTop
{
    class Program
    {
        public static List<string> topicsnew = new List<string>();

        static void Main(string[] args)
        {
            //BackgroundColor = ConsoleColor.White;
            //ForegroundColor = ConsoleColor.Black;

            string[] topics = File.ReadAllLines(@"data/cSharp-DevTopics_list.md");

            WriteLine("WARNING: this is a long list");
            WriteLine("Press 'y' to add the topic to the list.");
            foreach (string str in topics) {
                if (str.Length > 0) {
                    switch(str[0]) {
                        case '#': topicsnew.Add($"Chapter: {str}"); break;
                        case '-': Process(str); break;
                        default: break;
                    }
                }
            }

            WriteLine("--------------------------------------");

            foreach (string str in topicsnew) {
                WriteLine(str);
            }

            ResetColor();
            WriteLine("Todo: write to file");
        }

        static void Process(string str) {
            WriteLine($"SubTopic: {str}?");

            char tmp = ReadKey().KeyChar;

            switch (tmp) {
                case 'y':
                    ForegroundColor = ConsoleColor.Green;
                    topicsnew.Add(str);
                    WriteLine("ADDED TO LIST!"); break;
                default:
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Skipped!"); break;
            }

            ResetColor();
        }
    }
}
