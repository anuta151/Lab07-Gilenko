// // // задание 1.1
// // string[] days = { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };

// // for (int i = days.Length - 1; i >= 0; i--)
// // {
// //     Console.WriteLine($"{i}: {days[i]}");
// // }
// // // задание 1.2
// // double[] temps = { -5.5, -2.0, 0.5, 3.2, 6.8, 4.1, -1.3 };

// // foreach (double t in temps)
// // {
// //     Console.Write($"{t} ");
// // }
// // Console.WriteLine();
// // // задание 2
// // int[] prices = { 120, 45, 300, 80, 15, 210 };
// // int sum = 0;
// // int over100 = 0;
// // foreach (int price in prices)
// // {
// //     sum += price;
// //     if (price > 100)
// //     {
// //         over100++;
// //     }
// // }
// // double average = (double)sum / prices.Length;
// // Console.WriteLine($"Сумма: {sum}");
// // Console.WriteLine($"Средняя цена: {average:F2}");
// // Console.WriteLine($"Товаров дороже 100: {over100}");
// // // задание 3
// // int[] prices2 = { 120, 45, 300, 80, 15, 210 };
// // int min = prices2[0];
// // int maxIndex = 0;
// // for (int i = 1; i < prices2.Length; i++)
// // {
// //     if (prices2[i] < min)
// //     {
// //         min = prices2[i];
// //     }
// //     if (prices2[i] > prices2[maxIndex])
// //     {
// //         maxIndex = i;
// //     }
// // }
// // Console.WriteLine($"Минимальная цена: {min}");
// // Console.WriteLine($"Индекс самого дорогого товара: {maxIndex} (цена {prices2[maxIndex]})");
// // // задание 4
// // int[] balance = { 100, -50, 20, -5, 0, 75 };
// // for (int i = 0; i < balance.Length; i++)
// // {
// //     if (balance[i] < 0)
// //     {
// //         balance[i] = 0;
// //     }
// // }
// // Console.WriteLine("Изменённый массив:");
// // foreach (int b in balance)
// // {
// //     Console.Write($"{b} ");
// // }
// // Console.WriteLine();
// // // задание 5
// // int[] userNumbers = new int[5];
// // for (int i = 0; i < userNumbers.Length; i++)
// // {
// //     Console.Write($"Введите число {i + 1}: ");
// //     userNumbers[i] = int.Parse(Console.ReadLine());
// // }
// // Console.WriteLine("Массив в обратном порядке:");
// // for (int i = userNumbers.Length - 1; i >= 0; i--)
// // {
// //     Console.Write($"{userNumbers[i]} ");
// // }
// // Console.WriteLine();
// // int evenCount = 0;
// // foreach (int n in userNumbers)
// // {
// //     if (n % 2 == 0)
// //     {
// //         evenCount++;
// //     }
// // }
// // Console.WriteLine($"Чётных чисел: {evenCount}");
// // // задание 6
// // string[] names = { "Анна", "Игорь", "Мария", "Олег", "Ольга" };
// // Console.Write("Введите имя для поиска: ");
// // string searchName = Console.ReadLine();
// // int foundIndex = -1;
// // for (int i = 0; i < names.Length; i++)
// // {
// //     if (names[i] == searchName)
// //     {
// //         foundIndex = i;
// //         break;
// //     }
// // }
// // if (foundIndex >= 0)
// // {
// //     Console.WriteLine($"Имя найдено на позиции {foundIndex}");
// // }
// // else
// // {
// //     Console.WriteLine("Не найдено");
// // }
// // Итоговая задача: Журнал оценок
// int[] grades = { 5, 4, 3, 5, 4, 2, 5, 4 };
// // 1 все оценки
// Console.Write("Оценки: ");
// foreach (int g in grades)
// {
//     Console.Write($"{g} ");
// }
// Console.WriteLine();
// // 2 средняя оценка
// int total = 0;
// foreach (int g in grades)
// {
//     total += g;
// }
// double avg = (double)total / grades.Length;
// Console.WriteLine($"Средняя оценка: {avg:F2}");
// // 3 наибольшая и наименьшая
// int max = grades[0];
// int min = grades[0];
// for (int i = 1; i < grades.Length; i++)
// {
//     if (grades[i] > max) max = grades[i];
//     if (grades[i] < min) min = grades[i];
// }
// Console.WriteLine($"Наибольшая: {max}");
// Console.WriteLine($"Наименьшая: {min}");
// // 4 количество двоек и пятёрок
// int twos = 0;
// int fives = 0;
// foreach (int g in grades)
// {
//     if (g == 2) twos++;
//     if (g == 5) fives++;
// }
// Console.WriteLine($"Двоек: {twos}");
// Console.WriteLine($"Пятёрок: {fives}");
// // 5 статус
// if (avg >= 4.5)
// {
//     Console.WriteLine("Отличник");
// }
// else if (avg >= 3.5)
// {
//     Console.WriteLine("Хорошист");
// }
// else
// {
//     Console.WriteLine("Есть над чем поработать");
// }
// Дополнительное задание: разворот массива
int[] arr = { 1, 2, 3, 4, 5, 6 };
for (int i = 0; i < arr.Length / 2; i++)
{
    int temp = arr[i];
    arr[i] = arr[arr.Length - 1 - i];
    arr[arr.Length - 1 - i] = temp;
}
Console.WriteLine("Развёрнутый массив:");
foreach (int x in arr)
{
    Console.Write($"{x} ");
}
Console.WriteLine();