/*Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
Сделать через функции
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int GetValue(string msg)
{
    System.Console.Write(msg);
    string v = Console.ReadLine();
    return Convert.ToInt32(v);
}
int length = GetValue("Введите количество элементов массива: ");
int min = GetValue("Введите минимальное возможное число в  массиве: ");
int max = GetValue("Введите максимальное возможное число в массиве: ");

bool CheckNumbers(int min, int max, int length)
{
    if (max <= min)
    {
        Console.WriteLine("Максимальное значение должно быть больше минимального");
        return false;
    }
    if (length == 0)
    {
        Console.WriteLine(" количество элементов  не должно быть равно нулю");
        return false;
    }

    return true;
}

int[] SetArray(int length)
{
    int[] tempArr = new int[length];
    for (int i = 0; i < length; i++)
        tempArr[i] = new Random().Next(min, max);
    returntempArr;

}
void WriteArrayToConsole(int[] intArray)
{
    for (int i = 0; i < intArray.Length - 1; i++)
    {
        Console.Write(intArray[i]);
        Console.Write(",");
    }
    Console.WriteLine(intArray[intArray.Length - 1]);
}
if (CheckNumbers(min, max, length))
{
    Console.WriteLine("Получившийся массив:    ");
    WriteArrayToConsole(SetArray(length));
}



