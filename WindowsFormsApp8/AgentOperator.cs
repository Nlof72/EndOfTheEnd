using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    public class AgentOperator
    {
        double Mu;
        public int BusyOperators;
        public readonly int NumberOfOperators;
        Random rnd = new Random();

        public AgentOperator(double mu, int _NumberOdOperators)
        {
            Mu = mu;
            NumberOfOperators = _NumberOdOperators;
        }

        public double GetNextOperator()
        {
            if (BusyOperators > 0)
            {
                double q = rnd.NextDouble();
                return (-Math.Log(q * BusyOperators) / Mu);
            }
            else { return double.PositiveInfinity; }
        }

        public void ProcessEvent(AgentQueue _AgentQueue)
        {
            if (_AgentQueue.NumberOfPerson == 0)
            {
                BusyOperators--;
            }
            else
            {
                _AgentQueue.NumberOfPerson--;
            }
        }
    }
}
