using ManagerStudentApp.GUI.TreeControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerStudentApp.GUI.UserControls
{
    public class UserControlFactory
    {
        public static UserControl GetUserControl(ControlAction action)
        {
            UserControl userControl = null;
            switch (action)
            {
                case ControlAction.CHANGE_MAIL:
                    userControl = new ChangeMailUserControl();
                    break;
                case ControlAction.CHANGE_PASSWORD:
                    userControl = new ChangePasswordUserControl();
                    break;
                case ControlAction.ADD_ACCOUNT:
                    userControl = new AddAccountUserControl();
                    break;
                case ControlAction.LIST_ACCOUNT:
                    userControl = new ListAccountUserControl();
                    break;
                case ControlAction.ADD_STUDENT:
                    userControl = new AddStudentUserControl();
                    break;
                case ControlAction.MANAGE_STUDENT:
                    userControl = new ListStudentUserControl();
                    break;
                case ControlAction.ADD_CLASS:
                    userControl = new AddClassUserControl();
                    break;
                case ControlAction.CHANGE_CLASS:
                    userControl = new ChangeClassUserControl();
                    break;
                case ControlAction.LIST_CLASS:
                    userControl = new ListClassUserControl();
                    break;
                case ControlAction.ADD_SUBJECT:
                    userControl = new AddSubjectUserControl();
                    break;
                case ControlAction.LIST_SUBJECT:
                    userControl = new ListSubjectUserControl();
                    break;
                case ControlAction.ADD_SCORE:
                    userControl = new AddScoreUserControl();
                    break;
                case ControlAction.LIST_SCORE:
                    userControl = new ListScoreUserControl();
                    break;
                case ControlAction.ADD_REPORT_SUBJECT:
                    userControl = new AddReportSubjectUserControl();
                    break;
                case ControlAction.ADD_REPORT_SEMESTER:
                    userControl = new AddReportSemsterUserControl();
                    break;
                case ControlAction.LIST_REPORT:
                    userControl = new ListReportUserControl();
                    break;
                case ControlAction.SETTING:
                    userControl = new SettingUserControl();
                    break;
            }
            if (userControl != null)
            {
                userControl.AutoSize = true;
            }
            return userControl;
        }
    }
}
