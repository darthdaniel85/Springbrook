using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Springbrook.ViewModels
{
    public class MaintenanceFormViewModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [ValidateComplexType]
        public List<FormControlViewModel> FormControls { get; set; } = new();
    }
}
