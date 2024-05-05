using System.Drawing;
using System.Numerics;

sealed class SnakeGame
{
    private enum CellType
    {
        Border = -2,
        Empty = -1,

        SnakeHead = 0,
        SnakeBody = 1,
        Apple = 2,
    }

    private Vector2 _velocity;

    private const int _boardSize = 20;
    private int[][] _board = null!;

    #region Singleton Boilerplate
    private SnakeGame() 
    {
        _board = new int[_boardSize][];
        _velocity = new Vector2(1, 0);

        for (int i = 0; i < _board.Length; ++i)
        {
            _board[i] = new int[_boardSize];
            for (int j = 0; j < _board[i].Length; ++j)
            {
                _board[i][j] = (int)CellType.Empty;
                if (i == 0 || j == 0 || i  == _boardSize - 1 || j == _boardSize - 1) _board[i][j] = (int)CellType.Border;
            }
        }

        SpawnSnake();
    }

    private void SpawnSnake()
    {
        var spawnPosition = (2, 2);
        _board[spawnPosition.Item1][spawnPosition.Item2] = (int)CellType.SnakeHead;
    }

    private static SnakeGame _instance = null!;

    public static SnakeGame instance
    {
        get
        {
            _instance ??= new SnakeGame();
            return _instance;
        }
    }
    #endregion

    public void Run()
    {
        while (true)
        {
            Draw();
            Evaluate();
        }
    }

    public void Draw()
    {
        while (true)
        {
            var output = "";

            foreach (var row in _board)
            {
                var line = "";
                foreach (var cell in row)
                {
                    var cellCharacter = "";


                    _ = (CellType)cell switch
                    {
                        CellType.Apple => cellCharacter = "@",
                        CellType.SnakeBody => cellCharacter = "0",
                        CellType.SnakeHead => cellCharacter = "1",
                        CellType.Empty => cellCharacter = " ",
                        CellType.Border => cellCharacter = "*",
                        _ => throw new NotImplementedException()
                    };

                    line += cellCharacter;
                }
                output += $"{line}\n";
            }

            Console.SetCursorPosition(0, 0);
            Console.Write(output);
        }
    }

    public void Evaluate()
    {
    }
} 