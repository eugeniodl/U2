﻿using System;
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
            lblMessage = new Label()
            {
                Location = new Point(36, 46),
                AutoSize = true
            };
            Controls.Add(lblMessage);
            // Usar el método de extensión
            lblMessage.SetFormattedText("Number:");

            txtInput = new TextBox()
            {
                Size = new Size(200, 60),
                Location = new Point(200, 43)
            };
            Controls.Add(txtInput);
            btnCalculateSquare = new Button()
            {
                Size = new Size(300, 60),
                Location = new Point(36, 110)
            };
            Controls.Add(btnCalculateSquare);
            btnCalculateSquare.SetFormattedText("Calculate Square");

            // Aplicar un estado al botón
            SetButtonState(ButtonState.Enabled);

            btnCalculateSquare.Click += btnCalculateSquare_Click;
        }

        private void btnCalculateSquare_Click(object? sender, EventArgs e)
        {
            
        }

        private void SetButtonState(ButtonState state)
        {
            switch(state)
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
