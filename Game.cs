public class Game
{
    private List<Carta> cartas;

    private Jogador usuario;
    private Jogador computador;

    public Game()
    {
        cartas = new List<Carta>();
        cartas.Add(new CartaAtaque("Golpe Rápido", "Um corte veloz que fere o oponente.", 1, 2));
        cartas.Add(new CartaAtaque("Estocada Precisa", "Um ataque certeiro que perfura a defesa.", 2, 4));
        cartas.Add(new CartaAtaque("Machado Brutal", "Um golpe destruidor com machado pesado.", 3, 6));
        cartas.Add(new CartaAtaque("Espada Flamejante", "Um corte envolto em chamas, causando queimaduras.", 3, 5));
        cartas.Add(new CartaAtaque("Flecha Venenosa", "Atinge o inimigo e causa dano persistente.", 2, 3));
        cartas.Add(new CartaAtaque("Rajada de Gelo", "Um golpe congelante que reduz a movimentação.", 3, 4));
        cartas.Add(new CartaAtaque("Golpe Sombrio", "Um ataque das trevas, consumindo energia vital.", 4, 8));
        cartas.Add(new CartaAtaque("Fúria do Berserker", "Um ataque feroz, mas consome toda sua energia.", 5, 10));
        cartas.Add(new CartaAtaque("Impacto Sísmico", "Um golpe que faz o chão tremer, atingindo em cheio.", 6, 12));
        cartas.Add(new CartaAtaque("Lança Sombria", "Uma lança de energia negra atravessa o adversário.", 4, 6));
        cartas.Add(new CartaAtaque("Flecha Tripla", "Três flechas rápidas atingem o inimigo ao mesmo tempo.", 3, 5));
        cartas.Add(new CartaAtaque("Espinhos do Caos", "Projeta espinhos mágicos que perfuram a armadura.", 4, 7));
        cartas.Add(new CartaAtaque("Trovão Arcano", "Um raio destruidor cai sobre o oponente.", 5, 9));
        cartas.Add(new CartaAtaque("Golpe Veloz", "Um ataque ágil que confunde o inimigo.", 2, 4));
        cartas.Add(new CartaAtaque("Rajada de Lâminas", "Várias lâminas cortam o oponente de diferentes ângulos.", 4, 7));
        cartas.Add(new CartaAtaque("Garras da Fera", "Um ataque selvagem como de uma fera raivosa.", 3, 5));
        cartas.Add(new CartaAtaque("Chamas do Inferno", "Um fogo intenso consome o adversário.", 6, 11));
        cartas.Add(new CartaAtaque("Corte Duplo", "Dois cortes rápidos que ignoram parte da defesa.", 3, 5));
        cartas.Add(new CartaAtaque("Golpe Fantasma", "Uma espada espectral atinge o inimigo sem ser bloqueada.", 5, 9));
        cartas.Add(new CartaAtaque("Lança de Sangue", "Usa o próprio sangue para fortalecer o ataque.", 4, 7));
        cartas.Add(new CartaDefesa("Poção de Cura", "Uma poção básica que recupera energia vital.", 2, 4));
        cartas.Add(new CartaDefesa("Escudo Espiritual", "Uma barreira de luz bloqueia ataques.", 3, 6));
        cartas.Add(new CartaDefesa("Regeneração Mágica", "Uma magia que regenera feridas lentamente.", 4, 7));
        cartas.Add(new CartaDefesa("Cura do Druida", "A energia da natureza restaura suas forças.", 3, 5));
        cartas.Add(new CartaDefesa("Armadura de Pedra", "Endurece sua pele como rocha.", 4, 6));
        cartas.Add(new CartaDefesa("Aura de Vida", "Um brilho sagrado envolve o corpo, curando ferimentos.", 5, 8));
        cartas.Add(new CartaDefesa("Bênção dos Ancestrais", "Espíritos antigos restauram sua vitalidade.", 6, 10));
        cartas.Add(new CartaDefesa("Meditação Interior", "Acalma a mente e acelera a cura natural.", 2, 4));
        cartas.Add(new CartaDefesa("Pele de Aço", "Fortalece a resistência física por alguns instantes.", 3, 5));
        cartas.Add(new CartaDefesa("Muralha Arcana", "Uma barreira mágica absorve parte do impacto.", 4, 6));
        cartas.Add(new CartaDefesa("Fôlego Renovado", "Um segundo fôlego para continuar lutando.", 2, 3));
        cartas.Add(new CartaDefesa("Reflexos Felinos", "Movimentos rápidos evitam golpes fatais.", 3, 5));
        cartas.Add(new CartaDefesa("Escudo Elemental", "Uma barreira de fogo, gelo ou trovão protege você.", 4, 7));
        cartas.Add(new CartaDefesa("Proteção Divina", "Luz celestial fortalece sua alma.", 5, 9));
        cartas.Add(new CartaDefesa("Pele do Dragão", "Adquire resistência lendária temporária.", 6, 11));
        cartas.Add(new CartaDefesa("Poção de Vitalidade", "Uma mistura poderosa que restaura o vigor.", 2, 4));
        cartas.Add(new CartaDefesa("Resiliência Suprema", "Suporta ataques com a força de um titã.", 5, 9));
        cartas.Add(new CartaDefesa("Armadura Sagrada", "A luz purifica seu corpo, curando feridas profundas.", 6, 12));
        cartas.Add(new CartaDefesa("Restauração Total", "Uma magia suprema que regenera completamente.", 7, 15));
        cartas.Add(new CartaDefesa("Cura Sombria", "Poder negro que sacrifica um pouco de energia para curar.", 4, 6));

        usuario = new Jogador("Herói");
        computador = new Jogador("Vilão");

        // Exercício 1:
        // Distribuir 20 cartas para cada Jogador, sendo 10 de ataque e 10 de defesa.
        // usuario.IniciarDeck(cartasDoJogador)
        // Embaralha as cartas
        Random random = new Random();
        List<Carta> cartasEmbaralhadas = cartas.OrderBy(c => random.Next()).ToList();

        // Separa as cartas de ataque e defesa manualmente pq o OfType não funcionou
        List<Carta> cartasDeAtaque = new List<Carta>();
        List<Carta> cartasDeDefesa = new List<Carta>();

        foreach (var carta in cartasEmbaralhadas)
        {
            if (carta is CartaAtaque)
            {
                if (cartasDeAtaque.Count < 10)
                    cartasDeAtaque.Add(carta);
            }
            else if (carta is CartaDefesa)
            {
                if (cartasDeDefesa.Count < 10)
                    cartasDeDefesa.Add(carta);
            }

            // Quebra o loop se tiver 10 cartas dos 2 tipos
            if (cartasDeAtaque.Count >= 10 && cartasDeDefesa.Count >= 10)
                break;
        }

        // Inicia os decks
        usuario.IniciarDeck(cartasDeAtaque.Concat(cartasDeDefesa).ToList());
        computador.IniciarDeck(cartasDeAtaque.Concat(cartasDeDefesa).ToList());


        Console.WriteLine("Início do Jogo:");
        Console.WriteLine($"Jogador ({usuario.Nome}) - Vida: {usuario.Vidas} | Energia: {usuario.Energia}");
        Console.WriteLine($"Computador ({computador.Nome}) - Vida: {computador.Vidas} | Energia: {computador.Energia}");
    }

    public void Run()
    {
        // Exercício 2:
        // Enquanto nenhum dos jogadores tiver 0 de vida, o jogo continua.

       while (usuario.Vidas > 0 && computador.Vidas > 0)
    {
        // Exercício 3: Exibir as cartas do jogador e pedir para ele escolher uma carta.
        Console.WriteLine($"\nCartas de {usuario.Nome}:");
        for (int i = 0; i < usuario.Deck.Count; i++)
        {
            Console.WriteLine($"{i}: {usuario.Deck[i].Nome} - Energia: {usuario.Deck[i].Energia}");
        }

        Console.WriteLine($"Cartas disponíveis: {usuario.Deck.Count}");

        int escolha;
        while (true)
        {
            Console.WriteLine("Escolha uma carta válida, digitando o número correspondente:");

            string entrada = Console.ReadLine() ?? "";
            Console.WriteLine($"Entrada recebida: {entrada}");

            if (int.TryParse(entrada, out escolha) && escolha >= 0 && escolha < usuario.Deck.Count)
                break;
        }



        Carta cartaEscolhida = usuario.SelecionarCarta(escolha);
        cartaEscolhida.Usar(usuario, computador);
        Console.WriteLine($"{usuario.Nome} usou {cartaEscolhida.Nome}!");

        // Exercício 6: Exibir a quantidade de vidas e energia de cada jogador.
        Console.WriteLine($"{usuario.Nome} - Vida: {usuario.Vidas}, Energia: {usuario.Energia}");
        Console.WriteLine($"{computador.Nome} - Vida: {computador.Vidas}, Energia: {computador.Energia}");

        // Verificar se o computador ainda está vivo
        if (computador.Vidas <= 0) break;

        // Exercício 4: O computador escolhe uma carta aleatória do deck para usar.
        int indiceCarta = new Random().Next(computador.Deck.Count);
        Carta cartaComputador = computador.SelecionarCarta(indiceCarta);
        cartaComputador.Usar(computador, usuario);
        Console.WriteLine($"{computador.Nome} usou {cartaComputador.Nome}!");

        // Exercício 6: Exibir a quantidade de vidas e energia de cada jogador novamente.
        Console.WriteLine($"{usuario.Nome} - Vida: {usuario.Vidas}, Energia: {usuario.Energia}");
        Console.WriteLine($"{computador.Nome} - Vida: {computador.Vidas}, Energia: {computador.Energia}");

        // Exercício 7: Restaurar os Pontos de Energia.
        usuario.RestaurarEnergia();
        computador.RestaurarEnergia();
    }

    // Exercício 8: Mostrar o vencedor e encerrar o jogo.
    if (usuario.Vidas <= 0)
        Console.WriteLine($"{computador.Nome} venceu!");
    else
        Console.WriteLine($"{usuario.Nome} venceu!");
    }
}