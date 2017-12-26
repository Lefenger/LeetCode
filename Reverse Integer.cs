public class Solution {
    public int Reverse(int x) {
        if (x == 0)
                return 0;
            bool isminus = false;
            bool isend=true;
            string s=x.ToString();
            char[] clist = s.ToCharArray();
            string sr="";
           
            for (int i = clist.Length - 1; i >= 0;i--)
            {
                if (clist[i] == '-')
                {
                    isminus = true;
                    continue;
                }
                if(clist[i]!='0'||!isend)
                {
                    isend = false;
                    sr += clist[i];
                }
            }
            if (isminus)
                sr = '-' + sr;
            long result = Convert.ToInt64(sr);
            if (Math.Abs(result) > Math.Pow(2, 31) - 1) return 0;
            else return (int)result;
    }
}