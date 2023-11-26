using Laba6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Laba6.Tasks
{
    /// <summary>
    /// Interaction logic for Task7.xaml
    /// </summary>
    public partial class Task7 : Page
    {
        CustomOperatingSystem os = new CustomOperatingSystem();
        MobileApp app = new MobileApp();

        public Task7()
        {
            InitializeComponent();

            OSInstallButton.Click += (obj, e) => os.Install();
            OSUpdateButton.Click += (obj, e) => os.Update(OS_Result);
            OSWriteCodeButton.Click += (obj, e) => os.WriteCode();
            OSTestCodeButton.Click += (obj, e) => os.TestCode();
            OSRebootSystemButton.Click += (obj, e) => os.RebootSystem();
            OSAddUserButton.Click += (obj, e) => os.AddUserToTheSystem();

            MobileInstallButton.Click += (obj, e) => app.Install();
            MobileUpdateButton.Click += (obj, e) => app.Update(Mobile_Result);
            MobileWriteCodeButton.Click += (obj, e) => app.WriteCode();
            MobileTestCodeButton.Click += (obj, e) => app.TestCode();
            MobileTurnOnSecretChinaSpyCameraButton.Click += (obj, e) => app.TurnOnSecretChinaSpyCamera();
            MobileEnableRootAccessButton.Click += (obj, e) => app.EnableRootAccess();

            OS_Result.Content = os.ToString();
            Mobile_Result.Content = app.ToString();
        }


    }
}
