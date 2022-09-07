// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

Console.Clear();
Console.WriteLine("Введите координаты");
Console.Write("Координата X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Координата Y: ");
int y = Convert.ToInt32(Console.ReadLine());

string Qu (int x1, int y1)
{
    if (x1 > 0 && y1 > 0) return "Первая четверть";
    if (x1 < 0 && y1 > 0) return "Вторая четверть";
    if (x1 < 0 && y1 < 0) return "Третья четверть";
    if (x1 > 0 && y1 < 0) return "Четвертая четверть";
    return ("Введите корректные координаты");
}

string result = Qu (x, y);
Console.WriteLine(result);
