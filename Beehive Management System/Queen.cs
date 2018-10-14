namespace Beehive_Management_System
{
    public class Queen : Bee
    {
        private Worker[] workers;
        private int _shiftNumber;

        public Queen(Worker[] workers, double weightMg)
            : base(weightMg)
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
            _shiftNumber++;
            var totalHoneyConsumption = this.HoneyConsumptionRate();
            var shiftReport = $@"Report for Shift #{_shiftNumber}";
            for (int i = 0; i < workers.Length; i++)
            {
                totalHoneyConsumption += workers[i].HoneyConsumptionRate();

                if (workers[i].DidYouFinish())
                    shiftReport += $"\r\nWorker #{i + 1} finished the job!";
                else if (!string.IsNullOrEmpty(workers[i].CurrentJob))
                    shiftReport +=
                        $"\r\nWorker #{i + 1} is doing {workers[i].CurrentJob} for {workers[i].ShiftsLeft} more shifts.";
                else
                    shiftReport += $"\r\nWorker #{i + 1} is not working.";
            }

            shiftReport += $"\r\nTotal honey consumed for the shift: {totalHoneyConsumption} units";
            return shiftReport;
        }
    }
}