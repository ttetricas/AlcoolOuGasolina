string recomendacao;

Console.WriteLine("--Etanol ou Gasolina--\n");

Console.Write("Digite o preço do etanol (R$): ");
decimal etanol = Convert.ToDecimal(Console.ReadLine()!);
Console.Write("Digite o preço da gasolina (R$): ");
decimal gasolina = Convert.ToDecimal(Console.ReadLine()!);

if (DevoUsarGasolina(etanol, gasolina))
{
    recomendacao = "Gasolina";
}

else
{
    recomendacao = "Etanol";
}

double razao = CalcularRazao(etanol, gasolina) * 100;

Console.WriteLine($"\nO preço do etanol corresponde a {razao:N1}% do preço da gasolina.");
Console.WriteLine($"\nRecomendacao: Abasteça com {recomendacao.ToUpper()}.");

static double CalcularRazao(decimal precoEtanol, decimal precoGasolina)
{
    return Convert.ToDouble(precoEtanol / precoGasolina);
}
static bool DevoUsarGasolina(decimal precoEtanol, decimal precoGasolina)
{
    const double PORCENTAGEM = 0.73;
    return CalcularRazao(precoEtanol, precoGasolina) >= PORCENTAGEM;
}