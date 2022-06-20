using FinanceMentorTutorial.Server.Storage;
using FinanceMentorTutorial.Shared;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceMentorTutorial.Server
{
    public static class SampleData
    {
        public static void AddEarningRepository(this IServiceCollection services)
        {
            var today = DateTime.Today;
            var lastMonth = DateTime.Today.AddMonths(-1);
            var previousMonth = DateTime.Today.AddMonths(-2);

            var earningRepository = new MemoryRepository<Earning>();

            earningRepository.Add(new Earning { Date = new DateTime(previousMonth.Year, previousMonth.Month, 25), Amount = 2400, Category = EarningCategory.Flipping, Subject = "What" });

            services.AddSingleton<IRepository<Earning>>(earningRepository);
        }
    }
}
