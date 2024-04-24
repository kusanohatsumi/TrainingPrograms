using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap12_2_2;

class StringFormat
{
    static void Main()
    {
        string one = "1";

        int n1 = 2;
        int n2 = 3;

        Console.WriteLine(string.Format("{0}プラス{1}は{2}です", one, n1, n2));




        var first = "日経";
        var last = "太郎";
        var str1 = String.Format("私の名前は {0} {1}です。", first, last);
        Console.WriteLine(str1);

        var str2 = $"私の名前は{first} {last}です。";
        Console.WriteLine(str2);


        var price = 645;
        var str3 = $@"
    price: {price:C}-
    Tex: {price * 0.08:C}-";
        Console.WriteLine(str3);

    }
}
