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
        static int replacements = 0;

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
                replacements++;

                index = next_index + 1 + replace_to.Length;
            }

            //if done at least one replace, write text back to file
            if (write)
            {
                Console.WriteLine("file: " + file);
                File.WriteAllText(file, txt);
            }
        }

        public static void ReplaceTextDir(string dir, string match_begin, string match_end, string replace_to) 
        {
            /*Console.WriteLine("dir: "+dir);
            Console.WriteLine();*/

            string[] files=Directory.GetFiles(dir,"*.md");

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

        const string wpfpath = @"..\..\..\..\docs\framework\wpf\";
        const string winformspath = @"..\..\..\..\docs\framework\winforms\";

        static void ReplaceIncludes(string path)
        {
            ReplaceTextDir(path,@"[!INCLUDE[TLA2#tla_winclient](","includes/tla2sharptla-winclient-md.md)]","WPF");                        

            ReplaceTextDir(path,@"[!INCLUDE[TLA#tla_winclient](","includes/tlasharptla-winclient-md.md)]",
                "Windows Presentation Foundation (WPF)");

            ReplaceTextDir(path,@"[!INCLUDE[TLA#tla_mswin](","includes/tlasharptla-mswin-md.md)]",
                "Windows");

            ReplaceTextDir(path,@"[!INCLUDE[TLA#tla_xbap#plural](","includes/tlasharptla-xbapsharpplural-md.md)]",
                "XAML-приложения браузера (XBAP)");

            ReplaceTextDir(path,@"[!INCLUDE[TLA2#tla_wpf](","includes/tla2sharptla-wpf-md.md)]","WPF");
            ReplaceTextDir(path,@"[!INCLUDE[TLA2#tla_ui](","includes/tla2sharptla-ui-md.md)]","UI");
            ReplaceTextDir(path,@"[!INCLUDE[TLA#tla_xaml](","includes/tlasharptla-xaml-md.md)]","XAML");
            ReplaceTextDir(path,@"[!INCLUDE[TLA2#tla_xbap](","includes/tla2sharptla-xbap-md.md)]","XBAP");
            ReplaceTextDir(path,@"[!INCLUDE[TLA2#tla_xbap#plural](","includes/tla2sharptla-xbapsharpplural-md.md)]","XBAP");
            ReplaceTextDir(path,@"[!INCLUDE[TLA#tla_xbap](","includes/tlasharptla-xbap-md.md)]","Приложение обозревателя XAML (XBAP)");

            ReplaceTextDir(path,@"[!INCLUDE[TLA#tla_wpfbrowserappproj](","includes/tlasharptla-wpfbrowserappproj-md.md)]",
                "Приложение браузера XAML (WPF)");

            ReplaceTextDir(path,@"[!INCLUDE[TLA#tla_iegeneric](","includes/tlasharptla-iegeneric-md.md)]","Windows Internet Explorer");
            
            ReplaceTextDir(path,@"[!INCLUDE[TLA#tla_api#plural](","includes/tlasharptla-apisharpplural-md.md)]","API");

            ReplaceTextDir(path,@"[!INCLUDE[net_v40_long](","includes/net-v40-long-md.md)]",".NET Framework 4");

            ReplaceTextDir(path,@"[!INCLUDE[TLA2#tla_cas](","includes/tla2sharptla-cas-md.md)]","CAS");

            ReplaceTextDir(path,@"[!INCLUDE[TLA2#tla_clickonce](","includes/tla2sharptla-clickonce-md.md)]",
                "ClickOnce");

            ReplaceTextDir(path,@"[!INCLUDE[TLA#tla_html](", "includes/tlasharptla-html-md.md)]","HTML");

            ReplaceTextDir(path,@"[!INCLUDE[TLA2#tla_api#plural](","includes/tla2sharptla-apisharpplural-md.md)]","API");

            ReplaceTextDir(path,@"[!INCLUDE[TLA#tla_ui](","includes/tlasharptla-ui-md.md)]","UI ");

            ReplaceTextDir(path,@"[!INCLUDE[TLA#tla_cas](","includes/tlasharptla-cas-md.md)]",
                "CAS (Code Access Security — безопасность доступа кода)");

            ReplaceTextDir(path,@"[!INCLUDE[TLA#tla_clickonce](","includes/tlasharptla-clickonce-md.md)]",
                "ClickOnce");

            ReplaceTextDir(path,@"[!INCLUDE[TLA2#tla_uri](","includes/tla2sharptla-uri-md.md)]","URI");
            ReplaceTextDir(path,"[!INCLUDE[TLA#tla_url](","includes/tlasharptla-url-md.md)]","URL");
            ReplaceTextDir(path,@"[!INCLUDE[TLA2#tla_url](","includes/tla2sharptla-url-md.md)]","URL");
            ReplaceTextDir(path,@"[!INCLUDE[TLA#tla_uri](","includes/tlasharptla-uri-md.md)]","URI");

            ReplaceTextDir(path,@"[!INCLUDE[TLA2#tla_uri#plural](","includes/tla2sharptla-urisharpplural-md.md)]",
                "URI");

            ReplaceTextDir(path,@"[!INCLUDE[TLA2#tla_ie](","includes/tla2sharptla-ie-md.md)]",
                "Internet Explorer");

            ReplaceTextDir(path,@"[!INCLUDE[TLA2#tla_xaml](","includes/tla2sharptla-xaml-md.md)]",
                "XAML");

            ReplaceTextDir(path,@"[!INCLUDE[TLA#tla_titlexaml](","includes/tlasharptla-titlexaml-md.md)]",
                "XAML");

            ReplaceTextDir(path,@"[!INCLUDE[TLA2#tla_api](","includes/tla2sharptla-api-md.md)]",
                "API");

            ReplaceTextDir(path,@"[!INCLUDE[TLA2#tla_html](","includes/tla2sharptla-html-md.md)]",
                "HTML");

            ReplaceTextDir(path,@"[!INCLUDE[TLA2#tla_iegeneric](","includes/tla2sharptla-iegeneric-md.md)]",
                "Internet Explorer");

            ReplaceTextDir(path,@"[!INCLUDE[TLA2#tla_wininstall](","includes/tla2sharptla-wininstall-md.md)]",
                "Windows Installer");

            ReplaceTextDir(path,"[!INCLUDE[TLA2#tla_unc](","includes/tla2sharptla-unc-md.md)]","UNC");
            ReplaceTextDir(path, @"[!INCLUDE[TLA2#tla_xml](","includes/tla2sharptla-xml-md.md)]","XML");
            ReplaceTextDir(path,@"[!INCLUDE[TLA#tla_clr](","includes/tlasharptla-clr-md.md)]","CLR");
            ReplaceTextDir(path,@"[!INCLUDE[TLA#tla_xml](","includes/tlasharptla-xml-md.md)]","XML");

            ReplaceTextDir(path,@"[!INCLUDE[TLA#tla_xaml#initcap](","includes/tlasharptla-xamlsharpinitcap-md.md)]",
                "XAML");

            ReplaceTextDir(path,@"[!INCLUDE[TLA2#tla_clr](","includes/tla2sharptla-clr-md.md)]","CLR");

            ReplaceTextDir( path,@"[!INCLUDE[TLA#tla_ie](","includes/tlasharptla-ie-md.md)]",
                "Microsoft Internet Explorer");

            ReplaceTextDir(path,@"[!INCLUDE[TLA#tla_visualstu](","includes/tlasharptla-visualstu-md.md)]",
                "Microsoft Visual Studio");

            ReplaceTextDir(path,@"[!INCLUDE[TLA#tla_msbuild](","includes/tlasharptla-msbuild-md.md)]",
                "Microsoft Build Engine (MSBuild)");

            ReplaceTextDir(path,@"[!INCLUDE[TLA2#tla_msbuild](","includes/tla2sharptla-msbuild-md.md)]",
                "MSBuild");

            ReplaceTextDir(path,@"[!INCLUDE[TLA2#tla_sdk](","includes/tla2sharptla-sdk-md.md)]","SDK");

            ReplaceTextDir(path,@"[!INCLUDE[ndptecclick](","includes/ndptecclick-md.md)]","ClickOnce");

            ReplaceTextDir(path, @"[!INCLUDE[TLA#tla_winvista](", "includes/tlasharptla-winvista-md.md)]",
                "Windows Vista");

            ReplaceTextDir(path,@"[!INCLUDE[win7](","includes/win7-md.md)]","Windows 7");

            ReplaceTextDir( path, @"[!INCLUDE[TLA2#tla_winvista](","includes/tla2sharptla-winvista-md.md)]",
                "Windows Vista");

            ReplaceTextDir(path,@"[!INCLUDE[wiprlhext](","includes/wiprlhext-md.md)]","Windows Vista");

            ReplaceTextDir(path, @"[!INCLUDE[TLA#tla_winfxwebapp#plural](",
              "includes/tlasharptla-winfxwebappsharpplural-md.md)]","XAML-приложения браузера (XBAP)");

            ReplaceTextDir( path,@"[!INCLUDE[TL A#tla_xml](", "includes/tlasharptla-xml-md.md)]","XML");

            ReplaceTextDir(path,@"[!INCLUDE[TLA#tla_unicode](","includes/tlasharptla-unicode-md.md)]",
                "Unicode");

            ReplaceTextDir(path,@"[!INCLUDE[TLA2#tla_xps](","includes/tla2sharptla-xps-md.md)]","XPS");

            ReplaceTextDir(path,@"[!INCLUDE[TLA2#tla_http](","includes/tla2sharptla-http-md.md)]","HTTP");

            ReplaceTextDir(path,@"[!INCLUDE[TLA#tla_w3c](", "includes/tlasharptla-w3c-md.md)]","W3C");

            ReplaceTextDir(path,@"[!INCLUDE[TLA#tla_winxp](","includes/tlasharptla-winxp-md.md)]",
                "Microsoft Windows XP");

            ReplaceTextDir(path,@"[!INCLUDE[TLA#tla_actx](","includes/tlasharptla-actx-md.md)]",
                "Microsoft ActiveX");

            ReplaceTextDir(path, @"[!INCLUDE[TLA#tla_winnetsvrfam](", "includes/tlasharptla-winnetsvrfam-md.md)]", "Microsoft Windows Server 2003");
            ReplaceTextDir(path, @"[!INCLUDE[TLA2#tla_win32](", "includes/tla2sharptla-win32-md.md)]", "Win32");
            ReplaceTextDir(path, @"[!INCLUDE[TLA#tla_winforms](", "includes/tlasharptla-winforms-md.md)]", "Windows Forms");

            ReplaceTextDir(path, @"[!INCLUDE[TLA2#tla_intellisense](", "includes/tla2sharptla-intellisense-md.md)]", "IntelliSense");
            ReplaceTextDir(path, @"[!INCLUDE[TLA#tla_cpp](", "includes/tlasharptla-cpp-md.md)]", "C++");
            ReplaceTextDir(path, @"[!INCLUDE[TLA#tla_longhorn](", "includes/tlasharptla-longhorn-md.md)]", "Windows Vista");
            ReplaceTextDir(path, @"[!INCLUDE[TLA#tla_aspnet](", "includes/tlasharptla-aspnet-md.md)]", "ASP.NET");

            ReplaceTextDir(path, @"[!INCLUDE[TLA#tla_wpfxmlnsv1](", "includes/tlasharptla-wpfxmlnsv1-md.md)]",
                "http://schemas.microsoft.com/winfx/2006/xaml/presentation");

            ReplaceTextDir(path, @"[!INCLUDE[TLA#tla_ie7](", "includes/tlasharptla-ie7-md.md)]",
                "Windows Internet Explorer 7");

            ReplaceTextDir(path, @"[!INCLUDE[TLA#tla_ie6sp2](", "includes/tlasharptla-ie6sp2-md.md)]",
                "Microsoft Internet Explorer 6 с пакетом обновления 2 (SP2)");

            ReplaceTextDir(path, @"[!INCLUDE[TLA#tla_xamlxmlnsv1](", "includes/tlasharptla-xamlxmlnsv1-md.md)]",
                "http://schemas.microsoft.com/winfx/2006/xaml");

            ReplaceTextDir(path, @"[!INCLUDE[TLA2#tla_ie6sp2](", "includes/tla2sharptla-ie6sp2-md.md)]",
                "IE6 с пакетом обновления 2 (SP2)");

            ReplaceTextDir(path, @"[!INCLUDE[TLA#tla_winxpsp2](", "includes/tlasharptla-winxpsp2-md.md)]",
                "Microsoft Windows XP SP2");

            ReplaceTextDir(path, @"[!INCLUDE[TLA2#tla_winxpsp2](", "includes/tla2sharptla-winxpsp2-md.md)]",
                "Microsoft Windows XP SP2");

            ReplaceTextDir(path, @"[!INCLUDE[TLA#tla_winnetsvrfamsp1](", "includes/tlasharptla-winnetsvrfamsp1-md.md)]",
                "Microsoft Windows Server 2003 SP1");

            ReplaceTextDir(path, @"[!INCLUDE[TLA#tla_cppcli](", "includes/tlasharptla-cppcli-md.md)]", "C++/CLI");
            ReplaceTextDir(path, @"[!INCLUDE[TLA2#tla_ie7](", "includes/tla2sharptla-ie7-md.md)]", "Internet Explorer 7");
            ReplaceTextDir(path, @"[!INCLUDE[TLA2#tla_cpp](", "includes/tla2sharptla-cpp-md.md)]", "C++");
            ReplaceTextDir(path, @"[!INCLUDE[TLA2#tla_ie6](", "includes/tla2sharptla-ie6-md.md)]", "Microsoft Internet Explorer 6");
            ReplaceTextDir(path, @"[!INCLUDE[TLA#tla_win32](", "includes/tlasharptla-win32-md.md)]", "Win32");
            ReplaceTextDir(path, @"[!INCLUDE[TLA2#tla_winxp](", "includes/tla2sharptla-winxp-md.md)]", "Microsoft Windows XP");

            ReplaceTextDir(path, @"[!INCLUDE[TLA#tla_titlewinclient](", "includes/tlasharptla-titlewinclient-md.md)]", "WPF");
            ReplaceTextDir(path, @"[!INCLUDE[TLA2#tla_dll](", "includes/tla2sharptla-dll-md.md)]", "DLL");
            ReplaceTextDir(path, @"[!INCLUDE[TLA2#tla_dx](", "includes/tla2sharptla-dx-md.md)]", "DirectX");
            ReplaceTextDir(path, @"[!INCLUDE[TLA2#tla_gdi](", "includes/tla2sharptla-gdi-md.md)]", "GDI");
            ReplaceTextDir(path, @"[!INCLUDE[TLA#tla_dipixel#plural](", "includes/tlasharptla-dipixelsharpplural-md.md)]", "аппаратно-независимые единицы (1/96 дюйма на единицу)");
            ReplaceTextDir(path, @"[!INCLUDE[TLA#tla_bits](", "includes/tlasharptla-bits-md.md)]", "Фоновая интеллектуальная служба передачи (BITS)");
            ReplaceTextDir(path, @"[!INCLUDE[TLA#tla_win_update](", "includes/tlasharptla-win-update-md.md)]", "Центр обновления Windows");
            ReplaceTextDir(path, @"[!INCLUDE[TLA2#tla_ui#plural](", "includes/tla2sharptla-uisharpplural-md.md)]", "UI");

            ReplaceTextDir(path, @"[!INCLUDE[TLA#tla_dx](", "includes/tlasharptla-dx-md.md)]", "Microsoft DirectX");
            ReplaceTextDir(path, @"[!INCLUDE[TLA#tla_gdi](", "includes/tlasharptla-gdi-md.md)]", "Windows GDI");
            ReplaceTextDir(path, @"[!INCLUDE[TLA#tla_ui#plural](", "includes/tlasharptla-uisharpplural-md.md)]", "UI");
            ReplaceTextDir(path, @"[!INCLUDE[TLA#tla_dll](", "includes/tlasharptla-dll-md.md)]", "DLL");
            ReplaceTextDir(path, @"[!INCLUDE[TLA2#tla_gdiplus](", "includes/tla2sharptla-gdiplus-md.md)]", "GDI+");

            ReplaceTextDir(path, @"[!INCLUDE[TLA#tla_gdiplus](", "includes/tlasharptla-gdiplus-md.md)]", "Microsoft Windows GDI+");
            ReplaceTextDir(path, @"[!INCLUDE[TLA#tla_win](", "includes/tlasharptla-win-md.md)]", "Microsoft Windows");
            ReplaceTextDir(path, @"[!INCLUDE[TLA2#tla_wic](", "includes/tla2sharptla-wic-md.md)]", "Обработка изображений в WPF");
            ReplaceTextDir(path, @"[!INCLUDE[TLA#tla_ms](", "includes/tlasharptla-ms-md.md)]", "Microsoft");

            ReplaceTextDir(path, "[!INCLUDE[TLA#tla_wic](", "includes/tlasharptla-wic-md.md)]", "Компонент обработки изображений WPF");
            ReplaceTextDir(path, "[!INCLUDE[TLA#tla_mime](", "includes/tlasharptla-mime-md.md)]", "MIME");
            ReplaceTextDir(path, "[!INCLUDE[TLA2#tla_netframewk](", "includes/tla2sharptla-netframewk-md.md)]", "Платформа ");
            ReplaceTextDir(path, "[!INCLUDE[TLA2#tla_metro](", "includes/tla2sharptla-metro-md.md)]", "XPS");
            ReplaceTextDir(path, "[!INCLUDE[TLA#tla_emf](", "includes/tlasharptla-emf-md.md)]", "EMF (расширенный метафайл)");
            ReplaceTextDir(path, "[!INCLUDE[TLA2#tla_bmp](", "includes/tla2sharptla-bmp-md.md)]", "BMP");
            ReplaceTextDir(path, "[!INCLUDE[TLA2#tla_jpeg](", "includes/tla2sharptla-jpeg-md.md)]", "JPEG");
            ReplaceTextDir(path, "[!INCLUDE[TLA2#tla_png](", "includes/tla2sharptla-png-md.md)]", "PNG");
            ReplaceTextDir(path, "[!INCLUDE[TLA2#tla_tiff](", "includes/tla2sharptla-tiff-md.md)]", "TIFF");
            ReplaceTextDir(path, "[!INCLUDE[TLA2#tla_wdp](", "includes/tla2sharptla-wdp-md.md)]", "Windows Media Photo");
            ReplaceTextDir(path, "[!INCLUDE[TLA2#tla_gif](", "includes/tla2sharptla-gif-md.md)]", "GIF");
            ReplaceTextDir(path, "[!INCLUDE[TLA2#tla_ct](", "includes/tla2sharptla-ct-md.md)]", "ClearType");
            ReplaceTextDir(path, "[!INCLUDE[TLA#tla_opentype](", "includes/tlasharptla-opentype-md.md)]", "OpenType");
        }

        static void Main(string[] args)
        {
            ReplaceIncludes(wpfpath);
            ReplaceIncludes(winformspath);

            Console.WriteLine("Replaced items: "+replacements.ToString());
            Console.ReadKey();
        }
    }
}
