import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { MasterApiService } from 'src/app/routes/service/master.api.services';
import { MenuItem } from 'primeng/api/menuitem';
import Handsontable from 'handsontable';
import { defaults } from 'src/app/shared/service/settings';
import { TranslateService } from '@ngx-translate/core';
import { AccountApiService } from 'src/app/routes/service/account.api.service';
import { SelectItem, MessageService, ConfirmationService } from 'primeng/api';
import { ChartofAccounts, ReceiptVoucher, ReceiptVoucherDetails } from 'src/app/routes/domain';
import { JobMaster } from 'src/app/routes/domain/JobMaster';
import { CostCenterMaster } from 'src/app/routes/domain/CostCenterMaster';
import { AccountsTransactions } from 'src/app/routes/domain/AccountsTransactions';
import { HotTableRegisterer } from '@handsontable/angular';
import * as $ from 'jquery';
import { summaryFileName } from '@angular/compiler/src/aot/util';
import { DropDownValidator } from 'src/app/shared/validator/customvalidtor';
import { StockApiService } from 'src/app/routes/service/stock-api/stock-api.service';
import { GlobalSerivceService } from 'src/app/routes/service/stock-api/global-serivce.service';

@Component({
  selector: 'app-stockmovementreport',
  templateUrl: './stockmovementreport.component.html',
  styleUrls: ['./stockmovementreport.component.scss']
})
export class StockmovementreportComponent implements OnInit {

  dataset: [];
  list: any;
  confirmDropDatabaseDialogVisible = false;
  title: string;
  search: string;
  index: number = 0;
  displayMaximizable: boolean;
  breadcumbmodel: MenuItem[];
  licensekey: string;
  vchDetailsResponse:any;
  vchDetailsResponseTemp:any;
  btnFlag: ButtonFlag;
  currencyList: SelectItem[];
  currArry: string[] = [];

  accountArray: ChartofAccounts[] = [];
  acctArry: string[] = [];
  accountList: SelectItem[];

  jobArray: JobMaster[] = [];
  jobList: SelectItem[] = [];
  jobArry: string[] = [];

  costcenterArray: CostCenterMaster[] = [];
  costcenterList: SelectItem[] = [];
  costcenterArry: string[] = [];

  accountTransactionList: AccountsTransactions[] = [];
  receiptVoucherarry: ReceiptVoucher[] = [];
  savedReceiptVoucher: ReceiptVoucher;
  private hotRegisterer = new HotTableRegisterer();
  hotid = 'receiptVouchrEntry';
  constructor(private activatedroute: ActivatedRoute,
    private stockApi: StockApiService,
    private messageService: MessageService,
    private fb: FormBuilder,
    private confirmation: ConfirmationService,
    private translate: TranslateService,
    private router: Router,
    private masterapi: MasterApiService,
    private accountapi: AccountApiService) {
    this.licensekey = defaults.hotlicensekey;
  }

  stockmovementrpt: Handsontable.GridSettings;
  stockmovementrptDtls: Handsontable.GridSettings;
  stockMovementRptFormGroup: FormGroup;
  stockMovementRptFormGroup1: FormGroup;

