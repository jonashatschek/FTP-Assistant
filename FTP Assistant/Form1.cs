using Itenso.TimePeriod;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace FTP_Assistant
{
    /// <summary>
    /// Defines the <see cref="Form1" />
    /// </summary>
    public partial class FTPassistant : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public FTPassistant()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Defines the _listOfEmployees
        /// </summary>
        public List<Employee> _listOfEmployees = new List<Employee>();
        public string _ftpPassword = "";
        public string _linkToFtp = "";

        /// <summary>
        /// Defines the counter
        /// </summary>
        public int counter;

        /// <summary>
        /// The getDataFromFTP_btn_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void getDataFromFTP_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to get the selected data?", "Ey, want some data?",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return;
            }

            Cursor.Current = Cursors.WaitCursor;

            if (productionEnvironmentRadioBtn.Checked)
            {
                _ftpPassword = "";
                _linkToFtp = "";
            }
            else if (stageEnviromentRadioBtn.Checked)
            {
                _ftpPassword = "";
                _linkToFtp = "";
            }
            else
            {
                MessageBox.Show("Please select an environment to work with.");
                return;
            }


            //passes the selected dates to a string object
            string dates = CalendarForDateSelect_monthCalendar.SelectionRange.ToString();

            DateTime startDate = DateTime.ParseExact(dates.Substring(23, 10), "yyyy/MM/dd", null);
            DateTime endDate = DateTime.ParseExact(dates.Substring(49, 10), "yyyy/MM/dd", null);

            List<DateTime> selectedDatesList = FormatAndCuztomizeLink(dates.Substring(23, 10), dates.Substring(49, 10));

            List<string> linkToArchive = new List<string>();
            linkToArchive.Add(_linkToFtp);

            //gets all directory names in archive directory
            List<string> directoryNamesList = ConnectToFTPAndGetDirectoryNames(linkToArchive, false, _ftpPassword);

            //returns all directory dates as DateTime objects
            List<DateTime> directoryDatesList = TurnDirectoryNamesIntoDateTime(directoryNamesList);

            List<DateTime> matchingDatesList = GetMatchingDirectoryNames(startDate, endDate, directoryDatesList);

            List<DateStringFromDirectory> matchedNamesList = GetMatchingDateNames(matchingDatesList, directoryNamesList);

            List<string> listOfLinksToFolders = CreateLinkToSpecificDirectory(matchedNamesList, directoryNamesList);

            listOfLinksToFolders = listOfLinksToFolders.OrderBy(fl => fl.Substring(0, 40)).ToList();

            //get all directory names of the sub-folders
            List<string> listOfFileNames = ConnectToFTPAndGetDirectoryNames(listOfLinksToFolders, true, _ftpPassword);

            listOfFileNames = listOfFileNames.OrderBy(fn => fn.Substring(0, 80)).ToList();

            //gets the content in each directory
            List<string> listOfEmployeeData = ConnectToFTPAndGetContent(listOfFileNames, _ftpPassword);

            listOfEmployeeData = listOfEmployeeData.OrderBy(empl => empl.Substring(0, 6)).ToList();

            _listOfEmployees = GenerateListOfEmployees(listOfEmployeeData);

            string test = "";

            _listOfEmployees = _listOfEmployees.OrderBy(emp => emp.LocalId).ToList();

            displayEmployeeData.Rows.Clear();

            foreach (Employee employee in _listOfEmployees)
            {
                FillDataGridView(employee);

            }

            Cursor.Current = Cursors.Default;
        }

        public void UserPermissionToGetData()
        {
            DialogResult result = MessageBox.Show("Do you want to get the data from the selected dates?", "Ey, want some data?",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return;
            }

        }

        public void FillDataGridView(Employee employee)
        {
            string[] row = new string[] { employee.GCID, employee.Active, employee.FirstName, employee.LastName };
            displayEmployeeData.Rows.Add(row);

        }

        public List<string> FixDataBeforeConvertingToEmployee (List<string> listOfData)
        {

            if (!listOfData[4].Contains("@"))
                listOfData.Insert(4, "");

            if (!IsDate(listOfData[8]))
                listOfData.Insert(8, "");

            if (listOfData[18] == "" && listOfData.Count > 18)
                listOfData[18] = listOfData[19];

            return listOfData;
        }

        /// <summary>
        /// The GenerateListOfEmployees
        /// </summary>
        /// <param name="employeeData">The employeeData<see cref="List{string}"/></param>
        /// <returns>The <see cref="List{Employee}"/></returns>
        public List<Employee> GenerateListOfEmployees(List<string> employeeData)
        {
            List<Employee> returnList = new List<Employee>();
            int idCounter = 0;

            foreach (string employee in employeeData)
            {
                //splits a line when whitespaces appear, and puts the pieces in a temporary array in chronological order
                string[] tempEmployeeArray = employee.Split(
                    new[] { "#" },
                    StringSplitOptions.None);

                List<string> tempEmployeeList = tempEmployeeArray.ToList();

                tempEmployeeList = FixDataBeforeConvertingToEmployee(tempEmployeeList);

                Employee e = new Employee(idCounter++, tempEmployeeList[0], tempEmployeeList[1], tempEmployeeList[2], tempEmployeeList[3], tempEmployeeList[4], tempEmployeeList[5], tempEmployeeList[6], tempEmployeeList[7], tempEmployeeList[8], tempEmployeeList[9], tempEmployeeList[10], tempEmployeeList[11], tempEmployeeList[12], tempEmployeeList[13], tempEmployeeList[14], tempEmployeeList[15], tempEmployeeList[16], tempEmployeeList[17], tempEmployeeList[18]);
                //TODO: get rid of duplicates

                returnList.Add(e);

            }

            if(returnList.Distinct().Count() < returnList.Count()) { 
                var res = returnList.OrderBy(c => c.GCID).ThenBy(n => n.LinkToFile);

                foreach (var item in res)
                returnList.Add(item);
            }

            return returnList;
        }

        public bool HasDuplicateEmployees (List<Employee> inputList, string cgid, string link)
        {
            List<Employee> returnList = new List<Employee>();

            var tempList = inputList.Where(x => x.GCID.Equals(cgid));
            tempList = tempList.Where(y => y.LinkToFile.Equals(link));

            foreach (var item in tempList)
                returnList.Add(item);

            if (returnList.Count > 1)
                return true;
            else
                return false;
        }

        public bool IsDate(string input)
        {
            try
            {

                DateTime dt = DateTime.Parse(input);
                return true;
            }
            catch
            {
                return false;

            }
        }

        public void FindDuplicateDates (List<DateTime> dtList)
        {
            foreach(DateTime dateTimeObject in dtList)
            {
                var duplicates = dtList.Where(d => d.Date == dateTimeObject.Date);
            }
        }

        /// <summary>
        /// The GetMatchingDateNames
        /// </summary>
        /// <param name="matchingDatesList">The matchingDatesList<see cref="List{DateTime}"/></param>
        /// <param name="directoryNamesList">The directoryNamesList<see cref="List{string}"/></param>
        /// <returns>The <see cref="List{string}"/></returns>
        public List<DateStringFromDirectory> GetMatchingDateNames(List<DateTime> matchingDatesList, List<string> directoryNamesList)
        {
            List<DateStringFromDirectory> convertedDateStrings = new List<DateStringFromDirectory>();

            //Finds and removes duplicates
            IEnumerable<DateTime> filteredList = matchingDatesList
            .GroupBy(d => d.Date)
            .Select(group => group.First()).ToList();

            List<DateStringFromDirectory> returnList = new List<DateStringFromDirectory>();

            string tempDate = "";

            foreach (DateTime date in filteredList)
            {

                tempDate = date.ToString("dd'_'MM'_'yyyy");
                var matchingDates = new List<string>();

                matchingDates = directoryNamesList.Where(d => d.Contains(tempDate)).ToList();

                foreach (string row in matchingDates)
                    convertedDateStrings.Add(new DateStringFromDirectory(row, tempDate));

                convertedDateStrings = convertedDateStrings.GroupBy(d => d.Date).Select(group => group.First()).ToList();            

                foreach (DateStringFromDirectory content in convertedDateStrings)
                {
                    if (content.Content.Length == 57)
                        returnList.Add(new DateStringFromDirectory(content.Content, content.Content.Substring(content.Content.Length - 19, 10)));
                    else if (content.Content.Length == 58)
                        returnList.Add(new DateStringFromDirectory(content.Content, content.Content.Substring(content.Content.Length - 19, 10)));

                }
            }

            returnList = returnList.GroupBy(d => d.Date).Select(group => group.First()).ToList();


            return returnList;
        }

        /// <summary>
        /// The GetMatchingDirectoryNames
        /// </summary>
        /// <param name="startDate">The startDate<see cref="DateTime"/></param>
        /// <param name="endDate">The endDate<see cref="DateTime"/></param>
        /// <param name="listTwo">The listTwo<see cref="List{DateTime}"/></param>
        /// <returns>The <see cref="List{DateTime}"/></returns>
        public List<DateTime> GetMatchingDirectoryNames(DateTime startDate, DateTime endDate, List<DateTime> listTwo)
        {

            TimeRange selectedTimeRange = new TimeRange(startDate, endDate, false);

            List<DateTime> returnList = new List<DateTime>();

            if (startDate.Date == endDate.Date)
            {
                startDate = startDate.AddHours(-1);
                endDate = endDate.AddDays(1);
            }

            foreach (DateTime dateTimeObject in listTwo)
            {

                TimeRange datesFromDirectory = new TimeRange(dateTimeObject, false);

                selectedTimeRange.ExpandStartTo(startDate);
                selectedTimeRange.ExpandEndTo(endDate);

                if (datesFromDirectory.IntersectsWith(selectedTimeRange))
                {
                    returnList.Add(dateTimeObject);
                }

            }

            return returnList;
        }

        /// <summary>
        /// The ConnectToFTPAndGetDirectoryNames
        /// </summary>
        /// <param name="listOfLinks">The listOfLinks<see cref="List{string}"/></param>
        /// <param name="mergeWithLink">The mergeWithLink<see cref="bool"/></param>
        /// <returns>The <see cref="List{string}"/></returns>
        public List<string> ConnectToFTPAndGetDirectoryNames(List<string> listOfLinks, bool mergeWithLink, string ftpPassword)
        {

            string textfileContent = "";
            int counter = 0;
            List<string> returnList = new List<string>();
            List<string> tempList = new List<string>();

            foreach (string link in listOfLinks)
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(link);

                request.KeepAlive = true;
                request.UsePassive = true;
                request.UseBinary = true;
                request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

                string username = "";
                string password = ftpPassword;

                request.Credentials = new NetworkCredential(username, password);

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();

                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);

                textfileContent = reader.ReadToEnd();

                tempList = CleanAndOrganizeContent(textfileContent);

                counter++;

                if (counter == listOfLinks.Count)
                {
                    reader.Close();
                    response.Close();
                    responseStream.Close();

                }

                foreach (string item in tempList)
                {
                    if (item != "" && !mergeWithLink)
                        returnList.Add(item);
                    else if (item != "" && mergeWithLink)
                        returnList.Add(link + "/" + item.Substring(item.Length - 25, 25));
                }
            }

            return returnList;
        }

        /// <summary>
        /// The TurnDirectoryNamesIntoDateTime
        /// </summary>
        /// <param name="listOfDirectoryNames">The listOfDirectoryNames<see cref="List{string}"/></param>
        /// <returns>The <see cref="List{DateTime}"/></returns>
        public List<DateTime> TurnDirectoryNamesIntoDateTime(List<string> listOfDirectoryNames)
        {
            List<DateTime> directoryDatesList = new List<DateTime>();

            foreach (string name in listOfDirectoryNames)
            {
                if (String.IsNullOrEmpty(name))
                    continue;

                var dateWithUnderScores = "";
                var canParseToDateTime = false;
                string dateFormat = "";

                if (name.Length == 57 || name.Length == 58)
                {
                    dateWithUnderScores = name.Substring(name.Length - 19, 10);
                    dateFormat = "ddMMyyyy";
                }
                else
                {
                    dateWithUnderScores = name.Substring(37, 11);
                    dateFormat = "ddMMyyyy";
                }
                var cleanDate = Regex.Replace(dateWithUnderScores, @"[^0-9.]", String.Empty);
                canParseToDateTime = DateTime.TryParseExact(cleanDate, dateFormat, null, System.Globalization.DateTimeStyles.NoCurrentDateDefault, out var parsedDate);


                if (!canParseToDateTime)
                    continue;

                TimeSpan ts = new TimeSpan(0, 0, 0);
                parsedDate = parsedDate.Date + ts;

                directoryDatesList.Add(parsedDate);
            }

            return directoryDatesList;
        }

        /// <summary>
        /// The FormatAndCuztomizeLink
        /// </summary>
        /// <param name="startDateString">The startDateString<see cref="string"/></param>
        /// <param name="endDateString">The endDateString<see cref="string"/></param>
        /// <returns>The <see cref="List{DateTime}"/></returns>
        public List<DateTime> FormatAndCuztomizeLink(string startDateString, string endDateString)
        {
            //string link = "ftp://ftp.hm-stg.csod.com/Datafeed/Archive/01_01_2017_23_00_00/Users_";

            DateTime startDate = DateTime.ParseExact(startDateString, "yyyy/MM/dd", null);
            DateTime endDate = DateTime.ParseExact(endDateString, "yyyy/MM/dd", null);
            List<DateTime> selectedDatesList = new List<DateTime>();
            selectedDatesList.Add(startDate);

            while (startDate < endDate)
            {
                startDate = startDate.AddDays(1);
                selectedDatesList.Add(startDate);
            }

            selectedDatesList.Add(endDate);
            TimeSpan timeSpan = startDate - endDate;

            return selectedDatesList;
        }

        /// <summary>
        /// The CreateLinkToSpecificDirectory
        /// </summary>
        /// <param name="dates">The dates<see cref="List{string}"/></param>
        /// <param name="directoryNames">The directoryNames<see cref="List{string}"/></param>
        /// <returns>The <see cref="List{string}"/></returns>
        public List<string> CreateLinkToSpecificDirectory(List<DateStringFromDirectory> dates, List<string> directoryNames)
        {

            List<string> returnList = new List<string>();
            string tempName = "";
            foreach (DateStringFromDirectory date in dates)
            {

                var directoryNamesContainingMatchedDate = directoryNames.Where(c => c.Contains(date.Date)).ToList();

                //TODO: Solve problem with duplicates. Has to be solved at an early stage, to minimize performance reqs!

                foreach (string directoryName in directoryNamesContainingMatchedDate)
                {
                    if (stageEnviromentRadioBtn.Checked) { 
                        if (directoryName.Length > 60)
                            tempName = "ftp://ftp.hm-stg.csod.com/Datafeed/Archive/" + directoryName.Substring(directoryName.Length - 25, 25);
                        else
                            tempName = "ftp://ftp.hm-stg.csod.com/Datafeed/Archive/" + directoryName.Substring(directoryName.Length - 19, 19);
                    }
                    else if (productionEnvironmentRadioBtn.Checked)
                    {
                        if (directoryName.Length > 60)
                            tempName = "ftp://ftp.hm.csod.com/Datafeed/Archive/" + directoryName.Substring(directoryName.Length - 25, 25);
                        else
                            tempName = "ftp://ftp.hm.csod.com/Datafeed/Archive/" + directoryName.Substring(directoryName.Length - 19, 19);
                    }

                    returnList.Add(tempName);
                }

            }

            return returnList;
        }

        /// <summary>
        /// The FilterWhiteSpaces
        /// </summary>
        /// <param name="input">The input<see cref="string"/></param>
        /// <returns>The <see cref="string"/></returns>
        public static string FilterWhiteSpaces(string input)
        {
            if (input == null)
                return string.Empty;

            StringBuilder stringBuilder = new StringBuilder(input.Length);
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (i == 0 || c != ' ' || (c == '\t' && input[i - 1] != ' '))
                    stringBuilder.Append(c);
            }
            return stringBuilder.ToString();
        }

        /// <summary>
        /// The FindAndReplaceTabsAndSpaces
        /// </summary>
        /// <param name="input">The input<see cref="string"/></param>
        /// <returns>The <see cref="string"/></returns>
        public string FindAndReplaceTabsAndSpaces(string input)
        {

            string line = input.Replace("\t", "#");
            while (line.IndexOf("  ") > 0 || line.IndexOf("##") > 0)
            {
                line = line.Replace("  ", " ");
                line = line.Replace("##", "#");

            }

            return line;
        }

        /// <summary>
        /// The CleanAndOrganizeContent
        /// </summary>
        /// <param name="content">The content<see cref="string"/></param>
        /// <returns>The <see cref="List{string}"/></returns>
        public List<string> CleanAndOrganizeContent(string content)
        {

            string[] employeesArray = content.Split(
                new[] { "\r\n", "\r", "\n" },
            StringSplitOptions.None
            );

            List<string> employeesList = new List<string>();

            foreach (string l in employeesArray)
            {
                string cleanInput = FindAndReplaceTabsAndSpaces(l);
                employeesList.Add(cleanInput);

            }

            return employeesList;
        }

        /// <summary>
        /// The ConnectToFTPAndGetContent
        /// </summary>
        /// <param name="listOfLinks">The listOfLinks<see cref="List{string}"/></param>
        /// <returns>The <see cref="List{string}"/></returns>
        public List<string> ConnectToFTPAndGetContent(List<string> listOfLinks, string ftpPassword)
        {

            string textfileContent = "";
            int counter = 0;
            List<string> returnList = new List<string>();
            List<string> tempList = new List<string>();

            foreach (string link in listOfLinks)
            {

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(link);

                request.KeepAlive = true;
                request.UsePassive = true;
                request.UseBinary = true;
                request.Method = WebRequestMethods.Ftp.DownloadFile;

                string username = "";
                string password = ftpPassword;

                request.Credentials = new NetworkCredential(username, password);
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();

                //TODO: write something that will prevent it from connecting every time - like response.statuscode('not ok'), etc.

                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);
                textfileContent = reader.ReadToEnd();

                tempList = CleanAndOrganizeContent(textfileContent);
                counter++;

                if (counter == listOfLinks.Count)
                {
                    reader.Close();
                    response.Close();
                    responseStream.Close();

                }

                foreach (string item in tempList)
                {
                    if (item != "" && !item.Contains("#Userid") && !returnList.Contains(item))
                    {
                        returnList.Add(item + link);
                    }
                }
            }

            return returnList;
        }

        /// <summary>
        /// The search_textbox_TextChanged
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void search_textbox_TextChanged(object sender, EventArgs e)
        {
            var searchResults = _listOfEmployees.Where(c => c.GCID.Contains(search_textbox.Text));
            List<Employee> searchResultsList = searchResults.ToList();
            displayEmployeeData.Rows.Clear();

            foreach (Employee employee in searchResultsList)
            {
                FillDataGridView(employee);
            }

        }

        /// <summary>
        /// The exportToExcel_btn_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void exportToExcel_btn_Click(object sender, EventArgs e)
        {

            DataTable tableForExport = ExportToExcel();
            CreateSpredsheetWorkBook();

        }

        public DataTable ExportToExcel()
        {

            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("GCID", typeof(string));
            table.Columns.Add("First name", typeof(string));
            table.Columns.Add("Last name", typeof(string));
            table.Columns.Add("Active", typeof(string));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("Employment ended", typeof(string));
            table.Columns.Add("Employment status", typeof(string));
            table.Columns.Add("Original hire date", typeof(string));
            table.Columns.Add("Last hire date", typeof(string));
            table.Columns.Add("Legal entity ID", typeof(string));
            table.Columns.Add("Location ID", typeof(string));
            table.Columns.Add("Organisation ID", typeof(string));
            table.Columns.Add("Role ID", typeof(string));
            table.Columns.Add("Required approval", typeof(string));
            table.Columns.Add("Trainer ambition", typeof(string));

            foreach (Employee employee in _listOfEmployees)
            {
                table.Rows.Add(employee.GCID, employee.FirstName, employee.LastName, employee.Active, employee.Email, employee.EmploymentEnded, employee.EmploymentStatus, employee.OriginalHireDate, employee.LastHireDate, employee.LegalEntityId, employee.LocationId, employee.OrganisationId, employee.RoleId, employee.RequiredApproval, employee.TrainerAmbition);
            }

            return table;

        }

        /// <summary>
        /// The CreateSpredsheetWorkBook
        /// </summary>
        /// <param name="filePath">The filePath<see cref="string"/></param>
        public void CreateSpredsheetWorkBook()
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workBook;
            Microsoft.Office.Interop.Excel.Worksheet workSheet;
            Microsoft.Office.Interop.Excel.Range cellRange;

            excel = new Microsoft.Office.Interop.Excel.Application();

            workBook = excel.Workbooks.Add(Type.Missing);

            workSheet = (Microsoft.Office.Interop.Excel.Worksheet)workBook.ActiveSheet;
            workSheet.Name = "Selected table | FTP Assistant";

            int rowCount = 2;

            foreach (DataRow datarow in ExportToExcel().Rows)
            {
                rowCount += 1;
                for (int i = 1; i <= ExportToExcel().Columns.Count; i++)
                {

                    if (rowCount == 3)
                    {
                        workSheet.Cells[2, i] = ExportToExcel().Columns[i - 1].ColumnName;
                        workSheet.Cells.Font.Color = System.Drawing.Color.Black;

                    }

                    workSheet.Cells[rowCount, i] = datarow[i - 1].ToString();

                    if (rowCount > 3)
                    {
                        if (i == ExportToExcel().Columns.Count)
                        {
                            if (rowCount % 2 == 0)
                            {
                                cellRange = workSheet.Range[workSheet.Cells[rowCount, 1], workSheet.Cells[rowCount, ExportToExcel().Columns.Count]];
                            }

                        }
                    }

                }

            }

            cellRange = workSheet.Range[workSheet.Cells[1, 1], workSheet.Cells[rowCount, ExportToExcel().Columns.Count]];
            cellRange.EntireColumn.AutoFit();
            Microsoft.Office.Interop.Excel.Borders border = cellRange.Borders;
            border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            border.Weight = 2d;

            cellRange = workSheet.Range[workSheet.Cells[1, 1], workSheet.Cells[2, ExportToExcel().Columns.Count]];

            //Directory.CreateDirectory(@"C:\Desktop\");
            workBook.SaveAs("Exported users from FTP", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
            workBook.Close();
            excel.Quit();

        }

        /// <summary>
        /// The displayEmployeeData_CellContentClick
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="DataGridViewCellEventArgs"/></param>
        private void displayEmployeeData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = new DataGridViewRow();
            List<Employee> listOfFoundEmployees = new List<Employee>();

            int rowIndex = e.RowIndex;

            //makes user unable to select rims but only cells inside grid
            if(rowIndex > -1) { 
                selectedRow = displayEmployeeData.Rows[rowIndex];

                string pulledGCID = selectedRow.Cells[0].Value.ToString();
        
                var foundEmployee = _listOfEmployees.Where(c => c.GCID.Equals(pulledGCID));

                listOfFoundEmployees = foundEmployee.ToList();

                displayEmployeeDataInTextboxes(listOfFoundEmployees);

            }
        }
        
        //TODO: create a dynamic login page

        /// <summary>
        /// The displayEmployeeDataInTextboxes
        /// </summary>
        /// <param name="employee">The employee<see cref="Employee"/></param>
        private void displayEmployeeDataInTextboxes(List<Employee> employees)
        {

            foreach (Employee employee in employees) {

                nameAndCgidTextbox.Text = employee.FirstName + " " + employee.LastName + " (" + employee.GCID + ")";
                managerIdTextbox.Text = employee.ManagerId;
                countryCodeTextbox.Text = employee.CountryCode;
                emailTextbox.Text = employee.Email;
                employmentEndedTextbox.Text = employee.EmploymentEnded;
                employmentStatusTextbox.Text = employee.EmploymentStatus;
                originalHireDateTextbox.Text = employee.OriginalHireDate;
                lastHireDateTextbox.Text = employee.LastHireDate;
                leganEntityIdTextbox.Text = employee.LegalEntityId;
                locationIdTextbox.Text = employee.LocationId;
                organisationIdTextbox.Text = employee.OrganisationId;
                roleIdTextbox.Text = employee.RoleId;
                requiredApprovalTextbox.Text = employee.RequiredApproval;
                trainerAmbitionTextbox.Text = employee.TrainerAmbition;
                linkToFileTextbox.Text = employee.LinkToFile;

            }
        }

        private void copyLinkToClipboardButton_Click(object sender, EventArgs e)
        {
            if (linkToFileTextbox.Text != "")
            {
                Clipboard.SetText(linkToFileTextbox.Text);
                MessageBox.Show("Link copied!");
            }
            else
                MessageBox.Show("Textbox is empty");


        }

        private void productionEnvironmentRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (productionEnvironmentRadioBtn.Checked)
                stageEnviromentRadioBtn.Checked = false;

        }

    }
}
