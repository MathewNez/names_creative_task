using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace Names
{
    internal static class HistogramTask
    {
        public static HistogramData GetBirthsPerDayHistogram(NameData[] names, string name)
        {
            var dateX = new string[31];
            var countY = new double[31];
            for (int i = 0; i < dateX.Length; ++i)
            {
                dateX[i] = (i + 1).ToString();
            }
            foreach (var person in names)
            {
                if (person.BirthDate.Day != 1 && person.Name == name)
                {
                    ++countY[person.BirthDate.Day - 1];
                }
            }
            return new HistogramData(
                string.Format("Рождаемость людей с именем '{0}'", name), 
                dateX, 
                countY);
        }
    }
}