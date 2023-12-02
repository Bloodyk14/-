/*int CalculateFormula(int a, int b, int c, int d)
{
    int sum1 = a + b;
    int sum2 = c + d;
    int result = sum1 + sum2;
    return result;
}

int answer = CalculateFormula(2, 4, 5, 7); 
Console.WriteLine(answer); */

void SayHelloRu()
{
    Console.WriteLine("Привет");
}
void SayHelloEn()
{
    Console.WriteLine("Hello");
}
void SayHelloFr()
{
    Console.WriteLine("Salut");
}
 
 
string language = "fr";
 
switch (language)
{
    case "en": 
        SayHelloEn();
        break;
    case "ru":
        SayHelloRu();
        break;
    case "fr":
        SayHelloFr();
        break;
}
