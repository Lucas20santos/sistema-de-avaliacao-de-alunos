static void Menu()
{
    Console.WriteLine("[0] - Sair do Programa");
    Console.WriteLine("[1] - Adicionar Aluno");
    Console.WriteLine("[2] - Adicionar Notas");
    Console.WriteLine("[3] - Media do Aluno");
    Console.WriteLine("[4] - Status do Aluno");
}

static bool ValidarOpcao(string? entrada, out int opcao)
{
    if (string.IsNullOrWhiteSpace(entrada))
    {
        opcao = 0;
        return false;
    }
    return int.TryParse(entrada, out opcao);
}

Menu();

Console.Write("Escolha uma opção: ");
string? entrada = Console.ReadLine();

if(ValidarOpcao(entrada, out int opcao))
{
    while(opcao != 0)
    {
        
    }
}
