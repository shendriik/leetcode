namespace N13_Roman_to_integer
{
    public class Solution {
    
        private Dictionary<char,int> map = new Dictionary<char,int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };
    
        public int RomanToInt(string s) {
        
            var result = 0;
            var previous = 0;
            for(var i = 0;i < s.Length; i++)
            {
                var current = map[s[i]];
            
                if(previous < current && i!=0)
                {
                    result-= previous*2;
                }
            
                result+=current;
            
                previous = current;
            }
        
            return result;
        }
    }
}
