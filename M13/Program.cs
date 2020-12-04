using System;

namespace M13
{
    class Program
    {
        static void Pets(params string[] NamePets)
        {
                Console.Write("Сколько у Вас питомцев?");
                int CountAnimal = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ваших питомцев зовут: ");
                for (int i = 0; i < CountAnimal; i++)
                {
                    NamePets[i] = Console.ReadLine();
                }
                foreach (var NickName in NamePets)
                {
                    Console.WriteLine(NamePets);
                }
    
        }

        static void Main(string[] args)
        {
            (string name, string lastname, int age, bool HasPet, int CountAnimal) User;
            Console.Write("Введите имя: ");
            User.name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            User.lastname = Console.ReadLine();
            Console.Write("Введите Ваш возраст: ");
            User.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}, Ваша фамилия: {1}, Ваш возраст: {2}", User.name, User.lastname, User.age);

            Console.WriteLine("Есть ли у Вас животные? Да или Нет");

            var result = Console.ReadLine();
            if (result == "Да")
            {
                User.HasPet = true;
                                             
                Pets();
            }
            else
            {
                User.HasPet = false;
            }

            Console.ReadKey();
        }
    }
}
