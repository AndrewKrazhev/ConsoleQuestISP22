using ConsoleQuestISP22;
using System.Net;

internal class Program
{


    static int Scene00()
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
        switch (userSelect[0])
        {
            case '1':
                Console.WriteLine("Вы выбрали первый вариант.");
                return 1;
                break;
            case '2':
                Console.WriteLine("Вы выбрали второй вариант.");
                return 2;
                break;
            case '3':
                Console.WriteLine("Вы выбрали третий вариант.");
                return 3;
                break;
            default:
                Console.WriteLine("Вы выбрали что-то ещё.");
                Scene00();
                return 0;
                break;
        }
    }

    static void Scene0()
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
        switch (userSelect[0])
        {
            case '1':
                Console.WriteLine("Вы выбрали первый вариант.");
                Scene1();
                break;
            case '2':
                Console.WriteLine("Вы выбрали второй вариант.");
                break;
            case '3':
                Console.WriteLine("Вы выбрали третий вариант.");
                break;
            default:
                Console.WriteLine("Вы выбрали что-то ещё.");
                Scene0();
                break;
        }
    }
    static void Scene1()
    {
        Console.WriteLine("+++++++++++++++++++++++++++++++");
        Console.WriteLine("+ Сцена 1 +");
        Console.WriteLine("+++++++++++++++++++++++++++++++");
        Console.Write("Что вы будете делать?\n");
        Console.Write("1. 0 \n2. 1 \n3.2\n");
        Console.WriteLine("+++++++++++++++++++++++++++++++");
    }

    private static void Main(string[] args)
    {
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

        //Scene0();
        /*
        Scenes Scene01 = new Scenes();
        Scene01.SceneName = "kjnfghkj";
        Scene01.SceneNumber = 1;
        Scene01.Show();

        Scenes Scene02 = new Scenes(0, intro: "dfsdff");
        Scene02.AddSome(1, "dfsd", "fdsfsd", "dsfds");
    
        Console.ReadKey();
        
        
        
        var questScenes = new Dictionary<int, Scenes>();
        questScenes.Add(1, Scene01);


        FightScenes killTheBill = new FightScenes();

        Console.WriteLine( killTheBill.PlayerHP);
        */

        I2Scenes sceneI = new I2Scenes(2, "Описание", "Первая сцена");
        sceneI.ShowScene();


    }   
}