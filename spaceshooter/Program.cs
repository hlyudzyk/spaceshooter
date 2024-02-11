using spaceshooter;
using spaceshooter.UI;

public class Program
{
    private const int DisplayHeight = 50;
    private const int DisplayWidth = 100;

    public static void Main(string[] args)
    {
        char[,] displayMatrix = new char[DisplayHeight, DisplayWidth];
        Sprite ship = new Ship(50, 25, 'o');
        Sprite ship2 = new Ship(30, 10, 'o');

        for (int n = 0; n < 30; n++)
        {
            for (int i = 0; i < DisplayHeight; i++)
            {
                for (int j = 0; j < DisplayWidth; j++)
                {
                    displayMatrix[i, j] = '-';
                }
            }

            foreach (Point point in ship.DisplayPoints)
            {
                displayMatrix[point.Y, point.X] = point.DisplayPixel;
            }

            foreach (Point point in ship2.DisplayPoints)
            {
                displayMatrix[point.Y, point.X] = point.DisplayPixel;
            }

            for (int i = 0; i < DisplayHeight; i++)
            {
                for (int j = 0; j < DisplayWidth; j++)
                {
                    Console.Write(displayMatrix[i, j]);
                }
                Console.WriteLine();
            }

            Console.Clear();
            ship.CenterX++;
        }
    }
}