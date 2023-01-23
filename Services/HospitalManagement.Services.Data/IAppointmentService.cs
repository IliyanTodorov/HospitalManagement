namespace HospitalManagement.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using HospitalManagement.Data.Models;

    public interface IAppointmentService
    {
        Task<IEnumerable<Appointment>> GetAppointments();

        Task<Appointment> GetAppointmentById(int id);

        Task AddAppointment(Appointment appointment);

        Task UpdateAppointment(Appointment appointment);

        Task DeleteAppointment(int id);
    }

}
