﻿using MagicVilla_VillaAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controllers
{
    [Route("api/VillaAPI")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Villa> GetVillas()
        {
            return new List<Villa>()
            {
                new Villa{Id = 1, Name = "Pool VIew"},
                new Villa{Id = 2, Name = "Beach View"}
            };
        }
    }
}
