namespace N383_Ransome_Note
{
    public class Solution
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            var map = new Dictionary<char, int>();
            for (var i = 0; i < magazine.Length; i++)
            {
                if (!map.ContainsKey(magazine[i]))
                {
                    map.Add(magazine[i], 0);
                }

                map[magazine[i]]++;
            }

            for (var i = 0; i < ransomNote.Length; i++)
            {
                if (!map.ContainsKey(ransomNote[i]) || --map[ransomNote[i]] < 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}