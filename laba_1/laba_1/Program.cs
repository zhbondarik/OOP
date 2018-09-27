using System;
using System.Text;

namespace laba_1
{
    class MainClass
    {
        static void Main(string[] args)
        {
            //----- 1a ----//
            bool boolean = true;
            byte b = 0b1100_1001;
            char symbol = 'a';
            double dbl = 12.8765567;
            float fl = 43.46F;
            int n = 15;
            long ln = 2345678;
            sbyte sb = -102;
            short sh = 3;
            uint un = 14;
            ulong uln = 3456789;
            ushort ush = 5;
            //-------- 1b ----//
            //---------- Явные приведения ---------------//
            n = (int)dbl;
            un = (char)symbol;
            ln = (short)sh;
            ush = (ushort)ln;
            fl = (float)dbl;
            //---------- Неявные приведения -------------//
            ln = n;
            sh = b;
            un = ush;
            n = sh;
            dbl = fl;
            //------ 1с -----//
            object valueIntInBox = n;
            int valueIntFromBox = (int)valueIntInBox;
            object valueSbyteInBox = sb;
            sbyte valueSbyteFromBox = (sbyte)valueSbyteInBox;
            //------ 1d ----//
            var x = "hello!";
            Console.WriteLine("\n Тип неявно типизированной переменной: " + x.GetType());
            //----- 1e ----//
            int? a = 10;
            if (a.HasValue)
            {
                Console.WriteLine($"a is {a.Value}");
            }
            else
            {
                Console.WriteLine("a does not have a value");
            }
            //---- 2a -----//
            string s1 = "foo";
            string s2 = s1;
            string s3 = "foo";
            string s4 = "bar";
            Console.WriteLine(s1 == s3);
            Console.WriteLine(s1 == s4);
            Console.WriteLine((Object)s1 == (Object)s3);
            Console.WriteLine((Object)s1 == (Object)s2);
            //----- 2b ----//
            string str1 = "Minsk";
            string str2 = "Gomel";
            string str3 = "Brest";
            Console.WriteLine("Обьединение строк: " + string.Concat(str1, str2));
            Console.WriteLine("Выделение подстроки: " + str3.Substring(0, 2));
            string text = "Hello! How do you do?";
            Console.WriteLine("Разделение строки: " + text.Split(' '));
            Console.WriteLine("Вставка строки: " + text.Insert(20, str1));
            Console.WriteLine("Удаление подстроки: " + str2.Remove(2, 3));
            //---- 2c ------//
            string EmptyString = "";
            string NullString = null;
            if (String.Compare(EmptyString, NullString) != 0)
            {
                Console.WriteLine($"Строки {EmptyString} и {NullString} не равны");
            }
            else
            {
                Console.WriteLine($"Строки {EmptyString} и {NullString} равны");
            }

            //----- 2d ----//
            StringBuilder strb = new StringBuilder("Привет мир");
            Console.WriteLine("Удаление: " + strb.Remove(4, 6));
            Console.WriteLine("Добавление в начало: " + strb.Insert(0, ":)"));
            Console.WriteLine("Добавление в конец: " + strb.Append("ет мир"));
            //---- 3a ----//
            Console.WriteLine("Двумерный массив (матрица): ");
            int[,] myArr = new int[4, 4];
            Random ran = new Random();
            for (var i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    myArr[i, j] = ran.Next(1, 15);
                    Console.Write("{0}\t", myArr[i, j]);
                }
                Console.WriteLine();
            }
            //---- 3b ----//
            string[] strArr = { "string1", "string2", "string3", "string4" };
            Console.Write("Содержимое массива: ");
            for (var i = 0; i < 4; i++)
            {
                Console.Write(strArr[i] + ", ");
            }
            Console.WriteLine("\nДлина массива: " + strArr.Length);
            Console.WriteLine("Выберите номер элнемента, который необходимо изменить: ");
            int choose;
            choose = Int32.Parse(Console.ReadLine()) - 1;
            Console.WriteLine("Вы выбрали элемент {0}, введите значение, на которое следует его заменить", strArr[choose]);
            strArr[choose] = Console.ReadLine();
            Console.Write("\nГотово!\n Измененный массив: ");
            for (var i = 0; i < 4; i++)
            {
                Console.Write(strArr[i] + ", ");
            }
            Console.WriteLine("\n");
            //---- 3c ----//
            int[][] myArr2 = new int[3][];
            myArr2[0] = new int[2];
            myArr2[1] = new int[3];
            myArr2[2] = new int[4];
            for (var i = 0; i < 2; i++)
            {
                Console.WriteLine("Введите {0}-й элемент 1-ой ступени: ", i);
                myArr2[0][i] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("Массив 1-ой ступени: {0}, {1}",myArr2[0][0], myArr2[0][1]);
            for (var i = 0; i < 3; i++)
            {
                Console.WriteLine("Введите {0}-й элемент 2-ой ступени: ", i);
                myArr2[1][i] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("Массив 2-ой ступени: {0}, {1}, {2}", myArr2[1][0], myArr2[1][1], myArr2[1][2]);
            for (var i = 0; i < 4; i++)
            {
                Console.WriteLine("Введите {0}-й элемент 3-ой ступени: ", i);
                myArr2[2][i] = Int32.Parse(Console.ReadLine());
            }



            Console.WriteLine("Массив 3-ой ступени: {0}, {1}, {2}, {3}", myArr2[2][0], myArr2[2][1], myArr2[2][2], myArr2[2][3]);
            //---- 3d ----//
            object[] arrOfStr = { "array", "of", "strings" };
            Console.WriteLine($"Массив строка типизированный неявно: {arrOfStr[0]} {arrOfStr[1]} {arrOfStr[2]}");
            //---- 4a ----//
            (int IntValueOfTuple, string FirstStringValueOfTuple, char CharValueOFTuple, string SecondValueOfTuple, ulong UlongValueOfTuple) FirstTuple = (15, "Name", 'x', "Age", 23456);
            Console.WriteLine($"Кортеж целиком: {FirstTuple}");
            Console.WriteLine($"1, 3, 4 элементы кортежа: {FirstTuple.IntValueOfTuple}, {FirstTuple.Item3}, {FirstTuple.Item4}");
            // распаковка
            int IntValueOfTupleFromBox = FirstTuple.IntValueOfTuple;
            string FirstStringValueOfTupleFromBox = FirstTuple.FirstStringValueOfTuple;
            char CharValueOFTupleFromBox = FirstTuple.CharValueOFTuple;
            string SecondValueOfTupleFromBox = FirstTuple.SecondValueOfTuple;
            ulong UlongValueOfTupleFromBox = FirstTuple.UlongValueOfTuple;
            (int, string, char, string, ulong) SecondTuple = (245, "Age", 'x', "Sub", 87654);
            if (FirstTuple.CompareTo(SecondTuple) == 0)  // сравнение 2-х кортежей с разным кол-вом и разными типами полей невозможно
            {
                Console.WriteLine($"Кортежи {FirstTuple} и {SecondTuple} равны");
            }
            else
            {
               Console.WriteLine($"Кортежи {FirstTuple} и {SecondTuple} не равны");
            }

            //---- 5 -----//
            int[] ArrayForMethod = { 2, 7, 214, 26, 12, 40 };
            object MyLocalMethod(int[] LocalArr, string LocalStr)
            {
                (int maxElement, int minElement, int sumOfElements, char FirstCharOfString) LocalTuple;
                LocalTuple.maxElement = LocalArr[0];
                LocalTuple.minElement = LocalArr[0];
                LocalTuple.sumOfElements = 0;
                for (int i = 0; i < LocalArr.Length; i++)
                {
                    if (LocalTuple.maxElement < LocalArr[i])
                    {
                        LocalTuple.maxElement = LocalArr[i];
                    }
                    if (LocalTuple.minElement > LocalArr[i])
                    {
                        LocalTuple.minElement = LocalArr[i];
                    }
                    LocalTuple.sumOfElements += LocalArr[i];
                }
                LocalTuple.FirstCharOfString = LocalStr[0];
                return LocalTuple;
            }
            Console.WriteLine($"Созданный локальный метод и его значение: {MyLocalMethod(ArrayForMethod, "afgshtrhkskdgo")}");
        }
    }
}
