using System.ComponentModel.DataAnnotations;

namespace FinaBudget.Core.Requests.Transactions;

public class GetTransactionByIdRequest : Request
{
    [Required(ErrorMessage = "Id inválido")]
    public long Id { get; set; }
}