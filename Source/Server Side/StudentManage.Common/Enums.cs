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
        [Description("Adminstrator")]
        Adminstrator = 5,

        [Description(@"Giáo vụ")]
        Education_Staff = 4,

        [Description(@"Hiệu trưởng")]
        Principal = 3,

        [Description(@"Giáo viên")]
        Teacher = 2,

        [Description(@"Học sinh")]
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