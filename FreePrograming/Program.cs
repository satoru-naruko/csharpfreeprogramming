using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreePrograming
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] a = new int[10];
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("a is {0} {1}",i , 2);
            }

            // 16進数表記は従来から利用可能
            var int7 = 0xdeadbeaf;
            // C# 7.0より2進表記が利用可能に
            var int8 = 0b0001_1100;
            // C# 7.0より16進表記や2進表記と桁区切りも併せて利用可能
            var int9 = 0xdead_beaf;
            var int10 = 0b1001_1000_1111;

            Console.WriteLine("{0} {1} {2} {3}", int7, int8 , int9, int10);

            var str07 = "C:\\tmp\\log.txt"; // C:\tmp\log.txt
            var str08 = @"C:\tmp\log.txt";  // C:\tmp\log.txt

            Console.WriteLine("{0},{1}",str07,str08);

            //null合算演算子 左辺がnullの場合、右辺を返す。null出ない場合は左辺をそのまま返す
            var isnull = null ?? "ssaf";

            WriteStream();

            Console.ReadLine();
            
        }

        public static void WriteStream()
        {
            try
            {
                using (var w = new StreamWriter("test.txt", false, System.Text.Encoding.GetEncoding(932)))
                {
                    w.Write("aaa");
                    var data = new List<string>();
                    data.Add("bbb");
                    data.Add("ccc");
                    data.Add("ddd");
                    data.Add("eee");
                    foreach (var d in data)
                    {
                        w.WriteLine(d);
                    }
                    //while (r.EndOfStream == false)
                    //{
                    //    Console.WriteLine("{0}",r.ReadLine());
                    //}
                }
            }
            finally
            {
            }
        }
    }
}
