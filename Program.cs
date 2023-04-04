Console.WriteLine($"Escolha a bebida que voce quer: Coca-cola, suco de laranja, água ou Redbull");
string bebidaEscolhida = Console.ReadLine();

Console.WriteLine($"Deseja adicionar gelo a sua bebida? responda sim ou não ");
string gelo = Console.ReadLine();

switch (bebidaEscolhida)
{
    case "Coca-cola":

    if (gelo == "sim")
    {
    Console.WriteLine($"Aqui está sua Coca-cola com gelo ");
    }
    else
    {
        Console.WriteLine($"Aqui está sua Coca-cola sem gelo ");
    }
    break;


    case "Água":

    if (gelo == "sim")
    {
    Console.WriteLine($"Aqui está sua Água com gelo ");
    }
    else
    {
        Console.WriteLine($"Aqui está sua Água sem gelo ");
    }
    break;


    case "Suco de laranja":

    if (gelo == "sim")
    {
    Console.WriteLine($"Aqui está seu Suco de laranja com gelo ");
    }
    else
    {
        Console.WriteLine($"Aqui está seu Suco de laranja sem gelo ");
    }
    break;


    case "Redbull":

    if (gelo == "sim")
    {
    Console.WriteLine($"Aqui está seu Redbull com gelo ");
    }
    else
    {
        Console.WriteLine($"Aqui está seu Suco de laranja sem gelo ");
    }
    break;

    default:
    Console.WriteLine($"Essa bebida não tem em nosso cardápio");
    break;
}




