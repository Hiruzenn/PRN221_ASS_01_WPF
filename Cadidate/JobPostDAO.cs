using Candidate_BussinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_DAO
{
    public class JobPostDAO
    {
        private CandidateManagementContext dbContext;
        private static  JobPostDAO instance = null;

        public static  JobPostDAO Instance
        {
            get
            {
               if (instance == null)
                {
                    instance = new JobPostDAO();
                }
                return instance;
            }
        }
        public JobPostDAO()
        {
            dbContext = new CandidateManagementContext();
        }

        public JobPosting GetJobPosting(string JobId)
        {
            return dbContext.JobPostings.SingleOrDefault(m => m.PostingId.Equals(JobId));

        }

        public List<JobPosting> GetJobPostings()
        {
            return dbContext.JobPostings.ToList();
        }
        public bool AddJobPosting(JobPosting jobPosting) {
            bool isSuccess = false;
            JobPosting jobPost= GetJobPosting(jobPosting.PostingId);
            try
            {
                if (jobPosting == null)
                {
                    dbContext.JobPostings.Add(jobPosting);
                    dbContext.SaveChanges();
                    isSuccess = true;
                }
            }
            catch (Exception ex) 
            { 
                //Log
            }
            return isSuccess;
        }

        public bool RemoveJobPosting(JobPosting jobPosting)
        {
            bool isSuccess = false;
            JobPosting jobPost = GetJobPosting(jobPosting.PostingId);
            try
            {
                if (jobPosting != null)
                {
                    dbContext.JobPostings.Remove(jobPosting);
                    dbContext.SaveChanges();
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                //Log
            }
            return isSuccess;
        }

        public bool UpdateJobPosting(JobPosting jobPosting)
        {
            bool isSuccess = false;
            JobPosting jobPost = GetJobPosting(jobPosting.PostingId);
            try
            {
                if (jobPosting != null)
                {
                    dbContext.Entry<JobPosting>(jobPosting).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    dbContext.SaveChanges();
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                //Log
            }
            return isSuccess;
        }


    }
}
