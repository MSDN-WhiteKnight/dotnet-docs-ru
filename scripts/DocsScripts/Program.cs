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

        static void RemoveCppSamples()
        {
            //[!code-cpp[...](~/samples/snippets/cpp/...)]

            ReplaceTextDir(
                @"..\..\..\..\docs\framework\wpf\",
                @"[!code-cpp[",
                ")]",
                String.Empty);

            ReplaceTextDir(
                @"..\..\..\..\docs\framework\winforms\",
                @"[!code-cpp[",
                ")]",
                String.Empty);
        }

        static void ReplaceIncludes()
        {
            //[!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] -> WPF
            //[!INCLUDE[TLA#tla_winclient](../../../../includes/tlasharptla-winclient-md.md)] -> Windows Presentation Foundation (WPF)
            //[!INCLUDE[TLA#tla_mswin](../../../../includes/tlasharptla-mswin-md.md)] -> Windows
            //[!INCLUDE[TLA#tla_xbap#plural](../../../../includes/tlasharptla-xbapsharpplural-md.md)] -> XAML-приложения браузера (XBAP)
            //[!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] -> WPF
            //[!INCLUDE[TLA2#tla_ui](../../../../includes/tla2sharptla-ui-md.md)] -> UI
            //[!INCLUDE[TLA#tla_xaml](../../../includes/tlasharptla-xaml-md.md)] -> XAML
            //[!INCLUDE[TLA2#tla_xbap](../../../includes/tla2sharptla-xbap-md.md)] -> XBAP
            //[!INCLUDE[TLA2#tla_xbap#plural](../../../includes/tla2sharptla-xbapsharpplural-md.md)] -> XBAP

            const string wpfpath = @"..\..\..\..\docs\framework\wpf\";
            const string winformspath = @"..\..\..\..\docs\framework\winforms\";

            ReplaceTextDir(
                wpfpath,
                @"[!INCLUDE[TLA2#tla_winclient](",
                "includes/tla2sharptla-winclient-md.md)]",
                "WPF");

            ReplaceTextDir(
                winformspath,
                @"[!INCLUDE[TLA2#tla_winclient](",
                "includes/tla2sharptla-winclient-md.md)]",
                "WPF");

            ReplaceTextDir(
                wpfpath,
                @"[!INCLUDE[TLA#tla_winclient](",
                "includes/tlasharptla-winclient-md.md)]",
                "Windows Presentation Foundation (WPF)");

            ReplaceTextDir(
                wpfpath,
                @"[!INCLUDE[TLA#tla_mswin](",
                "includes/tlasharptla-mswin-md.md)]",
                "Windows");

            ReplaceTextDir(
                wpfpath,
                @"[!INCLUDE[TLA#tla_xbap#plural](",
                "includes/tlasharptla-xbapsharpplural-md.md)]",
                "XAML-приложения браузера (XBAP)");

            ReplaceTextDir(
                wpfpath,
                @"[!INCLUDE[TLA2#tla_wpf](",
                "includes/tla2sharptla-wpf-md.md)]",
                "WPF");

            ReplaceTextDir(
                wpfpath,
                @"[!INCLUDE[TLA2#tla_ui](",
                "includes/tla2sharptla-ui-md.md)]",
                "UI");

            ReplaceTextDir(
                wpfpath,
                @"[!INCLUDE[TLA#tla_xaml](",
                "includes/tlasharptla-xaml-md.md)]",
                "XAML");

            ReplaceTextDir(
                wpfpath,
                @"[!INCLUDE[TLA2#tla_xbap](",
                "includes/tla2sharptla-xbap-md.md)]",
                "XBAP");

            ReplaceTextDir(
                wpfpath,
                @"[!INCLUDE[TLA2#tla_xbap#plural](",
                "includes/tla2sharptla-xbapsharpplural-md.md)]",
                "XBAP");
                        
            //[!INCLUDE[TLA#tla_api#plural](../../../includes/tlasharptla-apisharpplural-md.md)]
            //[!INCLUDE[net_v40_long](../../../includes/net-v40-long-md.md)]
            //[!INCLUDE[TLA2#tla_cas](../../../includes/tla2sharptla-cas-md.md)]
            //[!INCLUDE[TLA2#tla_clickonce](../../../includes/tla2sharptla-clickonce-md.md)]
            //[!INCLUDE[TLA#tla_iegeneric](../../../includes/tlasharptla-iegeneric-md.md)]
            //[!INCLUDE[TLA2#tla_uri](../../../includes/tla2sharptla-uri-md.md)]                        
        }

        static void Main(string[] args)
        {
            ReplaceIncludes();

            Console.WriteLine("End");
            Console.ReadKey();
        }
    }
}
