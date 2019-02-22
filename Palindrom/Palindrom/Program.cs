using System;
using System.IO;
using System.Text;

namespace Palindrom
{
    class Program
    {
        static public void Main(string[] args)
        {

            var lines = "";

            var projectLocation = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));

            Console.WriteLine(projectLocation);

            var t = DateTime.Now;

            using (StreamReader str = new StreamReader(projectLocation.Replace("bin", "") + "\\6.txt", Encoding.Default))
                lines = str.ReadToEnd();

            Console.WriteLine(FindPallindrom(lines));

            TimeSpan s = DateTime.Now - t;

            Console.WriteLine(s.TotalMilliseconds);
        }

        static private string FindPallindrom(string line)
        {
            string pollindromMax = "";
            int e = 0;

            if (line.Length == 0)
                return "";
            else
            {
                e = 0;
                while (line.Length - e > 0)
                {
                    for (int i = 0; i <= e; i++)
                    {
                        var temp = line.Substring(i, line.Length - e);
                        if (temp.Equals(Reverse(temp)))
                            if (pollindromMax.Length < temp.Length)
                            {
                                pollindromMax = temp;
                                break;
                            }
                    }

                    if (pollindromMax != "")
                        break;

                    e++;
                }

            }
            return pollindromMax;
        }

        static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        //static private string[] GetStdin()
        //{
        //    var list = new List<string>();
        //    string line;
        //    while ((line = Console.ReadLine()) != null)
        //    {
        //        list.Add(line);
        //    }
        //    return list.ToArray();
        //}
    }
}
