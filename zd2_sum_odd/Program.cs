Console.Clear();
int[] arr = GetArray(10, -9, 11);
PrintArray(arr);
Console.WriteLine($"Сумма чисел, находящихся на нечетных позициях = { GetSumOddIndex(arr)}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}

int GetSumOddIndex(int[] array){
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2){
        sum += array[i];
    }
    return sum;
}

void PrintArray(int[] array){
    Console.WriteLine(String.Join(", ", array));
            
}