namespace comp1004_assignment4_200180985
{
    partial class StartForm
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.OrderLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.NewOrderButton = new System.Windows.Forms.Button();
            this.OpenOrderButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrderLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.Location = new System.Drawing.Point(45, 27);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(201, 20);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Order your computer today!";
            // 
            // OrderLogoPictureBox
            // 
            this.OrderLogoPictureBox.Location = new System.Drawing.Point(84, 56);
            this.OrderLogoPictureBox.Name = "OrderLogoPictureBox";
            this.OrderLogoPictureBox.Size = new System.Drawing.Size(125, 127);
            this.OrderLogoPictureBox.TabIndex = 1;
            this.OrderLogoPictureBox.TabStop = false;
            // 
            // NewOrderButton
            // 
            this.NewOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewOrderButton.Location = new System.Drawing.Point(84, 193);
            this.NewOrderButton.Name = "NewOrderButton";
            this.NewOrderButton.Size = new System.Drawing.Size(125, 28);
            this.NewOrderButton.TabIndex = 2;
            this.NewOrderButton.Text = "Start a New Order";
            this.NewOrderButton.UseVisualStyleBackColor = true;
            // 
            // OpenOrderButton
            // 
            this.OpenOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenOrderButton.Location = new System.Drawing.Point(84, 227);
            this.OpenOrderButton.Name = "OpenOrderButton";
            this.OpenOrderButton.Size = new System.Drawing.Size(125, 28);
            this.OpenOrderButton.TabIndex = 3;
            this.OpenOrderButton.Text = "Open a Saved Order";
            this.OpenOrderButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(84, 261);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(125, 28);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 323);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.OpenOrderButton);
            this.Controls.Add(this.NewOrderButton);
            this.Controls.Add(this.OrderLogoPictureBox);
            this.Controls.Add(this.WelcomeLabel);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Dollar Computer";
            ((System.ComponentModel.ISupportInitialize)(this.OrderLogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.PictureBox OrderLogoPictureBox;
        private System.Windows.Forms.Button NewOrderButton;
        private System.Windows.Forms.Button OpenOrderButton;
        private System.Windows.Forms.Button ExitButton;
    }
}