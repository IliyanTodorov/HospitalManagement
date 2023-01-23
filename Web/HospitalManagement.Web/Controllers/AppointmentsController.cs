namespace HospitalManagement.Web.Controllers
{
    using HospitalManagement.Services.Data;
    using Microsoft.AspNetCore.Mvc;

    public class AppointmentsController : BaseController
    {
        private readonly IAppointmentService appointmentService;

        public AppointmentsController(IAppointmentService appointmentService)
        {
            this.appointmentService = appointmentService;
        }

        public IActionResult Index()
        {
            return this.View();
        }
    }
}
