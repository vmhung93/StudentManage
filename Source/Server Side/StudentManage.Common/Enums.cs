using System.ComponentModel;

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

    /// <summary>
    /// User role level
    /// </summary>
    public enum RoleLevel
    {
        Adminstrator = 5,

        Education_Staff = 4,

        Principal = 3,

        Teacher = 2,

        Student = 1
    }

    /// <summary>
    /// System configuration
    /// </summary>
    public enum SystemConfigEnum
    {
        [Description("MinAge")]
        MinAge,

        [Description("MaxAge")]
        MaxAge,

        [Description("MaxNumberInClass")]
        MaxNumberInClass,

        [Description("PassScore")]
        PassScore
    }
}