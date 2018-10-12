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

        public bool AssignWork(string job, int shifts)
        {
            foreach (var worker in workers)
            {
                if (worker.DoThisJob(job, shifts))
                    return true;
            }

            return false;
        }

        public string WorkTheNextShift()
        {
            shiftNumber++;
            var shiftReport = $@"Report for Shift #{shiftNumber}";
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].DidYouFinish())
                    shiftReport += $"\r\nWorker #{i + 1} finished the job!";
                else if (!string.IsNullOrEmpty(workers[i].CurrentJob))
                    shiftReport +=
                        $"\r\nWorker #{i + 1} is doing {workers[i].CurrentJob} for {workers[i].ShiftsLeft} more shifts.";
                else
                    shiftReport += $"\r\nWorker #{i + 1} is not working.";
            }
            return shiftReport;
        }
    }
}