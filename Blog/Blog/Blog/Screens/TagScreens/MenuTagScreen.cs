using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Screens.TagScreens
{
    public static class MenuTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Tags");
            Console.WriteLine("---------------");
            Console.WriteLine("1 - List tags");
            Console.WriteLine("2 - Create tag");
            Console.WriteLine("3 - Update tag");
            Console.WriteLine("4 - Delete tag");
            Console.WriteLine("5 - Back");
            Console.WriteLine("---------------");
            Console.Write("Choose an option: ");
            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    ListTagScreen.Load();
                    break;
                case "2":
                    CreateTagScreen.Load();
                    break;
                case "3":
                    UpdateTagScreen.Load();
                    break;
                case "4":
                    DeleteTagScreen.Load();
                    break;
                case "5":
                    Program.Load();
                    break;
                default:
                    Load();
                    break;
            }
        }
    }
}
