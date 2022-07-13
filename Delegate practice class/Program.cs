using System;

namespace Delegate_practice_class
{
    class Program
    {
        public delegate bool CheckNames(string names);

        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Fidan", "Seadet", "Narmin", "Cavid" };
            Console.WriteLine(GetCheckNames(CheckName,names));
        }

        public static bool CheckName(string str)
        {
            return str != "Cavid";
        }



        public static List<string> GetCheckNames(Predicate<string> predicate, sList<string> names)
        {
            List<string> datas = new List<string>();
            foreach (var item in names)
            {
                if (predicate(item))
                {
                    LocalDataStoreSlot.Add(item);
                }
            }

            return datas;
        }


    }
}
