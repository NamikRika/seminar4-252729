// // Задача 25: Напишите цикл, который принимает на вход 
// // два числа (A и B) и возводит число A в натуральную степень B.
// // 3, 5 -> 243 (3⁵)
// // 2, 4 -> 16

// Console.WriteLine("Задача 25 \n Напишите цикл, который принимает на вход  \n два числа (A и B) и возводит число A в натуральную степень B.");
// Console.WriteLine();
// Console.WriteLine("Решение");   
// Console.WriteLine();

// void chisloVstepen (int chisloN, int stepenChisla)
// {
//     int rezultat = chisloN;

//      for (int i=1; i < stepenChisla; i++)
//     {
//        rezultat = rezultat * chisloN ;        
       
//     } 

//     Console.WriteLine("Число " + chisloN + " в степени " + stepenChisla + " равно " + rezultat);
 
// }

// Console.Write("Введите число A ");    
// int chisloA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B ");    
// int chisloB = Convert.ToInt32(Console.ReadLine());

// chisloVstepen (chisloA, chisloB);

// // Задача 25 - завершена -----------------------------------------------



// // Задача 27: Напишите программу, которая принимает на вход число 
// //             и выдаёт сумму цифр в числе.
// // 452 -> 11
// // 82 -> 10
// // 9012 -> 12

// Console.WriteLine("Задача 27 \n Напишите программу,  \n которая принимает на вход число и выдаёт сумму цифр в числе.");
// Console.WriteLine();
// Console.WriteLine("Решение");   
// Console.WriteLine();
  
// int SummaCifrVchisle (int chisloN)
// {
//     int rezultatChislo = 0;
//     string txtChislaN = Convert.ToString(chisloN);

//     for (int i = 0; i < txtChislaN.Length; i++) 
//       {
//           string rezultat = txtChislaN.Substring(i, Math.Min(txtChislaN.Length, 1));
//           rezultatChislo = rezultatChislo + Convert.ToInt32(rezultat);        
//       }

     
//      return rezultatChislo;
// }    
    
// Console.Write("Введите число, сумму цифр которых хотите посчитать: ");    
// int chisloP = Convert.ToInt32(Console.ReadLine());    
// SummaCifrVchisle (chisloP);              
// Console.WriteLine(SummaCifrVchisle (chisloP));
               
// // Задача 27 - завершена -----------------------------------------------


// // Задача 29: Напишите программу, которая задаёт массив 
// // из m элементов и выводит их на экран.
// // m = 5 -> [1, 2, 5, 7, 19]
// // m = 3 -> [6, 1, 33]
    
// Console.WriteLine("Задача 29 \n Напишите программу, которая задаёт массив из m элементов \n и выводит их на экран.");
// Console.WriteLine();
// Console.WriteLine("Решение");   
// Console.WriteLine();

// int [] GreateMarray (int chisloM)
// {
//    Random rnd = new Random();
//    int[] myArray = new int [chisloM];

//    for (int i = 0; i < chisloM; i++) 
//    {
//      myArray[i] = rnd.Next(0, 10);     
     
//    }

//   return myArray;

// }

// void ShowArray(int[] array)
// {
//    for (int i = 0; i < array.Length; i++)
//    {
//     Console.Write(array[i] + " ");
    
//    }
//    Console.WriteLine();
// }

// Console.Write("Введите чмслов  ");
// int chisloP = Convert.ToInt32(Console.ReadLine());

// int[] myArray2 = GreateMarray(chisloP);

// ShowArray(myArray2);

// // Задача 29 - завершена ------------------------------------



// // ---------Дополнительная задача - Заполнение массива с консоли ---------

// // Дополнительная задача, поставленная преподавателем в конце урока
// // Программа запрашивает у пользователя размер создаваемого массива
// // после у пользователя запрашиваются значения массива в том количестве
// // которому равен создаваемый массив

// int [] GreateArray (int size)
// {
//    int[] myArray = new int [size];
//    int kolvoDannix = 1;

//    for (int i = 0; i < size; i++) 
//    {
    
    
//     Console.Write("Введите " + kolvoDannix++ + " " + "число заполняемого массива ");
//      myArray[i] = Convert.ToInt32(Console.ReadLine());     
     
//    }

//   return myArray;

// }

// void ShowArray(int[] array)
// {
//    for (int i = 0; i < array.Length; i++)
//    {
//     Console.Write(array[i] + " ");
    
//    }
//    Console.WriteLine();
// }

// Console.Write("Введите размер заполняемого массива  ");

// int size = Convert.ToInt32(Console.ReadLine());

// int[] myArray2 = GreateArray(size);
// ShowArray(myArray2);  






