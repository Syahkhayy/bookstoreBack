﻿using System.Threading.Tasks;
using Abp.Application.Services;

namespace PlaygroundDemo.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task DisableRecurringPayments();

        Task EnableRecurringPayments();
    }
}
