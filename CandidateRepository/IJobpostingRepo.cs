﻿using Candidate_BussinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repository
{
    public interface IJobpostingRepo
    {

        public JobPosting GetJobPosting(string JobId);

        public List<JobPosting> GetJobPostings();

        public bool AddJobPosting(JobPosting jobPosting);
        public bool RemoveJobPosting(JobPosting jobPosting);
        public bool UpdateJobPosting(JobPosting jobPosting);

    }
}
