using Extensions;
using System.Drawing;

namespace PZPK_Labas.Laba1
{
    public static class Task6
    {
        public static void Run()
        {
            Console.WriteLine("Завдання 6. Написати програму яка обраховує атаки шахматних фігур.");

            Point chess1Pos;
            Point chess2Pos;
            Point chess3Pos;

            string chess1Type = "Ферзь";
            string chess2Type = "Король";
            string chess3Type = "Ферзь";

            string chess1Color = "Білий";
            string chess2Color = "Чорний";
            string chess3Color = "Чорний";

            chess1Pos = InputChessPosition(chess1Type, chess1Color);
            chess2Pos = InputChessPosition(chess2Type, chess2Color);
            chess3Pos = InputChessPosition(chess3Type, chess3Color);

            CalculateChessAttacks(chess1Pos, chess2Pos, chess3Pos, // chess 1 attack
                                    chess1Type, chess2Type, chess3Type,
                                    chess1Color, chess2Color, chess3Color);
            CalculateChessAttacks(chess2Pos, chess1Pos, chess3Pos, // chess 2 attack
                                    chess2Type, chess1Type, chess3Type,
                                    chess2Color, chess1Color, chess3Color);
            CalculateChessAttacks(chess3Pos, chess2Pos, chess1Pos, // chess 3 attack
                                    chess3Type, chess2Type, chess1Type,
                                    chess3Color, chess2Color, chess1Color);

            Console.ReadKey();
            Console.WriteLine();
        }

        private static Point InputChessPosition(string type, string color)
        {
            Console.WriteLine($"Введіть позицію {color} {type}");

            int x;
            int y;

            ConsoleInput.SafeIntInput("\tX", out x);
            ConsoleInput.SafeIntInput("\tY", out y);

            return new Point(x, y);
        }

        private static void CalculateChessAttacks(Point attackingChessPos, Point chess2Pos, Point chess3Pos,
                                                    string attackingChessType, string chess2Type, string chess3Type,
                                                    string attachingChessColor, string chess2Color, string chess3Color)
        {
            switch (attackingChessType)
            {
                case "Ферзь":
                    if (attachingChessColor != chess2Color & IsQueenAttackingChess(attackingChessPos, chess2Pos))
                        Console.WriteLine($"{attachingChessColor} ферзь атакує {chess2Color} {chess2Type}");

                    if (attachingChessColor != chess3Color & IsQueenAttackingChess(attackingChessPos, chess3Pos))
                        Console.WriteLine($"{attachingChessColor} ферзь атакує {chess3Color} {chess3Type}");
                    break;
                case "Король":
                    if (attachingChessColor != chess2Color & IsKingAttackingChess(attackingChessPos, chess2Pos))
                        Console.WriteLine($"{attachingChessColor} король атакує {chess2Color} {chess2Type}");

                    if (attachingChessColor != chess3Color & IsKingAttackingChess(attackingChessPos, chess3Pos))
                        Console.WriteLine($"{attachingChessColor} король атакує {chess3Color} {chess3Type}");
                    break;
            }
        }

        private static bool IsQueenAttackingChess(Point queenPos, Point attackedChessPos)
        {
            return queenPos.X == attackedChessPos.X || queenPos.Y == attackedChessPos.Y ||
                    Math.Abs(queenPos.X - attackedChessPos.X) == Math.Abs(queenPos.Y - attackedChessPos.Y);
        }

        private static bool IsKingAttackingChess(Point kingPos, Point attackedChessPos)
        {
            int deltaX = Math.Abs(kingPos.X - attackedChessPos.X);
            int deltaY = Math.Abs(kingPos.Y - attackedChessPos.Y);

            return deltaX <= 1 & deltaY <= 1;
        }
    }
}