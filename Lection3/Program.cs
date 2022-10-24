// Вид 1
// void Method1()
// {
//     Console.WriteLine("Привет");
// }

//Method1();

// Вид 2
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }

//Method2("Текст сообщения");

// Вид 21
// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }

// Method21(msg:"Текст сообщения", count:4);

//вид 3 что-то возвращает но ничего не принимает
// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year);

//вид 4 что-то принимают и отдают

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = string.Empty;
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
// return result;
// }

// string res = Method4(10,"текст ");
// Console.WriteLine(res);


//--------------------------------------------
// string Method4(int count, string text)
// {
//     string result = string.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }

//     return result;
// }

// string res = Method4(10, "текст ");
// Console.WriteLine(res);

//---------------------------------------------
// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i*j}");
//     }
//     Console.WriteLine();
// }

//----------------------------------------------
//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

// string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
// + "ежели бы вас послали вместо нашего милого Винценгероде,"
// + "вы бы взяли приступом согласие прусского короля."
// + "Вы так красноречивы. Вы дадите мне чаю?";

// string Replace(string text, char oldvalue, char newvalue)
// {
//     string result = string.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldvalue)
//         {
//             result = result + $"{newvalue}";
//         }
//         else
//         {
//             result = result + $"{text[i]}";
//         }
//     }


//     return result;
// }

// string newtext = Replace(text, ' ', '|');
// Console.WriteLine(newtext);

// Console.WriteLine();
// newtext = Replace(newtext, 'к', 'К');
// Console.WriteLine(newtext);

// Console.WriteLine();
// newtext = Replace(newtext, 'с', 'С');
// Console.WriteLine(newtext);


//сортировка----------------------------------------------
int[] array = { 1, 5, 4, 3, 2, 6, 7, 1, 1, };

void Printarray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{

    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition])
            {
                minPosition = j;
            }
        }



        int temporrary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporrary;
    }
}



Printarray(array);
SelectionSort(array);
Printarray(array);