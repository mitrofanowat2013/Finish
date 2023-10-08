// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
//  Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
//   лучше обойтись исключительно массивами.

string[] GetArrayStringConsole (string ConsolZnak)
{
    string[] arraylZnak = new string[ConsolZnak.Length];
    arraylZnak = ConsolZnak.Split(",");
    return arraylZnak;
}
string[] GetArrayThreeZnak (string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string Znak = array[i];
        if (Znak.Length <= 3)
        {
            count++;
        }
    }
    string[] arrayThreeZnak = new string[count];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        string Znak = array[i];
        if (Znak.Length <= 3)
        {
            arrayThreeZnak[j] = Znak;
            j++;
        }
    }
    return arrayThreeZnak;
}
void Print (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}
Console.Write("Введите массив через запятую (,) - ");
string inStringZnak = Console.ReadLine();
string[] arraylZnak = GetArrayStringConsole(inStringZnak);
Console.WriteLine();
Console.Write("Введенные символы - ");
Print(arraylZnak);
Console.WriteLine();
Console.Write("Массив из строк длинной меньше либо равны 3 - ");
Print(GetArrayThreeZnak(arraylZnak));
Console.WriteLine();