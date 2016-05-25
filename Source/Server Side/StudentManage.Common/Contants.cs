namespace StudentManage.Common
{
    public static class ResponseMessages
    {
        // User
        public static string InitiateDatabaseSuccessfully = "Data was initiated successfully";

        public static string InitiateDatabaseUnSuccessfully = "Data was initiated unsuccessfully";

        public static string CreateDataSuccessfully = "Data was created successfully";

        public static string CreateDataUnsuccessfully = "Data was created unsuccessfully";

        public static string UpdateUnsuccessful = "Update data unsuccessful";

        public static string UpdateSuccessful = "Update data successful";

        public static string GetDataUnsuccessful = "Get data unsuccessful";

        public static string GetDataSuccessful = "Get data successful";

        public static string DeleteUnsuccessful = "Delete data unsuccessful";

        public static string DeleteSuccessful = "Delete data successful";

        public static string NoRecord = "Don't have record in database";

        public static string LogoutSuccessfully = "Logout successfully";

        public static string LogoutUnSuccessfully = "Logout unsuccessfully";

        public static string LoginSuccessfully = "Login successfully";

        public static string LoginInvalidBadgeIdOrPassword = "The badge id/password combination is not valid";

        public static string UpdatePasswordSuccessfully = "Your password was changed successfully";

        public static string UpdatePasswordUnSuccessfully = "Your password was changed unsuccessfully";

        public static string InternalServerError = "Process error";

        public static string EmailAlreadyExist = "This email already exists for another use. Please try another.";

        public static string BadRequest = "All required fields must be completed";

        public static string TokenIsExpired = "The session has timed out.";

        public static string TokenIsInvalid = "Token is invalid";

        public static string RequestSuccessfully = "OK";

        public static string OldPasswordIncorrect = "Old password incorrect";

        public static string PermissionDeclined = "You don't have permission to access this page";
    }
}