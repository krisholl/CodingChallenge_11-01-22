using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtBash_Cypher.Encrypter
{
    public class Encryption
    {
        public Encryption()
        {

        }
        private static string Lower { get; } = "abcdefghijklmnopqrstuvwxyz";
        private static string ReverseLower { get; } = string.Join("", Lower.Reverse());

        private static string Upper { get; } = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static string ReverseUpper { get; } = string.Join("", Upper.Reverse());

        public string Encrypt(string regular)
        {
            if(regular == "")
            {
                return "Nothing given";
            }
            string result = "";
            foreach(char c in regular)
            {
                if (Lower.IndexOf(c) != -1)
                {
                    result += ReverseLower[Lower.IndexOf(c)];
                }
                else if(Upper.IndexOf(c)!=-1)
                {
                    result += ReverseUpper[Upper.IndexOf(c)];
                }
                else
                {
                    result += c;
                }
            }
            return result;
        }

        public string Decrypt(string cryptic)
        {
            if (cryptic == "")
            {
                return "Nothing given";
            }
            string result = "";
            foreach (char c in cryptic)
            {
                if(Lower.IndexOf(c) != -1)
                {
                    result += ReverseLower[Lower.IndexOf(c)];
                }
                else if(Upper.IndexOf(c) != -1)
                {
                    result += ReverseUpper[Upper.IndexOf(c)];
                }
                else
                {
                    result += c;
                }
            }
            return result;
        }
    }
}
