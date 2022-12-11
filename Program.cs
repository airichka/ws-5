/* замена элементов массива (положительных на отриц)*/

int [] array = new int [10] ;

for(int i = 0; i < array.Length; i++)
array[i] = new Random().Next(-9, 10);
print(array);

invers(array);
print(array);

void invers(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
arr[i] = -arr[i];
}
























void print(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    Console.Write($"{arr[i]}");
    Console.WriteLine();
}