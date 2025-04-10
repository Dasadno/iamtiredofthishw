﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iamtiredofthishw
{
    public class Money
    {
        public double Sum { get; set; }



        public static implicit operator Money(double sum)
        {
            return new Money(sum); // for a while, this is the only solution that i find 
        }


        public static Money operator+ (Money num1, Money num2)
        {
            return new Money(num1.Sum + num2.Sum);
        }
        public static Money operator +(Money num1, double num2)
        {
            Money res = num1 + num2;
            return res;
        }

        public static Money operator- (Money num1, Money num2)
        {
            return new Money(num1.Sum - num2.Sum);
        }

        public static Money operator- (Money num1, double num2)
        {
            Money res = num1 - num2;
            return res;
        }
         


        public static Money operator* (Money num1, int num2)
        {
            return new Money(num1.Sum * num2);
        }

        public static Money operator/ (Money num1, int num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("you can't divide any number by 0");
            }
            return new Money(num1.Sum / num2);
        }



        public static Money operator++ (Money num)
        {
            return new Money(num.Sum + 0.1);
        }

        public static Money operator-- (Money num)
        {
            
            return new Money(num.Sum - 0.1);
        }


        public static bool operator> (Money num1, Money num2)
        {
            return num1.Sum > num2.Sum;
        }

        public static bool operator <(Money num1, Money num2)
        {
            return num1.Sum < num2.Sum;
        }

        public static bool operator ==(Money num1, Money num2)
        {
            return num1.Sum == num2.Sum;
        }

        public static bool operator !=(Money num1, Money num2)
        {
            return num1.Sum != num2.Sum;
        }

        public Money(double sum)
        {
            Sum = sum;
        }

        public bool IsNegative()
        {
            return Sum < 0;
        }


    }
}
