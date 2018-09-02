using BLL.Services;
using DAL.Entities;
using DAL.Entities.QueryParameters;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class ClientTypesController : Controller
    {
        private IClientTypeService _clientTypeService;

        public ClientTypesController(IClientTypeService clientTypeService)
        {
            _clientTypeService = clientTypeService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<ClientTypes>), 200)]
        public IActionResult GetClientTypes(Pagination pagination)
        {

            var result = _clientTypeService.GetAllClientTypes(pagination);
            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(new { result.totalCount }));

            return Ok(result.clientTypes);
        }
    }
}
