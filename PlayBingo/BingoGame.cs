using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayBingo
{
    class BingoGame
    {
        List<int> numbersList = new List<int> { };

        public int PlayGame()
        {
            Random bingoNumber = new Random();
            var nums = Enumerable.Range(1, 75).OrderBy(x => bingoNumber.Next()).ToList();

            while (numbersList.Count < 75)
            {
                numbersList.Add(nums[0]);
                nums.RemoveAt(0);
            }

            foreach (int num in numbersList)
            {
                Console.WriteLine(num);
            }
            return numbersList.Count();
        }
    }
}
