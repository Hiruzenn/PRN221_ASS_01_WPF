﻿using Candidate_BussinessObjects;
using Candidate_Repository;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Service
{

    public class HRAccountService : IHRAccountService
    {
        private IHRAccountRepo iAccountRepo;

        public HRAccountService() { 
            iAccountRepo = new HRAccountRepo();
        }
        public Hraccount GetHraccountByEmail(string email)
        {
           return iAccountRepo.GetHraccountByEmail(email);
        }

        public List<Hraccount> GetHraccounts()
        {
           return iAccountRepo.GetHraccounts();
        }
    }
}
