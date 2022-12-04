// // Напишите программу, которая задает массив из 8 элементов и выводит их на экран

Console.Clear();

int[] array = new int[8];
for (int i = 0; i < 8; i++)
{
  Console.Write("Введите элемент массива: ");
      int element = Convert.ToInt32(Console.ReadLine());
      array[i] = element;
}
Console.WriteLine($"[{string.Join(", ", array)}]"); 