﻿using System;

namespace PadawansTask1
{
    public class Population
    {
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            if(initialPopulation<=0 || currentPopulation<=0)
            {
                throw new ArgumentException();
                
            }

            int years = 0;
            while (initialPopulation<currentPopulation)
            {
                initialPopulation += ((int)(initialPopulation * percent) / 100) + visitors;
                years++;
            }
            return years;
        }
    }
}