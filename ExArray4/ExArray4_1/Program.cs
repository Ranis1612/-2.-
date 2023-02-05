void FillArray(int[] collection) // void это метод который не возвращает переменную, поэтому не используется оператор return
{
  int length = collection.Length;
  int index = 0;
  while (index < length)
  {
    collection[index] = new Random().Next(1, 10); // 
    index++; // index = index + 1
  }
};
void PrintArray(int[]col)
{
  int count = col.Length;
  int position = 0;
  while(position < count)
  {
    Console.WriteLine(col [position]);
    position++;
  }
};

int IndexOf(int[] collection, int find)
{
  int count = collection.Length;
  int index = 0;
  int position = 0; // вместо 0 пишем -1. если искомого элемента нет в массиве, индекс будет показываться как -1.  
  while(index < count)
  {
    if(collection[index] == find)
    {
      position = index;
      break; // добавили break 
    }
    index++;
  }
return position;
};
int [] array = new int[10]; // new int[10]= создай новый массив в котором будет 10 элементов по умолчанию он будет наполнен нулями
FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos = IndexOf(array, 4);// ищем 4ку в массиве
Console.WriteLine(pos); // получаем индекс этой 4ки первой по порядку
