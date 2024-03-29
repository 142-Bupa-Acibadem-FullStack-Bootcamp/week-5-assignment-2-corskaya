﻿using Northwind.Bll.Base;
using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bll
{
    public class CustomerDemographicManager : BllBase<CustomerDemographic, DtoCustomerDemographic>, ICustomerDemographicService
    {
        public readonly ICustomerDemographicRepository demoRepository;
        public CustomerDemographicManager(IServiceProvider service) : base(service)
        {
            demoRepository = service.GetService<ICustomerDemographicRepository>();
        }

        public IQueryable CustomerDemographicReport()
        {
            return demoRepository.CustomerDemographicReport();
        }
    }
}
