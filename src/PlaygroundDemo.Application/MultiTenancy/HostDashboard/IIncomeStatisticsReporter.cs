using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PlaygroundDemo.MultiTenancy.HostDashboard.Dto;

namespace PlaygroundDemo.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}