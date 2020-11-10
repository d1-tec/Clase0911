using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ManageRecipesUserControl : UserControl
    {
        private MainWindow mainWindow;

        public ManageRecipesUserControl(MainWindow mainWindow)
        {
            InitializeComponent();

            this.mainWindow = mainWindow;
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            this.mainWindow.GoTo(MenuOption.MAIN_MENU);
        }
    }
}
