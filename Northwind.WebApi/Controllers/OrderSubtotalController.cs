﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using Northwind.WebApi.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderSubtotalController : ApiBaseController<IOrderSubtotalService, OrderSubtotal, DtoOrderSubtotal>
    {
        private readonly IOrderSubtotalService subtotalService;
        public OrderSubtotalController(IOrderSubtotalService subtotalService) : base(subtotalService)
        {
            this.subtotalService = subtotalService;
        }
    }
}
