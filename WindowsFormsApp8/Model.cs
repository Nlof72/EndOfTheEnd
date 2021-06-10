using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    class Model
    {
        double NextPerson, NextOperator;
        double Time = 0;
        double T;
        int k;
        int N;
        double Lambda;
        double Mu;
        double Rho;
        int NumberOfOperators;
        double ISD;
        public readonly Dictionary<int, double> Freq = new Dictionary<int, double>();
        public Dictionary<int, double> Stat;

        private void InitialStationaryDistribution()
        {
            double temp = 0;
            for (int i = 0; i < NumberOfOperators; i++)
            {
                temp += Math.Pow(Rho, i) / Factorial(i);
            }
            double temp1 = Math.Pow(Rho, (NumberOfOperators + 1)) / Factorial(NumberOfOperators) * (NumberOfOperators - Rho);
            ISD = Math.Pow((temp + temp1), -1); ;
        }

        private int Factorial(int i)
        {
            return (int)MathNet.Numerics.SpecialFunctions.Factorial(i);
        }

        void Statistics()
        {
            Stat = Freq;
            foreach (int i in Stat.Keys.ToList())
            {
                if (i < NumberOfOperators)
                {
                    Stat[i] = (Math.Pow(Rho, i) / Factorial(i)) * ISD;
                }
                else
                {
                    Stat[i] = (Math.Pow(Rho, i) / (Factorial(i) * Math.Pow(NumberOfOperators, i - NumberOfOperators))) * ISD;
                }
            }
        }

        public Model(double l, double m, int n, double t, int noo)
        {
            Lambda = l;
            Mu = m;
            Rho = l / m;
            N = n;
            T = t;
            k = 0;
            NumberOfOperators = noo;
            InitialStationaryDistribution();
        }



        public void Simulate( )
        {
            AgentOperator ao = new AgentOperator(Mu, NumberOfOperators);
            AgentQueue aqp = new AgentQueue(Lambda);
            while (k < N)
            {
                while (Time < T)
                {
                    NextOperator = ao.GetNextOperator();
                    NextPerson = aqp.GetNextPerson();
                    if (NextPerson < NextOperator)
                    {
                        aqp.ProcessEvent(ao);
                        Time += NextPerson;
                    }
                    else
                    {
                        ao.ProcessEvent(aqp);
                        Time += NextOperator;
                    }
                }
                k++;
                Time = 0;

                if(!Freq.ContainsKey(ao.BusyOperators + aqp.NumberOfPerson))
                {
                    Freq.Add(ao.BusyOperators + aqp.NumberOfPerson, 0);
                }

                Freq[ao.BusyOperators + aqp.NumberOfPerson]++;

            }
            foreach (int i in Freq.Keys.ToList())
            {
                Freq[i] /= N;
            }
            Statistics();
        }



    }
}
