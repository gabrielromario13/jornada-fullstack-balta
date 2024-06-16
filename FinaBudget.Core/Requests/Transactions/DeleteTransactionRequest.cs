using System.ComponentModel.DataAnnotations;

namespace FinaBudget.Core.Requests.Transactions;

public class DeleteTransactionRequest : Request
{
    [Required(ErrorMessage = "Id inválido")]
    public long Id { get; set; }
}