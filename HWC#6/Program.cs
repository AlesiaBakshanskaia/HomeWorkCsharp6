// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Console.WriteLine("Введите несколько цифр через пробел");
// string members = Console.ReadLine()!;

//Доп.Задача 
//Найти произведение всех элементов массива целых чисел, меньших заданного числа. Размерность массива –10. Заполнение массива осуществить случайными числами от 50 до 100.

Console.WriteLine("Введите число N");
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