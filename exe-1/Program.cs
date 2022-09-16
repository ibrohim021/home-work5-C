// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] array = new int [4];

int[] createArray() //Функция создает массив
{
    var random = new Random();
    var result = new int[4];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = random.Next(100, 999);
        
    }
    return result;
}

var array = createArray(); // 
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}

int even_number(int[] array){
    int quantity = 0;
    for (int i = 0; i<array.Length; i++ ){
    if (array[i] % 2 == 0)
    {
      quantity++;
    }
  }
  return quantity;
}

int quantity = even_number(array);
Console.WriteLine($"Количество чётных чисел в массиве: {quantity}");
