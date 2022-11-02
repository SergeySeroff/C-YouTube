string str = "5";

int a = int.Parse(str); // можно double.Pars(str) если дробное число

string str1 = "5jhjkg";
try
{
    int b = Convert.ToInt32(str1); // можно int.Parse(str1)
    Console.WriteLine("Успешная конвертация");
}
catch (Exception)
{
    Console.WriteLine("Ошибка при конвертации");
}

string str2 = "1 dfsd sfsdf";

int c;

bool result = int.TryParse(str2, out c);

if (result)
{
    Console.WriteLine("Операция успешна, значение = " + c);
}
else
{
    Console.WriteLine("Не удалось конвертировать!");
}