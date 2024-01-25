internal class Program
{
    private static void Main(string[] args)
    {
        string userSelect = "";

        Console.WriteLine("+++++++++++++++++++++++++++++++");
        Console.WriteLine("+ Вы стоите у ворот техникума +");
        Console.WriteLine("+++++++++++++++++++++++++++++++");
        Console.Write("Что вы будете делать?\n");
        Console.Write("1. Войду \n2. Уйду \n3.Жрац хочу\n");
        Console.WriteLine("+++++++++++++++++++++++++++++++");
        Console.Write("> ");
        userSelect = Console.ReadLine();
        Console.Beep();
        Console.WriteLine(userSelect[0]);
        /*
        if (userSelect[0] == '1') 
            {
            Console.WriteLine("Вы выбрали первый вариант.");
            }
        if (userSelect[0] == '2')
        {
            Console.WriteLine("Вы выбрали второй вариант.");
        }
        if (userSelect[0] == '3')
        {
            Console.WriteLine("Вы выбрали третий вариант.");
        }
        */
        switch (userSelect[0])
        {
            case '1':
                Console.WriteLine("Вы выбрали первый вариант.");
                break;
            case '2':
                Console.WriteLine("Вы выбрали второй вариант.");
                break;
            case '3':
                Console.WriteLine("Вы выбрали третий вариант.");
                break;
            default:
                Console.WriteLine("Вы выбрали что-то ещё.");
                break;
        }


    }   
}