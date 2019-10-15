namespace FTP_Assistant
{
    /// <summary>
    /// Defines the <see cref="Employee" />
    /// </summary>
    public class Employee
    {

        public int LocalId { get; set; }
        /// <summary>
        /// Gets or sets the GCID
        /// </summary>
        public string GCID { get; set; }

        //public string Data { get; set; }
        /// <summary>
        /// Gets or sets the Active
        /// </summary>
        public string Active { get; set; }

        /// <summary>
        /// Gets or sets the FirstName
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the LastName
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the CountryCode
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the RequiredApproval
        /// </summary>
        public string RequiredApproval { get; set; }

        /// <summary>
        /// Gets or sets the LastHireDate
        /// </summary>
        public string LastHireDate { get; set; }

        /// <summary>
        /// Gets or sets the OriginalHireDate
        /// </summary>
        public string OriginalHireDate { get; set; }

        /// <summary>
        /// Gets or sets the EmploymentEnded
        /// </summary>
        public string EmploymentEnded { get; set; }

        /// <summary>
        /// Gets or sets the ManagerId
        /// </summary>
        public string ManagerId { get; set; }

        /// <summary>
        /// Gets or sets the TrainerAmbition
        /// </summary>
        public string TrainerAmbition { get; set; }

        /// <summary>
        /// Gets or sets the OrganisationId
        /// </summary>
        public string OrganisationId { get; set; }

        /// <summary>
        /// Gets or sets the RoleId
        /// </summary>
        public string RoleId { get; set; }

        /// <summary>
        /// Gets or sets the LocationId
        /// </summary>
        public string LocationId { get; set; }

        /// <summary>
        /// Gets or sets the LegalEntityId
        /// </summary>
        public string LegalEntityId { get; set; }

        /// <summary>
        /// Gets or sets the UserType
        /// </summary>
        public string UserType { get; set; }

        /// <summary>
        /// Gets or sets the EmploymentStatus
        /// </summary>
        public string EmploymentStatus { get; set; }

        public string LinkToFile { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        /// <param name="gCID">The gCID<see cref="string"/></param>
        /// <param name="active">The active<see cref="string"/></param>
        /// <param name="firstName">The firstName<see cref="string"/></param>
        /// <param name="lastName">The lastName<see cref="string"/></param>
        /// <param name="email">The email<see cref="string"/></param>
        /// <param name="countryCode">The countryCode<see cref="string"/></param>
        /// <param name="requiredApproval">The requiredApproval<see cref="string"/></param>
        /// <param name="lastHireDate">The lastHireDate<see cref="string"/></param>
        /// <param name="originalHireDate">The originalHireDate<see cref="string"/></param>
        /// <param name="managerId">The managerId<see cref="string"/></param>
        /// <param name="employmentEnded">The employmentEnded<see cref="string"/></param>
        /// <param name="trainerAmbition">The trainerAmbition<see cref="string"/></param>
        /// <param name="organisationId">The organisationId<see cref="string"/></param>
        /// <param name="roleId">The roleId<see cref="string"/></param>
        /// <param name="locationId">The locationId<see cref="string"/></param>
        /// <param name="legalEntityId">The legalEntityId<see cref="string"/></param>
        /// <param name="userType">The userType<see cref="string"/></param>
        /// <param name="employmentStatus">The employmentStatus<see cref="string"/></param>
        public Employee(int localId, string gCID, string active, string firstName, string lastName, string email, string countryCode, string requiredApproval, string lastHireDate, string originalHireDate, string managerId, string employmentEnded, string trainerAmbition, string organisationId, string roleId, string locationId, string legalEntityId, string userType, string employmentStatus, string linkToFile)
        {
            LocalId = localId;
            GCID = gCID;
            Active = active;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            CountryCode = countryCode;
            RequiredApproval = requiredApproval;
            LastHireDate = lastHireDate;
            OriginalHireDate = originalHireDate;
            ManagerId = managerId;
            EmploymentEnded = employmentEnded;
            TrainerAmbition = trainerAmbition;
            OrganisationId = organisationId;
            RoleId = roleId;
            LocationId = locationId;
            LegalEntityId = legalEntityId;
            UserType = userType;
            EmploymentStatus = employmentStatus;
            LinkToFile = linkToFile;
        }
    }

    public class DateStringFromDirectory
    {
        public string Content { get; set; }
        public string Date { get; set; }

        public DateStringFromDirectory(string content, string date )
        {
            Content = content;
            Date = date;
        }
    }
}