  cols: any;
  ItemFromStockLedger: any;
  ngOnInit(): void {
    this.cols = [
      { field: 'Item_Master_Item_ID', header: 'Item Id' },
      { field: 'Item_Master_Item_Name', header: 'Item Name' },
      { field: 'Item_Master_Part_No', header: 'Item Part No' },
      { field: 'Item_Master_Barcode', header: 'Item Barcode' }
    ];
    this.btnFlag = { edit: false, cancel: false, save: true, update: false, delete: false };
    this.initializeControls();
    this.stockMovementRptFormGroup1 = new FormGroup({
      stockMovementRptItemGroup: new FormControl(''),
      stockMovementRptDetailType: new FormControl(''),
      stockMovementRptDetails: new FormControl(''),
      stockMovementRptSalesMan: new FormControl(''),
      stockMovementRptItemName: new FormControl(''),
      stockMovementRptLocation: new FormControl(''),
      stockMovementRptJob: new FormControl('')
    });
    this.stockMovementRptFormGroup = this.fb.group({
      ReceiptVoucherMasterSNO: [null],
      ReceiptVoucherMasterVoucherNo: [{ value: null, disabled: true }],
      ReceiptVoucherMasterVoucherDate: [null, [Validators.required]],
      ReceiptVoucherMasterRefNo: ['', [Validators.required]],
      ReceiptVoucherMasterDrAcNo: [-1, [DropDownValidator]],
      ReceiptVoucherMasterDrAmount: [null],
      ReceiptVoucherMasterNarration: ['', [Validators.required]],
      ReceiptVoucherMasterCurrencyId: [-1, [DropDownValidator]]
    });
    this.breadcumbmodel = this.router.url.slice(1).split('/').map((k) => ({ label: k }));
    this.activatedroute.data.subscribe(data => {
      this.title = data.title;
    });
    if (GlobalSerivceService.getDetailsByItemFromStockLedger != null) {
      this.ItemFromStockLedger = GlobalSerivceService.getDetailsByItemFromStockLedger;
      if (this.ItemFromStockLedger.length > 0) {
        this.getStockVchDetails(this.ItemFromStockLedger[0].Item_Id);    ////////Changes Needed
        setTimeout(()=>{
          //this.stockMovementRptFormGroup1.value.stockMovementRptItemGroup = this.ItemFromStockLedger[0].Item_Id;
          //this.stockMovementRptFormGroup1.value.stockMovementRptItemName = this.ItemFromStockLedger[0].Item_Name;
          $("#itemGroup").val(this.ItemFromStockLedger[0].Item_Id);
          $("#itemName").val(this.ItemFromStockLedger[0].Item_Name);
        },300);
      }
    }
  }
  getStockVchDetails(itemId:any){
    this.stockApi.getStockVchDetails({"itemGroup":new String(itemId)}).subscribe(
      data =>{
        this.vchDetailsResponseTemp = data;
        this.vchDetailsResponse = this.vchDetailsResponseTemp.Stock_Register;
      }
    )
  }
  GetItemList() {
    console.log('called');
    this.stockApi.getAllItemsList().subscribe(respose => {
      this.list = respose;
      console.log(this.list);
      this.dataset = this.list.Item_Master;
      this.displayMaximizable = true;
    },
      error => {
        console.error("Data Not found...!");
      });
  }
  GetItemDetails(id) {
    this.displayMaximizable = false;
    this.stockApi.getStockMovementDetailsRpt({ ItemMasterItemId: id }).subscribe(respose => {
      this.list = respose;
      this.dataset = this.list.ItemDetails;
      console.error(this.dataset);
    },
      error => {
        console.error("Data Not found...!");
      });
  }
  handleChange(e) {
    this.index = e.index;
  }
  get f1() {
    return this.stockMovementRptFormGroup1.controls;
  }
  get f() {
    return this.stockMovementRptFormGroup.controls;
  }
  initializeControls() {
    this.stockmovementrpt = {
      rowHeaders: true,
      viewportColumnRenderingOffset: 27,
      viewportRowRenderingOffset: 'auto',
      colWidths: [40,100,40,50],
      minRows: 2,
      width: '100%',
      height: 150,
      rowHeights: 23,
      fillHandle: {
        direction: 'vertical',
        autoInsertRow: true
      },
      data: [],
      minSpareRows: 1,
      // allowInsertColumn: false,
      allowInsertRow: true,
      // allowRemoveColumn: false,
      // allowRemoveRow: false,
      // autoWrapRow: false,
      // autoWrapCol: false,
      stretchH: "all",
      //  autoWrapRow: true,
      // height: 487,
      // maxRows: 22,
      manualRowResize: true,
      manualColumnResize: true,
      hiddenColumns: {
        columns: [8],
        indicators: false
      },
      // rowHeaders: true,
      columns: [
        {
          data: 'account',
          type: 'autocomplete',
          source: (query, callback) => {
            callback(this.acctArry);
          },
          allowInvalid: false,
          strict: false
        },
        {
          data: 'credit',
          type: 'numeric'
        },
        {
          data: 'jobname',
          type: 'autocomplete',
          source: (query, callback) => {
            callback(this.jobArry);
          },
          allowInvalid: false,
          strict: false
        },
        {
          data: 'costcenter',
          type: 'dropdown',
          source: (query, callback) => {
            callback(this.costcenterArry);
          },
        },
        {
          data: 'narration',
          type: 'text',
        },
        {
          data: 'id',
          type: 'numeric'
        },
        {
          data: 'Temp',
          type: 'numeric'

        },
        {
          data: 'Temp',
          type: 'numeric'

        }
      ],
      colHeaders: [
        this.translate.instant('A'),
        this.translate.instant('B'),
        this.translate.instant('C'),
        this.translate.instant('D'),
        this.translate.instant('E'),
        this.translate.instant('F'),
        this.translate.instant('G'),
        this.translate.instant('H')
      ],
      manualRowMove: true,
      manualColumnMove: true,
      contextMenu: true,
      filters: true,
      dropdownMenu: true,
    };

    this.stockmovementrpt.beforeChangeRender = (change, source) => {
      this.ColumnSum();

    };
    this.stockmovementrpt.afterRemoveRow = (index: number, amount: number) => {
      // console.log('beforeRemove: index: %d, amount: %d', index, amount);
      // console.log(this.hotRegisterer.getInstance(this.hotid).getDataAtRow(index));
      this.ColumnSum();

    };


    this.stockmovementrpt.afterValidate = (isValid, value, row, prop) => {
      if (!isValid) {
        this.messageService.add({ severity: 'error', summary: 'Alert', detail: 'Invalid entry' });
      }

    };
    this.initializeControlsDtls();
  }
  initializeControlsDtls() {
  this.stockmovementrptDtls = {
      rowHeaders: true,
      viewportColumnRenderingOffset: 27,
      viewportRowRenderingOffset: 'auto',
      colWidths: [100,100,150,100,100,100,100,120,120],
      minRows: 2,
      width: '100%',
      height: 150,
      rowHeights: 23,
      fillHandle: {
        direction: 'vertical',
        autoInsertRow: true
      },
      data: [],
      minSpareRows: 1,
      // allowInsertColumn: false,
      allowInsertRow: true,
      // allowRemoveColumn: false,
      // allowRemoveRow: false,
      // autoWrapRow: false,
      // autoWrapCol: false,
      stretchH: "all",
      //  autoWrapRow: true,
      // height: 487,
      // maxRows: 22,
      manualRowResize: true,
      manualColumnResize: true,
      hiddenColumns: {
        columns: [8],
        indicators: false
      },
      // rowHeaders: true,
      columns: [
        {
          data: 'account',
          type: 'autocomplete',
          source: (query, callback) => {
            callback(this.acctArry);
          },
          allowInvalid: false,
          strict: false
        },
        {
          data: 'credit',
          type: 'numeric'
        },
        {
          data: 'jobname',
          type: 'autocomplete',
          source: (query, callback) => {
            callback(this.jobArry);
          },
          allowInvalid: false,
          strict: false
        },
        {
          data: 'costcenter',
          type: 'dropdown',
          source: (query, callback) => {
            callback(this.costcenterArry);
          },
        },
        {
          data: 'narration',
          type: 'text',
        },
        {
          data: 'id',
          type: 'numeric'
        },
        {
          data: 'Temp',
          type: 'numeric'

        },
        {
          data: 'Temp',
          type: 'numeric'

        }
      ],
      colHeaders: [
        this.translate.instant('A'),
        this.translate.instant('B'),
        this.translate.instant('C'),
        this.translate.instant('D'),
        this.translate.instant('E'),
        this.translate.instant('F'),
        this.translate.instant('G'),
        this.translate.instant('H')
      ],
      manualRowMove: true,
      manualColumnMove: true,
      contextMenu: true,
      filters: true,
      dropdownMenu: true,
    };

    this.stockmovementrpt.beforeChangeRender = (change, source) => {
      this.ColumnSum();

    };
    this.stockmovementrpt.afterRemoveRow = (index: number, amount: number) => {
      // console.log('beforeRemove: index: %d, amount: %d', index, amount);
      // console.log(this.hotRegisterer.getInstance(this.hotid).getDataAtRow(index));
      this.ColumnSum();

    };


    this.stockmovementrpt.afterValidate = (isValid, value, row, prop) => {
      if (!isValid) {
        this.messageService.add({ severity: 'error', summary: 'Alert', detail: 'Invalid entry' });
      }

    };



  }
  ColumnSum() {
    if (this.stockmovementrpt.data.length > 0) {
      const sum1 = this.stockmovementrpt.data.filter(item => item.hasOwnProperty('credit'))
        .reduce((sum, current) => sum + current.credit, 0);
      this.stockMovementRptFormGroup.controls.ReceiptVoucherMasterDrAmount.setValue(sum1);
    }
  }
}
interface ButtonFlag {
  edit?: boolean; cancel?: boolean; update?: boolean;
  save?: boolean; delete?: boolean;
}
