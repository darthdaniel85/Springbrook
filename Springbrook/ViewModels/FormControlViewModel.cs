using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Springbrook.ViewModels
{
    public class FormControlViewModel : IComparable<FormControlViewModel>
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Label { get; set; }

        public int? Order { get; set; } = 0;

        public bool IsRequired { get; set; } = false;

        [Required]
        [Range(typeof(bool), "true", "true", ErrorMessage = "Invalid")]
        public bool IsValid => Order.HasValue || !IsRequired;

        public int CompareTo(FormControlViewModel other)
        {
            return Order?.CompareTo(other?.Order) ?? 0;
        }
    }

    public class FormControlTextViewModel : FormControlViewModel
    {
        public string Value { get; set; } = string.Empty;
    }

    public class FormControlNumberViewModel : FormControlViewModel
    {
        public int Value { get; set; }

        public string PlaceHolder { get; set; } = "0000000";
    }

    public class FormControlDateTimeViewModel : FormControlViewModel
    {
        public DateTime Value { get; set; } = DateTime.Now;

        public string Mask { get; set; } = " / / ";
    }
}
