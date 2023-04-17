namespace GardenTest
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
            lblCurrentMode = new Label();
            btnManuell = new Button();
            label1 = new Label();
            cbWaterLevel = new CheckBox();
            label2 = new Label();
            lblWaterState = new Label();
            cbValve = new CheckBox();
            cbPump = new CheckBox();
            btnTropfer = new Button();
            btnSprueher = new Button();
            btnWerfer = new Button();
            SuspendLayout();
            // 
            // lblCurrentMode
            // 
            lblCurrentMode.AutoSize = true;
            lblCurrentMode.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrentMode.Location = new Point(12, 46);
            lblCurrentMode.Name = "lblCurrentMode";
            lblCurrentMode.Size = new Size(126, 30);
            lblCurrentMode.TabIndex = 0;
            lblCurrentMode.Text = "UNKNOWN";
            // 
            // btnManuell
            // 
            btnManuell.Location = new Point(639, 16);
            btnManuell.Name = "btnManuell";
            btnManuell.Size = new Size(149, 23);
            btnManuell.TabIndex = 1;
            btnManuell.Text = "Toggle Manuell";
            btnManuell.UseVisualStyleBackColor = true;
            btnManuell.Click += btnManuell_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 2;
            label1.Text = "Current Action";
            // 
            // cbWaterLevel
            // 
            cbWaterLevel.AutoSize = true;
            cbWaterLevel.Location = new Point(489, 57);
            cbWaterLevel.Name = "cbWaterLevel";
            cbWaterLevel.Size = new Size(87, 19);
            cbWaterLevel.TabIndex = 3;
            cbWaterLevel.Text = "Water Level";
            cbWaterLevel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(144, 31);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 5;
            label2.Text = "Current WaterState";
            // 
            // lblWaterState
            // 
            lblWaterState.AutoSize = true;
            lblWaterState.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblWaterState.Location = new Point(144, 46);
            lblWaterState.Name = "lblWaterState";
            lblWaterState.Size = new Size(126, 30);
            lblWaterState.TabIndex = 4;
            lblWaterState.Text = "UNKNOWN";
            // 
            // cbValve
            // 
            cbValve.AutoSize = true;
            cbValve.Enabled = false;
            cbValve.Location = new Point(489, 107);
            cbValve.Name = "cbValve";
            cbValve.Size = new Size(72, 19);
            cbValve.TabIndex = 6;
            cbValve.Text = "Valve On";
            cbValve.UseVisualStyleBackColor = true;
            // 
            // cbPump
            // 
            cbPump.AutoSize = true;
            cbPump.Enabled = false;
            cbPump.Location = new Point(489, 82);
            cbPump.Name = "cbPump";
            cbPump.Size = new Size(77, 19);
            cbPump.TabIndex = 7;
            cbPump.Text = "Pump On";
            cbPump.UseVisualStyleBackColor = true;
            // 
            // btnTropfer
            // 
            btnTropfer.Location = new Point(639, 103);
            btnTropfer.Name = "btnTropfer";
            btnTropfer.Size = new Size(149, 23);
            btnTropfer.TabIndex = 8;
            btnTropfer.Text = "Toggle Tropfer";
            btnTropfer.UseVisualStyleBackColor = true;
            btnTropfer.Click += btnTropfer_Click;
            // 
            // btnSprueher
            // 
            btnSprueher.Location = new Point(639, 74);
            btnSprueher.Name = "btnSprueher";
            btnSprueher.Size = new Size(149, 23);
            btnSprueher.TabIndex = 9;
            btnSprueher.Text = "Toggle Sprueher";
            btnSprueher.UseVisualStyleBackColor = true;
            btnSprueher.Click += btnSprueher_Click;
            // 
            // btnWerfer
            // 
            btnWerfer.Location = new Point(639, 45);
            btnWerfer.Name = "btnWerfer";
            btnWerfer.Size = new Size(149, 23);
            btnWerfer.TabIndex = 10;
            btnWerfer.Text = "Toggle Werfer";
            btnWerfer.UseVisualStyleBackColor = true;
            btnWerfer.Click += btnWerfer_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnWerfer);
            Controls.Add(btnSprueher);
            Controls.Add(btnTropfer);
            Controls.Add(cbPump);
            Controls.Add(cbValve);
            Controls.Add(label2);
            Controls.Add(lblWaterState);
            Controls.Add(cbWaterLevel);
            Controls.Add(label1);
            Controls.Add(btnManuell);
            Controls.Add(lblCurrentMode);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCurrentMode;
        private Button btnManuell;
        private Label label1;
        private CheckBox cbWaterLevel;
        private Label label2;
        private Label lblWaterState;
        private CheckBox cbValve;
        private CheckBox cbPump;
        private Button btnTropfer;
        private Button btnSprueher;
        private Button btnWerfer;
    }
}