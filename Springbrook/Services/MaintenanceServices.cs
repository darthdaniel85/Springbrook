using Springbrook.ViewModels;

namespace Springbrook.Services
{
    public class MaintenanceServices : IMaintenanceServices
    {
        public MaintenanceFormViewModel InitMaintenanceForm()
        {
            var maintenanceForm = new MaintenanceFormViewModel();

            var an = new FormControlNumberViewModel()
            {
                Label = "Account Number",
                IsRequired = true
            };
            maintenanceForm.FormControls.Add(an);

            var ad = new FormControlTextViewModel()
            {
                Label = "Account Description"
            };
            maintenanceForm.FormControls.Add(ad);

            var cn = new FormControlNumberViewModel()
            {
                Label = "Customer Number"
            };
            maintenanceForm.FormControls.Add(cn);

            var cna = new FormControlTextViewModel()
            {
                Label = "Customer Name"
            };
            maintenanceForm.FormControls.Add(cna);

            var td = new FormControlDateTimeViewModel()
            {
                Label = "Transaction Date",
                IsRequired = true
            };
            maintenanceForm.FormControls.Add(td);

            var dd = new FormControlDateTimeViewModel()
            {
                Label = "Due Date",
                IsRequired = true
            };
            maintenanceForm.FormControls.Add(dd);

            var rn = new FormControlNumberViewModel()
            {
                Label = "Reference Number"
            };
            maintenanceForm.FormControls.Add(rn);

            var ab = new FormControlNumberViewModel()
            {
                Label = "Account Balance"
            };
            maintenanceForm.FormControls.Add(ab);

            var ac = new FormControlNumberViewModel()
            {
                Label = "Outstanding Credit"
            };
            maintenanceForm.FormControls.Add(ac);

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
