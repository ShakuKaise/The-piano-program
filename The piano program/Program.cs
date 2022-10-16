namespace The_piano_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            int OctaveNum = 1;
            int[,] Octaves = new int[9, 12]
            {
                { 16, 17, 18, 19, 20, 21, 23, 24, 25, 27, 29, 30 },
                { 32, 34, 36, 38, 41, 43, 46, 49, 51, 55, 58, 61 },
                { 65, 69, 73, 77, 82, 87, 92, 98, 103, 110, 116, 123 },
                { 130, 138, 146, 155, 164, 174, 185, 196, 207, 220, 233, 246 },
                { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 593 },
                { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 },
                { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 },
                { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 },
                { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 }
            };
            do
            {
                Console.WriteLine("F5 - уменьшить октаву на 1");
                Console.WriteLine("F6 - увеличить октаву на 1");
                Console.WriteLine("F9 - выход из программы");
                Console.WriteLine($"Текущая октава - {OctaveNum}");

                key = Console.ReadKey();

                OctaveNum = OctavesSwitcher(OctaveNum, key);
                
                switch (key.Key)
                {
                    case ConsoleKey.A:
                        Voice(Octaves[OctaveNum, 0]);
                        break;
                    case ConsoleKey.B:
                        Voice(Octaves[OctaveNum, 1]);
                        break;
                    case ConsoleKey.C:
                        Voice(Octaves[OctaveNum, 2]);
                        break;
                    case ConsoleKey.D:
                        Voice(Octaves[OctaveNum, 3]);
                        break;
                    case ConsoleKey.E:
                        Voice(Octaves[OctaveNum, 4]);
                        break;
                    case ConsoleKey.F:
                        Voice(Octaves[OctaveNum, 5]);
                        break;
                    case ConsoleKey.G:
                        Voice(Octaves[OctaveNum, 6]);
                        break;
                    case ConsoleKey.H:
                        Voice(Octaves[OctaveNum, 7]);
                        break;
                    case ConsoleKey.I:
                        Voice(Octaves[OctaveNum, 8]);
                        break;
                    case ConsoleKey.J:
                        Voice(Octaves[OctaveNum, 9]);
                        break;
                    case ConsoleKey.K:
                        Voice(Octaves[OctaveNum, 10]);
                        break;
                    case ConsoleKey.L:
                        Voice(Octaves[OctaveNum, 11]);
                        break;
                }
                Console.Clear();
            } while (key.Key != ConsoleKey.F9);
        }

        static int OctavesSwitcher(int OctaveNum, ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.F5:
                    OctaveNum--;
                    if (OctaveNum == 0)
                    {
                        OctaveNum = 1;
                    }
                    break;
                case ConsoleKey.F6:
                    OctaveNum++;
                    if (OctaveNum == 10)
                    {
                        OctaveNum = 9;
                    }
                    break;
            }
            return OctaveNum;
        }

        static void Voice(int note)
        {
            if (note < 37)
            {
                note = 37;
            }
            Console.Beep(note, 250);
        }
    }
}