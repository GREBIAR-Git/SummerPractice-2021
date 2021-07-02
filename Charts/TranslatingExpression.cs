using System;

namespace Charts
{
    class TranslatingExpression
    {
        public static float Translating(string str,float x)
        {
            str = str.ToLower();
            str = str.Replace(" ", "");
            str = str.Replace("--", "-");
            str = str.Replace("x", x.ToString());
            for (int i = 0; str.Length > i; i++)
            {
                if (str.Length-3 > i && str[i] == 's' && str[i + 1] == 'i' && str[i + 2] == 'n')
                {
                    string inParentheses = string.Empty;
                    int placeInsertion = 0;
                    if (funcO(3, ref i, ref str, ref inParentheses,ref placeInsertion))
                    {
                        string t = (new System.Data.DataTable()).Compute(inParentheses, "").ToString();
                        str = str.Insert(placeInsertion, Math.Round(Math.Sin(Convert.ToDouble(t)), 1).ToString());
                        i = -1;
                    }
                }
                else if (str.Length - 3 > i && str[i] == 'c' && str[i + 1] == 'o' && str[i + 2] == 's')
                {
                    string inParentheses = string.Empty;
                    int placeInsertion = 0;
                    if (funcO(3, ref i, ref str, ref inParentheses, ref placeInsertion))
                    {
                        string t = (new System.Data.DataTable()).Compute(inParentheses, "").ToString();
                        str = str.Insert(placeInsertion, Math.Round(Math.Cos(Convert.ToDouble(t)), 1).ToString());
                        i = -1;
                    }
                }
                else if (str.Length - 3 > i && str[i] == 'l' && str[i + 1] == 'o' && str[i + 2] == 'g')
                {
                    string inParentheses = string.Empty;
                    int placeInsertion = 0;
                    if (funcO(3, ref i, ref str, ref inParentheses, ref placeInsertion))
                    {
                        string t = (new System.Data.DataTable()).Compute(inParentheses, "").ToString();
                        str = str.Insert(placeInsertion, Math.Round(Math.Log(Convert.ToDouble(t)), 1).ToString());
                        i = -1;
                    }
                }
                else if (str.Length - 2 > i && str[i] == 't' && str[i + 1] == 'g')
                {
                    string inParentheses = string.Empty;
                    int placeInsertion = 0;
                    if (funcO(2, ref i, ref str, ref inParentheses, ref placeInsertion))
                    {
                        string t = (new System.Data.DataTable()).Compute(inParentheses, "").ToString();
                        str = str.Insert(placeInsertion, Math.Round(Math.Tan(Convert.ToDouble(t)), 1).ToString());
                        i = -1;
                    }
                }
                else if (str.Length - 2 > i && str[i] == 'l' && str[i + 1] == 'n')
                {
                    string inParentheses = string.Empty;
                    int placeInsertion = 0;
                    if (funcO(2, ref i, ref str, ref inParentheses, ref placeInsertion))
                    {
                        string t = (new System.Data.DataTable()).Compute(inParentheses, "").ToString();
                        str = str.Insert(placeInsertion, Math.Round(Math.Log10(Convert.ToDouble(t)), 1).ToString());
                        i = -1;
                    }
                }
                else if (str.Length - 1 > i&&str[i] == '^')
                {
                    string inParentheses = string.Empty;
                    int placeInsertion = 0;
                    int countS=0;
                    int f;
                    for (f=i - 1; f>=0;f--)
                    {
                        if (Char.IsDigit(str[f]))
                        {
                            countS++;
                        }
                        else
                        {
                            if(str[f]=='-')
                            {
                                countS++;

                            }
                            else
                            {
                                f++;
                            }
                            break;
                        }
                    }
                    string byff = "";
                    if(f==-1)
                    {
                        f = 0;
                    }
                    byff = str.Substring(f, countS);
                    placeInsertion = f;
                    if (funcR(1, ref i, ref str, ref inParentheses, ref placeInsertion))
                    {
                        if (byff[0] == '-' && byff.Length == 1)
                        {
                            byff = "-1";
                        }
                        str = str.Replace(',', '.');
                        string t = (new System.Data.DataTable()).Compute(inParentheses, "").ToString();
                        str = str.Insert(placeInsertion, Math.Round(-Math.Pow(double.Parse(byff),Convert.ToDouble(t)), 1).ToString());
                        i = -1;
                    }
                }
            }
            str = str.Replace(',', '.');
            if(str=="не число")
            {
                str = "0";
            }
            str = (new System.Data.DataTable()).Compute(str, "").ToString();
            if(str=="")
            {
                return 0;
            }
            return float.Parse(str);
        }

        static bool funcO(int num, ref int i, ref string str, ref string inParentheses, ref int tyt)
        {
            i += 1 + num;
            int t1 = i - 1;
            while (str[i] != ')')
            {
                inParentheses += str[i];
                i++;
            }
            if (Search(inParentheses) == 0)
            {
                str = str.Substring(0, t1 - num - tyt) + str.Substring(i + 1, str.Length - i - 1);
                tyt = t1 - num - tyt;
                return true;
            }
            else
            {
                i = t1;
                return false;
            }
        }


        static bool funcR(int num,ref int i,ref string str,ref string inParentheses,ref int tyt)
        {
            i += 1+num;
            int t1 = i - 1;
            while (str[i] != ')')
            {
                inParentheses += str[i];
                i++;
            }
            if (Search(inParentheses) == 0)
            {
                str = str.Substring(0, tyt) + str.Substring(i + 1, str.Length - i - 1);
                return true;
            }
            else
            {
                i = t1;
                return false;
            }
        }

        static int Search(string str)
        {
            for (int i = 0; str.Length - 3 > i; i++)
            {
                if (str[i] == 's' && str[i + 1] == 'i' && str[i + 2] == 'n')
                {
                    return -1;
                }
                else if (str[i] == 'c' && str[i + 1] == 'o' && str[i + 2] == 's')
                {
                    return -1;
                }
                else if (str[i] == 'l' && str[i + 1] == 'o' && str[i + 2] == 'g')
                {
                    return -1;
                }
                else if (str[i] == 't' && str[i + 1] == 'g')
                {
                    return -1;
                }
                else if (str[i] == 'l' && str[i + 1] == 'n')
                {
                    return -1;
                }
                else if (str[i] == '^')
                {
                    return -1;
                }
            }
            return 0;
        }
    }
}
