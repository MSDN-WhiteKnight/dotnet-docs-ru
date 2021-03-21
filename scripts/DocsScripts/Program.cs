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

                index = next_index + 1 + replace_to.Length;
            }

            File.WriteAllText(file, txt);
        }

        public static void ReplaceTextDir(string dir, string match_begin, string match_end, string replace_to) 
        {
            string[] files=Directory.GetFiles(dir);

            for (int i = 0; i < files.Length; i++) 
            {
                ReplaceText(files[i], match_begin, match_end, replace_to);
            }

            string[] dirs = Directory.GetDirectories(dir);

            for (int i = 0; i < dirs.Length; i++)
            {
                ReplaceTextDir(dirs[i], match_begin, match_end, replace_to);
            }
        }

        //[!code-vb[...](~/samples/snippets/visualbasic/...)]
        //docs\framework\wpf\app-development\how-to-call-a-page-function.md

        static void Main(string[] args)
        {
            ReplaceText(
                @"..\..\..\..\docs\framework\wpf\app-development\how-to-call-a-page-function.md",
                @"[!code-vb[",
                ")]",
                String.Empty);

            Console.WriteLine("End");
            Console.ReadKey();
        }
    }
}
