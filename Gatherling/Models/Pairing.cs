using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Gatherling.Models
{
    public class Pairing : IComparable<Box>
    {
        public string A { get; internal set; }
        public int A_wins { get; internal set; }
        public string B { get; internal set; }
        public int B_wins { get; internal set; }
        public string Res { get; internal set; }
        public string Verification { get; internal set; }

        public string[] Players => A == B ? new string[] { A } : Regex.replace(A.lower, "[^a-z]").compareTo(Regex.replace(B.lower, "[^a-z]")) <= 0 ? new string[] { A, B } : new string[] { B, A };

        public override string ToString()
        {
            CalculateRes();
            if (Res == "BYE")
                return $"{A} has the BYE!";
            return $"{A} {Res} {B}";
        }

        public void CalculateRes()
        {
            if (Res == null)
            {
                if (A == B)
                {
                    Res = "BYE";
                }
                else if (Verification == "verified")
                {
                    if (A_wins == 0 && B_wins == 0)
                    {
                        Res = $"?-?";
                    }
                    else
                    {
                        Res = $"{A_wins}-{B_wins}";
                    }
                }
                else
                {
                    Res = "vs.";
                }
            }
        }
        public int CompareTo(Pairing pair)
        {
            return A.Regex.replace(A.lower, "[^a-z]").compareTo(Regex.replace(pair.A.lower, "[^a-z]"));
        }

    }

}
