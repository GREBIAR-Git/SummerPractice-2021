using System;
namespace Charts
{
    public class TranslatingExpression
    {
        void addBracket(ref string str,int i,int offset)
        {
            if (str[i + offset] != '(')
            {
                int f = i + offset;
                if(str[f]=='-')
                {
                    f++;
                }
                while (str.Length > f &&( Char.IsDigit(str[f]) || str[f]=='x'))
                {
                    f++;
                }
                str = str.Insert(i + offset, "(");
                str = str.Insert(f + 1, ")");
            }
        }
        public float Translating(string str,float x)
        {
            try
            {
                str = str.ToLower();
                str = str.Replace(" ", "");
                str = str.Replace("--", "-");
                str = str.Replace(",", ".");
                for(int i=0;i<str.Length;i++)
                {
                    if (str.Length - 1 > i&& str[i] == '^')
                    {
                        addBracket(ref str, i, 1);
                        if (str[i - 1] != ')')
                        {
                            int f = i - 1;
                            while (f > 0 && Char.IsDigit(str[f]))
                            {
                                f--;
                            }
                            str = str.Insert(i, ")");
                            if(str[f]=='-')
                            {
                                str = str.Insert(f + 1, "(");
                            }
                            else
                            {
                                str = str.Insert(f, "(");
                            }
                        }
                    }
                    else if(str.Length - 2 > i && str[i] == 'l' && str[i+1] == 'n')
                    {
                        addBracket(ref str, i, 2);
                    }
                    else if (str.Length - 2 > i && str[i] == 't' && str[i+1] == 'g')
                    {
                        addBracket(ref str, i, 2);
                    }
                    else if (str.Length - 3 > i && str[i] == 's' && str[i+1] == 'i' && str[i + 2] == 'n')
                    {
                        addBracket(ref str, i, 3);
                    }
                    else if (str.Length - 3 > i && str[i] == 'c' && str[i+1] == 'o' && str[i + 2] == 's')
                    {
                        addBracket(ref str, i, 3);
                    }
                    else if (str.Length - 3 > i && str[i] == 'l' && str[i+1] == 'o' && str[i + 2] == 'g')
                    {
                        addBracket(ref str, i, 3);
                    }
                }
                str = str.Replace("x", x.ToString());
                for (int i = 0; str.Length > i; i++)
                {
                    if (str.Length - 2 > i && str[i] == 's' && str[i + 1] == 'i' && str[i + 2] == 'n')
                    {
                        string inParentheses = string.Empty;
                        int placeInsertion = 0;
                        if (funcO(3, ref i, ref str, ref inParentheses, ref placeInsertion))
                        {
                            str = str.Insert(placeInsertion, Math.Sin(Convert.ToDouble(inParentheses)).ToString());
                        }
                    }
                    else if (str.Length - 2 > i && str[i] == 'c' && str[i + 1] == 'o' && str[i + 2] == 's')
                    {
                        string inParentheses = string.Empty;
                        int placeInsertion = 0;
                        if (funcO(3, ref i, ref str, ref inParentheses, ref placeInsertion))
                        {
                            str = str.Insert(placeInsertion, Math.Cos(Convert.ToDouble(inParentheses)).ToString());
                        }
                    }
                    else if (str.Length - 2 > i && str[i] == 'l' && str[i + 1] == 'o' && str[i + 2] == 'g')
                    {
                        string inParentheses = string.Empty;
                        int placeInsertion = 0;
                        if (funcO(3, ref i, ref str, ref inParentheses, ref placeInsertion))
                        {
                            str = str.Insert(placeInsertion, Math.Log(Convert.ToDouble(inParentheses)).ToString());
                        }
                    }
                    else if (str.Length - 1 > i && str[i] == 't' && str[i + 1] == 'g')
                    {
                        string inParentheses = string.Empty;
                        int placeInsertion = 0;
                        if (funcO(2, ref i, ref str, ref inParentheses, ref placeInsertion))
                        {
                            str = str.Insert(placeInsertion, Math.Tan(Convert.ToDouble(inParentheses)).ToString());
                        }
                    }
                    else if (str.Length - 1 > i && str[i] == 'l' && str[i + 1] == 'n')
                    {
                        string inParentheses = string.Empty;
                        int placeInsertion = 0;
                        if (funcO(2, ref i, ref str, ref inParentheses, ref placeInsertion))
                        {
                            str = str.Insert(placeInsertion, Math.Log10(Convert.ToDouble(inParentheses)).ToString());
                        }
                    }
                    else if (str[i] == '^')
                    {
                        string inParentheses = string.Empty;
                        int placeInsertion = 0;
                        int countS = 0;
                        int f=i-2;
                        while(str[f]!='(')
                        {
                            countS++;
                            f--;
                        }
                        f++;
                        string byff = "";
                        byff = str.Substring(f, countS);
                        placeInsertion = f;
                        if (funcO(1, ref i, ref str, ref inParentheses, ref placeInsertion))
                        {
                            str = str.Insert(placeInsertion,Math.Pow(double.Parse(byff), Convert.ToDouble(inParentheses)).ToString());
                        }
                    }
                }
                str = str.Replace(',', '.');
                str = (new System.Data.DataTable()).Compute(str, "").ToString();
                if (str == "")
                {
                    return 0;
                }
                return -float.Parse(str);
            }
            catch
            {
                return float.NaN;
            }
        }

        bool funcO(int num, ref int i, ref string str, ref string inParentheses, ref int placeInsertion)
        {
            i += 1 + num;
            int start = i - 1;
            int countTemp=0;
            while (str[i] != ')' || countTemp>0)
            {
                if(str[i]=='(')
                {
                    countTemp++;
                }
                else if(str[i] == ')')
                {
                    countTemp--;
                }
                inParentheses += str[i];
                i++;
            }
            if (Search(inParentheses) == 0)
            {
                if(num!=1)
                {
                    placeInsertion = start - num - placeInsertion;
                    str = str.Substring(0, placeInsertion) + str.Substring(i + 1, str.Length - i - 1);
                }
                else
                {
                    str = str.Insert(i + 1, ")");
                    str = str.Substring(0, placeInsertion) + str.Substring(i + 1, str.Length - i - 1);
                }
                i = -1;
                str = str.Replace(',', '.');
                inParentheses = inParentheses.Replace(',', '.');
                inParentheses = (new System.Data.DataTable()).Compute(inParentheses, "").ToString();
                return true;
            }
            else
            {
                i = start;
                return false;
            }
        }

        int Search(string str)
        {
            for (int i = 0; str.Length > i; i++)
            {
                if (str.Length - 2 > i && str[i] == 's' && str[i + 1] == 'i' && str[i + 2] == 'n')
                {
                    return -1;
                }
                else if (str.Length - 2 > i && str[i] == 'c' && str[i + 1] == 'o' && str[i + 2] == 's')
                {
                    return -1;
                }
                else if (str.Length - 2 > i && str[i] == 'l' && str[i + 1] == 'o' && str[i + 2] == 'g')
                {
                    return -1;
                }
                else if (str.Length - 1 > i && str[i] == 't' && str[i + 1] == 'g')
                {
                    return -1;
                }
                else if (str.Length - 1 > i && str[i] == 'l' && str[i + 1] == 'n')
                {
                    return -1;
                }
                else if (str.Length> i && str[i] == '^')
                {
                    return -1;
                }
            }
            return 0;
        }
    }
}
