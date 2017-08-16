using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TxtReader
{
    public class TxtReader
    {
        byte[] byData = new byte[100];
        char[] charData = new char[1000];

        public void FileStremRead(string fileUri)
        {
            FileStream file = new FileStream(fileUri, FileMode.Open);
            file.Seek(0, SeekOrigin.Begin);
            file.Read(byData, 0, 100);//byData传进来的字节数组,用以接受FileStream对象中的数据,第2个参数是字节数组中开始写入数据的位置,它通常是0,表示从数组的开端文件中向数组写数据,最后一个参数规定从文件读多少字符.
            Decoder d = Encoding.Default.GetDecoder();
            d.GetChars(byData, 0, byData.Length, charData, 0);
            Console.WriteLine(charData);
            file.Close();
        }

        public void ReadB(string fileUri)
        {
            StreamReader sr = new StreamReader(fileUri, Encoding.Default);
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line.ToString());
            }
        }

        public void FileStremWrite()
        {
            FileStream fs = new FileStream("E:\\ak.txt", FileMode.Create);
            //获得字节数组
            byte[] data = System.Text.Encoding.Default.GetBytes("Hello World!");
            //开始写入
            fs.Write(data, 0, data.Length);
            //清空缓冲区、关闭流
            fs.Flush();
            fs.Close();
        }

        public void Write(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            //开始写入
            sw.Write("Hello World!!!!");
            //清空缓冲区
            sw.Flush();
            //关闭流
            sw.Close();
            fs.Close();
        }

    }
}