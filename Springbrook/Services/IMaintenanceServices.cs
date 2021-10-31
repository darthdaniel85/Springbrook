using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Springbrook.ViewModels;

namespace Springbrook.Services
{
    public interface IMaintenanceServices
    {
        MaintenanceFormViewModel InitMaintenanceForm();

        void SaveMaintenanceForm(MaintenanceFormViewModel maintenanceVm);

        void SaveMaintenanceFormSettings(MaintenanceFormViewModel maintenanceVm);
    }
}
