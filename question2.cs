public class Solution {
    public int RomanToInt(string s) {
        Dictionary<string, int> romans =
        new Dictionary<string, int>()
        {
            {"I", 1}, {"V", 5},
            {"X", 10}, {"L", 50},
             {"C", 100}, {"D", 500}, {"M", 1000}
        };
        int temp=0;
        int answer=0;
        for(int i=s.Length-1;i>=0;i--){
            if(romans[s[i].ToString()]>=temp){
                answer+=romans[s[i].ToString()];
            }else{
                answer-=romans[s[i].ToString()];
            }
            temp = romans[s[i].ToString()];
        }
        return answer;
    }
}