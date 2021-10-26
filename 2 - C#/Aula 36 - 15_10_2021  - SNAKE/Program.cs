using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threads
{
    class Snake
    {
        int Width;
        int Height;
        char CurrentDirection = 'u';
        char Direction = 'u';
        int[] SnakeHead = new int[2];
        List<int[]> SnakeBody = new List<int[]>();

        int[] FoodPos = new int[2];
        List<int[]> Eating = new List<int[]>();
        int pontos = 0;
        public bool Life = true;

        public Snake(int Width, int Height)
        {
            this.Width = Width;
            this.Height = Height;
            this.SnakeHead[0] = (int)Math.Ceiling(Width / 2d);
            this.SnakeHead[1] = (int)Math.Ceiling(Height / 2d);
            int H = (int)Math.Ceiling(Height / 2d);
            for (int i = 0; i < 5; i++)
            {
                int[] pos = new int[2] { (int)Math.Ceiling(Width / 2d), this.SnakeHead[1] };
                SnakeBody.Add(pos);
                H++;
            }
            RandomFoodGenerator();
        }

        public void MoveSnakeHead()
        {
            if (Direction == 'l')
            {
                SnakeHead[0] = SnakeHead[0] - 1;
                if (SnakeHead[0] == 0)
                {
                    this.SnakeHead[0] = Width;
                }
                this.CurrentDirection = 'l';
            }
            else if (Direction == 'u')
            {
                SnakeHead[1] = SnakeHead[1] - 1;
                if (SnakeHead[1] == 0)
                {
                    this.SnakeHead[1] = Height;
                }
                this.CurrentDirection = 'u';
            }
            else if (Direction == 'r')
            {
                SnakeHead[0] = SnakeHead[0] + 1;
                if (SnakeHead[0] == Width + 1)
                {
                    this.SnakeHead[0] = 1;
                }
                this.CurrentDirection = 'r';
            }
            else if (Direction == 'd')
            {
                SnakeHead[1] = SnakeHead[1] + 1;
                if (SnakeHead[1] == Height + 1)
                {
                    this.SnakeHead[1] = 1;
                }
                this.CurrentDirection = 'd';
            }

            if (SnakeHead[0] == FoodPos[0] && SnakeHead[1] == FoodPos[1])
            {
                pontos++;
                int[] temp = new int[2];
                FoodPos.CopyTo(temp, 0);
                Eating.Add(temp);
                /*Eating[Eating.Count - 1][0] = SnakeHead[0];
                Eating[Eating.Count - 1][1] = SnakeHead[1];*/
                RandomFoodGenerator();
            }
        }

        public void MoveBody()
        {
            if (Eating.Count > 0 && SnakeBody[SnakeBody.Count-1][0] == Eating[0][0] && SnakeBody[SnakeBody.Count - 1][1] == Eating[0][1])
            {
                int[] temp = new int[2];
                temp[0] = Eating[0][0];
                temp[1] = Eating[0][1];
                SnakeBody.Add(temp);
                Eating.RemoveAt(0);
            }

            List<int[]> copia = new List<int[]>();
            foreach (int[] i in SnakeBody)
            {
                int[] temp = new int[2];
                i.CopyTo(temp, 0);
                copia.Add(temp);
            }

            SnakeBody[0][0] = SnakeHead[0];
            SnakeBody[0][1] = SnakeHead[1];
            for (int i = 1; i < SnakeBody.Count; i++)
            {
                SnakeBody[i][0] = copia[i - 1][0];
                SnakeBody[i][1] = copia[i - 1][1];
            }
        }

        public void MoveSnake()
        {
            MoveBody();
            MoveSnakeHead();
        }

        public void DrawSnake()
        {
            Console.WriteLine($"Pontuação: {pontos}\n");
            Console.WriteLine("Pressione ESC para parar.\n");
            for (int y = 0; y <= Height + 1; y++)
            {
                if (y == 0 || y == Height + 1)
                {
                    for (int x = 0; x <= Width + 1; x++)
                    {
                        if (x == 0 || x == Width + 1)
                        {
                            Console.Write("+");
                        }
                        else
                        {
                            Console.Write("-");
                        }
                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int x = 0; x <= Width + 1; x++)
                    {
                        if (x == 0 || x == Width + 1)
                        {
                            Console.Write("|");
                        }

                        // Desenha a cobra
                        else
                        {
                            if (x == SnakeHead[0] && y == SnakeHead[1])
                            {
                                Console.Write("@");
                            }
                            else
                            {
                                bool z = true;
                                foreach (int[] eat in Eating)
                                {
                                    if (eat[0] == x && eat[1] == y)
                                    {
                                        Console.Write("§");
                                        z = false;
                                    }
                                }
                                if (z)
                                {
                                    foreach (int[] i in SnakeBody)
                                    {
                                        if (x == i[0] && y == i[1])
                                        {
                                            Console.Write("#");
                                            z = false;
                                            break;
                                        }
                                    }
                                    if (z)
                                    {
                                        if (x == FoodPos[0] && y == FoodPos[1])
                                        {
                                            Console.Write("+");
                                        }
                                        else
                                        {
                                            Console.Write(" ");
                                        }
                                    }
                                }
                            }
                        }
                    }
                    Console.WriteLine();
                }
            }
        }

        public void SetDirection(char Direction)
        {
            if (Direction == 'l' && this.CurrentDirection != 'r')
            {
                this.Direction = 'l';
            }
            else if (Direction == 'u' && this.CurrentDirection != 'd')
            {
                this.Direction = 'u';
            }
            else if (Direction == 'r' && this.CurrentDirection != 'l')
            {
                this.Direction = 'r';
            }
            else if (Direction == 'd' && this.CurrentDirection != 'u')
            {
                this.Direction = 'd';
            }
        }

        public void RandomFoodGenerator()
        {
            int FoodX = 0;
            int FoodY = 0;
            bool con = true;
            while (con)
            {
                Random rng = new Random();
                FoodX = rng.Next(1, Width + 1);
                FoodY = rng.Next(1, Height + 1);
                foreach (int[] body in SnakeBody)
                {
                    if (!(body[0] == FoodX && body[1] == FoodY) && !(SnakeHead[0] == FoodX && SnakeHead[1] == FoodY))
                    {
                        con = false;
                    }
                }
            }
            FoodPos[0] = FoodX;
            FoodPos[1] = FoodY;

        }

        public void IsAlive()
        {
            foreach (int[] body in SnakeBody)
            {
                if (SnakeHead[0] == body[0] && SnakeHead[1] == body[1])
                {
                    this.Life = false;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Snake snake = new Snake(10, 10);

            Thread keyboard = new Thread(new ThreadStart(() => KeyBoard(snake)));
            keyboard.Start();
            keyboard.IsBackground = true;

            while (snake.Life)
            {
                Console.Clear();
                snake.MoveSnake();
                snake.DrawSnake();
                snake.IsAlive();
                Task.Delay(200).Wait();
            }
        }

        static void KeyBoard(Snake snake)
        {
            while (true)
            {
                ConsoleKey arrow = Console.ReadKey(true).Key;
                if (arrow == ConsoleKey.LeftArrow)
                {
                    snake.SetDirection('l');
                }
                else if (arrow == ConsoleKey.UpArrow)
                {
                    snake.SetDirection('u');
                }
                else if (arrow == ConsoleKey.RightArrow)
                {
                    snake.SetDirection('r');
                }
                else if (arrow == ConsoleKey.DownArrow)
                {
                    snake.SetDirection('d');
                }
                else if (arrow == ConsoleKey.Escape)
                {
                    snake.Life = false;
                }
            }
        }
    }
}
