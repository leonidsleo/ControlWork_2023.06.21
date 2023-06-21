// ЗАДАНИЕ КОНТРОЛЬНОЙ РАБОТЫ!
// Написать программу, которая из имеющегося 
// массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться к
// оллекциями, лучше обойтись исключительно массивами.

void NewArray(string[] array)
{
    for (int i = 0; i < array.Length; i++) 
    {
        Console.Write("Введите значение для массива = ");
        string value = Console.ReadLine();
        array[i] = value;
    }
}
void PrintArray(string[] array)
{
    Console.WriteLine("Array [\"{0}\"]", string.Join("\", \"", array));
}
Console.WriteLine("Значения для массива можно вносить как цифры, так и слова.");
Console.Write("Введите длинну массива = ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = new string[size];
NewArray(array);
PrintArray(array);
Console.WriteLine();
string[] array2 = new string[size];
int i = 0;
int j = 0;
while (i < size)
{
    if (array[i].Length <= 3)
    {
        array2 [j] = array [ i ];
        i++;
        j++;
    }
    else i++;
}
array2 = array2.Where(j => j != null).ToArray();
Console.WriteLine("Array2 [\"{0}\"]", string.Join("\", \"", array2));