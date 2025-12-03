Module Module_GlobalVariables

	''--->>> Module_HRIS <<<---

	Public FilePath As String = ""

	Public _EmployeeName As String
	Public _EmployeeDepartment As String
	Public _EmployeePosition As String
	Public _EmployeeStatus As String
	Public _StartDate As DateTime = Date.Now
	Public _EndDate As DateTime = Date.Now
	Public _ReviewDate As DateTime = Date.Now
	Public _ProjectDesignation As String

	Public hasInitialized As Boolean = False
	Public isUpdate As Boolean = False

	Public _strSameAsAddressValidation As Integer
	Public isOperationDept As Integer
	Public isInactive As Integer

	Public isFlexi As Integer
	Public isForceBreak As Integer

	Public _strShiftID As Integer
	Public _strShiftEffectivityID As Integer
	Public _strShiftEmployeeID As Integer

	Public _strCompanyID As Integer
	Public _strParentDepartmentID As Integer
	Public _strDepartmentID As Integer
	Public _strJobTitleID As Integer
	Public _strLeaveTypeID As Integer
	Public _strHierarchyID As Integer
	Public _strHierarchyDetailID As Integer
	Public _strSystemSettingsID As Integer

	Public _strPerformancePart1Form1ID As Integer
	Public _strPerformancePart1Form2ID As Integer

	Public _strPerformancePart2FormID As String
	Public _strPerformancePart2FormAID As Integer
	Public _strPerformancePart2FormBID As Integer
	Public _strPerformancePart2FormCID As Integer

	Public _TrainingListID As Integer
	Public _TrainingBatchListID As Integer
	Public _TrainingSubDetailID As Integer
	Public _TrainingEmployeeID As Integer
	Public _TrainingRequestID As Integer

	Public isEdit As Boolean = False
	Public PanelTagID As Integer = 0
	Public _PersonnelPSID1 As Integer
	Public _PersonnelPSID2 As Integer = 1000000
	Public _PersonnelSCID1 As Integer
	Public _PersonnelSCID2 As Integer = 1000000

	Public _PersonnelEducationID1 As Integer
	Public _PersonnelEducationID2 As Integer = 1000000

	Public _PersonnelCharRefID1 As Integer
	Public _PersonnelCharRefID2 As Integer = 1000000

	Public _ContractID1 As Integer
	Public _ContractID2 As Integer = 1000000

	Public _COEID1 As Integer
	Public _COEType As Integer

	Public _PersonnelEmploymentHistoryID1 As Integer
	Public _PersonnelEmploymentHistoryID2 As Integer = 1000000

	Public _PersonnelAppraisalID1 As Integer
	Public _PersonnelAppraisalID2 As Integer = 1000000

	Public _201FileID As Integer

	Public _LeaveTypeID As Integer


	''--->>> End of Module_HRIS <<<---

	''--->>> Module_PCMS <<<---

	Public _strLoginEmployeeID As Integer '' ID of User who uses or currently logged-in to the system

	Public BtnColorText As Button = Nothing

	Public CurrentForm As Form
	Public currentSubMenuForm As Form = Nothing
	Public _strPayPeriodID As Integer
	Public _strWorkdate As String = Nothing
	Public _strEmployeeID As Integer
	Public _strProjectChargeID As Integer = 0
	Public strEmpIDforInsert As Integer
	Public strEmployeeNumber As String
	Public _strUserLevel As String = Nothing
	Public _strProjectDeptID As Integer = 0
	Public _strFiledDocs As String = Nothing
	Public _strIsFlexiSched As Boolean
	Public _strAttendanceFrom As String
	Public _strAttendanceTo As String
	Public _strTimeSheetID As Integer
	Public _strTimeIn As String = Nothing

	Public MenuAccessList As New List(Of String)
	Public SubMenuAccessList As New List(Of String)

	Public _SystemGroupID As Integer
	Public _SystemUserID As Integer

	Public _AllowInsert As Boolean = False
	Public _AllowUpdate As Boolean = False
	Public _AllowDelete As Boolean = False
	Public _AllowView As Boolean = False
	Public _AllowPrint As Boolean = False
	Public _AllowPost As Boolean = False

	''--->>> End of Module_PCMS <<<---

	''--->>> Module_Accounting <<<---

	Public _DepartmentChargingID1 As Integer
	Public _DepartmentChargingID2 As Integer
	Public _DepartmentChargingID3 As Integer = 0

	Public _ProjectChargingID1 As Integer
	Public _ProjectChargingID2 As Integer
	Public _ProjectChargingID3 As Integer

	Public _FiscalPeriodID As Integer

	Public _CashFlowCategoryID As Integer
	Public _CashFlowCategoryDetailID As Integer
	Public _CashFlowCategorySubDetailID As Integer

	Public _strCashFlowCategory As String
	Public _strCashFlowCategoryDetail As String

	Public _strCostCenterID As String

	Public _AccountCategoryID As Integer
	Public _AccountCategoryDetailID As Integer

	Public _LevelID As Integer
	Public _ChartLevel1ID As Integer
	Public _ChartLevel2ID As Integer
	Public _ChartLevel3ID As Integer

	Public BankID As Integer
	Public BankDetailID As Integer

	Public SubsidiaryTypeID As Integer
	Public SubsidiaryAccountID As Integer

	Public SupplierTypeID As Integer
	Public SupplierAccountID As Integer

	Public TaxRateID As Integer

	Public ItemCategoryID As Integer
	Public ItemOPEID As Integer
	Public ItemSubDetailID As Integer

	Public BeginProjectID As Integer
	Public BeginProjectDetailID As Integer

	Public TransactionClosingID As Integer

	Public YearEndClosingID As Integer

	Public AccountBalancesYear As Integer
	Public AccountBalancesID As Integer

	Public AccountMappingInternal As String = ""

	'Vouchers
	Public PayeeTypeID As Integer

	Public VoucherDepartmentID1 As Integer
	Public VoucherDepartmentID2 As Integer
	Public VoucherDepartmentID3 As Integer = 0

	Public VoucherCostCenterID1 As Integer
	Public VoucherCostCenterID2 As Integer
	Public VoucherCostCenterID3 As Integer = 0

	Public VoucherAccountTitleID1 As Integer
	Public VoucherAccountTitleID2 As Integer
	Public VoucherAccountTitleID3 As Integer = 1000000

	Public VoucherProjectNameID1 As Integer
	Public VoucherProjectNameID2 As Integer
	Public VoucherProjectNameID3 As Integer

	Public VoucherSubsidiaryID1 As Integer
	Public VoucherSubsidiaryID2 As Integer

	Public RequestVoucherID As Integer
	Public RequestVoucherDetailID As Integer


	''--->>> End of Module_Accounting <<<---
End Module
