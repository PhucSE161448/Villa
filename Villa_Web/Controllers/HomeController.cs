using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using Villa_Web.Models;
using Villa_Web.Models.DTO;
using Villa_Web.Services.IServices;

namespace Villa_Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IVillaService _villaService;
        private readonly IMapper _mapper;
        public HomeController(IVillaService villaService, IMapper mapper)
        {
            _villaService = villaService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            List<VillaDTO> list = new List<VillaDTO>();
            var response = await _villaService.GetAllAsync<APIResponse>();
            if (response != null && response.IsSuccess)
            {
                list = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(response.Result));
            }
            return View(list);
        }
    }
}