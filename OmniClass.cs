using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace cs_lab1
{
    class OmniClass
    {
        public double fraction(double x)
        {
            return x % 1;
        }
        public int charToNum(char x)
        {
            return x - 48;
        }

        public bool is2Digits(int x)
        {
            return x >= 10 && x <= 99;
        }

        public bool isInRange(int a, int b, int num)
        {
            if (b < a)
            {
                int c;
                c = a;
                a = b;
                b = c;
            }
            return num >= a && num <= b;
        }

        public bool isEqual(int a, int b, int c)
        {
            return a == b && b == c;
        }

        public int abs(int x)
        {
            if (x < 0)
            {
                x = -x;
            }
            return x;
        }

        public bool is35(int x)
        {
            bool divisibleBy3 = x % 3 == 0;
            bool divisibleBy5 = x % 5 == 0;
            return (divisibleBy3 || divisibleBy5) && !(divisibleBy3 && divisibleBy5);
        }

        public int max3(int x, int y, int z)
        {
            int max = 0;
            if (x < y)
            {
                max = y;
            }
            else
            {
                max = x;
            }

            if (max < z)
            {
                return z;
            }
            return max;
        }

        public int sum2(int x, int y)
        {
            int sum = x + y;
            if (sum >= 10 && sum <= 19)
            {
                return 20;
            }
            return sum;
        }

        public String day(int x)
        {
            switch (x)
            {
                case 1: return "понедельник";
                case 2: return "вторник";
                case 3: return "среда";
                case 4: return "четверг";
                case 5: return "пятница";
                case 6: return "суббота";
                case 7: return "воскресенье";
                default: return "это не день недели";
            }
        }

        public String listNums(int x)
        {
            string str = "";
            for (int i = 0; i <= x; i++)
            {
                str += i + " ";
            }
            return str;
        }
        
        public String chet(int x)
        {
            string str = "";
            for (int i = 0; i <= x; i += 2)
            {
                str += i + " ";
            }
            return str;
        }

        public int numLen(long x)
        {
            int ctr = 0;
            while (x > 0)
            {
                x = x / 10;
                ctr++;
            }
            return ctr;
        }

        public void square(int x)
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void rightTriangle(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                for (int j = 0; j < x - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < i; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        public int findFirst(int[] arr, int x)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }

        public int maxAbs(int[] arr)
        {
            int max = arr[0];
            int maxabs = abs(arr[0]);
            for (int i = 1; i < arr.Length; i++)
            {
                int val = abs(arr[i]);
                if (val > maxabs)
                {
                    maxabs = val;
                    max = arr[i];
                }
            }
            return max;
        }

        public int[] add(int[] arr, int[] ins, int pos)
        {
            int newlen = arr.Length + ins.Length;
            int[] result = new int[newlen];

            for (int i = 0; i < pos; i++)
            {
                result[i] = arr[i];
            }

            for (int i = 0; i < ins.Length; i++)
            {
                result[pos + i] = ins[i];
            }

            for (int i = pos; i < arr.Length; i++)
            {
                result[ins.Length + i] = arr[i];
            }

            return result;
        }

        public int[] reverseBack(int[] arr)
        {
            int[] result = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = arr[arr.Length - 1 - i];
            }

            return result;
        }

        public int[] findAll(int[] arr, int x)
        {
            int cnt = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                    cnt++;
            }

            int[] result = new int[cnt];

            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    result[index] = i;
                    index++;
                }
            }

            return result;
        }
    }
}
