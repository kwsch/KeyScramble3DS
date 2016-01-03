namespace KeyScramble3DS
{
    partial class Form1
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
            this.TB_KeyX = new System.Windows.Forms.TextBox();
            this.TB_KeyY = new System.Windows.Forms.TextBox();
            this.L_KeyX = new System.Windows.Forms.Label();
            this.L_KeyY = new System.Windows.Forms.Label();
            this.TB_KeyN = new System.Windows.Forms.TextBox();
            this.B_Scramble = new System.Windows.Forms.Button();
            this.L_KeyN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_KeyX
            // 
            this.TB_KeyX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_KeyX.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_KeyX.Location = new System.Drawing.Point(61, 12);
            this.TB_KeyX.MaxLength = 32;
            this.TB_KeyX.Name = "TB_KeyX";
            this.TB_KeyX.Size = new System.Drawing.Size(231, 20);
            this.TB_KeyX.TabIndex = 0;
            this.TB_KeyX.Text = "B529221CDDB5DB5A1BF26EFF2041E875";
            // 
            // TB_KeyY
            // 
            this.TB_KeyY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_KeyY.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_KeyY.Location = new System.Drawing.Point(61, 38);
            this.TB_KeyY.MaxLength = 32;
            this.TB_KeyY.Name = "TB_KeyY";
            this.TB_KeyY.Size = new System.Drawing.Size(231, 20);
            this.TB_KeyY.TabIndex = 1;
            this.TB_KeyY.Text = "ED7858A8BBA7EED7FC970C5979BC0AF2";
            // 
            // L_KeyX
            // 
            this.L_KeyX.Location = new System.Drawing.Point(5, 11);
            this.L_KeyX.Name = "L_KeyX";
            this.L_KeyX.Size = new System.Drawing.Size(50, 20);
            this.L_KeyX.TabIndex = 3;
            this.L_KeyX.Text = "KeyX:";
            this.L_KeyX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // L_KeyY
            // 
            this.L_KeyY.Location = new System.Drawing.Point(5, 37);
            this.L_KeyY.Name = "L_KeyY";
            this.L_KeyY.Size = new System.Drawing.Size(50, 20);
            this.L_KeyY.TabIndex = 4;
            this.L_KeyY.Text = "KeyY:";
            this.L_KeyY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TB_KeyN
            // 
            this.TB_KeyN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_KeyN.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_KeyN.Location = new System.Drawing.Point(61, 93);
            this.TB_KeyN.MaxLength = 32;
            this.TB_KeyN.Name = "TB_KeyN";
            this.TB_KeyN.ReadOnly = true;
            this.TB_KeyN.Size = new System.Drawing.Size(231, 20);
            this.TB_KeyN.TabIndex = 6;
            // 
            // B_Scramble
            // 
            this.B_Scramble.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Scramble.Location = new System.Drawing.Point(217, 64);
            this.B_Scramble.Name = "B_Scramble";
            this.B_Scramble.Size = new System.Drawing.Size(75, 23);
            this.B_Scramble.TabIndex = 7;
            this.B_Scramble.Text = "Scramble!";
            this.B_Scramble.UseVisualStyleBackColor = true;
            this.B_Scramble.Click += new System.EventHandler(this.B_Scramble_Click);
            // 
            // L_KeyN
            // 
            this.L_KeyN.Location = new System.Drawing.Point(5, 92);
            this.L_KeyN.Name = "L_KeyN";
            this.L_KeyN.Size = new System.Drawing.Size(50, 20);
            this.L_KeyN.TabIndex = 8;
            this.L_KeyN.Text = "Key:";
            this.L_KeyN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 122);
            this.Controls.Add(this.L_KeyN);
            this.Controls.Add(this.B_Scramble);
            this.Controls.Add(this.TB_KeyN);
            this.Controls.Add(this.L_KeyY);
            this.Controls.Add(this.L_KeyX);
            this.Controls.Add(this.TB_KeyY);
            this.Controls.Add(this.TB_KeyX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "3DS KeyScrambler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_KeyX;
        private System.Windows.Forms.TextBox TB_KeyY;
        private System.Windows.Forms.Label L_KeyX;
        private System.Windows.Forms.Label L_KeyY;
        private System.Windows.Forms.TextBox TB_KeyN;
        private System.Windows.Forms.Button B_Scramble;
        private System.Windows.Forms.Label L_KeyN;
    }
}

