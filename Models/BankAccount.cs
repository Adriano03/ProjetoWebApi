using System.ComponentModel.DataAnnotations;

namespace ProjetoWebApi.Models
{

// Owner - Proprietátio   Number- numero conta   Balance - Saldo   -Benificiary - beneficiario
    public class BankAccount
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório!")]
        [MaxLength(40, ErrorMessage = "Máximo 40 caracteres!")]
        [MinLength(4, ErrorMessage = "Mínimo 4 caracteres!")]
        public string Owner { get; set; }

        [Required(ErrorMessage = "Este Campo é obrigatório!")]
        public string OwnerBank { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório!")]
        [MaxLength(20, ErrorMessage = "Máximo 20 caracteres!")]
        [MinLength(2, ErrorMessage = "Mínimo 2 caracteres!")]
        public int OwnerNumber { get; set; }

        public decimal OwnerBalance { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório!")]
        [MaxLength(40, ErrorMessage = "Máximo 40 caracteres!")]
        [MinLength(4, ErrorMessage = "Mínimo 4 caracteres!")]
        public string Beneficiary { get; set; }

        [Required(ErrorMessage = "Este Campo é obrigatório!")]
        public string BeneficiaryBank { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório!")]
        [MaxLength(20, ErrorMessage = "Máximo 20 caracteres!")]
        [MinLength(2, ErrorMessage = "Mínimo 2 caracteres!")]
        public int BeneficiaryNumber { get; set; }

        public decimal BeneficiaryBalance { get; set; }



    }
}