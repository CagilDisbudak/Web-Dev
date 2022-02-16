using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable CS0219

namespace ConsoleApp201711022
{
    class Food
    {
        private int food_id;
        public int Food_id
        {
            get
            {
                return food_id;
            }
            set
            {
                this.food_id = value;
            }
        }
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }

        private string type;
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                this.type = value;
            }
        }

        private int price;
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                this.price = value;
            }
        }


    }




    class Program
    {
        static void Main(string[] args)
        {
            int tut ;
            int t;
            int i = -1;
            string s = "";
            string bas ="";
            int z = 0;

            Console.Write("Input number of food(s) : ");
            tut = Convert.ToInt32(Console.ReadLine());

          //  Food[] ad = new Food[tut];

            var foods = new List<Food>(tut);
            
         

            while (i <= tut)
            {
                if (bas == "exit" || bas == "Exit")
                {
                    break;
                }
                else if (bas == "add" || bas == "Add")
                {
                    Food temp = new Food();
                    Console.Write("Enter FoodId :");
                    temp.Food_id = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Name :");
                    temp.Name = Console.ReadLine();

                    Console.Write("Enter Price :");
                    temp.Price = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Type :  ( s , v , m ,d ) : ");
                    temp.Type = Console.ReadLine();

                    foods.Add(temp);
                    
                    i++;
                }

                else if (bas == "remove" || bas == "Remove")
                {

                    Console.Write("Remove with food id :");
                    t = Convert.ToInt32(Console.ReadLine());


                    int indx = foods.BinarySearch(foods.Find(x => (t == x.Food_id)));

                    foods.RemoveAt(indx);



                    i--;
                }

                else if (bas == "search" || bas == "Search")
                {
                        Console.Write("Search with food id :");
                        t = Convert.ToInt32(Console.ReadLine());

                    Food temp = foods.Find(x => ( t == x.Food_id)) ;


                    Console.WriteLine("Name : " + temp.Name);
                    Console.WriteLine("ID : " + temp.Food_id);
                    Console.WriteLine("FoodType : " + temp.Type);
                    Console.WriteLine("Food Price :" + temp.Price);


                }

                else if(bas == "Display" || bas == "display")
                {
                    Console.WriteLine("Soup : ");
                    for (z = 0; z<=i; z++)
                    {
                        if((foods[z].Type) == "s")
                        {
                            Console.Write("Name : " + foods[z].Name);
                            Console.Write(" ID : " + foods[z].Food_id);
                            Console.Write(" FoodType : " + foods[z].Type);
                            Console.WriteLine(" Food Price :" + foods[z].Price);
                        }
                    }

                    Console.WriteLine("Vegetable : ");
                    for ( z = 0; z <= i; z++)
                    {
                        if ((foods[z].Type) == "v")
                        {
                            Console.Write("Name : " + foods[z].Name);
                            Console.Write(" ID : " + foods[z].Food_id);
                            Console.Write(" FoodType : " + foods[z].Type);
                            Console.WriteLine(" Food Price :" + foods[z].Price);
                        }
                    }

                    Console.WriteLine("Main : ");
                    for ( z = 0; z <= i; z++)
                    {
                        if (foods[z].Type == "m")
                        {
                            Console.Write("Name : " + foods[z].Name);
                            Console.Write(" ID : " + foods[z].Food_id);
                            Console.Write(" FoodType : " + foods[z].Type);
                            Console.WriteLine(" Food Price :" + foods[z].Price);
                        }
                    }


                    Console.WriteLine("Dessert : ");
                    for ( z = 0; z <= i; z++)
                    {
                        if (foods[z].Type == "d")
                        {
                            Console.Write("Name : " + foods[z].Name);
                            Console.Write(" ID : " + foods[z].Food_id);
                            Console.Write(" FoodType : " + foods[z].Type);
                            Console.WriteLine(" Food Price :" + foods[z].Price);
                        }
                    }

                }
                
                Console.Write("Choose an operation : ");
                bas = Console.ReadLine();
            }


        }







    }
}
