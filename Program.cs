using System.ComponentModel.Design;
using System.Data.SqlTypes;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography;
using kr_2;
using Microsoft.VisualBasic;

namespace С_Metods
{
    class Program
    {

        static void Main()
        {
            Player player = new Player(100, true);

            Scene scene = new Scene();

            Door door = new Door("я дверь, я дверь", true);
            Checkpoint checkpoint = new Checkpoint("чекпоинт");
            Trap trap = new Trap("Ловушка-лохушка", 20);
            Light light = new Light("триггер");
            Button button = new Button("", light);
            scene.Objects.Add(door);
            scene.Objects.Add(checkpoint);
            scene.Objects.Add(trap);
            scene.Objects.Add(light);
            scene.Objects.Add(button);



            while (true)
            {
                Console.WriteLine("меню поиска");
                Console.WriteLine("1. Показать все объекты ");
                Console.WriteLine("2.Показать только интерактивные объекты");
                Console.WriteLine("3.Взаимодействовать с объектом по Id");
                Console.WriteLine("4.Отключить объект по Id");
                Console.WriteLine("5.Включить объект по Id");
                string aa = Console.ReadLine();
                if (int.TryParse(aa, out int numberr))
                {
                    if (numberr > 5)
                    {
                        Console.WriteLine("чо пишешь то...");
                    }
                    if (numberr == 0)
                    {
                        Console.WriteLine("чо пишешь то...");
                    }
                    if (numberr == 1)
                    {
                        scene.PrintAll();
                    }
                    if (numberr == 2)
                    {
                        foreach (var obj in scene.Objects)
                        {
                            if (obj is IInteractable interactable)
                            {
                                {
                                    Console.WriteLine(obj.Info());
                                }
                            }
                        }
                    }
                    if (numberr == 3)
                    {
                        if (scene.Objects is IInteractable interactable)
                        {
                            interactable.Interact(player);
                        }
                        else
                        {
                            Console.WriteLine("не подходит");
                        }
                    }
                    if (numberr == 4)
                    {
                        Console.WriteLine("введи Id:");
                        string pididi = Console.ReadLine();
                        if (int.TryParse(pididi, out int id))
                        {
                            var obj = scene.Objects[id];
                            obj.Disable();

                        }
                    }
                    if (numberr == 5)
                    {
                        Console.WriteLine("введи Id:");
                        string pididi = Console.ReadLine();
                        if (int.TryParse(pididi, out int idd))
                        {
                            var obj = scene.Objects(idd);
                            obj.Enable();

                        }
                    }
                }
            }
        }
    }
}
