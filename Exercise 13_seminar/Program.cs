/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет. 645 -> 5, 78 -> третьей цифры нет, 32679 -> 6 */

void FillArray(int[] massiv1)
{
int length1 = massiv1.Length;
int index1 = 0;
while (index1 < length1)
{
massiv1[index1] = new Random().Next(1,10);
index1++;
}

}

void PrintArray(int[] massiv2)
{int lengh2 = massiv2.Length;
 int index2 = 0;
 while(index2 < lengh2)
 {Console.Write(massiv2[index2]);
  index2++;
  }
}

int[] array = new int[3]; // обьявляем массив с n-ю элементами

FillArray(array);
PrintArray(array);

int lengh = array.Length;
if(lengh < 3) {Console.WriteLine("-> Третей цифры нет!");}
else {Console.WriteLine("-> " + array[2] ); }
