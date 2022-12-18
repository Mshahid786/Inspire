using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Inspire.Erp.Application.Master;
using Inspire.Erp.Domain.Entities;
using Inspire.Erp.Web.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Inspire.Erp.Web.Controllers
{
    [Route("api/master")]
    [Produces("application/json")]
    [ApiController]
    public class UnitController : ControllerBase
    {
        private readonly IMapper _mapper;
        private IUnitMasterService unitMasterService;
        public UnitController(IUnitMasterService _unitMasterService, IMapper mapper)
        {
            unitMasterService = _unitMasterService;
            _mapper = mapper;
        }
        [HttpGet]
        [Route("GetAllUnit")]
        public List<UnitMasterViewModel> GetAllUnit()
        {
            return unitMasterService.GetAllUnit().Select(k => new UnitMasterViewModel
            {
                 UnitMasterUnitId = k.UnitMasterUnitId,
                 UnitMasterUnitShortName = k.UnitMasterUnitShortName,
                 UnitMasterUnitFullName = k.UnitMasterUnitFullName,
                 UnitMasterUnitDescription = k.UnitMasterUnitDescription,
                 UnitMasterUnitStatus = k.UnitMasterUnitStatus,
                UnitMasterUnitDelStatus=k.UnitMasterUnitDelStatus
            }).ToList();
        }

        [HttpGet("{id}", Name = "GetAllUnitById")]
        [Route("GetAllUnitById/{id}")]
        public List<UnitMasterViewModel> GetAllUnitById(int id)
        {
            return unitMasterService.GetAllUnitById(id).Select(k => new UnitMasterViewModel
            {
                UnitMasterUnitId = k.UnitMasterUnitId,
                UnitMasterUnitShortName = k.UnitMasterUnitShortName,
                UnitMasterUnitFullName = k.UnitMasterUnitFullName,
                UnitMasterUnitDescription = k.UnitMasterUnitDescription,
                UnitMasterUnitStatus = k.UnitMasterUnitStatus,
                UnitMasterUnitDelStatus = k.UnitMasterUnitDelStatus
            }).ToList();
        }


        [HttpPost]
        [Route("InsertUnit")]
        public List<UnitMasterViewModel> InsertUnit([FromBody] UnitMasterViewModel unitMaster)
        {
            var result = _mapper.Map<UnitMaster>(unitMaster);
            return unitMasterService.InsertUnit(result).Select(k => new UnitMasterViewModel
            {
                UnitMasterUnitId = k.UnitMasterUnitId,
                UnitMasterUnitShortName = k.UnitMasterUnitShortName,
                UnitMasterUnitFullName = k.UnitMasterUnitFullName,
                UnitMasterUnitDescription = k.UnitMasterUnitDescription,
                UnitMasterUnitStatus = k.UnitMasterUnitStatus,
                UnitMasterUnitDelStatus = k.UnitMasterUnitDelStatus
            }).ToList();
        }

        [HttpPost]
        [Route("UpdateUnit")]
        public List<UnitMasterViewModel> UpdateUnit([FromBody] UnitMasterViewModel unitMaster)
        {
            var result = _mapper.Map<UnitMaster>(unitMaster);
            return unitMasterService.UpdateUnit(result).Select(k => new UnitMasterViewModel
            {
                UnitMasterUnitId = k.UnitMasterUnitId,
                UnitMasterUnitShortName = k.UnitMasterUnitShortName,
                UnitMasterUnitFullName = k.UnitMasterUnitFullName,
                UnitMasterUnitDescription = k.UnitMasterUnitDescription,
                UnitMasterUnitStatus = k.UnitMasterUnitStatus,
                UnitMasterUnitDelStatus = k.UnitMasterUnitDelStatus
            }).ToList();
        }

        [HttpPost]
        [Route("DeleteUnit")]
        public List<UnitMasterViewModel> DeleteUnit([FromBody] UnitMasterViewModel unitMaster)
        {
            var result = _mapper.Map<UnitMaster>(unitMaster);
            return unitMasterService.DeleteUnit(result).Select(k => new UnitMasterViewModel
            {
                UnitMasterUnitId = k.UnitMasterUnitId,
                UnitMasterUnitShortName = k.UnitMasterUnitShortName,
                UnitMasterUnitFullName = k.UnitMasterUnitFullName,
                UnitMasterUnitDescription = k.UnitMasterUnitDescription,
                UnitMasterUnitStatus = k.UnitMasterUnitStatus,
                UnitMasterUnitDelStatus = k.UnitMasterUnitDelStatus
            }).ToList();
        }
    }
}
