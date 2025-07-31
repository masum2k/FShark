using System.ComponentModel.DataAnnotations;

namespace api.Dtos.Stock
{
    public class CreateStockRequestDto
    {
        [Required]
        [MaxLength(10, ErrorMessage = "Symbol cannot exceed 10 characters.")]
        public string Symbol { get; set; } = String.Empty;
        [Required]
        [MaxLength(10, ErrorMessage = "Company name cannot exceed 10 characters.")]
        public string CompanyName { get; set; } = String.Empty;
        [Required]
        [Range(1,1000000000, ErrorMessage = "Price must be between 1 and 1,000,000,000.")]
        public decimal Purchase { get; set; }
        [Required]
        [Range(0.001,100,ErrorMessage ="something")]
        public decimal LastDiv { get; set; }
        [Required]
        [MaxLength(10, ErrorMessage = "Industry cannot exceed 10 characters.")]
        public string Industry { get; set; } = String.Empty;
        [Required]
        [Range(1,5000000000, ErrorMessage = "Market cap must be between 1 and 1,000,000,000.")]
        public long MarketCap { get; set; }
    }
}
