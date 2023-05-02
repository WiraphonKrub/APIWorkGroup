using System;
using APIWorkGroup.Models;
using APIWorkGroup.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace APIWorkGroup.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly IDataRepository _IDataRepository;
        private readonly IMapper _mapper;

        public AdminController(IDataRepository IdataRepository, IMapper mapper)
        {
            _IDataRepository = IdataRepository ??
                throw new ArgumentNullException(nameof(IdataRepository));
            _mapper = mapper;
        }
        [Route("Show")]
        [HttpGet()]
        public IActionResult Show()
        {
            try { var employee = _IDataRepository.Admin_TBs_Show(); return Ok(employee); }
            catch (Exception ex)
            { return Ok(ex.Message.ToString()); }
        }
    }

}
