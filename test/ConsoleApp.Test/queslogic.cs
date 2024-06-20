using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Test
{
    internal class queslogic
    {
        public bool ques(int[] arr, int target)
        {
            if (target == arr[0]) return true;

            //prefix array
         /*   int[] temp = new int[arr.Length];*/
            HashSet<int> set = new HashSet<int>();  

          /*  temp[0] = arr[0];*/

            int tempVal = arr[0];
            set.Add(tempVal);

            for(int i=1; i<arr.Length; i++)
            {
                /*temp[i] = arr[i]+ temp[i-1];
                if (temp[i] == target) return true;
                set.Add(temp[i]);*/

                if (arr[i] == target) return true;

                tempVal += arr[i];
                if (tempVal == target) return true;
                if (set.Contains(tempVal - target)) return true;

                set.Add(tempVal);   
            }

         /*   for(int i=0; i<arr.Length; i++)
            {
                if (set.Contains(temp[i] - target)) { return true; }
            }*/

            return false;
        }
        public bool ques2(int[] arr, int tar)
        {
            for(int i=0; i<arr.Length; i++)
            {
                int tempSum = 0;
                for(int j =i; j<arr.Length; j++)
                {
                    tempSum += arr[j];
                    if(tempSum == tar) { return true; }
                }
            }
            return false;
        }
        public void method()
        {
            int[] arr = { 1, 5,2,31 };
            int target = 9-1;

            bool ans = ques(arr, target);
            Console.WriteLine(ans);
        }
    }
}
