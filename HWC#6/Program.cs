// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Первый вариант решения
/*
int[] Array = GetArray(5);
Console.WriteLine(String.Join(" ", Array));
Console.WriteLine($"Вы ввели {numplus(Array)}  чисел больше нуля");


int numplus (int[] array){
    int count = 0;
    foreach (int element in Array){
        if (element > 0){
            count += 1;
        }
        
    }
    return count;
}

int[] GetArray (int size){
    int[] res = new int[size];
    for (int i = 0; i < size; i++){
        Console.WriteLine("Введите  целое число");
        res[i] = int.Parse(Console.ReadLine()!);
    }
    return res;
}

*/


/*
// Второй вариант решения
Console.WriteLine("Введите несколько чисел через пробел");
string Numbers = Console.ReadLine()!;
string[] negative = Numbers.Split(new char[] { ' '});
//string[] negative = Numbers.Split(new char[] { ' ', '.', ',', }, StringSplitOptions.RemoveEmptyEntries);
double[] Array = new double [negative.Length];
for (int i = 0; i < negative.Length; i++) {
        Array[i] = Convert.ToDouble(negative[i]);
   }
Console.WriteLine(String.Join(" ", Array));


int count = 0;
for (int i = 0; i < Array.Length; i++) { 
    if (Array[i] > 0){
        count += 1;
    }
}
Console.WriteLine($"Вы ввели {count} цифр(у,ы) больше нуля");
*/


//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите  целое число b1");
double b1 = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("Введите  целое число k1");
double k1 = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("Введите  целое число b2");
double b2 = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("Введите  целое число k2");
double k2 = Convert.ToDouble(Console.ReadLine()!);
if (k1 == k2){
     Console.WriteLine("Прямые, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2 параллельны и не пересекаются");
}
else {
    double x = (b1 - b2) / (k2 - k1);
    double y = k1 * x + b1;
    Console.WriteLine($"Координаты точки пересечения прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2 ({x:f3};{y:f3})");
}





//Доп.Задача 
//Найти произведение всех элементов массива целых чисел, меньших заданного числа. Размерность массива –10. Заполнение массива осуществить случайными числами от 50 до 100.

/*Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine()!);
int[] Array = GetArray(10, 50, 100);
Console.WriteLine(String.Join(" ", Array));
if (Multiply( N) == 1){
    Console.WriteLine($"В массиве нет чисел меньше {N}");
}
else Console.WriteLine($"Произведение элементов массива, меньших {N}, равно {Multiply(N)}");

//Метод поиска произведения чисел меньших N

int Multiply( int num){
    int result = 1;
    foreach (int element in Array){
        if (element < N){
            result = result * element ;
        }
        
    }
    return result;
}

//Метод задания массива
int[] GetArray (int size, int min, int max){
    int[] res = new int[size];
    for (int i = 0; i < size; i++){
        res[i] = new Random().Next(min, max+1);
    }
    return res;
}
*/