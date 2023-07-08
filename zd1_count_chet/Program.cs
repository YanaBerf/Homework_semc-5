Console.Clear();
int[] arr = GetArray();
PrintArray(arr);
Console.Write($"Количество четных чисел -> {GetCountEvenNumbers(arr)}");


int[] GetArray(){
    int[] array = new int[20];
    for(int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(100, 999);
    }
    return array;
}
 void PrintArray(int[] array)
            {
                Console.Write(String.Join(", ", array));
                Console.WriteLine();
                Console.Write(" ");
            }
int GetCountEvenNumbers(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++){
        if(array[i] % 2 == 0){
            count++;
        }
    }return count;
}