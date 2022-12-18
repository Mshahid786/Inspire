using AutoMapper;
using Inspire.Erp.Domain.Entities;
using Inspire.Erp.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inspire.Erp.Web.Common
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<CurrencyMaster, CurrencyMasterViewModel>();
            CreateMap<CurrencyMasterViewModel, CurrencyMaster>();
            CreateMap<CountryMasterViewModel, CountryMaster>();
            CreateMap<CountryMaster, CountryMasterViewModel>();
            CreateMap<SuppliersMasterViewModel, SuppliersMaster>();
            CreateMap<SuppliersMaster, SuppliersMasterViewModel>();
            CreateMap<CityMasterViewModel, CityMaster>();
            CreateMap<CityMaster, CityMasterViewModel>();
            CreateMap<BrandMasterViewModel, VendorMaster>();
            CreateMap<VendorMaster, BrandMasterViewModel>();
            CreateMap<BudgetMasterViewModel, BudgetMaster>();
            CreateMap<BudgetMaster, BudgetMasterViewModel>();
            CreateMap<DepartmentMaster, DepartmentMasterViewModel>();
            CreateMap<DepartmentMasterViewModel, DepartmentMaster>();
            CreateMap<BusinessMasterViewModel, BusinessTypeMaster>();
            CreateMap<BusinessTypeMaster, BusinessMasterViewModel>();
            CreateMap<LocationMaster, LocationMasterViewModel>();
            CreateMap<LocationMasterViewModel, LocationMaster>();
            CreateMap<TermsAndCondition, TermsAndConditionViewModel>();
            CreateMap<TermsAndConditionViewModel, TermsAndCondition>();
            CreateMap<CustomerMaster, CustomerMasterViewModel>();
            CreateMap<CustomerMasterViewModel, CustomerMaster>();
            CreateMap<SalesManMaster, SalesmanMasterViewModel>();
            CreateMap<SalesmanMasterViewModel, SalesManMaster>();
            CreateMap<ChartofAccountsViewModel, MasterAccountsTable>();
            CreateMap<MasterAccountsTable, ChartofAccountsViewModel>();
            CreateMap<ItemMaster, ItemMasterViewModel>();
            CreateMap<ItemMasterViewModel, ItemMaster>();
            CreateMap<JobMaster, JobMasterViewModel>();
            CreateMap<JobMasterViewModel, JobMaster>();
            CreateMap<UnitMaster, UnitMasterViewModel>();
            CreateMap<UnitMasterViewModel, UnitMaster>();
            CreateMap<CostCenterMaster, CostCenterViewModel>();
            CreateMap<CostCenterViewModel, CostCenterMaster>();
            CreateMap<PriceLevelMaster, PriceLevelMasterViewModel>();
            CreateMap<PriceLevelMasterViewModel, PriceLevelMaster>();
            CreateMap<StaffMaster, StaffMasterViewModel>();
            CreateMap<StaffMasterViewModel, StaffMaster>();
            CreateMap<WorkGroupMaster, WorkGroupMasterViewModel>();
            CreateMap<WorkGroupMasterViewModel, WorkGroupMaster>();
            CreateMap<ProjectDescriptionMaster, ProjectDescriptionViewModel>();
            CreateMap<ProjectDescriptionViewModel, ProjectDescriptionMaster>();
            CreateMap<TypeMaster, TypeMasterViewModel>();
            CreateMap<TypeMasterViewModel, TypeMaster>();

            CreateMap<PaymentVoucher, PaymentVoucherViewModel>();
            CreateMap<PaymentVoucherViewModel, PaymentVoucher>();

            CreateMap<PaymentVoucherDetails, PaymentVoucherDetailsViewModel>();
            CreateMap<PaymentVoucherDetailsViewModel, PaymentVoucherDetails>();

            CreateMap<AccountsTransactions, AccountTransactionsViewModel>();
            CreateMap<AccountTransactionsViewModel, AccountsTransactions>();


            CreateMap<ReceiptVoucherMaster, ReceiptVoucherMasterViewModel>();
            CreateMap<ReceiptVoucherMasterViewModel, ReceiptVoucherMaster>();

            CreateMap<ReceiptVoucherDetails, ReceiptVoucherDetailsViewModel>();
            CreateMap<ReceiptVoucherDetailsViewModel, ReceiptVoucherDetails>();

            CreateMap<ItemStockType, ItemStockTypeViewModel>();

            CreateMap<SupplierDetails, SupplierDetailsViewModel>();
            CreateMap<SupplierDetailsViewModel, SupplierDetails>();


            CreateMap<UnitDetails, UnitDetailsViewModel>();
            CreateMap<UnitDetailsViewModel, UnitDetails>();

            CreateMap<ItemPriceLevelDetails, ItemPriceLevelDetailsViewModel>();
            CreateMap<ItemPriceLevelDetailsViewModel, ItemPriceLevelDetails>();
        }
    }
}
