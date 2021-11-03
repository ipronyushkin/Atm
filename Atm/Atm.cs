using System.Collections.Generic;


namespace Atm
{
    public class Atm
    {
        public void getAnswer(int cash, int[] banknote, int ind, string str, List<string> ans)
        {
            for(int i = ind; i > -1; i--)
            {
                if (cash - banknote[i] > 0)
                {
                    var tmp = banknote[i].ToString();
                    str += tmp + " ";
                    ind = i;
                    getAnswer(cash - banknote[i], banknote, ind, str, ans);
                    str = str.Substring(0, str.Length - tmp.Length - 1);
                } else if (cash - banknote[i] == 0)
                {
                    str += banknote[i].ToString();
                    ans.Add(str);
                }
            }
        }
    }
}