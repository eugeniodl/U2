using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateSquare
{
    public partial class MainForm : Form
    {
        private Label lblMessage;
        private Button btnCalculateSquare;
        private TextBox txtInput;

        public enum ButtonState
        {
            Enabled,
            Disabled,
            Hidden
        }

        public MainForm()
        {
            InitializeComponent();

            // Aplicar configuraciones
            BackColor = Color.FromName(AppSettings.ThemeColor);
            Font = new Font(Font.FontFamily, AppSettings.Fontsize);

            InitializeControls();
        }

    }
}
