using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using APIWorkGroup.Services;
using AutoMapper;

namespace APIWorkGroup.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminApiController : ControllerBase
    {
        private readonly IDataRepository _IDataRepository;
        private readonly IMapper _mapper;

        public AdminApiController(IDataRepository IdataReposity, IMapper mapper)
        {
            _IDataRepository = IdataReposity ??
                throw new ArgumentNullException(nameof(IdataReposity));
            _mapper = mapper;
        }
        [Route("AdminShow")]
        [HttpGet()]
        public IActionResult Admin_TBs_Show()
        {
            try { var adminShow = _IDataRepository.Admin_TBs_Show(); return Ok(adminShow); }
            catch (Exception ex)
            { return Ok(ex.Message.ToString()); }

        }
    }
}