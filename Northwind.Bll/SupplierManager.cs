﻿using Northwind.Bll.Base;
using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace Northwind.Bll
{
    public class SupplierManager : BllBase<Supplier, DtoSupplier>, ISupplierService
    {
        public readonly ISupplierRepository supplierRepository;
        public SupplierManager(IServiceProvider service) : base(service)
        {
            supplierRepository= service.GetService<ISupplierRepository>();
        }
    }
}
