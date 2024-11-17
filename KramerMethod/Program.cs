using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KramerMethod
{
    internal class Program
    {
        static List<int> Main_Matrix = new List<int>() 
        { 0, 0, 0, 0,
          0, 0, 0, 0,
          0, 0, 0, 0 };

        static int Counting(List<int> Matrix)
        {
            int first_res1 = Matrix[0] * Matrix[4] * Matrix[10];
            int second_res1 = Matrix[1] * Matrix[6] * Matrix[8];
            int third_res1 = Matrix[2] * Matrix[4] * Matrix[9];
            int first_result = first_res1 + second_res1 + third_res1;

            int first_res2 = Matrix[2] * Matrix[5] * Matrix[8];
            int second_res2 = Matrix[1] * Matrix[4] * Matrix[10];
            int third_res2 = Matrix[0] * Matrix[6] * Matrix[9];
            int second_result = first_res2 + second_res2 + third_res2;

            int main_res = first_result - second_result;

            Console.WriteLine($"{Matrix[0]}*{Matrix[4]}*{Matrix[10]} + {Matrix[1]}*{Matrix[6]}*{Matrix[8]} + {Matrix[2]}*{Matrix[4]}*{Matrix[9]} = {first_res1}");
            Console.WriteLine($"{Matrix[2]}*{Matrix[5]}*{Matrix[8]} + {Matrix[1]}*{Matrix[4]}*{Matrix[10]} + {Matrix[0]}*{Matrix[6]}*{Matrix[9]} = {second_res1}");
            Console.WriteLine($"{first_result} - {second_result} = {main_res}");

            return main_res;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter data");
            for (int i = 0; i < 12; i++)
            {
                Console.Clear();
                Console.WriteLine("Your Matrix");
                Console.WriteLine(
                    $"{Main_Matrix[0]} {Main_Matrix[1]} {Main_Matrix[2]} | {Main_Matrix[3]}\n" +
                    $"{Main_Matrix[4]} {Main_Matrix[5]} {Main_Matrix[6]} | {Main_Matrix[7]}\n" +
                    $"{Main_Matrix[8]} {Main_Matrix[9]} {Main_Matrix[10]} | {Main_Matrix[11]}\n"
                    );
                Console.WriteLine("Enter number");
                int num = Convert.ToInt32(Console.ReadLine());
                Main_Matrix[i] = num;
            }
            List<int> first_A = new List<int>(Main_Matrix);
            List<int> second_A = new List<int>(Main_Matrix);
            List<int> third_A = new List<int>(Main_Matrix);
            Console.Clear();
            Console.WriteLine("Here is your Matrix");
            Console.WriteLine(
                    $"{Main_Matrix[0]} {Main_Matrix[1]} {Main_Matrix[2]} | {Main_Matrix[3]}\n" +
                    $"{Main_Matrix[4]} {Main_Matrix[5]} {Main_Matrix[6]}  |  {Main_Matrix[7]}\n" +
                    $"{Main_Matrix[8]} {Main_Matrix[9]} {Main_Matrix[10]} | {Main_Matrix[11]}\n"
                    );
            Console.WriteLine("\nLet's count");

            Console.WriteLine("Here is devider");
            double devider = Counting(Main_Matrix);

            Console.WriteLine("Here is A1");
            first_A[0] = first_A[3];
            first_A[4] = first_A[7];
            first_A[8] = first_A[11];
            double first = Counting(first_A);

            Console.WriteLine("Here is A2");
            second_A[1] = second_A[3];
            second_A[5] = second_A[7];
            second_A[9] = second_A[11];
            double second = Counting(second_A);

            Console.WriteLine("Here is A3");
            third_A[2] = third_A[3];
            third_A[6] = third_A[7];
            third_A[10] = third_A[11];
            double third = Counting(third_A);

            Console.WriteLine("Now let's find X1, X2, X3");
            Console.WriteLine($"X1 = {first} / {devider} = {Math.Round(first/devider, 5)}\nX2 = {second} / {devider} = {Math.Round(second / devider, 5)}\nX3 = {third} / {devider} = {Math.Round(third / devider, 5)}");
            Console.ReadLine();
        }
    }
}
