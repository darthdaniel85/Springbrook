using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Springbrook.ViewModels;

namespace Springbrook.Services
{
    public class MaintenanceServices : IMaintenanceServices
    {
        public MaintenanceFormViewModel InitMaintenanceForm()
        {
            var maintenanceForm = new MaintenanceFormViewModel();

            var an = new FormControlViewModel()
            {
                Label = "Account Number",
                Value = "000000",
                Type = FormControlType.Number,
                IsRequired = true
            };
            maintenanceForm.FormControls.Add(an);

            var ad = new FormControlViewModel()
            {
                Label = "Account Description",
                Value = string.Empty
            };
            maintenanceForm.FormControls.Add(ad);

            var cn = new FormControlViewModel()
            {
                Label = "Customer Number",
                Value = "000000",
                Type = FormControlType.Number
            };
            maintenanceForm.FormControls.Add(cn);

            var cna = new FormControlViewModel()
            {
                Label = "Customer Name",
                Value = string.Empty
            };
            maintenanceForm.FormControls.Add(cna);

            var td = new FormControlViewModel()
            {
                Label = "Transaction Date",
                Value = DateTime.Now.ToString(CultureInfo.InvariantCulture),
                Type = FormControlType.DateTime,
                IsRequired = true
            };
            maintenanceForm.FormControls.Add(td);

            var dd = new FormControlViewModel()
            {
                Label = "Due Date",
                Type = FormControlType.DateTime,
                IsRequired = true
            };
            maintenanceForm.FormControls.Add(dd);


            return maintenanceForm;
        }

        public void SaveMaintenanceForm(MaintenanceFormViewModel maintenanceVm)
        {
            // Persist in DB (out of scope)...
        }

        public void SaveMaintenanceFormSettings(MaintenanceFormViewModel maintenanceVm)
        {
            maintenanceVm.FormControls.RemoveAll(c => !c.Order.HasValue);
            maintenanceVm.FormControls.Sort();
        }
    }
}
