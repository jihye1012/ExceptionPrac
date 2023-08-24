using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionPrac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "가", "나" };
            Console.Write("숫자 입력:");

            try
            {
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine("입력한 위치의 값은 '" + array[input] + "'입니다.");
            }catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("인덱스 범위를 벗어났습니다.");
            }
             catch(FormatException ex)
            {
                Console.WriteLine("숫자 입력:");
            }

            catch (Exception ex) 
            {
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
           
            


        
        }
    }
}
