using System;

namespace cs_lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            OmniClass tasks = new OmniClass();

            while (true)
            {
                Console.WriteLine("выбери метод для выполнения:");
                Console.WriteLine("1. fraction - дробная часть числа");
                Console.WriteLine("2. charToNum - символ в число");
                Console.WriteLine("3. is2Digits - двузначное ли число");
                Console.WriteLine("4. isInRange - число в диапазоне");
                Console.WriteLine("5. isEqual - равны ли три числа");
                Console.WriteLine("6. abs - модуль числа");
                Console.WriteLine("7. is35 - деление на 3 и 5");
                Console.WriteLine("8. max3 - максимальное из трех чисел");
                Console.WriteLine("9. sum2 - сумма двух чисел (со странным условием)");
                Console.WriteLine("10. day - день недели по номеру");
                Console.WriteLine("11. listNums - список чисел до N");
                Console.WriteLine("12. chet - четные числа до N");
                Console.WriteLine("13. numLen - количество цифр в числе");
                Console.WriteLine("14. square - квадрат из звездочек");
                Console.WriteLine("15. rightTriangle - прямоугольный треугольник");
                Console.WriteLine("16. findFirst - найти первое вхождение в массиве");
                Console.WriteLine("17. maxAbs - максимальное по модулю число в массиве");
                Console.WriteLine("18. add - вставить массив в массив");
                Console.WriteLine("19. reverseBack - перевернуть массив");
                Console.WriteLine("20. findAll - найти все вхождения в массиве");
                Console.WriteLine("0. Выход");

                Console.Write("что выбираешь? ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("введи число: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("результат: " + tasks.fraction(num1));
                        break;

                    case 2:
                        Console.Write("введи символ: ");
                        char ch = Convert.ToChar(Console.ReadLine());
                        Console.WriteLine("результат: " + tasks.charToNum(ch));
                        break;

                    case 3:
                        Console.Write("введи число: ");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("результат: " + tasks.is2Digits(num2));
                        break;

                    case 4:
                        Console.Write("введи начало диапазона: ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("введи конец диапазона: ");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.Write("введи число для проверки: ");
                        int num3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("результат: " + tasks.isInRange(a, b, num3));
                        break;

                    case 5:
                        Console.Write("введи первое число: ");
                        int x1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("введи второе число: ");
                        int x2 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("введи третье число: ");
                        int x3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("результат: " + tasks.isEqual(x1, x2, x3));
                        break;

                    case 6:
                        Console.Write("введи число: ");
                        int num4 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("результат: " + tasks.abs(num4));
                        break;

                    case 7:
                        Console.Write("введи число: ");
                        int num35 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("результат: " + tasks.is35(num35));
                        break;

                    case 8:
                        Console.Write("введи первое число: ");
                        int y1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("введи второе число: ");
                        int y2 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("введи третье число: ");
                        int y3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("результат: " + tasks.max3(y1, y2, y3));
                        break;

                    case 9:
                        Console.Write("введи первое число: ");
                        int s1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("введи второе число: ");
                        int s2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("результат: " + tasks.sum2(s1, s2));
                        break;

                    case 10:
                        Console.Write("введи номер дня недели (1-7): ");
                        int dayNum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("результат: " + tasks.day(dayNum));
                        break;

                    case 11:
                        Console.Write("введи число N: ");
                        int n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("результат: " + tasks.listNums(n1));
                        break;

                    case 12:
                        Console.Write("введи число N: ");
                        int n2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("результат: " + tasks.chet(n2));
                        break;

                    case 13:
                        Console.Write("введи число: ");
                        long num5 = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("результат: " + tasks.numLen(num5));
                        break;

                    case 14:
                        Console.Write("введи размер квадрата: ");
                        int size1 = Convert.ToInt32(Console.ReadLine());
                        tasks.square(size1);
                        break;

                    case 15:
                        Console.Write("введи высоту треугольника: ");
                        int size2 = Convert.ToInt32(Console.ReadLine());
                        tasks.rightTriangle(size2);
                        break;

                    case 16:
                        Console.Write("введи длину массива: ");
                        int len1 = Convert.ToInt32(Console.ReadLine());
                        int[] arr1 = new int[len1];
                        for (int i = 0; i < len1; i++)
                        {
                            Console.Write("элемент [" + i + "]: ");
                            arr1[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.Write("введи число для поиска: ");
                        int search1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("результат: " + tasks.findFirst(arr1, search1));
                        break;

                    case 17:
                        Console.Write("введи длину массива: ");
                        int len2 = Convert.ToInt32(Console.ReadLine());
                        int[] arr2 = new int[len2];
                        for (int i = 0; i < len2; i++)
                        {
                            Console.Write("элемент [" + i + "]: ");
                            arr2[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine("результат: " + tasks.maxAbs(arr2));
                        break;

                    case 18:
                        Console.Write("введи длину первого массива: ");
                        int len3 = Convert.ToInt32(Console.ReadLine());
                        int[] arr3 = new int[len3];
                        for (int i = 0; i < len3; i++)
                        {
                            Console.Write("элемент [" + i + "]: ");
                            arr3[i] = Convert.ToInt32(Console.ReadLine());
                        }

                        Console.Write("введи длину второго массива: ");
                        int len4 = Convert.ToInt32(Console.ReadLine());
                        int[] arr4 = new int[len4];
                        for (int i = 0; i < len4; i++)
                        {
                            Console.Write("элемент [" + i + "]: ");
                            arr4[i] = Convert.ToInt32(Console.ReadLine());
                        }

                        Console.Write("введи позицию для вставки: ");
                        int pos = Convert.ToInt32(Console.ReadLine());

                        int[] result = tasks.add(arr3, arr4, pos);
                        Console.Write("результат: ");
                        for (int i = 0; i < result.Length; i++)
                        {
                            Console.Write(result[i] + " ");
                        }
                        Console.WriteLine();
                        break;

                    case 19:
                        Console.Write("введи длину массива: ");
                        int len5 = Convert.ToInt32(Console.ReadLine());
                        int[] arr5 = new int[len5];
                        for (int i = 0; i < len5; i++)
                        {
                            Console.Write("элемент [" + i + "]: ");
                            arr5[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        int[] reversed = tasks.reverseBack(arr5);
                        Console.Write("результат: ");
                        for (int i = 0; i < reversed.Length; i++)
                        {
                            Console.Write(reversed[i] + " ");
                        }
                        Console.WriteLine();
                        break;

                    case 20:
                        Console.Write("введи длину массива: ");
                        int len6 = Convert.ToInt32(Console.ReadLine());
                        int[] arr6 = new int[len6];
                        for (int i = 0; i < len6; i++)
                        {
                            Console.Write("элемент [" + i + "]: ");
                            arr6[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.Write("введи число для поиска: ");
                        int search2 = Convert.ToInt32(Console.ReadLine());
                        int[] found = tasks.findAll(arr6, search2);
                        Console.Write("результат: ");
                        for (int i = 0; i < found.Length; i++)
                        {
                            Console.Write(found[i] + " ");
                        }
                        Console.WriteLine();
                        break;

                    case 0:
                        return;

                    default:
                        Console.WriteLine("неверный выбор");
                        break;
                }

                Console.WriteLine("\nнажми любую клавишу для продолжения");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}