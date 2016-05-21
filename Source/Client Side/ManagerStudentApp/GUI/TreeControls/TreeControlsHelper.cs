using ManagerStudentLib.Authentication;
using ManagerStudentApp.GUI.TabControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ManagerStudentApp.GUI.TreeControls
{
    public enum ControlAction {
        NONE,
        [Description("Thay đổi mail")]              CHANGE_MAIL,
        [Description("Thay đổi mật khẩu")]          CHANGE_PASSWORD,
        [Description("Thêm tài khoản")]             ADD_ACCOUNT,
        [Description("Danh sách các tài khoản")]    LIST_ACCOUNT,
        [Description("Thêm mới học sinh")]          ADD_STUDENT,
        [Description("Tra cứu thông tin học sinh")] MANAGE_STUDENT,
        [Description("Thành lập lớp")]              ADD_CLASS,
        [Description("Danh sách các lớp")]          LIST_CLASS,
        [Description("Thêm môn học")]               ADD_SUBJECT,
        [Description("Danh sách các môn học")]      LIST_SUBJECT,
        [Description("Lập bảng điểm")]              ADD_SCORE,
        [Description("Danh sách bảng điểm")]        LIST_SCORE,
        [Description("Lập báo cáo môn học")]        ADD_REPORT_SUBJECT,
        [Description("Lập báo cáo học kỳ")]         ADD_REPORT_SEMESTER,
        [Description("Danh sách các báo cáo")]      LIST_REPORT,
        [Description("Quy định")]                   SETTING
    }
    public class TreeControlsHelper
    {
        private Dictionary<TreeRootId, TreeNodeControl> dicNodes;
        private static TreeControlsHelper instance;
        private TreeView treeView;
        //singleton
        public static TreeControlsHelper GetInstance()
        {
            if (instance == null)
            {
                instance = new TreeControlsHelper();
            }
            return instance;
        }

        private TreeControlsHelper() {
            dicNodes = new Dictionary<TreeRootId, TreeNodeControl>();
        }

        private void InitImages(ImageList imageList)
        {
            imageList.Images.Clear();
            imageList.Images.Add("userInfo", Properties.Resources.userInfo);
            imageList.Images.Add("password", Properties.Resources.password);
            imageList.Images.Add("email", Properties.Resources.email);
            imageList.Images.Add("student", Properties.Resources.student);
            imageList.Images.Add("account", Properties.Resources.account);
            imageList.Images.Add("adduser", Properties.Resources.adduser);
            imageList.Images.Add("class", Properties.Resources._class);
            imageList.Images.Add("list", Properties.Resources.list);
            imageList.Images.Add("plus", Properties.Resources.plus);
            imageList.Images.Add("report", Properties.Resources.report);
            imageList.Images.Add("score", Properties.Resources.score);
            imageList.Images.Add("subject", Properties.Resources.subject);
            imageList.Images.Add("settings", Properties.Resources.settings);
        }

        public void BuildTreeNodeControls(TreeView treeView, ImageList imageList)
        {
            var userRole = AuthenticationService.GetInstance().GetCurrentUser().Role;
            this.treeView = treeView;
            InitImages(imageList);
            treeView.ImageList = imageList;
            BuildInfoTreeNode(dicNodes);
            if (userRole >= UserRole.STUDENT)
            {
                BuildStudentTreeNode(dicNodes);
            }
            if (userRole >= UserRole.TEACHER)
            {
                BuildTeacherTreeNode(dicNodes);
            }
            if (userRole >= UserRole.PRINCIPAL)
            {
                BuildPrincipalTreeNode(dicNodes);
            }
            if (userRole >= UserRole.EDUCATION_STAFF)
            {
                BuildEducationStaffTreeNode(dicNodes);
            }
            if (userRole == UserRole.ADMINSTRATOR)
            {
                BuildAdminstratorTreeNode(dicNodes);
            }

            var nodes = dicNodes.Values.ToList<TreeNodeControl>();
            var nodeGUIs = new List<TreeNode>();
            foreach (TreeNodeControl control in nodes) {
                nodeGUIs.Add(control);
            }
            AddEventExpandChilds(treeView);
            treeView.Nodes.AddRange(nodeGUIs.ToArray());
        }

        private  void AddEventExpandChilds(TreeView treeView)
        {
            treeView.AfterSelect += new TreeViewEventHandler(this.TreeNodeAfterSelect);
        }

        private void TreeNodeAfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node is TreeNodeControl)
            {
                var nodeControl = (TreeNodeControl)e.Node;
                if (nodeControl.GetAction() == ControlAction.NONE)
                {
                    nodeControl.ExpandAll();
                }
                else
                {
                    TabControlsHelper.GetInstance().SelectTab(nodeControl.GetAction());
                }

            }
        }

        private void BuildInfoTreeNode(Dictionary<TreeRootId, TreeNodeControl> dicNodes)
        {
            var infoNode = new TreeNodeControl("Thông tin cá nhân", 0, 0, null);
            var childNode = new TreeNodeControl(GetActionValue(ControlAction.CHANGE_MAIL), 2, 2, infoNode).SetAction(ControlAction.CHANGE_MAIL);
            childNode = new TreeNodeControl(GetActionValue(ControlAction.CHANGE_PASSWORD), 1, 1, infoNode).SetAction(ControlAction.CHANGE_PASSWORD);
            dicNodes.Add(TreeRootId.INFO, infoNode);
        }

        private  void BuildAdminstratorTreeNode(Dictionary<TreeRootId, TreeNodeControl> dicNodes)
        {
            TreeNodeControl node;
            if (dicNodes.TryGetValue(TreeRootId.ACCOUNT, out node))
            {
                var childNode = new TreeNodeControl(GetActionValue(ControlAction.ADD_ACCOUNT), 8, 8, node).SetAction(ControlAction.ADD_ACCOUNT);
            }
        }

        private  void BuildPrincipalTreeNode(Dictionary<TreeRootId, TreeNodeControl> dicNodes)
        {
            var accountNode = new TreeNodeControl("Tài khoản", 4, 4, null);
            var childNode = new TreeNodeControl(GetActionValue(ControlAction.LIST_ACCOUNT), 7, 7, accountNode).SetAction(ControlAction.LIST_ACCOUNT);
            dicNodes.Add(TreeRootId.ACCOUNT, accountNode);
        }

        private  void BuildEducationStaffTreeNode(Dictionary<TreeRootId, TreeNodeControl> dicNodes)
        {
            TreeNodeControl node;
            if (dicNodes.TryGetValue(TreeRootId.STUDENT,out node)) {
                var childNode = new TreeNodeControl(GetActionValue(ControlAction.ADD_STUDENT), 8, 8, node).SetAction(ControlAction.ADD_STUDENT);
            }

            if (dicNodes.TryGetValue(TreeRootId.CLASS, out node))
            {
                var childNode = new TreeNodeControl(GetActionValue(ControlAction.ADD_CLASS), 8, 8, node).SetAction(ControlAction.ADD_CLASS);
            }
            if (dicNodes.TryGetValue(TreeRootId.SUBJECT, out node))
            {
                var childNode = new TreeNodeControl(GetActionValue(ControlAction.ADD_SUBJECT), 8, 8, node).SetAction(ControlAction.ADD_SUBJECT);
            }
            if (dicNodes.TryGetValue(TreeRootId.SCORE, out node))
            {
                var childNode = new TreeNodeControl(GetActionValue(ControlAction.ADD_SCORE), 8, 8, node).SetAction(ControlAction.ADD_SCORE);
            }
            if (dicNodes.TryGetValue(TreeRootId.REPORT, out node))
            {
                var childNode = new TreeNodeControl(GetActionValue(ControlAction.ADD_REPORT_SUBJECT), 8, 8, node).SetAction(ControlAction.ADD_REPORT_SUBJECT);
                childNode = new TreeNodeControl(GetActionValue(ControlAction.ADD_REPORT_SEMESTER), 8, 8, node).SetAction(ControlAction.ADD_REPORT_SEMESTER);
            }

            var settingNode = new TreeNodeControl(GetActionValue(ControlAction.SETTING), 12, 12, null).SetAction(ControlAction.SETTING);
            dicNodes.Add(TreeRootId.SETTING, settingNode);
        }

        private  void BuildTeacherTreeNode(Dictionary<TreeRootId, TreeNodeControl> dicNodes)
        {
            var reportNode = new TreeNodeControl("Báo cáo tổng kết", 9, 9, null);
            var childNode = new TreeNodeControl(GetActionValue(ControlAction.LIST_REPORT), 7, 7, reportNode).SetAction(ControlAction.LIST_REPORT);
            dicNodes.Add(TreeRootId.REPORT, reportNode);
        }

        private  void BuildStudentTreeNode(Dictionary<TreeRootId, TreeNodeControl> dicNodes)
        {
            var studentNode = new TreeNodeControl("Học sinh", 3, 3, null);
            var childNode = new TreeNodeControl(GetActionValue(ControlAction.MANAGE_STUDENT), 7, 7, studentNode).SetAction(ControlAction.MANAGE_STUDENT);
            dicNodes.Add(TreeRootId.STUDENT, studentNode);

            var classNode = new TreeNodeControl("Lớp", 6, 6, null);
            childNode = new TreeNodeControl(GetActionValue(ControlAction.LIST_CLASS), 7, 7, classNode).SetAction(ControlAction.LIST_CLASS);
            dicNodes.Add(TreeRootId.CLASS, classNode);

            var subjectNode = new TreeNodeControl("Môn học", 11, 11, null);
            childNode = new TreeNodeControl(GetActionValue(ControlAction.LIST_SUBJECT), 7, 7, subjectNode).SetAction(ControlAction.LIST_SUBJECT);
            dicNodes.Add(TreeRootId.SUBJECT, subjectNode);

            var scoreNode = new TreeNodeControl("Điểm số", 10, 10, null);
            childNode = new TreeNodeControl(GetActionValue(ControlAction.LIST_SCORE), 7, 7, scoreNode).SetAction(ControlAction.LIST_SCORE);
            dicNodes.Add(TreeRootId.SCORE, scoreNode);
        }

        public static string GetActionValue(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }
    }


}
