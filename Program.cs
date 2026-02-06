string jogadorUm;
int jogadorUmPonto = 0;

string jogadorDois;
int jogadorDoisPonto = 0;

string opcao = "inicio";

while (opcao == "inicio")
{
    Console.WriteLine("Jogador 1 escolha entre: \nPedra - Papel - Tesoura");
    jogadorUm = Console.ReadLine();

    Console.Clear();

    Console.WriteLine("Jogador 2 escolha entre: \nPedra - Papel - Tesoura");
    jogadorDois= Console.ReadLine();

    Console.Clear();

    if (jogadorUm == jogadorDois)
    {
        Console.WriteLine("\nEmpate!\n\n");
    } 
    else if ((jogadorUm == "Pedra" && jogadorDois == "Tesoura") || (jogadorUm == "Papel" && jogadorDois == "Pedra") || (jogadorUm == "Tesoura" && jogadorDois == "Papel"))
    {
        jogadorUmPonto += 1;
        Console.WriteLine("\nJogador 1 ganhou um ponto! \n\n");
    } else {
        jogadorDoisPonto += 1;
        Console.WriteLine("\nJogador 2 ganhou um ponto! \n\n");
    }
    
    Console.WriteLine("Placar\n");
    Console.WriteLine($"Pontos do jogador Um: {jogadorUmPonto}\n");
    Console.WriteLine($"Pontos do jogodor Dois: {jogadorDoisPonto}\n\n");

    Console.WriteLine("Quer jogar mais uma: \n (1) sim  | (2) não");
    opcao = Console.ReadLine();

    if (opcao == "2"){
        opcao = "Fim";
    } else {
        Console.Clear();
        opcao = "inicio";
    }
}