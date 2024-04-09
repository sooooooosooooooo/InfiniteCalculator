using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiniteCalculator
{
    internal class Repetitive
    {
        public static bool Checker(int[] a, int[] b)
        {
            for (int i = 0;i < a.Length; i++)
            {
                if (a[i] > b[i])
                {
                    return true;
                }
            }
            return false;
        }
        // correct array to dont let numbers start from 0
        public static int[] Overwriter(int[] x)
        {
            int times = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (i == x.Length - 1)
                    break;
                else if (x[i] == 0)
                    times++;
                else
                    break;
            }
            int[] result = new int[x.Length - times];
            for (int i = 0; i < result.Length; i++)
            {
                result[result.Length - (i + 1)] = x[x.Length - (i + 1)];
            }
            return result;
        }
        // adding first array numbers to second
        public static int[] ArrayAdder(int[] a , int[] b)
        {
            int max = Math.Max(a.Length, b.Length) + 1;
            int[] result = new int[max];

            int overflow = 0;
            for (int i = 0; i < max; i++)
            {
                int sum = overflow;
                if (i < a.Length)
                    sum += a[a.Length - (i + 1)];
                if (i < b.Length)
                    sum += b[b.Length - (i + 1)];

                result[max - (i + 1)] = sum % 10;
                overflow = sum / 10;
            }
            return result;
        }
        // minusing second array numbers to first
        public static int[] ArrayMinuser(int[] a, int[] b)
        {
            int max = Math.Max(a.Length, b.Length);
            int[] result = new int[max];

            int lacking = 0;
            for (int i = 0; i < b.Length; i++)
            {
                if (b[b.Length - (i + 1)] > a[a.Length - (i + 1)] || b[b.Length - (i + 1)] > a[a.Length - (i + 1)] + lacking)
                {
                    int sum = lacking;
                    sum = sum + a[a.Length - (i + 1)] + 10 - b[b.Length - (i + 1)];
                    result[result.Length - (i + 1)] = sum;
                    lacking = - 1;
                }
                else
                {
                    int sum = lacking;
                    sum = sum + a[a.Length - (i + 1)] - b[b.Length - (i + 1)];
                    result[result.Length - (i + 1)] = sum;
                    lacking = 0;
                }
                if (i == b.Length - 1 && lacking == - 1 && a.Length < b.Length)
                {
                    a[a.Length - (i + 2)]--;
                }
            }
            return result;
        }
        // multiplying arrays to each other
        public static int[] ArrayMultiply(int[] a, int[] b)
        {
            int[] result = new int[a.Length + b.Length];
            int multiplier = 1;
            int saveMultiplier = 1;
            int overflow = 0;
            
            if (a.Length <= b.Length)
            {
                SimpleMultiply(a,b,ref multiplier,ref saveMultiplier,result,ref overflow);
                return result;
            }
            else
            {
                SimpleMultiply(b, a, ref multiplier, ref saveMultiplier, result, ref overflow);
                return result;
            }
        }
        public static void SimpleMultiply(int[] a, int[] b,ref int multiplier,ref int saveMultiplier, int[] result ,ref int overflow)
        {
            for (int i = a.Length - 1; i >= 0; i--)
            {
                multiplier = saveMultiplier;
                for (int j = b.Length - 1; j >= 0; j--)
                {
                    string answer = Convert.ToString(a[i] * b[j]);
                    if (answer.Length == 1)
                    {
                        overflow = (result[result.Length - multiplier] + Convert.ToInt32(answer)) / 10;
                        result[result.Length - multiplier] = (result[result.Length - multiplier] + Convert.ToInt32(answer)) % 10;
                        if (overflow > 0)
                        {
                            result[result.Length - (multiplier + 1)] += overflow;
                        }
                        overflow = 0;
                        multiplier++;
                    }
                    if (answer.Length == 2)
                    {
                        overflow = (result[result.Length - multiplier] + (Convert.ToInt32(answer[1]) - 48)) / 10;
                        result[result.Length - multiplier] = (result[result.Length - multiplier] + (Convert.ToInt32(answer[1]) - 48)) % 10;
                        if (overflow > 0)
                        {
                            result[result.Length - (multiplier + 1)] += overflow;
                        }
                        overflow = (result[result.Length - (multiplier + 1)] + (Convert.ToInt32(answer[0]) - 48)) / 10;
                        result[result.Length - (multiplier + 1)] = (result[result.Length - (multiplier + 1)] + (Convert.ToInt32(answer[0]) - 48)) % 10;
                        if (overflow > 0)
                        {
                            result[result.Length - (multiplier + 2)] += overflow;
                        }
                        multiplier++;
                    }
                }
                saveMultiplier++;
            }
        }
    }
}
