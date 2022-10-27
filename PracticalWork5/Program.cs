using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticalWork5;
using System.IO;

namespace PracticalWork5
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int position;
            Cake cake = new Cake();
            Item circle = new Item();
            circle.Name = "Круг";
            circle.Price = 500;
            Item square = new Item();
            square.Name = "Квадрат";
            square.Price = 600;
            Item hearth = new Item();
            hearth.Name = "Сердце";
            hearth.Price = 800;
            List<Item> shapes = new List<Item>();
            shapes.Add(circle);
            shapes.Add(square);
            shapes.Add(hearth);

            Item small = new Item();
            small.Name = "Маленький";
            small.Price = 1000;
            Item medium = new Item();
            medium.Name = "Средний";
            medium.Price = 1250;
            Item big = new Item();
            big.Name = "Большой";
            big.Price = 1500;
            List<Item> sizes = new List<Item>();
            sizes.Add(small);
            sizes.Add(medium);
            sizes.Add(big);

            Item vanilla = new Item();
            vanilla.Name = "Ванильный";
            vanilla.Price = 200;
            Item chocolate = new Item();
            chocolate.Name = "Шоколадный";
            chocolate.Price = 300;
            Item caramel = new Item();
            caramel.Name = "Карамельный";
            caramel.Price = 300;
            Item berry = new Item();
            berry.Name = "Ягодный";
            berry.Price = 250;
            Item coconut = new Item();
            coconut.Name = "Кокосовый";
            coconut.Price = 350;
            List<Item> taste = new List<Item>();
            taste.Add(vanilla);
            taste.Add(chocolate);
            taste.Add(caramel);
            taste.Add(berry);
            taste.Add(coconut);

            Item one = new Item();
            one.Name = "Один корж";
            one.Price = 200;
            Item two = new Item();
            two.Name = "Два коржа";
            two.Price = 400;
            Item three = new Item();
            three.Name = "Три коржа";
            three.Price = 600;
            Item four = new Item();
            four.Name = "Четыре коржа";
            four.Price = 800;
            List<Item> amount = new List<Item>();
            amount.Add(one);
            amount.Add(two);
            amount.Add(three);
            amount.Add(four);

            Item chocolateGlaze = new Item();
            chocolateGlaze.Name = "Шоколад";
            chocolateGlaze.Price = 100;
            Item cream = new Item();
            cream.Name = "Карамель";
            cream.Price = 100;
            Item meringue = new Item();
            meringue.Name = "Безе";
            meringue.Price = 150;
            Item berryGlaze = new Item();
            berryGlaze.Name = "Ягоды";
            berryGlaze.Price = 200;
            List<Item> glaze = new List<Item>();
            glaze.Add(chocolateGlaze);
            glaze.Add(cream);
            glaze.Add(meringue);
            glaze.Add(berryGlaze);

            Item chocolateDecor = new Item();
            chocolateDecor.Name = "Шоколадный";
            chocolateDecor.Price = 150;
            Item berryDecor = new Item();
            berryDecor.Name = "Ягодный";
            berryDecor.Price = 150;
            Item creamDecor = new Item();
            creamDecor.Name = "Кремовый";
            creamDecor.Price = 150;
            List<Item> decor = new List<Item>();
            decor.Add(chocolateDecor);
            decor.Add(berryDecor);
            decor.Add(creamDecor);

            if (!File.Exists("C:\\Users\\Den\\Desktop\\Cakes.txt"))
                File.Create("C:\\Users\\Den\\Desktop\\Cakes.txt");
            while (true)
            {
                position = cake.Menu();
                switch (position)
                {
                    case 3:
                        cake.SecondMenu(shapes);
                        break;
                    case 4:
                        cake.SecondMenu(sizes);
                        break;
                    case 5:
                        cake.SecondMenu(taste);
                        break;
                    case 6:
                        cake.SecondMenu(amount);
                        break;
                    case 7:
                        cake.SecondMenu(glaze);
                        break;
                    case 8:
                        cake.SecondMenu(decor);
                        break;
                }
            }
        }
    }
}
