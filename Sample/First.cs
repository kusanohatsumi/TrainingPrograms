// 名前を入力して表示するプログラム#1
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

class First
{
    static string program_var = "sample #1";

    static void Main()
    {
        System.Console.WriteLine(program_var);
        System.Console.WriteLine("お名前は？≫");
        string? name = System.Console.ReadLine();
        System.Console.WriteLine($"ようこそ、{name}さん！");
    }
}

