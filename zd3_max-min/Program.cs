Console.Clear();
double[] arr = GetArray(6);
PrintArray(arr);
double[] arr2 = GetDiffMaxMin(arr);
Console.WriteLine($"max - min: {(arr2[0] -arr2[1]):f2}");

double[] GetArray(int size){
    double[] array = new double[size];
    Random rand = new Random();
    for(int i = 0; i < size; i++){
        array[i] = rand.Next(-10, 10) + rand.NextDouble();

    }return array;
}

double[] GetDiffMaxMin(double[] array){
    double max = array[0];
    double min = array[0]; 
    double[] maxmin = new double[2];

    for(int i = 0; i < array.Length; i++){
        if(array[i] > max){
            max = array[i];
            maxmin[0] = max;
        } 
        if(array[i] < min){
            min = array[i];
            maxmin[1] = min;
        } 
    }
     return maxmin;
}

void PrintArray(double[] array){
    Console.WriteLine(String.Join(", ", array));
            
}