//из имеющегося массива строк формирует массив из строк, длинна которых меньше либо равна 3 симолов
Console.Clear();
string [] arr = {"Kate", "Ted", "John", "Mary", "Lu"};
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i].Length <= 3)
    Console.Write($"{arr[i]} ");
}