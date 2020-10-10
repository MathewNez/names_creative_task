using System;
using System.Linq;
using ZedGraph;

/*
 * !!!ВНИМАНИЕ!!!
 * если ещё не поздно, то тут будет ссылка на github-репу,
 * куда я выложу решение творческого задания, возможно,
 * даже с адекватными и последовательными коммитами
 * ССЫЛКА: https://github.com/.../ (пока её нет, но всё впереди)
 */

namespace Names
{
    internal static class HeatmapTask
    {

        public static void InitArray(string[] arr, int shift)
        {
            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = (i + shift).ToString();
            }
        }
        public static HeatmapData GetBirthsPerDateHeatmap(NameData[] names)
        {
            var daysX = new string[30];
            var monthsY = new string[12];
            InitArray(daysX, 2);
            InitArray(monthsY, 1);
            var count = new double[30, 12];
            foreach (var person in names)
            {
                if (person.BirthDate.Day != 1)
                {
                    ++count[person.BirthDate.Day-2, person.BirthDate.Month-1];
                }
            }
            return new HeatmapData(
                "Рождаемость в зависимости от дня и месяца",
                count, 
                daysX, 
                monthsY);
        }
    }
}