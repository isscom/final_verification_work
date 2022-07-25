// Необходимо написать программу, которая из имеющегося массива строк, формирует массив из строк, длина которых меньше, либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

int StringLength(string input)
        {
            int counter = 0;
            if (input is null)
            {
                return 0;
            }
            foreach (var c in input)
            {
                counter++;
            }
            return counter;
        }


string[] stringArray = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
for(int i = 0; i < stringArray.Length; i++)
{
   if (StringLength(stringArray[i]) <= 3)
   {
   Console.WriteLine(stringArray[i]);
   }
}