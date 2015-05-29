using DonglesAreGreat.Core.Models;
using DonglesAreGreat.Core.Repositories;
using DonglesAreGreat.Core.Services;
using DonglesAreGreat.Core.Services.Interfaces;
using DonglesAreGreat.Infrastructure.Entities;

namespace DonglesAreGreat.Infrastructure
{
    public class DongleRepository : IDongleRepository
    {
        private IClassLoggingService _loggingService;

        public DongleRepository(IClassLoggingService loggingService)
        {
            _loggingService = loggingService;
        }

        public Dongle GetDongle()
        {
            _loggingService.Info("Getting the Dongle...");
            var de = new DongleEntity();
            var result = AutoMapper.Mapper.Map<Dongle>(de);
            return result;
        }
    }
}