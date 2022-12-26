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

