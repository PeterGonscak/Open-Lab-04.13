using System;

namespace Open_Lab_04._13
{
    public class StringTools
    {
        public string GetLongestCommonSequence(string str1, string str2)
        {
            var dlzky = new int[str1.Length, str2.Length];
            int najDlzka = 0;
            string output = "";
            for (int i = 0; i < str1.Length; i++)
            {
                for (int j = 0; j < str2.Length; j++)
                {
                    if (str1[i] == str2[j])
                    {
                        dlzky[i, j] = i == 0 || j == 0 ? 1 : dlzky[i - 1, j - 1] + 1;
                        if (dlzky[i, j] > najDlzka)
                        {
                            najDlzka = dlzky[i, j];
                            output = str1.Substring(i - najDlzka + 1, najDlzka);
                        }
                    }
                    else
                    {
                        dlzky[i, j] = 0;
                    }
                }
            }
            return output;
        }
    }
}
