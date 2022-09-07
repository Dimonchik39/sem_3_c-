// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.Clear();
Console.WriteLine("Введите номер четверти: ");
int Qu = Convert.ToInt32(Console.ReadLine());

string coor (int Qu1)
{
    if (Qu1 == 1) return "x1 > 0 / y1 > 0";
    if (Qu1 == 2) return "x1 < 0 / y1 > 0";
    if (Qu1 == 3) return "x1 < 0 / y1 < 0";
    if (Qu1 == 4) return "x1 > 0 / y1 < 0";
    return ("Введите номер четверти от 1 до 4");
}

string results = coor(Qu);
Console.WriteLine(results);
