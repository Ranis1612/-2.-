int Max( int arg1, int arg2, int arg3)
{
  int result = arg1;
  if(arg2 > result) result = arg2;
  if(arg3 > result) result = arg3;
  return result;
}
//            [ 0  1  2  3  4   5  6  7  8 ]  в массиве отсчёт начинается с нуля
int [] array = {11,42,33,74,65,56,77,28,19};
array [0] = 12;

Console.Write(array[0]);