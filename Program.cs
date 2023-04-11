using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_PolessUP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ввод переменных
            int[] nums = new int[] { 2, 7, 11, 15 };
            int target = 9;
            for (int i = 0;i <= nums.Length;i++)           
                for (int j = i+1; j <= nums.Length; j++)              
                    if (nums[i] + nums[j] == target)
                    {
                        Console.WriteLine($"[{i}, {j}]");
                        break;
                    }                                        
        }
    }
}
