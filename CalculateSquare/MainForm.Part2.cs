using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSquare
{
    public partial class MainForm
    {
        private void InitializeControls()
        {
            lblMessage = new Label
            {
                Location = new Point(36, 46),
                AutoSize = true
            };
            Controls.Add(lblMessage);

            // Usar el método de extensión
            lblMessage.SetFormattedText("Number:");

            txtInput = new TextBox
            {
                Location = new Point(125, 43)
            };
            Controls.Add(txtInput);
            btnCalculateSquare = new Button
            {
                Size = new Size(158, 42),
                Location = new Point(36, 110)
            };
            Controls.Add(btnCalculateSquare);
            btnCalculateSquare.SetFormattedText("Calculate Square");

            // Aplicar un estado al botón
            SetButtonState(ButtonState.Enabled);
            btnCalculateSquare.Click += btnCalculateSquare_Click;
        }

        private void btnCalculateSquare_Click(object? sender, 
            EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int number))
            {
                int result = MathHelper.Square(number);
                MessageBox.Show($"The square of {number} is {result}");
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void SetButtonState(ButtonState state)
        {
            switch (state)
            {
                case ButtonState.Enabled:
                    btnCalculateSquare.Enabled = true;
                    btnCalculateSquare.Visible = true;
                    break;
                case ButtonState.Disabled:
                    btnCalculateSquare.Enabled = false;
                    btnCalculateSquare.Visible = true;
                    break;
                case ButtonState.Hidden:
                    btnCalculateSquare.Visible = false;
                    break;
            }
        }
    }
}
