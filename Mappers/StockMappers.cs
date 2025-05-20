using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dto.Stock;
using api.Models;

namespace api.Mappers
{
    public static class StockMappers
    {
        public static StockDto ToStockDto(this Stock StockModel)
        {
            return new StockDto
            {
                Id = StockModel.Id,
                Symbol = StockModel.Symbol,
                CompanyName = StockModel.CompanyName,
                Purchase = StockModel.Purchase,
                LastDiv = StockModel.LastDiv,
                Industry = StockModel.Industry,
                Marketcap = StockModel.Marketcap
            };
        }

        public static Stock ToStockFromCreateDto(this CreateStockRequestDto StockDto)
        {
            return new Stock
            {
                Symbol = StockDto.Symbol,
                CompanyName = StockDto.CompanyName,
                Purchase = StockDto.Purchase,
                LastDiv = StockDto.LastDiv,
                Industry = StockDto.Industry,
                Marketcap = StockDto.Marketcap
            };
        }
    }
}