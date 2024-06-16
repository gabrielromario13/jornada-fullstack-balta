using System.ComponentModel.DataAnnotations;

namespace FinaBudget.Core.Requests.Categories;

public class GetCategoryByIdRequest : Request
{
    [Required(ErrorMessage = "Id inválido")]
    public long Id { get; set; }
}