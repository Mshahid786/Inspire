using System;
using System.Transactions;
using Inspire.Erp.Application.Account;
using Inspire.Erp.Application.Account.Implementations;
using Inspire.Erp.Application.StoreWareHouse.Implementations;
using Inspire.Erp.Application.Account.Interfaces;
using Inspire.Erp.Application.Mapping;
using Inspire.Erp.Application.Master;
using Inspire.Erp.Application.StoreWareHouse.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Inspire.Erp.Application.VoucherPrinting.Interface;
using Inspire.Erp.Application.VoucherPrinting.Implementation;
using Inspire.Erp.Application.StatementOfAccounts.Interface;

namespace Inspire.Erp.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IStatementOfAccountsSummary, Inspire.Erp.Application.StatementOfAccounts.Implementation.StatementOfAccountsSummary>();
            services.AddScoped<IStatementOfAccountsDetail, Inspire.Erp.Application.StatementOfAccounts.Implementation.StatementOFAccountsDetail>();
            services.AddScoped<IvoucherPrinting, Inspire.Erp.Application.VoucherPrinting.Implementation.VoucherPrinting>();
            services.AddScoped(typeof(IMapFrom<>), typeof(MapFrom<>));
            services.AddScoped<ICurrencyMasterService, CurrencyMasterService>();
            services.AddScoped<ISupplierMasterService, SupplierMasterService>();
            services.AddScoped<ICountryMasterService, CountryMasterService>();
            services.AddScoped<ICityMasterService, CityMasterService>();
            services.AddScoped<IBrandMasterService, BrandMasterService>();
            services.AddScoped<IBudgetMasterService, BudgetMasterService>();
            services.AddScoped<IDepartmentMasterService, DepartmentMasterService>();
            services.AddScoped<IBusinessTypeMasterService, BusinessTypeMasterService>();
            services.AddScoped<ILocationMasterService, LocationMasterService>();
            services.AddScoped<ITermsAndConditionService, TermsAndConditionService>();
            services.AddScoped<ICustomerMasterService, CustomerMasterService>();
            services.AddScoped<ISalesmanMasterService, SalesmanMasterService>();
            services.AddScoped<ICustomerTypeService, CustomerTypeService>();
            services.AddScoped<IItemMasterService, ItemMasterService>();
            services.AddScoped<IJobMasterService, JobMasterService>();
            services.AddScoped<IUnitMasterService, UnitMasterSevice>();
            services.AddScoped<ICostCenterMasterService, CostCenterMasterService>();
            services.AddScoped<IPriceLevelMasterService, PriceLevelMasterService>();
            services.AddScoped<IStaffMasterService, StaffMasterService>();
            services.AddScoped<IWorkGroupMasterService, WorkGroupMasterService>();
            services.AddScoped<IProjectDescriptionService, ProjectDescriptionService>();
            services.AddScoped<ITypeMasterService, TypeMasterService>();
            services.AddScoped<IChartofAccountsService, ChartofAccountsService>();
            services.AddScoped<IPaymentVoucherService, PaymentVoucherService>();
            services.AddScoped<IReceiptVoucherService, ReceiptVoucherService>();
            services.AddScoped<IReceiptVoucherService, ReceiptVoucherService>();
            services.AddScoped<IStoreWareHouse, StoreWareHouses>();
            return services;
        }
    }
}
