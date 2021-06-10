using System;

namespace WindowsFormsApp8
{
    public class AgentQueue
    {
        double Lambda;
        public int NumberOfPerson;
        Random rnd = new Random();

        public AgentQueue(double lambda)
        {
            Lambda = lambda;
            NumberOfPerson = 0;
        }

        public void ProcessEvent(AgentOperator _AgentOperator)
        {
            if (_AgentOperator.BusyOperators < _AgentOperator.NumberOfOperators)
            {
                _AgentOperator.BusyOperators++;
            }
            else
            {
                NumberOfPerson++;
            }
        }

        public double GetNextPerson()
        {
            double q = rnd.NextDouble();
            return (-Math.Log(q) / Lambda);
        }
    }
}
