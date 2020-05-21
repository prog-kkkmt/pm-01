using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ModuleExam
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath;
            char[] unique;
            List<char> data1 = new List<char>();
            List<char> data2 = new List<char>();

            Console.WriteLine("Введите путь к первому файлу");
            filePath = Console.ReadLine();
            foreach (char c in ReadFile(filePath).ToCharArray())
            {
                data1.Add(c);
            }

            Console.WriteLine("Введите путь ко второму файлу");
            filePath = Console.ReadLine();
            foreach (char c in ReadFile(filePath))
            {
                data2.Add(c);
            }

            unique = (CompareVowels(data1, data2));

            Console.WriteLine("Гласные в первом файле, не встречающиеся во втором:");
            foreach (char c in unique)
            {
                Console.Write(c.ToString());
            }

            Console.ReadKey();
        }

        static string ReadFile(string filePath)
        {
            string fileData;
            FileStream file = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);

            fileData = reader.ReadToEnd();

            reader.Close();
            return fileData;
        }

        static char[] CompareVowels(List<char> d1, List<char> d2)
        {
            IEnumerable<char> onlyInFirst = d1.Except(d2);
            char[] rez = new char[50];
            int i = 0;
            string vowels = "A a E e I i O o U u Y y";
            char[] s = vowels.ToCharArray();

            foreach (char c in onlyInFirst)
            {
                foreach (char ss in s)
                {
                    if (c == ss)
                        rez[i] = c;
                }
                i++;
            }

            Array.Resize<char>(ref rez, onlyInFirst.Count());

            return rez;
        }

    }
}
