using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using Warehouse.Application.Contract;

namespace Warehouse.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WarehouseController : ControllerBase
    {
        private readonly IWarehouseService _WarehouseService;

        public WarehouseController(IWarehouseService warehouseService)
        {
            _WarehouseService = warehouseService;
        }

        [HttpPost]
        public bool Define(DefineWarehouse command)
        {
            return _WarehouseService.Define(command);
        }
    }
}
