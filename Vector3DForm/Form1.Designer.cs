namespace Vector3DForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtV1X = new TextBox();
            txtV1Y = new TextBox();
            txtV1Z = new TextBox();
            txtV2Z = new TextBox();
            txtV2Y = new TextBox();
            txtV2X = new TextBox();
            btnSumar = new Button();
            btnProductoEscalar = new Button();
            lblResultado = new Label();
            groupBox1 = new GroupBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(202, 19);
            label1.Name = "label1";
            label1.Size = new Size(126, 32);
            label1.TabIndex = 0;
            label1.Text = "Vector 3D";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(81, 132);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 1;
            label2.Text = "Vector 1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(81, 184);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 2;
            label3.Text = "Vector 2:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(228, 84);
            label4.Name = "label4";
            label4.Size = new Size(20, 21);
            label4.TabIndex = 3;
            label4.Text = "X";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(351, 84);
            label5.Name = "label5";
            label5.Size = new Size(20, 21);
            label5.TabIndex = 4;
            label5.Text = "Y";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(474, 84);
            label6.Name = "label6";
            label6.Size = new Size(20, 21);
            label6.TabIndex = 5;
            label6.Text = "Z";
            // 
            // txtV1X
            // 
            txtV1X.Location = new Point(218, 129);
            txtV1X.Name = "txtV1X";
            txtV1X.Size = new Size(38, 23);
            txtV1X.TabIndex = 6;
            // 
            // txtV1Y
            // 
            txtV1Y.Location = new Point(341, 129);
            txtV1Y.Name = "txtV1Y";
            txtV1Y.Size = new Size(38, 23);
            txtV1Y.TabIndex = 7;
            // 
            // txtV1Z
            // 
            txtV1Z.Location = new Point(464, 129);
            txtV1Z.Name = "txtV1Z";
            txtV1Z.Size = new Size(38, 23);
            txtV1Z.TabIndex = 8;
            // 
            // txtV2Z
            // 
            txtV2Z.Location = new Point(464, 181);
            txtV2Z.Name = "txtV2Z";
            txtV2Z.Size = new Size(38, 23);
            txtV2Z.TabIndex = 11;
            // 
            // txtV2Y
            // 
            txtV2Y.Location = new Point(341, 181);
            txtV2Y.Name = "txtV2Y";
            txtV2Y.Size = new Size(38, 23);
            txtV2Y.TabIndex = 10;
            // 
            // txtV2X
            // 
            txtV2X.Location = new Point(218, 181);
            txtV2X.Name = "txtV2X";
            txtV2X.Size = new Size(38, 23);
            txtV2X.TabIndex = 9;
            // 
            // btnSumar
            // 
            btnSumar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSumar.Location = new Point(81, 260);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(142, 42);
            btnSumar.TabIndex = 12;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // btnProductoEscalar
            // 
            btnProductoEscalar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnProductoEscalar.Location = new Point(81, 322);
            btnProductoEscalar.Name = "btnProductoEscalar";
            btnProductoEscalar.Size = new Size(142, 42);
            btnProductoEscalar.TabIndex = 13;
            btnProductoEscalar.Text = "Producto escalar";
            btnProductoEscalar.UseVisualStyleBackColor = true;
            btnProductoEscalar.Click += btnProductoEscalar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.Location = new Point(309, 293);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(57, 21);
            lblResultado.TabIndex = 14;
            lblResultado.Text = "label7";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(398, 236);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 415);
            Controls.Add(groupBox1);
            Controls.Add(lblResultado);
            Controls.Add(btnProductoEscalar);
            Controls.Add(btnSumar);
            Controls.Add(txtV2Z);
            Controls.Add(txtV2Y);
            Controls.Add(txtV2X);
            Controls.Add(txtV1Z);
            Controls.Add(txtV1Y);
            Controls.Add(txtV1X);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtV1X;
        private TextBox txtV1Y;
        private TextBox txtV1Z;
        private TextBox txtV2Z;
        private TextBox txtV2Y;
        private TextBox txtV2X;
        private Button btnSumar;
        private Button btnProductoEscalar;
        private Label lblResultado;
        private GroupBox groupBox1;
    }
}