var nota1 = 5.2;
var nota2 = 6.4;
var nota3 = 7.3;

var media = (nota1 + nota2 + nota3) / 3;

Console.WriteLine($"Média final: {Convert.ToInt32(media)}");

if (media >= 7)
{
    Console.WriteLine("Aprovado");
}
else if (media >= 5 && media < 7)
{
    Console.WriteLine("Recuperacção");
} else
{
   Console.WriteLine("Reprovado");
}