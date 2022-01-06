using JasonTaylorCleanArch.Application.Common.Interfaces;

namespace JasonTaylorCleanArch.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}