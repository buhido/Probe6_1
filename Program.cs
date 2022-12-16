



bool isWork = true;

while (isWork)
{
    string command = Console.ReadLine();

    switch (command)
    {
        case "task41": Task41(); break;
        case "task43": Task43(); break;
        case "exit": isWork = false; break;
    }
}


void Task41()
{
    // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
    //0, 7, 8, -2, -2 -> 2
    //1, -7, 567, 89, 223-> 3



    Console.Write("Введите элементы(через пробел): ");
    int count = 0;
    int[] M = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); // Split() -задает ожидание разделителя(пробела),
                                                                       //         который разбивает строку одномерного массива M на части.

    for (int i = 0; i < M.Length; i++)
    {
        if (M[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Кол-во элементов больше 0: {count}");
}

void Task43()
{
    //Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
    //значения b1, k1, b2 и k2 задаются пользователем.
    //b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)
    Console.Write("Введите b1: ");
    var b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите k1: ");
    var k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите b2: ");
    var b2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите k2: ");
    var k2 = Convert.ToDouble(Console.ReadLine());


    var x = (b2 - b1) / (k1 - k2);
    var y = k1 * x + b1;

    x = Math.Round(x, 3);
    y = Math.Round(y, 3);

    Console.WriteLine($"Пересечение в точке: ({x};{y})");
}