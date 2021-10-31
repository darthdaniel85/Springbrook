using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Springbrook.ViewModels
{
    public enum FormControlType
    {
        Text,
        Number,
        DateTime,
        Currency
    }

    public class FormControlViewModel : IComparable<FormControlViewModel>
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        
        public string Label { get; set; }

        public FormControlType Type { get; set; } = FormControlType.Text;

        public string Value { get; set; }
        
        public int? Order { get; set; }

        public bool IsRequired { get; set; } = false;

        [Required]
        [Range(typeof(bool), "true", "true", ErrorMessage = "Invalid")]
        public bool IsValid => Order.HasValue || !IsRequired;

        public int CompareTo(FormControlViewModel other)
        {
            return Order?.CompareTo(other?.Order) ?? 0;
        }
    }
}
