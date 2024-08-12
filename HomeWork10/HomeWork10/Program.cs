// See https://aka.ms/new-console-template for more information

//"1. Виведіть усі числа від 10 до 50 через кому"
Console.WriteLine(String.Join(',', Enumerable.Range(10, 41).ToArray()));

//"2. Виведіть лише ті числа від 10 до 50, які можна поділити на 3"
Console.WriteLine(String.Join(',', Enumerable.Range(10, 41).ToList().FindAll(i => i % 3 == 0)));

//"3. Виведіть слово Linq 10 разів"
Console.WriteLine(String.Join(',', Enumerable.Repeat("Linq", 10)));

//"4. Вивести всі слова з буквою «а» в рядку «aaa;abb;ccc;dap»"
Console.WriteLine(String.Join(',', "aaa;abb;ccc;dap".Split(';').ToList<string>().FindAll(i => i.Contains('a'))));

//"5. Виведіть кількість літер «а» у словах з цією літерою в рядку «aaa;abb;ccc;dap» через кому"
Console.WriteLine(String.Join(',', "aaa;abb;ccc;dap".Split(';').ToList().FindAll(i => i.Contains('a')).Select(i => i.Count(c => c == 'a'))));

//"6. Вивести true, якщо слово abb існує в рядку aaa;xabbx;abb;ccc;dap, інакше false"
Console.WriteLine("aaa;xabbx;abb;ccc;dap".Split(';').ToList<string>().Any<string>(i => i == "abb"));

//"7. Отримати найдовше слово в рядку aaa;xabbx;abb;ccc;dap");
Console.WriteLine("aaa;xabbx;abb;ccc;dap".Split(';').ToList().OrderByDescending(i => i.Length).First());

//"8. Обчислити середню довжину слова в рядку aaa;xabbx;abb;ccc;dap"
Console.WriteLine("aaa;xttttabbx;abb;cccaaa;dap".Split(';').ToList<string>().Average(i => i.Length));

//"9. Вивести найкоротше слово в рядку aaa;xabbx;abb;ccc;dap;zh у зворотному порядку"
Console.WriteLine(String.Join("", "aaa;xabbx;abb;ccc;dap;zh".Split(';').ToList().OrderBy(i => i.Length).First().Reverse()));

//"10. Вивести true, якщо в першому слові, яке починається з aa, усі літери b (За винятком аа), інакше false baaa;aabb;aaa;xabbx;abb;ccc;dap;zh"
Console.WriteLine("baaa;aabb;aaa;xabbx;abb;ccc;dap;zh".Split(';').ToList<string>().Find(i => i.StartsWith("aa"))?.Skip(2).ToArray<char>().All(c => c == 'b'));

//"11. Вивести останнє слово в послідовності, за винятком перших двох елементів, які закінчуються на bb (використовуйте послідовність із 10 завдання) baaa;aabb;aaa;xabbx;abb;ccc;dap;zh"
Console.WriteLine("baaa;aabb;aaa;xabbx;abb;ccc;dap;zh".Split(';').Skip(2).ToList().FindLast(i => i.Remove(0, i.Length - 2) == "bb"));
