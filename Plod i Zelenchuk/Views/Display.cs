using Plod_i_Zelenchuk.Controllers;
using Plod_i_Zelenchuk.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plod_i_Zelenchuk.Views
{
    public class Display
    {
        private VeganLogic veganlogicisdisplay = new VeganLogic();
        private int closeOperation = 6;
        public Display()
        {

            Input();

        }
        private void ShowMenu()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "MENU" + new string(' ', 18));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. List all entries");
            Console.WriteLine("2. Add new entry");
            Console.WriteLine("3. Update entry");
            Console.WriteLine("4. Fetch entry by ID");
            Console.WriteLine("5. Delete entry by ID");
            Console.WriteLine("6. Exit");
        }

        private void Input()
        {
            var operation = -1;
            do
            {
                ShowMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        ListAll();
                        break;
                    case 2:
                        Add();
                        break;
                    case 3:
                        Update();
                        break;
                    case 4:
                        Fetch();

                        break;
                    case 5:
                        Delete();
                    default:
                        break;

                }
            } while (operation != closeOperation);

        }

        private void Fetch()
        {
            Console.WriteLine("Въведи номер на клона!");
            int id = int.Parse(Console.ReadLine());
            VeganLogic vegancontroller = new VeganLogic();
            Vegan vegan = vegancontroller.Get(id);
            if (vegan != null)
            {
                PrintVegan(vegan);
            }
        }

        private void PrintVegan(Vegan vegan)
        {
            Console.WriteLine($"{vegan},{vegan.Name} --- Cena {vegan.Cena},VeganTypesId{vegan.VeganTypeId}");
        }

        private void Delete()
        {
            Console.WriteLine("Въведи номер на клона!");
            int id = int.Parse(Console.ReadLine());
            VeganLogic vegancontroller = new VeganLogic();
            Vegan vegan = vegancontroller.Get(id);
            if (vegan != null)
            {
                vegancontroller.Delete(id);
            }
        }


        private void Update()
        {
            Console.WriteLine("enter Vegan id");
            int veganId = int.Parse(Console.ReadLine());
            Vegan newVegan = veganlogicisdisplay.Get(veganId);
            if (newVegan != null)
            {
                Console.WriteLine("Nqma namereno kuche");
                return;
            }
            PrintVegan(newVegan);
            Console.WriteLine("vavedi novi tarseniq");
            Console.Write("Name:");
            newVegan.Name = Console.ReadLine();
            Console.Write("Age: ");
            newVegan.Cena = int.Parse(Console.ReadLine());
            VeganTypesLogic veganTypesLogic = new VeganTypesLogic();
            List<VeganTypes> allveganTypes = veganTypesLogic.GetAllVeganTypes();
            Console.WriteLine("vidove");
            Console.WriteLine(new string('-', 4));
            foreach (var item in allveganTypes)
            {
                Console.WriteLine(item.Id + ". " + item.Name);
            }
            Console.WriteLine("izberi vid");
            newVegan.VeganTypeId = int.Parse(Console.ReadLine());
            VeganLogic veganConstroller = new VeganLogic();
            veganConstroller.Update(veganId, newVegan);
        }

        private void Add()
        {
            Vegan VeganAdd = new Vegan();
            Console.WriteLine("Name:");
            VeganAdd.Name = Console.ReadLine();
            Console.Write("cena: ");
            VeganAdd.Cena = int.Parse(Console.ReadLine());
            VeganTypesLogic veganTypesLogic = new VeganTypesLogic();
            List<Vegan> allvegans = veganlogicisdisplay.GetAllVeganTypes();
            Console.WriteLine("Porodi:");
            Console.WriteLine(new string('-', 4));
            foreach (var item in allvegans)
            {
                Console.WriteLine(item.Id + ". " + item.Name);
            }
            Console.WriteLine("Izberi poroda:");
            VeganAdd.VeganTypeId = int.Parse(Console.ReadLine());
            VeganTypesLogic dogContorller = new VeganTypesLogic();
            dogContorller.Create(VeganAdd);
            Console.WriteLine($"{VeganAdd.Id}. {VeganAdd.Name} >>> {VeganAdd.Cena} >> VegansTypes:{VeganAdd.VeganTypeId}");
        }

    }

    private void ListAll()
    {
        Console.WriteLine(new string('-', 40));
        Console.WriteLine(new string(' ', 16) + "VEgans" + new string(' ', 16));
        Console.WriteLine(new string('-', 40));
        VeganLogic veganContorller = new VeganLogic();
        var products = veganContorller.GetAll();
        foreach (var item in products)
        {
            Console.WriteLine($"{item.Id} {item.Name} {item.Cena},{item.vegantypes}");
        }
    }
}


    

