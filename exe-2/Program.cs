// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] createArray() //Функция создает массив
{
    var random = new Random();
    var result = new int[4];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = random.Next(1, 10);
        
    }
    return result;
}

var array = createArray(); // 
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}

int even_number(int[] array){
    int sumElements = 0;
    for (int i = 0; i<array.Length; i++ ){
        if (i % 2 == 0)
        {
            sumElements = sumElements + array[i];
        }
  }
  return sumElements;
}

int even_num = even_number(array);
Console.WriteLine($"Cумму элементов, стоящих на нечётных позициях = {even_num}");
