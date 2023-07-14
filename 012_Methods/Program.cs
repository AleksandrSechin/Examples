// Вид метода 1 не принимает и не возвращает

void Method1()
{
    Console.WriteLine("Автор такой-то");
}
// Method1();



// Вид метода 2 принимает но не возвращает

void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21("Текст", 4);  Method21(count: 4, msg: "Текст новый");



// Вид метода 3 не принимает но что-то возвращает

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
// Console.WriteLine(year);


// Вид метода 4 что-то принимает и что-то возвращает

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; // пустая строка

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);