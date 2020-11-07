using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section2
{
    public class Calculator
    {
        //Question 3
        public int calculateSumOfMultiples()
        {
            List<int> multiples = new List<int>();
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    multiples.Add(i);
                }
            }

            return multiples.Sum();
        }

        //Question 4
        public int get1001Prime()
        {
            int num = 1; 
            int i = 3;

            while (num <= 10001)
            {
                if (isPrime(i))
                {
                    num++;
                    if (num == 10001)
                    {
                        //cout << i;
                        return 0;
                    }
                }
                i += 2; 
            }
            return 0;
        }

        public bool isPrime(int n)
        {
            var primes = new int[1000];
            int j = 0;
            primes[0] = 2; 

            while (n > primes[j] && n % primes[j] != 0) {

                j++;
                if (primes[j] == 0)
                {
                    primes[j] = n;
                    return true;
                }
            }
            return false;
        }


        //Question 5
        public int sumOfEvenFibonacciTerms(int number)
        {
            int[] a = new int[number];
            List<int> evenFibonacciTerms = new List<int>();
            a[0] = 1;
            a[1] = 2;
            if (a[0] % 2 == 0)
            {
                evenFibonacciTerms.Add(a[0]);
            }

            if (a[1] % 2 == 0)
            {
                evenFibonacciTerms.Add(a[1]);
            }

            for (int i = 2; i < number; i++)
            {
                a[i] = a[i - 2] + a[i - 1];

                if (a[i] < 4000000 && a[i] % 2 == 0)
                {
                    evenFibonacciTerms.Add(a[i]);
                }
            }
            return evenFibonacciTerms.Sum();
        }
    }
}
