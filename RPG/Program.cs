string Nome = "";
bool ContinuarApp = true;


Console.Write("Escreva o seu nome: ");
Nome = Console.ReadLine();

while(ContinuarApp == true)
{
    bool ContinuarJogo = true;
    bool Vitoria = false;
    bool Empate = false;
    bool Derrota = false;
    string RespostaLimpar = "";
    int VidaJogador = 10;
    int VidaMonstro = 10;

    while (RespostaLimpar != "S" && RespostaLimpar != "s" && RespostaLimpar != "N" && RespostaLimpar != "n")
    {
        Console.WriteLine("Deseja que a linha de comando seja limpada a cada ação do jogador? Escreva \"S\" ou \"N\"");
        RespostaLimpar = Console.ReadLine();

        if(RespostaLimpar != "S" && RespostaLimpar != "s" && RespostaLimpar != "N" && RespostaLimpar != "n")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Resposta inválida!");
            Console.ForegroundColor = ConsoleColor.White;
        }

    }

    while (ContinuarJogo == true)
    {
        string Resposta = "";
        string RespostaMaiuscula;
        Random Aleatorio = new Random();
        int NumeroAleatorio = 0;
        Console.WriteLine("Vida do " + Nome + ": " + VidaJogador);
        Console.WriteLine("Vida do Monstro: " + VidaMonstro);

        while (Resposta != "A" && Resposta != "a" && Resposta != "C" && Resposta != "c")
        {
            Console.WriteLine("Digite \"A\" para atacar ou \"C\" para se curar:");
            Resposta = Console.ReadLine();

            if(Resposta != "A" && Resposta != "a" && Resposta != "C" && Resposta != "c")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Resposta inválida!");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        if(RespostaLimpar == "S" || RespostaLimpar == "s")
        {
            Console.Clear();
        }

        RespostaMaiuscula = Resposta.ToUpper();

        if(RespostaMaiuscula == "A")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Nome + " atacou!");
            VidaMonstro -= 2;
            Console.ForegroundColor = ConsoleColor.White;
        }

        if(RespostaMaiuscula == "C")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            NumeroAleatorio = Aleatorio.Next(1, 4);
            VidaJogador += NumeroAleatorio;
            Console.WriteLine(Nome + " curou " + NumeroAleatorio + " pontos de vida!");
            Console.ForegroundColor = ConsoleColor.White;
        }

        NumeroAleatorio = Aleatorio.Next(1, 3);

        if(NumeroAleatorio == 1)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Monstro atacou!");
            VidaJogador -= 2;
            Console.ForegroundColor = ConsoleColor.White;
        }

        if(NumeroAleatorio == 2)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            NumeroAleatorio = Aleatorio.Next(1, 4);
            VidaMonstro += NumeroAleatorio;
            Console.WriteLine("Monstro curou " + NumeroAleatorio + " pontos de vida");
            Console.ForegroundColor = ConsoleColor.White;
        }

        Console.WriteLine();

        if (VidaJogador <= 0 && VidaMonstro <= 0)
        {
            Empate = true;
            ContinuarJogo = false;
        }

        if(VidaJogador > 0 && VidaMonstro <= 0)
        {
            Vitoria = true;
            ContinuarJogo = false;
        }

        if(VidaJogador < 0 && VidaMonstro > 0)
        {
            Derrota = true;
            ContinuarJogo = false;
        }
    }

    if(Vitoria == true)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Vitória!");
        Console.ForegroundColor = ConsoleColor.White;
    }

    if(Derrota == true)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Derrota!");
        Console.ForegroundColor = ConsoleColor.White;
    }
    
    if(Empate == true)
    {
        Console.WriteLine("Empate!");
    }

    string RespostaContinuar = "";

    while (RespostaContinuar != "S" && RespostaContinuar != "s" && RespostaContinuar != "N" && RespostaContinuar != "n")
    {
        Console.WriteLine("Deseja jogar novamente? Digite \"S\" ou \"N\"");
        RespostaContinuar = Console.ReadLine();

        if(RespostaContinuar != "S" && RespostaContinuar != "s" && RespostaContinuar != "N" && RespostaContinuar != "n")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Resposta inválida!");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }



    if(RespostaContinuar == "N" || RespostaContinuar == "n")
    {
        ContinuarApp = false;
    }
}

Console.WriteLine("Obrigado por jogar!");
