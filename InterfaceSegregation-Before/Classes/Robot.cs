using InterfaceSegregation_Before.Contracts;

namespace InterfaceSegregation_Before.Classes
{
    public class Robot : IWorker
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Sleep()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            //work
        }
    }
}
