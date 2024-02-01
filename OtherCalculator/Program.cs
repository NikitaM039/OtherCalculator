namespace OtherCalculator
{
    internal class Program
    {
        static void Main()
        {
            var calc = new Calculator();
            calc.CalcChange += CalcChangeEvent;
            calc.Run();

        }

        private static void CalcChangeEvent(object? sender, EventArgs e)
        {
            if (sender is Calculator)
            {
                Console.WriteLine(((Calculator)sender).Result);
            }
        }
    }
}