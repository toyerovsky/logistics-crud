namespace PSK.Databases.LogisticsCRUD.Forms
{
    partial class MainForm
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
            this.customersButton = new System.Windows.Forms.Button();
            this.couriersButton = new System.Windows.Forms.Button();
            this.complaintsButton = new System.Windows.Forms.Button();
            this.packagesButton = new System.Windows.Forms.Button();
            this.vehiclesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customersButton
            // 
            this.customersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.customersButton.Location = new System.Drawing.Point(124, 115);
            this.customersButton.Name = "customersButton";
            this.customersButton.Size = new System.Drawing.Size(251, 47);
            this.customersButton.TabIndex = 0;
            this.customersButton.Text = "Klienci";
            this.customersButton.UseVisualStyleBackColor = true;
            this.customersButton.Click += new System.EventHandler(this.customersButton_Click);
            // 
            // couriersButton
            // 
            this.couriersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.couriersButton.Location = new System.Drawing.Point(124, 168);
            this.couriersButton.Name = "couriersButton";
            this.couriersButton.Size = new System.Drawing.Size(251, 47);
            this.couriersButton.TabIndex = 1;
            this.couriersButton.Text = "Kurierzy";
            this.couriersButton.UseVisualStyleBackColor = true;
            this.couriersButton.Click += new System.EventHandler(this.couriersButton_Click);
            // 
            // complaintsButton
            // 
            this.complaintsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.complaintsButton.Location = new System.Drawing.Point(124, 221);
            this.complaintsButton.Name = "complaintsButton";
            this.complaintsButton.Size = new System.Drawing.Size(251, 47);
            this.complaintsButton.TabIndex = 2;
            this.complaintsButton.Text = "Skargi";
            this.complaintsButton.UseVisualStyleBackColor = true;
            this.complaintsButton.Click += new System.EventHandler(this.complaintsButton_Click);
            // 
            // packagesButton
            // 
            this.packagesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.packagesButton.Location = new System.Drawing.Point(124, 274);
            this.packagesButton.Name = "packagesButton";
            this.packagesButton.Size = new System.Drawing.Size(251, 47);
            this.packagesButton.TabIndex = 3;
            this.packagesButton.Text = "Paczki";
            this.packagesButton.UseVisualStyleBackColor = true;
            this.packagesButton.Click += new System.EventHandler(this.packagesButton_Click);
            // 
            // vehiclesButton
            // 
            this.vehiclesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vehiclesButton.Location = new System.Drawing.Point(124, 327);
            this.vehiclesButton.Name = "vehiclesButton";
            this.vehiclesButton.Size = new System.Drawing.Size(251, 47);
            this.vehiclesButton.TabIndex = 4;
            this.vehiclesButton.Text = "Pojazdy";
            this.vehiclesButton.UseVisualStyleBackColor = true;
            this.vehiclesButton.Click += new System.EventHandler(this.vehiclesButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 36);
            this.label1.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 423);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vehiclesButton);
            this.Controls.Add(this.packagesButton);
            this.Controls.Add(this.complaintsButton);
            this.Controls.Add(this.couriersButton);
            this.Controls.Add(this.customersButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button customersButton;
        private System.Windows.Forms.Button couriersButton;
        private System.Windows.Forms.Button complaintsButton;
        private System.Windows.Forms.Button packagesButton;
        private System.Windows.Forms.Button vehiclesButton;
        private System.Windows.Forms.Label label1;
    }
}