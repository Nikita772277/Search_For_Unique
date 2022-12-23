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
            foreach( string s in strings)
            {
                string word = strings[0];
                int counter = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    for (int j = 0; j < word.Length; j++)
                    {
                        if (s[i] == word[j])
                        {
                            if (s[i] != ' ')
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
                    list.Add(s);
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
