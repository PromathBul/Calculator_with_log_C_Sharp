public class UI
{

    /**
     * Метод получения от пользователя значения
     */
    public Double inputDouble(String msg)
    {
        Console.Write(msg + ": ");
        return double.Parse(Console.ReadLine());
    }

    /**
     * Метод выбора операции
     * @return - номер операции
     */
    public int getChoice()
    {
        Console.WriteLine("Choice operation:");
        Console.WriteLine("\t1. Summarize");
        Console.WriteLine("\t2. Subtraction");
        Console.WriteLine("\t3. Multiplication");
        Console.WriteLine("\t4. Division");
        return int.Parse(Console.ReadLine());
    }
}
