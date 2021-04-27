using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сапер
{
    class Field
    {
        private int N;
        private Cell [,] arr;
        private int score = 0;

        public Field(int n)
        {
            arr = new Cell[n, n];
            N = n;
        }

        public void GenerateField()
        {
            int b = 1;
            Random rand = new Random();
            
            int bomb = 0;
            
            for (int i = 0; i < N; i++)
            {
                for(int j=0;j<N;j++)
                {
                    int random = rand.Next(1, 10);
                    if ((random == 9 || random == 10) && bomb <= 10)
                    {
                            arr[i, j] = new BombCell();
                            b++;
                            bomb++;
                       
                    }
                    else
                    {
                        arr[i, j] = new NumberedCell();
                        b++;
                    }
                }
            }
        }
        public void PrintField()
        {
            
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    arr[i, j].PrintCell();
                }
                Console.WriteLine();
            }
            Console.WriteLine(score);
        }
        public void OpenCell(int x,int y)
        {
            arr[x, y].OpenCell();
            PrintField();
        }
        public void Score(int x,int y)
        {
            score += arr[x, y].AddScore();
        }
        public void Play()
        { int i = 0;
            while(i==0)
            {
                Console.WriteLine("Введите X:");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите Y:");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Score(x, y);
                OpenCell(x,y);
               
            }
        }
    }
}
