using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace OneNote.WFRP
{
    static class NameGenerator
    {
        static string[] maleForenames;
        static string[] femaleForenames;
        static string[] surnames;
        static string[] surnamePrefixes;
        static string[] surnameSuffixes;
        static Random rand;

        static NameGenerator()
        {
            Console.WriteLine("Reading Files...\n");
            maleForenames = new string[845];
            femaleForenames = new string[421];
            surnames = new string[780];
            rand = new Random();
            ReadFiles();
        }

        private static void ReadFiles()
        {
            try
            {
                int lineCounter = 0;
                string file = Properties.Resources.male_forenames;
                using (var reader = new StringReader(file))
                {
                    string input;
                    while ((input = reader.ReadLine()) != null)
                    {
                        maleForenames[lineCounter] = input.Split(' ')[1];
                        lineCounter++;
                    }
                }

                lineCounter = 0;
                file = Properties.Resources.female_forenames;
                using (var reader = new StringReader(file))
                {
                    string input;
                    while ((input = reader.ReadLine()) != null)
                    {
                        femaleForenames[lineCounter] = input.Split(' ')[1];
                        lineCounter++;
                    }
                }

                lineCounter = 0;
                file = Properties.Resources.surnames;
                using (var reader = new StringReader(file))
                {
                    string input;
                    while ((input = reader.ReadLine()) != null)
                    {
                        surnames[lineCounter] = input.Substring(4);
                        lineCounter++;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static string Name()
        {
            if (rand.Next(0, 2) == 0)
                return MaleName();
            else
                return FemaleName();
        }

        public static string MaleName()
        {
            return MaleForename() + " " + Surname();
        }

        public static string FemaleName()
        {
            return FemaleForename() + " " + Surname();
        }

        public static string MaleForename()
        {
            string name = maleForenames[rand.Next(maleForenames.Length)];
            name = RemoveParentheses(name);
            return name;
        }

        public static string FemaleForename()
        {
            string name = femaleForenames[rand.Next(femaleForenames.Length)];
            name = RemoveParentheses(name);
            return name;
        }

        public static string Surname()
        {
            string [] nameAndOptions = surnames[rand.Next(surnames.Length)].Trim(',').Split(',');
            string name;

            if (nameAndOptions.Length > 1)
            {
                name = nameAndOptions[0] + nameAndOptions[rand.Next(1, nameAndOptions.Length)].Substring(2);
            }
            else
            {
                name = nameAndOptions[0];
            }
            return RemoveParentheses(name);
        }

        private static string RemoveParentheses(string nameStarter)
        {
            while (nameStarter.IndexOf("(") != -1)
            {
                int parenIndex = nameStarter.IndexOf("(");
                int closeIndex = nameStarter.IndexOf(")");

                if (rand.Next(2) == 0)
                {
                    nameStarter = nameStarter.Substring(0, parenIndex) + nameStarter.Substring(closeIndex+1, nameStarter.Length - (closeIndex+1));
                }
                else
                {
                    string additionalString = nameStarter.Substring(parenIndex + 1, closeIndex - (parenIndex + 1));
                    string first = nameStarter.Substring(0, parenIndex);
                    string last = nameStarter.Substring(closeIndex + 1, nameStarter.Length - (closeIndex + 1));
                    nameStarter = first + additionalString + last;
                }
            }
            return nameStarter;
        }
    }
}
