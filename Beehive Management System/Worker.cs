namespace Beehive_Management_System
{
    public class Worker
    {
        public string CurrentJob { get; }
        public int ShiftsLeft { get; set; }

        private string[] _jobsICanDo;
        private int _shiftsToWork;
        private int _shiftsWorked;

        public bool DoThisJob()
        {
            return false;
        }

        public bool DidYouFinish()
        {
            return false;
        }
    }
}