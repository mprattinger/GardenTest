namespace GardenTest
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnManuell = new Button();
            label2 = new Label();
            lblWaterState = new Label();
            cbWaterLevel = new CheckBox();
            label1 = new Label();
            lblState = new Label();
            cbPump = new CheckBox();
            btnWerfer = new Button();
            btnSprueher = new Button();
            btnTropfer = new Button();
            cbWerfer = new CheckBox();
            cbVent = new CheckBox();
            cbSprueher = new CheckBox();
            cbTropfer = new CheckBox();
            SuspendLayout();
            // 
            // btnManuell
            // 
            btnManuell.Location = new Point(12, 12);
            btnManuell.Name = "btnManuell";
            btnManuell.Size = new Size(149, 23);
            btnManuell.TabIndex = 2;
            btnManuell.Text = "Toggle Manuell";
            btnManuell.UseVisualStyleBackColor = true;
            btnManuell.Click += btnManuell_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(662, 24);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 7;
            label2.Text = "Current WaterState";
            // 
            // lblWaterState
            // 
            lblWaterState.AutoSize = true;
            lblWaterState.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblWaterState.Location = new Point(662, 39);
            lblWaterState.Name = "lblWaterState";
            lblWaterState.Size = new Size(126, 30);
            lblWaterState.TabIndex = 6;
            lblWaterState.Text = "UNKNOWN";
            // 
            // cbWaterLevel
            // 
            cbWaterLevel.AutoSize = true;
            cbWaterLevel.Location = new Point(542, 185);
            cbWaterLevel.Name = "cbWaterLevel";
            cbWaterLevel.Size = new Size(87, 19);
            cbWaterLevel.TabIndex = 8;
            cbWaterLevel.Text = "Water Level";
            cbWaterLevel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(493, 24);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 10;
            label1.Text = "Current State";
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblState.Location = new Point(493, 39);
            lblState.Name = "lblState";
            lblState.Size = new Size(126, 30);
            lblState.TabIndex = 9;
            lblState.Text = "UNKNOWN";
            // 
            // cbPump
            // 
            cbPump.AutoSize = true;
            cbPump.Enabled = false;
            cbPump.Location = new Point(542, 210);
            cbPump.Name = "cbPump";
            cbPump.Size = new Size(77, 19);
            cbPump.TabIndex = 11;
            cbPump.Text = "Pump On";
            cbPump.UseVisualStyleBackColor = true;
            // 
            // btnWerfer
            // 
            btnWerfer.Location = new Point(12, 41);
            btnWerfer.Name = "btnWerfer";
            btnWerfer.Size = new Size(149, 23);
            btnWerfer.TabIndex = 14;
            btnWerfer.Text = "Toggle Werfer";
            btnWerfer.UseVisualStyleBackColor = true;
            btnWerfer.Click += btnWerfer_Click;
            // 
            // btnSprueher
            // 
            btnSprueher.Location = new Point(12, 70);
            btnSprueher.Name = "btnSprueher";
            btnSprueher.Size = new Size(149, 23);
            btnSprueher.TabIndex = 13;
            btnSprueher.Text = "Toggle Sprueher";
            btnSprueher.UseVisualStyleBackColor = true;
            btnSprueher.Click += btnSprueher_Click;
            // 
            // btnTropfer
            // 
            btnTropfer.Location = new Point(12, 99);
            btnTropfer.Name = "btnTropfer";
            btnTropfer.Size = new Size(149, 23);
            btnTropfer.TabIndex = 12;
            btnTropfer.Text = "Toggle Tropfer";
            btnTropfer.UseVisualStyleBackColor = true;
            btnTropfer.Click += btnTropfer_Click;
            // 
            // cbWerfer
            // 
            cbWerfer.AutoSize = true;
            cbWerfer.Enabled = false;
            cbWerfer.Location = new Point(408, 185);
            cbWerfer.Name = "cbWerfer";
            cbWerfer.Size = new Size(106, 19);
            cbWerfer.TabIndex = 16;
            cbWerfer.Text = "Werfer Vent On";
            cbWerfer.UseVisualStyleBackColor = true;
            // 
            // cbVent
            // 
            cbVent.AutoSize = true;
            cbVent.Location = new Point(542, 235);
            cbVent.Name = "cbVent";
            cbVent.Size = new Size(55, 19);
            cbVent.TabIndex = 15;
            cbVent.Text = "Ventil";
            cbVent.UseVisualStyleBackColor = true;
            // 
            // cbSprueher
            // 
            cbSprueher.AutoSize = true;
            cbSprueher.Enabled = false;
            cbSprueher.Location = new Point(408, 210);
            cbSprueher.Name = "cbSprueher";
            cbSprueher.Size = new Size(112, 19);
            cbSprueher.TabIndex = 17;
            cbSprueher.Text = "Sprüher Vent On";
            cbSprueher.UseVisualStyleBackColor = true;
            // 
            // cbTropfer
            // 
            cbTropfer.AutoSize = true;
            cbTropfer.Enabled = false;
            cbTropfer.Location = new Point(408, 235);
            cbTropfer.Name = "cbTropfer";
            cbTropfer.Size = new Size(108, 19);
            cbTropfer.TabIndex = 18;
            cbTropfer.Text = "Tropfer Vent On";
            cbTropfer.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbTropfer);
            Controls.Add(cbSprueher);
            Controls.Add(cbWerfer);
            Controls.Add(cbVent);
            Controls.Add(btnWerfer);
            Controls.Add(btnSprueher);
            Controls.Add(btnTropfer);
            Controls.Add(cbPump);
            Controls.Add(label1);
            Controls.Add(lblState);
            Controls.Add(cbWaterLevel);
            Controls.Add(label2);
            Controls.Add(lblWaterState);
            Controls.Add(btnManuell);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnManuell;
        private Label label2;
        private Label lblWaterState;
        private CheckBox cbWaterLevel;
        private Label label1;
        private Label lblState;
        private CheckBox cbPump;
        private Button btnWerfer;
        private Button btnSprueher;
        private Button btnTropfer;
        private CheckBox cbWerfer;
        private CheckBox cbVent;
        private CheckBox cbSprueher;
        private CheckBox cbTropfer;
    }
}