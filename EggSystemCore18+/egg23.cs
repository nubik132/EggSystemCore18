using System;
using System.IO;
using System.Runtime;
using System.Text;

namespace EggSystemCore18_
{
    internal class egg23
    {
        public static void Prog()
        {
            ex4_13();
        }
        static void ex2()
        {
            const string path = @"E:\TEMP1";
            DirectoryInfo dirinfo = new(path);
            dirinfo.Create();

            //Console.WriteLine("Название каталога: {0}", dirinfo.Name);
            //Console.WriteLine("Полное название каталога: {0}", dirinfo.FullName);
            //Console.WriteLine("Время создания каталога: {0}", dirinfo.CreationTime);
            //Console.WriteLine("Корневой каталог: {0}", dirinfo.Root);
            //dirinfo.MoveTo("E:\\TEMP2");

            FileInfo txt = new("E:\\txt_tut.txt");
            if (txt.Exists)
                txt.MoveTo(path + @"\txt_tam.txt");
        }
        static async void ex4_18()
        {
            StringBuilder result = new("");
            int k = Convert.ToInt32(Console.ReadLine());
            StreamReader read = new("E:\\txt.txt");
            string? temp = read.ReadLine();
            while (temp != null)
            {
                if (k < temp.Length)
                    result.AppendLine(temp.Substring(k, temp.Length - k - 1));
                else
                    result.Append("\n");
                temp = read.ReadLine();
            }
            read.Close();
            StreamWriter write = new("E:\\txt.txt");
            write.Write(result);
            write.Close();
        }
        static async void ex4_13()
        {
            string result = new("");
            StreamReader read = new("E:\\txt1.txt");
            string temp1 = read.ReadLine();
            string temp = read.ReadToEnd();        
            result = temp.Substring(temp1.Length, temp.Length - temp1.Length - 1);
            read.Close();
            StreamWriter write = new("E:\\txt1.txt");
            write.Write(temp);
            write.Close();
        }
    }
}
