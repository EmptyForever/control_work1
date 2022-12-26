Console.Clear();

// метод для нахождения кол-ва строк, размер которых не больше 3
int HowManyStringMore3(string[] arr1)
{
    int k = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3) k++;
    }
    return k;
}

// метод для присваивания значений новому массиву -->из другого массива
string[] FillArr(string[] arr1, int size)
{
    string[] arr2 = new string[size];
    int j = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3)
        {
            arr2[j] = arr1[i];
            j++;
        }
    }
    return arr2;
}

// метод для печати массива
void PrintArray(string[] arr)
{
    if (arr.Length == 0) 
    {
        Console.Write("[");
        Console.Write("]");
        return;
    }
    Console.Write("[");
    int last = 0;
    if (arr.Length > 1)
    {
        for (int i = 0; i <= arr.Length - 2; i++)
        {
            Console.Write($"{arr[i]}, ");
            last = i;
        }
        last = last + 1;
        Console.Write(arr[last]);
    }
    else Console.Write(arr[last]);
    Console.Write("]");
}

Console.WriteLine("Введите размер будущегом ассива: ");
int size1 = Convert.ToInt32(Console.ReadLine());

// создаём массив из size1 элементов
string[] array1 = new string[size1]; 
for (int i = 0; i < array1.Length; i++)
{
    Console.Write($"Задайте строку {i + 1}: \n");
    array1[i] = Console.ReadLine();
    if (array1[i] == string.Empty)
    {
        array1[i] = "-";
    }
}

int howMany = HowManyStringMore3(array1);
Console.WriteLine($"{howMany}");
string[] newArray = FillArr(array1, howMany);
Console.WriteLine("Исходный массив строк: ");
PrintArray(array1);
Console.WriteLine($"\n\nНовый массив размером --> ({howMany}) \n с элементами длинной меньше 4: ");
PrintArray(newArray);

// Калинкин Алексей