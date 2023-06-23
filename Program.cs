

//Console.Write("Введите имя:");
//string str = Console.ReadLine();

//Console.WriteLine($"Длина строки {str.Length}");

//if (str == "Маша"){
//    Console.WriteLine("Привет, Маша!");
//}
//else{
//    Console.WriteLine($"Кто ты? {str}");
//}


//Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] Arr = new int[4];
string tmp_str = "";

//void initarr(int[] Arr)
//{
//    for (int i = 0; i < Arr.Length; i++)
//    {
//        Arr[i] = Random.Shared.Next(-10, 10);
//        tmp_str += Arr[i].ToString() + ", ";
//    }
//}
//initarr(Arr);
//Console.WriteLine($"Первоначальный массив {tmp_str}");

//tmp_str = "";

//void invertarr(int[] Arr)
//{
//    for (int i = 0; i < Arr.Length; i++)
//    {
//        Arr[i] *= -1;
//        tmp_str += Arr[i].ToString() + ", ";
//    }
//}
//invertarr(Arr);
//Console.WriteLine($"Новый массив массив {tmp_str}");

void addelemarr(int[] Arr) {
    for (int i = 0; i < Arr.Length; i++)
    {
        Console.WriteLine("Введите элемент массива " + i);
        Int32.TryParse(Console.ReadLine(), out Arr[i]);
    }
}
addelemarr(Arr);

bool checkHasIntInArr (int[] Arr, int tmp_int) 
{

    for (int i = 0; i < Arr.Length; i++)
    {
        if (Arr[i] == tmp_int) { return true; }
    }
    return false;
}

int tmp_int = 0;
Console.WriteLine("Введите число.");
Int32.TryParse(Console.ReadLine(), out tmp_int);

if (checkHasIntInArr(Arr, tmp_int))
{
    Console.WriteLine("Такое число есть");
}
else {
    Console.WriteLine("Такого числа нет");
}


//Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6]-> 36 21
