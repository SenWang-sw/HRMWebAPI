﻿using Emp.AppCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp.AppCore.Contract.Service
{
    public interface IEmpService
    {
        Task<IEnumerable<Emplo>> GetAll();
        //Task<IEnumerable<JobRequirementResponseModel>> GetAll();
        Task<int> AddAsync(Emplo entity);
        Task<int> DeleteAsync(int id);
        Task<int> UpdateAsync(Emplo entity);
        Task<Emplo> GetByIdAsync(int id);
    }
}
