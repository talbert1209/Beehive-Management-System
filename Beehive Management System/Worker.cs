namespace Beehive_Management_System
{
    public class Worker
    {
        public string CurrentJob
        {
            get { return _currentJob; }
        }

        public int ShiftsLeft
        {
            get { return _shiftsToWork - _shiftsWorked; }
        }

        private readonly string[] _jobsICanDo;
        private int _shiftsToWork;
        private int _shiftsWorked;
        private string _currentJob = "";

        public Worker(string[] jobs)
        {
            _jobsICanDo = jobs;
        }

        /// <summary>
        /// This method checks to see if the bee is currently working.
        /// If he is, it returns false. If not, it checks to see if the bee can do that job.
        /// If he can, it assigns the job and returns true. If he can't, it returns false.
        /// </summary>
        /// <param name="jobToDo"></param>
        /// <param name="shifts"></param>
        /// <returns></returns>
        public bool DoThisJob(string jobToDo, int shifts)
        {
            if (string.IsNullOrEmpty(_currentJob))
            {
                foreach (var job in _jobsICanDo)
                {
                    if (job == jobToDo)
                    {
                        _currentJob = jobToDo;
                        _shiftsToWork = shifts;
                        _shiftsWorked = 0;
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// This method checks to see if the bee currently has a job.
        /// If so, it tells the bee to work by incrementing the _shiftsWorked field
        /// Finally, it checks to see if that was the bees last shift.
        /// If so, it resets all the fields.
        /// </summary>
        /// <returns></returns>
        public bool DidYouFinish()
        {
            if (!string.IsNullOrEmpty(_currentJob))
            {
                _shiftsWorked ++;
                if (_shiftsWorked >= _shiftsToWork)
                {
                    _currentJob = "";
                    _shiftsWorked = 0;
                    _shiftsToWork = 0;
                    return true;
                }
            }

            return false;
        }
    }
}