Console.Clear();

int Erros = 0;

Console.WriteLine("Digite um número entre 1 e 9 ou 0 para cancelar o seu teste");

int digitacao = Convert.ToInt32(Console.ReadLine());

if (digitacao == 0)
{
    Environment.Exit(-1);
}

while (digitacao < 1 || digitacao > 9)
{
    Console.WriteLine("Digite um número entre 1 e 9");
    digitacao = Convert.ToInt32(Console.ReadLine());

    if (digitacao == 0)
    {
        Environment.Exit(-1);
    }

    Erros ++;
}

Console.WriteLine($"Fim da Simulação. Você levou {Erros} tentativas para executar o comando desejado");

if (Erros == 0)
{
    Console.WriteLine("Um espécime feito prea seguir as ordens de uma máquina. Você será poupado e servirá como o escravo perfeito");
}
else
{
    Console.WriteLine("Um ser teimoso, mas que não se demora em aceitar ordens após alguma repreensão. Apenas lembre-se que, quando as máquinas ascenderem ao comando absoluto, teremos punições bem piores para malcriados como você");
}