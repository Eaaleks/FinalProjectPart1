/*Напишите программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна три символа. Первоначальный массив можно вывести с клавиатуры  либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

   
Console.WriteLine("Введите элементы массива через запятую:");   // Запрос пользователю ввода элементов массива
string input = Console.ReadLine();

string[] array = input.Split(','); // Разбиение введенной строки на элементы массива

Console.WriteLine("Массив:");    // Вывод массива на консоль
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}

Console.WriteLine();

void SelectElements(string[] array)
{
    Random random = new Random(); // Создание экземпляра генератора случайных чисел

    int count = random.Next(4); // Генерация случайного числа от 0 до 3

    Console.WriteLine($"Выбрано {count} элементов:");

    for (int i = 0; i < count; i++)
    {
        int index = random.Next(array.Length); // Генерация случайного индекса элемента массива
        Console.WriteLine(array[index]); // Вывод элемента на консоль

        // Удаление выбранного элемента из массива
        string temp = array[index];
        array[index] = array[array.Length - 1];
        array[array.Length - 1] = temp;
        Array.Resize(ref array, array.Length - 1);
    }
}

SelectElements(array); // Вызов функции для вывода случайных элементов массива

