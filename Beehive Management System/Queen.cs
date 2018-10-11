namespace Beehive_Management_System
{
    public class Queen
    {
        private Worker[] workers;
        private int shiftNumber;

        public Queen(Worker[] workers)
        {
            this.workers = workers;
        }

        public bool AssignWork(string job, int shift)
        {
            return false;
        }

        public string WorkTheNextShift()
        {
            return "Shift Report";
        }
    }
}