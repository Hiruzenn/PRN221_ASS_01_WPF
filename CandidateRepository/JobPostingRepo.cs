using Candidate_BussinessObjects;
using Candidate_DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repository
{
    public class JobPostingRepo : IJobpostingRepo
    {
        private JobPostDAO jobPostDAO;

        public bool AddJobPosting(JobPosting jobPosting) => JobPostDAO.Instance.AddJobPosting(jobPosting);

        public JobPosting GetJobPosting(string JobId) => JobPostDAO.Instance.GetJobPosting(JobId);
        

        public List<JobPosting> GetJobPostings() => JobPostDAO.Instance.GetJobPostings();
       
        public bool RemoveJobPosting(JobPosting jobPosting) => JobPostDAO.Instance.RemoveJobPosting(jobPosting);
        

        public bool UpdateJobPosting(JobPosting jobPosting) => JobPostDAO.Instance.UpdateJobPosting(jobPosting);
        
    }
}
