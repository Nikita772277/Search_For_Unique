using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class WorkingWithStrings
    {
        public List<string> SearchForAUnique(string[] strings)
        {
            if (strings == null)
            {
                return null;
            }
            List<string> list = new List<string>();
            for(int s = 0; s < strings.Length; s++)
            {
                string word = strings[0];
                int counter = 0;
                for (int i = 0; i < s; i++)
                {
                    for (int j = 0; j < word.Length; j++)
                    {
                        if (strings[s][i] == word[j])
                        {
                            if (strings[s][i] != ' ')
                                counter++;
                        }
                        if (counter == 1)
                        {
                            break;
                        }
                    }
                }
                if(counter == 0)
                {
                    list.Add(strings[s]);
                }
                if (list.Count == 1)
                {
                    break;
                }
            }
            return list;
        }
    }
}
