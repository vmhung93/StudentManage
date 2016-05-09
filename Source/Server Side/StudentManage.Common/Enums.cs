namespace StudentManage.Common
{
    /// <summary>
    ///  Status of record
    ///  Inactive, Active and Deleted
    /// </summary>
    public enum Status
    {
        InActive = 0,
        Active = 1,
        Deleted = -1
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

        Principal = 1,

        // Giáo vụ
        Teacher = 3,

        Student = 4
    }
}