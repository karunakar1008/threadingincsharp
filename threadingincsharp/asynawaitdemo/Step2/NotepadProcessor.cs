using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace asynawaitdemo
{
  public  class NotepadProcessor
    {
        private int countNumberOfChars()
        {
            int count = 0;

            using (StreamReader reader=new StreamReader(@"C:\Users\karunakarb\Desktop\TestFile.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(5000);
            }

            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("How the tread is blocked for a long running method");

            NotepadProcessor notepadProcessor = new NotepadProcessor();

          int textLength=  notepadProcessor.countNumberOfChars();

            Console.WriteLine("Number of chars in the file: {0}",textLength);

            Console.ReadKey();

        }
    }
}
