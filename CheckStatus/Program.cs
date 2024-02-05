using System;
using System.Threading.Tasks;

namespace CheckStatus
{
    internal class Program
    {
        private bool status = true;

        static void Main(string[] args)
        {
            Program prog = new Program();
            prog.WritingText("Hello, guest! Please enter code: ");
            string code = Console.ReadLine();
            if (code == "what")
            {
                while (true)
                {
                    Console.Clear();
                    prog.WritingText("Code is correct, welcome back.\n 1. Check status\n 2. Update status\n 3. Leave \n");
                    try
                    {
                        int num = int.Parse(Console.ReadLine());
                        switch (num)
                        {
                            case 1:
                                Console.Clear();
                                prog.WritingText($"Current status: {prog.status}");
                                Console.ReadKey();
                                continue;
                            case 2:
                                Console.Clear();
                                if (prog.status)
                                    prog.status = false;
                                else
                                    prog.status = true;
                                prog.WritingText("The status has been updated.");
                                Console.ReadKey();
                                continue;
                            case 3:
                                Console.Clear();
                                prog.WritingText("Goodbye.");
                                break;
                            default:
                                continue;
                        }
                        Console.ReadKey();
                        break;
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
            else
            {
                Console.Clear();
                prog.WritingText("Incorrect");
                Console.ReadKey();
            }
        }

        async private void WritingText(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);
                await Task.Delay(17);
            }
        }
    }
}
