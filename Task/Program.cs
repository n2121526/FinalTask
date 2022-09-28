/*Test task. Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символам. 
Первоначальный массив ввести с клавиатуры или задать на старте.*/
string[] myArray = new string[] {};
Console.Write("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine());
myArray = new string[n];
for (int i = 0; i < myArray.Length; i++)
 {
     Console.Write($" Введите {i + 1} элемент: ");
     myArray[i] = Console.ReadLine();
 }

int GetArray(string[] array)
 {
     int count = 0;
     for (int i = 0; i < array.Length; i++)
     {
         if (array[i].Length <= 3)
             count++;
     }
     return count;
 }

 string PrintArray(string[] array)
 {
     string result = string.Empty;
     Console.WriteLine("Новый массив, соответствующий условию задачи :");
     result = "[ ";
     for (int i = 0; i < array.Length; i++)
     {
         result += $"{array[i], 1}";
         if (i < array.Length - 1)
             result += ", ";
     }
     result += " ]";
     return result;
 }

 string[] NewArray(string[] array, int count)
 {
     string[] result = new string[count];
     for (int i = 0; i < array.Length; i++)
     {
         if (array[i].Length <= 3)
         {
             result[result.Length - count] = array[i];
             count--;
         }
     }
     return result;
 }

int numElements = GetArray(myArray);
string[] newArray = NewArray(myArray, numElements);
Console.WriteLine($"{PrintArray(newArray)}");
