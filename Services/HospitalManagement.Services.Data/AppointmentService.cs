namespace HospitalManagement.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using HospitalManagement.Data.Common.Repositories;
    using HospitalManagement.Data.Models;
    using HospitalManagement.Services.Mapping;
    using Microsoft.EntityFrameworkCore;

    public class AppointmentService : IAppointmentService
    {
        private readonly IDeletableEntityRepository<Appointment> appointmentRepository;

        public AppointmentService(IDeletableEntityRepository<Appointment> appointmentRepository)
        {
            this.appointmentRepository = appointmentRepository;
        }

        public async Task<IEnumerable<Appointment>> GetAppointments()
        {
            var appointments = await this.appointmentRepository.AllAsNoTracking().ToListAsync();
            return appointments;
        }

        public async Task<Appointment> GetAppointmentById(int id)
        {
            var appointment = await this.appointmentRepository
                .AllAsNoTracking()
                .Where(a => a.Id == id)
                .FirstOrDefaultAsync();
            return appointment;
        }

        public async Task AddAppointment(Appointment appointment)
        {
            await this.appointmentRepository.AddAsync(appointment);
            await this.appointmentRepository.SaveChangesAsync();
        }

        public async Task UpdateAppointment(Appointment appointment)
        {
            this.appointmentRepository.Update(appointment);
            await this.appointmentRepository.SaveChangesAsync();
        }

        public async Task DeleteAppointment(int id)
        {
            var appointment = await this.appointmentRepository
                .AllAsNoTracking()
                .Where(a => a.Id == id)
                .FirstOrDefaultAsync();
            this.appointmentRepository.Delete(appointment);

            await this.appointmentRepository.SaveChangesAsync();
        }
    }

}
