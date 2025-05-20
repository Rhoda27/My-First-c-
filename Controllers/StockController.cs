using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dto.Stock;
using api.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/stock")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public StockController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetALL()
        {
            var stocks = _context.Stock.ToList()
             .Select(s => s.ToStockDto());

            return Ok(stocks);
        }
        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var stock = _context.Stock.Find(id);

            if (stock == null)
            {
                return NotFound();
            }
            return Ok(stock.ToStockDto());
        }
        [HttpPost]
        public IActionResult Create([FromBody] CreateStockRequestDto StockDto)
        {
            var StockModel = StockDto.ToStockFromCreateDto();
            _context.Stock.Add(StockModel);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { id = StockModel.Id }, StockModel.ToStockDto());
        }
        [HttpPut]
        [Route("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] UpdateStockRequestDto UpdateDto)
        {
            var StockModel = _context.Stock.FirstOrDefault(x => x.Id == id);
            if (StockModel == null)
            {
                return NotFound();
            }

            StockModel.Symbol = UpdateDto.Symbol;
            StockModel.CompanyName = UpdateDto.CompanyName;
            StockModel.Purchase = UpdateDto.Purchase;
            StockModel.LastDiv = UpdateDto.LastDiv;
            StockModel.Industry = UpdateDto.Industry;
            StockModel.Marketcap = UpdateDto.Marketcap;

            _context.SaveChanges();
            return Ok(StockModel.ToStockDto());
        }
        [HttpDelete]
        [Route("{Id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var StockModel = _context.Stock.FirstOrDefault(x => x.Id == id);

            if (StockModel == null)
            {
                return NotFound();
            }

            _context.Stock.Remove(StockModel);
            _context.SaveChanges();
            return NoContent();
        }
    }
}    