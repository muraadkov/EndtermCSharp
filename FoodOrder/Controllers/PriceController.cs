using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using AutoMapper;
using FoodOrder.Core.DTOs;
using FoodOrder.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoodOrder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PriceController : ControllerBase

    {
        private readonly FoodContext _dataContext;
        private readonly IMapper _mapper;
        public PriceController(IMapper mapper, FoodContext context)
        {
            _mapper = mapper;
            _dataContext = context;
        }

        [HttpGet("{productId}")]
        public async Task<IActionResult> GetProductById(Guid productId)
        {
            var priceListItems = await _dataContext.PricelistItems.Where(x=>x.ProductId == productId).ToListAsync();
            var productToSend = _mapper.Map<IEnumerable<PriceListItemDTO>>(priceListItems);
            return productToSend != null ? (IActionResult)Ok(productToSend) : NoContent();
        }

        [HttpPost("createpricelist")]
        public async Task<IActionResult> CreatePriceList(Pricelist priceList)
        {
            if (priceList == null)
            {
                return BadRequest();
            }
                await _dataContext.PriceList.AddAsync(priceList);
                await _dataContext.SaveChangesAsync();
            
            return Accepted();
        }
    }
}
