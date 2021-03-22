/* Docs scripts 
 * Copyright (c) 2021, MSDN.WhiteKnight (https://github.com/MSDN-WhiteKnight) 
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace DocsScripts
{
    class Program
    {
        public static void ReplaceText(string file, string match_begin, string match_end, string replace_to)
        {
            string txt = File.ReadAllText(file);
            int index=0;
            int next_index=0;
            int end_index;
            bool write = false;

            while (true) 
            {
                if (index >= txt.Length) break;
                next_index=txt.IndexOf(match_begin, index);
                if (next_index < 0) break;

                end_index = txt.IndexOf(match_end, next_index);
                if (end_index < 0) break;

                string s = txt.Substring(next_index, (end_index + match_end.Length) - next_index);
                Console.WriteLine(s);

                txt = txt.Replace(s,replace_to);
                write = true;

                index = next_index + 1 + replace_to.Length;
            }

            //if done at least one replace, write text back to file
            if(write) File.WriteAllText(file, txt);
        }

        public static void ReplaceTextDir(string dir, string match_begin, string match_end, string replace_to) 
        {
            Console.WriteLine("dir: "+dir);
            Console.WriteLine();

            string[] files=Directory.GetFiles(dir,"*.md");

            for (int i = 0; i < files.Length; i++) 
            {
                Console.WriteLine("file: " + files[i]);
                ReplaceText(files[i], match_begin, match_end, replace_to);
            }

            Console.WriteLine();

            string[] dirs = Directory.GetDirectories(dir);

            for (int i = 0; i < dirs.Length; i++)
            {
                ReplaceTextDir(dirs[i], match_begin, match_end, replace_to);
            }
        }

        static void RemoveVbSamples()
        {
            //[!code-vb[...](~/samples/snippets/visualbasic/...)]
            
            ReplaceTextDir(
                @"..\..\..\..\docs\framework\wpf\",
                @"[!code-vb[",
                ")]",
                String.Empty);

            ReplaceTextDir(
                @"..\..\..\..\docs\framework\winforms\",
                @"[!code-vb[",
                ")]",
                String.Empty);
        }
        
        //..\..\..\..\docs\framework\wpf\app-development\how-to-call-a-page-function.md

        static void Main(string[] args)
        {
            //RemoveVbSamples();

            Console.WriteLine("End");
            Console.ReadKey();
        }
    }
}
