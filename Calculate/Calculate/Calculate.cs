using System;

namespace Calculate
{
    public class Calculate
    {
        public Calculate()
        {
        }

        public static void CalculateMyMoney()
        {
            Console.WriteLine("Напишите свой доход");
            var add = Console.Read();
            Console.WriteLine("Напишите свой расход на машину(топливо,сервис и тд.)");
            var car = Console.Read();
            Console.WriteLine("Напишите свой расход на нужды(еда, одежда и тд.)");
            var nj = Console.Read();
            Console.WriteLine($"Вы смогли получили  - {add}");
            Console.WriteLine($"Вы потратили - {car + nj}");
            Console.WriteLine($"Вы смогли сохранить - {howICanSave(add, car, nj)}");
            Console.WriteLine($"Вы смогли сохранить в процентах - {howICanSaveInProcent(add, car, nj)}");
            Console.WriteLine(status(add, car, nj));
        }

        private static int howICanSave(int add,int car, int nj)
        {
            int save = add - car - nj;
            return save;
        }

        private static int howICanSaveInProcent(int add, int car, int nj)
        {
            int save = add - car - nj;
            int procent = add / 100;
            return save /  procent;
        }

        private static string status(int add, int car, int nj)
        {
            if (howICanSaveInProcent(add, add, nj) <= 40)
            {
                return "Вы смогли сохранить менее 20% своего дохода. Status - bad :(";
            }
            else if (howICanSaveInProcent(add, car, nj) > 40 && howICanSaveInProcent(add, car, nj) < 70)
            {
                return $"Вы смогли сохранить {howICanSaveInProcent(add, car, nj)} своего дохода. Status - normal :|";
            }    
            else if (howICanSaveInProcent(add, add, nj) >= 70)
            {
                return $"Вы смогли сохранить {howICanSaveInProcent(add, car, nj)} своего дохода. Status - good :)";
            }
            return null;
        }
    }
}