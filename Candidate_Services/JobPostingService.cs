using Candidate_BussinessObjects;
using Candidate_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Services
{
    public class JobPostingService : IJobPostingService
    {
        private IJobpostingRepo postingRepo;
        public JobPostingService()
        {
            postingRepo = new JobPostingRepo();
        }
        public bool AddJobPosting(JobPosting jobPosting)
        {
            return postingRepo.AddJobPosting(jobPosting);
        }

        public JobPosting GetJobPosting(string JobId)
        {
            return postingRepo.GetJobPosting(JobId);
        }

        public List<JobPosting> GetJobPostings()
        {
            return postingRepo.GetJobPostings();
        }

        public bool RemoveJobPosting(JobPosting jobPosting)
        {
            return postingRepo.RemoveJobPosting(jobPosting);
        }

        public bool UpdateJobPosting(JobPosting jobPosting)
        {
           return postingRepo.UpdateJobPosting(jobPosting);
        }
    }
}
