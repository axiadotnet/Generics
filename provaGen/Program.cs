using System;

namespace provaGen
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal gatto = new Animal("gatto", 4);
            Animal gallina = new Animal("gallina", 2);

            Console.WriteLine(gatto);
            Console.WriteLine(gallina);

            Console.WriteLine("///////////");
            Swap(ref gatto, ref gallina);

            Console.WriteLine(gatto);
            Console.WriteLine(gallina);

            Console.WriteLine("///////////");
            Console.WriteLine("///////////");

            string gattoS = "gatto";
            string gallinaS = "gallina";

            Console.WriteLine(gattoS);
            Console.WriteLine(gallinaS);

            Console.WriteLine("///////////");
            Swap(ref gattoS, ref gallinaS);

            Console.WriteLine(gattoS);
            Console.WriteLine(gallinaS);


            Console.WriteLine("///////////");
            Console.WriteLine("///////////");

            int gattoZ = 4;
            int gallinaZ = 2;

            Console.WriteLine(gattoZ);
            Console.WriteLine(gallinaZ);

            Console.WriteLine("///////////");
            Swap(ref gattoZ, ref gallinaZ);

            Console.WriteLine(gattoZ);
            Console.WriteLine(gallinaZ);

            MyList list = new MyList();
            list.Add(gatto);
            list.Add(gallina);
            list.Add(gattoS);
            list.Add(gallinaS);
            list.Add(gattoZ);
            list.Add(gallinaZ);

            Console.WriteLine("///////////");
            Console.WriteLine("///////////");

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list.Get(i));
            }

            Console.WriteLine("///////////");
            Console.WriteLine("///////////");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }



            MyGenList<Animal> list2 = new MyGenList<Animal>();
            list2.Add(gatto);
            list2.Add(gallina);
            list2.Add(gallinaS);

            Console.WriteLine("///////////");
            Console.WriteLine("///////////");

            for (int i = 0; i < list2.Count; i++)
            {
                Console.WriteLine(list.Get(i));
            }

            Console.WriteLine("///////////");
            Console.WriteLine("///////////");

            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }
        }

        static void Swap<T>(ref T a1,ref T a2)
        {
            T temp = a1;
            a1 = a2;
            a2 = temp;
        }
    }
}
