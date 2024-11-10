using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace BethanysPieShop.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }
    }
}