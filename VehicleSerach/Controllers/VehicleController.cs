using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Remotion.Linq.Clauses;
using VehicleSerach.DBContexts;
using VehicleSerach.Filter;
using VehicleSerach.Helpers;
using VehicleSerach.Models;
using VehicleSerach.Services;
using VehicleSerach.Wrappers;

namespace VehicleSerach.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IUriService uriService;
        public VehicleController(ApplicationDbContext context, IUriService uriService)
        {
            this.context = context;
            this.uriService = uriService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] PaginationFilter filter, [FromQuery] string keyword)
        {
            if(keyword is null) { keyword = ""; }
            var route = Request.Path.Value;
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            var pagedData = await context.vehicles.Where(a =>a.Vehicle_Number.Contains(keyword) || a.Vehicle_Type.Contains(keyword))
               .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
               .Take(validFilter.PageSize)
               .ToListAsync();
            var totalRecords = await context.vehicles.CountAsync();
            var pagedReponse = PaginationHelper.CreatePagedReponse<Vehicle>(pagedData, validFilter, totalRecords, uriService, route);
            return Ok(pagedReponse);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var vehicle = await context.vehicles.Where(a => a.id == id).FirstOrDefaultAsync();
            return Ok(new Response<Vehicle>(vehicle));
        }
    }
}
