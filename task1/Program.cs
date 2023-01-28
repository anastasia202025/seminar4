/*Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Не использовать Math.Pow

3, 5 -> 243 (3⁵)

2, 4 -> 16*/


int GetValue(string msg)
{
    System.Console.Write(msg);
    string v = Console.ReadLine();
    return Convert.ToInt32(v);

}
bool CheckNumber(int b)
{
    if (b < 0)
    {
        Console.WriteLine("Показатель не должен быть отрицательным");
        return false;
    }
    return true;
}
long MyPow(int a, int b)
{
    int degree = 1;
    long result = a;
    while (degree < Math.Abs(b))
    {
        result *= a;
        degree++;
    }
    return result;
}

int a = GetValue("Введите основание числа:  ");
int b = GetValue("Введите показатель числа:  ");

if (CheckNumber(b))
{
    long result = MyPow(a, b);
    System.Console.WriteLine($"{a} ^ {b}={result}");
}


