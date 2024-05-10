using System.Linq;

namespace LeetCode
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            String[] strs = ["eat", "tea", "tan", "ate", "nat", "bat","tab","car","rar","rac","arc"];
            foreach (var group in GroupAnagrams(strs))
            {
                Console.WriteLine(string.Join(", ", group));
            }
        }
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            bool groupfound = false;
            IList<IList<String>> group = new List<IList<string>>();
            group.Add([strs[0]]);
            foreach (String str in strs)
            {
                foreach (IList<String> groupe in group.ToList())
                {
                    if (IsAnagram(str, groupe[0]))
                    {
                        groupfound = true;
                        groupe.Add(str);
                        break;
                        
                    }
                }
                if (groupfound)
                {
                    groupfound = false;
                    continue;
                }
                group.Add([str]);                

            }
            group[0].RemoveAt(0);
            return group;
        }
        static bool IsAnagram(string s, string t)
        {
            char[] s1 = s.ToCharArray();
            char[] t1 = t.ToCharArray();
            Array.Sort(s1);
            Array.Sort(t1);
       
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != t1[i])
                {
                    return false;
                }
               
            }
            return true;
        }
       
    }
   




    

}