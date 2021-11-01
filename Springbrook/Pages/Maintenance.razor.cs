using System.Linq;
using Microsoft.AspNetCore.Components;
using Springbrook.Services;
using Springbrook.ViewModels;

namespace Springbrook.Pages
{
    public class MaintenanceBase : ComponentBase
    {
        [Inject]
        public IMaintenanceServices MaintenanceServices { get; set; }

        protected MaintenanceFormViewModel maintenanceVM = new();

        public bool InSettingMode { get; set; }


        protected override void OnInitialized()
        {
            maintenanceVM = MaintenanceServices.InitMaintenanceForm();
        }

        public void ShowSettings()
        {
            InSettingMode = true;
            if (maintenanceVM.FormControls.All(c => c.Order == 0))
                maintenanceVM.FormControls.ForEach(c => c.Order = null);
        }

        public void ResetForm()
        {
            maintenanceVM = MaintenanceServices.InitMaintenanceForm();
            InSettingMode = false;
        }

        protected void Save()
        {
            if (!InSettingMode)
            {
                MaintenanceServices.SaveMaintenanceForm(maintenanceVM);
            }
            else
            {
                MaintenanceServices.SaveMaintenanceFormSettings(maintenanceVM);
                InSettingMode = false;
            }
        }
    }
}
