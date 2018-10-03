using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Table
{
    class Program
    {
        /*static void resize(int[,] array, int s)
        {

        }*/
        static void Main(string[] args)
        {
            int choice, sort = 0, size = 0;
            int[] seatnumber = new int[size];
            int[] chinese = new int[size];
            int[] english = new int[size];
            int[] math = new int[size];
            bool bl = true;
            string output = "";
            do
            {
                Console.Write("請選擇動作: 1)輸入資料 2)印出資料 3)排序 0)離開> ");
                choice = int.Parse(Console.ReadLine());
                if (choice == 0)
                    bl = false;
                else if (choice != 1 && seatnumber.Length == 0)
                    Console.WriteLine("尚無成績資料");
                else
                {
                    if (choice == 1)
                    {
                        Console.Write("\n請輸入班級人數> ");
                        size = int.Parse(Console.ReadLine());
                        //int[,] grade = new int[size, 3];
                        Array.Resize(ref seatnumber, seatnumber.Length + size);
                        Array.Resize(ref chinese, chinese.Length + size);
                        Array.Resize(ref english, english.Length + size);
                        Array.Resize(ref math, math.Length + size);
                        for (int i = 1; i <= size; i++)
                        {
                            seatnumber[i - 1] = i;
                            Console.WriteLine("\n請輸入{0}號同學的成績:", seatnumber[i - 1]);
                            Console.Write("國文成績> ");
                            chinese[i - 1] = int.Parse(Console.ReadLine());
                            Console.Write("英文成績> ");
                            english[i - 1] = int.Parse(Console.ReadLine());
                            Console.Write("數學成績> ");
                            math[i - 1] = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine();
                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine("\n座號    國文    英文    數學\n================================");
                        for(int i = 0; i < size; i++)
                        {
                            output = String.Format("{0,-8}", seatnumber[i]);
                            Console.Write(output);
                            output = String.Format("{0,-8}", chinese[i]);
                            Console.Write(output);
                            output = String.Format("{0,-8}", english[i]);
                            Console.Write(output);
                            output = String.Format("{0,-8}", math[i]);
                            Console.WriteLine(output);
                        }
                        Console.WriteLine();
                    }
                    else if(choice == 3)
                    {
                        Console.Write("請輸入排序依據: 1)座號 2)國文 3)英文 4)數學> ");
                        sort = int.Parse(Console.ReadLine());
                        if (sort == 1)
                        {
                            Array.Sort(seatnumber.ToArray(), chinese);
                            Array.Sort(seatnumber.ToArray(), english);
                            Array.Sort(seatnumber, math);
                        }
                        else if(sort == 2)
                        {
                            Array.Sort(chinese.ToArray(), seatnumber);
                            Array.Sort(chinese.ToArray(), english);
                            Array.Sort(chinese, math);
                        }
                        else if(sort == 3)
                        {
                            Array.Sort(english.ToArray(), seatnumber);
                            Array.Sort(english.ToArray(), chinese);
                            Array.Sort(english, math);
                        }
                        else if(sort == 4)
                        {
                            Array.Sort(math.ToArray(), seatnumber);
                            Array.Sort(math.ToArray(), chinese);
                            Array.Sort(math, english);
                        }
                        Console.WriteLine();
                    }
                }
            } while (bl);
            Console.WriteLine("程式結束，按任意鍵繼續...");
            Console.Read();
        }
    }
}
