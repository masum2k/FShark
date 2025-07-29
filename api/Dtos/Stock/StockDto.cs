using api.Dtos.Comment;
using api.Models;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Dtos.Stock
{
    public class StockDto
    {
        public int Id { get; set; }
        public string Symbol { get; set; } = String.Empty;
        public string CompanyName { get; set; } = String.Empty;
        public decimal Purchase { get; set; }
        public decimal LastDiv { get; set; }
        public string Industry { get; set; }
        public long MarketCap { get; set; }
        public List<CommentDto> Comments { get; set; }

    }
}
