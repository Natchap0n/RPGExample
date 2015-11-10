namespace RPGGame
{
    partial class RPGGameView
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
            this.btnUp = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.lblEP = new System.Windows.Forms.Label();
            this.btnAttack = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(614, 519);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(64, 40);
            this.btnUp.TabIndex = 0;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(575, 565);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(64, 40);
            this.btnLeft.TabIndex = 1;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(645, 565);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(64, 40);
            this.btnRight.TabIndex = 2;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(614, 611);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(64, 40);
            this.btnDown.TabIndex = 3;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "HP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 540);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "EP";
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHP.Location = new System.Drawing.Point(118, 495);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(52, 31);
            this.lblHP.TabIndex = 6;
            this.lblHP.Text = "HP";
            // 
            // lblEP
            // 
            this.lblEP.AutoSize = true;
            this.lblEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEP.Location = new System.Drawing.Point(118, 540);
            this.lblEP.Name = "lblEP";
            this.lblEP.Size = new System.Drawing.Size(52, 31);
            this.lblEP.TabIndex = 7;
            this.lblEP.Text = "HP";
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(457, 565);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(64, 40);
            this.btnAttack.TabIndex = 8;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.Location = new System.Drawing.Point(42, 436);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(52, 31);
            this.lblMsg.TabIndex = 9;
            this.lblMsg.Text = "HP";
            this.lblMsg.Click += new System.EventHandler(this.lblMsg_Click);
            // 
            // RPGGameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 649);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.lblEP);
            this.Controls.Add(this.lblHP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnUp);
            this.Name = "RPGGameView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label lblEP;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Label lblMsg;
    }
}

