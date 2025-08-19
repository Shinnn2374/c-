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
            Console.WriteLine($"Вы смогли получили  - {add}" + "\n" + "Вы потратили - " + car + nj + "\n"
                + $"Вы сохранили - {howICanSave(add, car, nj)}" + "\n");
            
        }

        private static int howICanSave(int add,int car, int nj)
        {
            int save = add - car - nj;
            return save;
        }

        private int howICanSaveInProcent(int add, int car, int nj)
        {
            int save = add - car - nj;
            int procent = add / 100;
            return save /  procent;
        }

        private void status(int add, int car, int nj)
        {
            if (howICanSaveInProcent(add, add, nj) <= 40)
            {
                Console.WriteLine("Вы смогли сохранить менее 20% своего дохода. Status - bad :(");
            }
            else if (howICanSaveInProcent(add, car, nj) > 40 && howICanSaveInProcent(add, car, nj) < 70)
            {
                Console.WriteLine($"Вы смогли сохранить {howICanSaveInProcent(add, car, nj)} своего дохода. Status - normal :|");
            }    
            else if (howICanSaveInProcent(add, add, nj) >= 70)
            {
                Console.WriteLine($"Вы смогли сохранить {howICanSaveInProcent(add, car, nj)} своего дохода. Status - good :)");
            }
        }
    }
}