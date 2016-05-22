namespace StudentManage.Common
{
    /// <summary>
    ///  Status of record
    ///  Inactive, Active and Deleted
    /// </summary>
    public enum Status
    {
        Active = 0,
        InActive = -1,
        Deleted = -2
    }

    /// <summary>
    /// Gender
    /// </summary>
    public enum Gender
    {
        Male = 0,
        Female = 1
    }

    public enum RoleLevel
    {
        Adminstrator = 0,

        Education_Staff = 1,

        Principal = 2,

        Teacher = 3,

        Student = 4
    }
}