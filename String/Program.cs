//https://gbcdn.mrgcdn.ru/uploads/asset/4312773/attachment/ed8c1f2c15da325114976e1c313ef5f8.png
// написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше или равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо 
// задать на старте выполнения алгоритма. При решении не рекоментуется пользоваться коллекциями, лучше
// обойтись исключительно массивами.
//  ["hello", "2","world", ":-)"] -> ["2", ":-)"]


String [] random_in = new String [] {"hello", "2", "world", ":-)"};
//  Console.WriteLine(String.Join("\n", random_in)); 
int n = random_in.Length;
int j = 0;


    for (int i = 0; i<n; i++)
    {String temp = random_in[i];
    
    if (temp.Length<=3) 
        {random_in[j]=temp; 
        j++;
        }
    }

  

      // Function to perform sorting
    
   
//  Console.WriteLine(String.Join("\n", random_in)); 

void printArraystring(String []str, int n)
    {
        for (int i=0; i<n; i++)
            Console.Write(str[i]+" ");
    }
printArraystring(random_in,j);
Console.WriteLine();


