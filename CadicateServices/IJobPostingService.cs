using Candidate_BussinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Service
{
    public interface IJobPostingService
    {
        public JobPosting GetJobPosting(string JobId);

        public List<JobPosting> GetJobPostings();

        public bool AddJobPosting(JobPosting jobPosting);
        public bool RemoveJobPosting(JobPosting jobPosting);
        public bool UpdateJobPosting(JobPosting jobPosting);
    }
}
