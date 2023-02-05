int [] array = {14, 82, 34, 45, 16, 87, 128, 18 };

int n = array.Length;
int find =18;

int index =0;

while(index < n)
{
  if(array[index] == find)
  {
    Console.WriteLine(index);// Мы ищем индекс определённого числа
    break; // оператор останавливает работу при нахождении индекса
  }
  // index = index + 1
  index++;
}