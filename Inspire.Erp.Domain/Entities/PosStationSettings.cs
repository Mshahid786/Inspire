using System;
using System.Collections.Generic;

namespace Inspire.Erp.Domain.Entities
{
    public partial class PosStationSettings
    {
        public int PosStationSettingsId { get; set; }
        public string PosStationSettingsStationName { get; set; }
        public string PosStationSettingsPrinterName { get; set; }
        public string PosStationSettingsPrinterType { get; set; }
        public string PosStationSettingsPrinterPort { get; set; }
        public string PosStationSettingsHeader1 { get; set; }
        public string PosStationSettingsHeader2 { get; set; }
        public string PosStationSettingsHeader3 { get; set; }
        public string PosStationSettingsHeader4 { get; set; }
        public string PosStationSettingsFooter1 { get; set; }
        public string PosStationSettingsFooter2 { get; set; }
        public string PosStationSettingsFooter3 { get; set; }
        public string PosStationSettingsFooter4 { get; set; }
        public string PosStationSettingsVfdDriver { get; set; }
        public int? PosStationSettingsDisplayLines { get; set; }
        public int? PosStationSettingsBaudRate { get; set; }
        public string PosStationSettingsWelcomeMessage { get; set; }
        public string PosStationSettingsBillClosing { get; set; }
        public string PosStationSettingsScanner { get; set; }
        public string PosStationSettingsEmulation { get; set; }
        public bool? PosStationSettingsShowVatcolumn { get; set; }
        public bool? PosStationSettingsShowDiscountColumn { get; set; }
        public bool? PosStationSettingsShowVattotal { get; set; }
        public bool? PosStationSettingsClubGrid { get; set; }
        public string PosStationSettingsParity { get; set; }
        public bool? PosStationSettingsShowUnit { get; set; }
        public bool? PosStationSettingsShowBarCode { get; set; }
        public bool? PosStationSettingsDisableVat { get; set; }
        public bool? PosStationSettingsEnablePrinter { get; set; }
        public bool? PosStationSettingsEnableVfd { get; set; }
        public bool? PosStationSettingsReportCashSale { get; set; }
        public bool? PosStationSettingsReportCardSale { get; set; }
        public bool? PosStationSettingsReportCreditSales { get; set; }
        public bool? PosStationSettingsReportItemTotal { get; set; }
        public bool? PosStationSettingsReportGroupTotal { get; set; }
        public int? PosStationSettingsCsBcopy { get; set; }
        public int? PosStationSettingsCrBcopy { get; set; }
        public double? PosStationSettingsVatPercentage { get; set; }
        public bool? PosStationSettingsVatInclusive { get; set; }
        public bool? PosStationSettingsReorderCheck { get; set; }
        public bool? PosStationSettingsDelStatus { get; set; }
    }
}
