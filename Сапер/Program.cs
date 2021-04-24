using System;

namespace Сапер
{
    class Program
    {
        static void Main(string[] args)
        {

            Field field = new Field(10);
            field.GenerateField();
            field.PrintField();
            field.Play();


        }
    }
}
