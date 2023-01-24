// int[] CreateArray(){
//     int[] array = new int[10];
//     for(int i = 0; i < array.Length; i++){
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }
// void PrintNums(){
//     int[] array = CreateArray();
//     Console.WriteLine($"{String.Join(",", array)}");
//     int count = 0;
//     for(int i = 0; i < array.Length; i++){
//         if(array[i] % 2 ==0){
//             count++;
//         }
//     }
//     Console.WriteLine ($"Четных чисел в массиве ==> {count}");
// }

// PrintNums();

    
    
    // Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int[] Array(){
//     int[] array = new int[4];
//     for(int i=0;i < array.Length;i++){
//          array[i]=new Random().Next(1,100);
//     }
// return array;

// }
// void Pointsum(int[] array){
//     int sum = 0;
//     for(int i=0;i < array.Length;i++){
//         if(i % 2 != 0){
//             sum = sum + array[i];
//       }       
//     }
//     Console.WriteLine(sum);
// }
/*Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.*/
int[] startArray = GetArray(5, 0, 5);
Console.WriteLine(String.Join(" ", startArray));

Console.WriteLine(String.Join(" ", ResultArray(startArray)));

int[] GetArray(int a, int minValue, int maxValue)
{
    int[] res = new int[a];
    for(int i = 0; i < a; i++ ){
        res[i] = new Random().Next(minValue,maxValue + 1);     
        }
        return res;
}
int[] ResultArray(int[] array)
{
    int size = array.Length / 2;
    if (array.Length % 2 == 1) size++;
    int[] result = new int[size];
    for (int i = 0; i < array.Length / 2; i++){
        result[i] = array[i] * array[array.Length - 1 -i];
    }
    if (array.Length % 2 == 1) result[size-1] = array[array.Length / 2];
    return result;
}


 















