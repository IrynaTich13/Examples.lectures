
//  Искала варианты решения задачи №19


Console.Write("Введите пятизначное число: ");
//int num = Convert.ToInt32(Console.ReadLine());

string num = Console.ReadLine();
int size_num = num[0] == '-'? num.Length - 1 : num.Length;

Console.WriteLine(size_num ? "Да" : "Нет");

// bool Palindrom(num)
// {
//     if
// }



//  bool g = false;
//             int count = 0;
//             int a = Convert.ToInt32(Console.ReadLine()); 
//             int b = 0;
//             if (a == 0)
//             { g = true; }
            
//             {
//                 while (a != 0)
//                 {
//                     b = a % 10;
//                     a = a / 10;
//                     count++;
 
 
//                 }
//             }
//             if (g)
//             { Console.WriteLine("Количество цифр: " + 1); }
//             else
//             {
//                 Console.WriteLine("Количество цифр: " + count);
//             }
//             Console.ReadLine();

            //    Console.WriteLine("Ведите число");
            // int x = int.Parse(Console.ReadLine());
            // int f = x % 10;
            // int i = 1;
            // do
            // {
            //     i++;
            //     x /= 10;
            // } while (x > 10);
            // Console.WriteLine("Количество: "+i.ToString());
            // Console.WriteLine("Первая цифра: " + x.ToString());
            // Console.WriteLine("Последняя цифра: " + f.ToString());
            // Console.ReadKey();
