Console.WriteLine("Введите размер массива ");
int a = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[a];
for (int i = 0; i < a; i++)
{
    Console.WriteLine("Введите число или команду (end) для завершения ");
    string res = Console.ReadLine();

    arr[i] = Convert.ToInt32(res);

}
Console.WriteLine(" ");
Console.Write("[");
PrintArray(arr);
Console.Write("]");


static void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
        if (i < count - 1)
        {
            Console.Write(", ");
        }
    }
}
