// есть массив array из n элементов, требуется найти элемент массива равный find 

int[] array = { 1, 12, 21, 45, 67, 18, 17, 45 };

int n = array.Length;
int find = 45;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; //остановка поиска после первого найденног, если одинаковые значения элементов в массиве
    }
    index++; // index = index + 1
}


