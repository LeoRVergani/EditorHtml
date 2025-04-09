using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);

        }

        public static void DrawScreen()
        {
            Console.Write("+");
            for(int i = 0; i <= 30; i ++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");

            for(int lines = 0; lines <= 15; lines++ )
            {
                Console.Write("|");
                for(int i = 0; i <= 30; i ++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");
            }
            Console.Write("+");
            for(int i = 0; i <= 30; i ++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
            
        }
        
        public static void WriteOptions()
        {
            Console.SetCursorPosition(3,1);
            Console.Write("Editor HTML");
            Console.SetCursorPosition(3,2);
            Console.Write("Selecione uma opção abaixo");
            Console.SetCursorPosition(3,3);
            Console.WriteLine("1- Novo arquivo");
            Console.SetCursorPosition(3,4);
            Console.Write("2 - Abrir");
            Console.SetCursorPosition(3,5);
            Console.Write("0 - Sair");
            Console.SetCursorPosition(3,6);
            Console.Write("Opção: ");

        }

        public static void HandleMenuOption(short option)
        {
            switch(option) {
                case 1: Editor.Show(); break;
                case 2: Console.WriteLine("View"); break;
                case 0:
                {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
                default: Show(); break;
            }
        }
    }
    
}