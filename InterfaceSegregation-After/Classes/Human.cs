using InterfaceSegregation_After.Contracts;

namespace InterfaceSegregation_After.Classes
{
    public class Human : IEater, ISleeper, IWorker
    {
        public void Eat()
        {
            //eat
        }

        public void Sleep()
        {
            //sleep
        }

        public void Work()
        {
            //work
        }
    }
}
