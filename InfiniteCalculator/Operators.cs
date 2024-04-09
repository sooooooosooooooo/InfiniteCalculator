using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InfiniteCalculator
{
    internal class Operators
    {
        // adding a and b below
        public static Infinite Plus(Infinite a, Infinite b)
        {

            //if both nubers are negative
            if (a.Negativity == true && b.Negativity == true)
            {
                return new Infinite()
                {
                    Num = Repetitive.Overwriter(Repetitive.ArrayAdder(a.Num,b.Num)),
                    Negativity = true
                };
            }
            // if one of numbers are negative
            else if (a.Negativity == true || b.Negativity == true)
            {
                // if number a is bigger than number b
                if (a.Num.Length > b.Num.Length || (a.Num.Length == b.Num.Length && Repetitive.Checker(a.Num,b.Num)))
                {
                    if (a.Negativity == true)
                        return new Infinite()
                        {
                            Num = Repetitive.Overwriter(Repetitive.ArrayMinuser(a.Num, b.Num)),
                            Negativity = true
                        };
                    else
                        return new Infinite()
                        {
                            Num = Repetitive.Overwriter(Repetitive.ArrayMinuser(a.Num, b.Num)),
                            Negativity = false
                        };
                }
                // if number b is bigger than number a
                else if (b.Num.Length > a.Num.Length || (b.Num.Length == a.Num.Length && Repetitive.Checker(b.Num, a.Num)))
                {
                    if (b.Negativity == true)
                        return new Infinite()
                        {
                            Num = Repetitive.Overwriter(Repetitive.ArrayMinuser(b.Num,a.Num)),
                            Negativity = true
                        };
                    else
                        return new Infinite()
                        {
                            Num = Repetitive.Overwriter(Repetitive.ArrayMinuser(b.Num, a.Num)),
                            Negativity = false
                        };
                }
            }
            //if both are positive
            else
            {
                return new Infinite()
                {
                    Num = Repetitive.Overwriter(Repetitive.ArrayAdder(a.Num, b.Num)),
                    Negativity = false
                };
            }
            return new Infinite();
        }
        // minusing a and b below
        public static Infinite Minus(Infinite a, Infinite b)
        {
            //when both are negative
            if (a.Negativity == true && b.Negativity == true)
            {
                // if number a is bigger than number b
                if (a.Num.Length > b.Num.Length || (a.Num.Length == b.Num.Length && Repetitive.Checker(a.Num, b.Num)))
                {
                    return new Infinite()
                    {
                        Num = Repetitive.Overwriter(Repetitive.ArrayMinuser(a.Num, b.Num)),
                        Negativity = true
                    };
                }
                // if number b is bigger than number a
                else if (b.Num.Length > a.Num.Length || (b.Num.Length == a.Num.Length && Repetitive.Checker(b.Num, a.Num)))
                {
                    return new Infinite()
                    {
                        Num = Repetitive.Overwriter(Repetitive.ArrayMinuser(b.Num, a.Num)),
                        Negativity = false
                    };
                }
            }
            //if one of them is negative
            else if (a.Negativity == true && b.Negativity == false)
            {
                return new Infinite()
                {
                    Num = Repetitive.Overwriter(Repetitive.ArrayAdder(b.Num, a.Num)),
                    Negativity = true
                };
            }
            else if (a.Negativity == false && b.Negativity == true)
            {
                return new Infinite()
                {
                    Num = Repetitive.Overwriter(Repetitive.ArrayAdder(b.Num, a.Num)),
                    Negativity = false
                };
            }
            // if both are positive
            else
            {
                //if number a is bigger than b
                if (a.Num.Length > b.Num.Length || (a.Num.Length == b.Num.Length && Repetitive.Checker(a.Num, b.Num)))
                {
                    return new Infinite()
                    {
                        Num = Repetitive.Overwriter(Repetitive.ArrayMinuser(a.Num, b.Num)),
                        Negativity = false
                    };
                }
                // if number b is bigger than number a
                else
                {
                    return new Infinite()
                    {
                        Num = Repetitive.Overwriter(Repetitive.ArrayMinuser(b.Num, a.Num)),
                        Negativity = true
                    };
                }
            }
            return new Infinite() { Num = new int[] { 0 } };
        }
        // multiplying a and b below
        public static Infinite Times(Infinite a,Infinite b)
        {
            // if both operators are negative
            if (a.Negativity == true && b.Negativity == true)
            {
                return new Infinite()
                {
                    Num = Repetitive.Overwriter(Repetitive.ArrayMultiply(a.Num, b.Num)),
                    Negativity = false
                };
            }
            // if one of operators is negative and another positive
            else if ((a.Negativity == true && b.Negativity == false) || (a.Negativity == false && b.Negativity == true))
            {
                return new Infinite()
                {
                    Num = Repetitive.Overwriter(Repetitive.ArrayMultiply(a.Num,b.Num)),
                    Negativity = true
                };
            }
            // if both operators are positive
            else if (a.Negativity == false && b.Negativity == false)
            {
                return new Infinite()
                {
                    Num = Repetitive.Overwriter(Repetitive.ArrayMultiply(a.Num, b.Num)),
                    Negativity = false
                };
            }
            return new Infinite() ;
        }
    }
}
