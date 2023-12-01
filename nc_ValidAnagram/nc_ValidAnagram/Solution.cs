namespace nc_ValidAnagram
{
    public class Solution
    {

        //could have just used a dict instead to count frequency of chars
        //would result in better run time of O(n)
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            List<char> schars = new List<char>();
            List<char> tchars = new List<char>();

            for(int i =0; i < s.Length;i++)
            {
                schars.Add(s[i]);
                tchars.Add(t[i]);
            }

            schars.Sort();
            tchars.Sort();

            for(int i = 0; i < schars.Count; i++)
            {
                if (schars[i] != tchars[i])
                    return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IsAnagram("anagram", "nagaram"));
            
            
        }
    }
}