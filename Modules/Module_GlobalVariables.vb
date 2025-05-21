Module Module_GlobalVariables

	''--->>> Module_HRIS <<<---

	Public FilePath As String = ""

	Public _strSameAsAddressValidation As Integer
	Public isOperationDept As Integer
	Public isInactive As Integer

	Public isFlexi As Integer
	Public isForceBreak As Integer

	Public _strShiftID As Integer
	Public _strShiftEffectivityID As Integer
	Public _strShiftEmployeeID As Integer

	Public _strCompanyID As Integer
	Public _strDepartmentID As Integer
	Public _strJobTitleID As Integer
	Public _strLeaveTypeID As Integer
	Public _strHierarchyID As Integer
	Public _strHierarchyDetailID As Integer

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

	Public _201FileID As Integer

	''--->>> End of Module_HRIS <<<---

End Module
