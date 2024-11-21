using System.ComponentModel.DataAnnotations;

namespace Bookstore.Models
{
    public class Seller
    {
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "Insira um email válido")]
        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        public string Email { get; set; }

        [Display(Name = "Salário")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:c2}")]
        public double Salary { get; set; }
        [Display(Name = "Vendas")]
        public ICollection<Sale> Sales { get; set; } = new List<Sale>();

        public Seller()
        {
            
        }
        public Seller(int id,string name, string email, double salary)
        {
            Id = id;
            Name = name;
            Email = email;
            Salary = salary;
        }
        public double CalculateTotalSalesAmount() 
        {
            return Sales.Sum(sale => sale.Amount);
        }
    }
}
