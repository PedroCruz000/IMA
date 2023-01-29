using System;

public class TicTacToe
{
    private Game game;

    public TicTacToe()
    {
        // inicializa o jogo
        game = new Game();
    }

    public void Play()
    {
        // loop do jogo
        while (true)
        {
            // imprime o tabuleiro
            Game.PrintBoard(game.board);

            // solicita a posição para o jogador
            Console.Write("Jogador " + game.CurrentPlayer + ", escolha a posição (linha coluna): ");
            string[] coordinates = Console.ReadLine().Split();
            int x = int.Parse(coordinates[0]) - 1;
            int y = int.Parse(coordinates[1]) - 1;

            // passa a jogada para o jogo tratar
            game.HandleMove(x, y);

           /* // verifica se o jogo terminou
            if (Game.IsWon(game.board))
            {
                Console.WriteLine("Jogador " + game.CurrentPlayer + " ganhou!");
                Game.Reset(game);
            }
            else if (Game.IsDraw(game.board))
            {
                Console.WriteLine("Empate!");
                Game.Reset(game);
            }*/
        }
    }

    public static void Main(string[] args)
    {
        TicTacToe ticTacToe = new TicTacToe();
        ticTacToe.Play();
    }
}

public class Game
{
    public string[,] board = new string[3, 3] {
        {"", "", ""},
        {"", "", ""},
        {"", "", ""}
    };

    public string currentPlayer = "X";

    public string CurrentPlayer
    {
        get { return currentPlayer; }
    }

    public void HandleMove(int x, int y)
    {
        // verifica se a célula já foi marcada
        if (board[x, y] != "")
        {
            Console.WriteLine("Essa célula já foi marcada!");
            return;
        }

        // marca a célula com o símbolo do jogador ativo
        board[x, y] = currentPlayer;

        // muda o jogador ativo
        if (currentPlayer == "X")
        {
            currentPlayer = "O";
        }
        else
        {
            currentPlayer = "X";
        }
    }

    public static void PrintBoard(string[,] board)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(board[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public static bool IsWon(string[,] board)
    {
        // verifica as linhas
        for (int i = 0; i < 3; i++)
        {
            if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != "")
            {
                return true;
            }
        }

        // verifica as colunas
        for (int i = 0; i < 3; i++)
        {
            if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0, i] != "")
            {
                return true;
            }
        }

        // verifica as diagonais
        if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != "")
        {
            return true;
        }
        if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != "")
        {
            return true;
        }

        return false;
    }
}