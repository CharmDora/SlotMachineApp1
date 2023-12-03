using System;

namespace SlotMachineApp
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
            this.btnSpin = new System.Windows.Forms.Button();
            this.lblSlot1 = new System.Windows.Forms.Label();
            this.lblSlot2 = new System.Windows.Forms.Label();
            this.lblSlot3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSpin
            // 
            this.btnSpin.BackColor = System.Drawing.Color.Yellow;
            this.btnSpin.Font = new System.Drawing.Font("Stencil", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpin.Location = new System.Drawing.Point(360, 470);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(263, 92);
            this.btnSpin.TabIndex = 0;
            this.btnSpin.Text = "ÇEVİR";
            this.btnSpin.UseVisualStyleBackColor = false;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click_1);
            // 
            // lblSlot1
            // 
            this.lblSlot1.AutoSize = true;
            this.lblSlot1.BackColor = System.Drawing.Color.Lime;
            this.lblSlot1.Font = new System.Drawing.Font("Stencil", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlot1.Location = new System.Drawing.Point(246, 181);
            this.lblSlot1.Name = "lblSlot1";
            this.lblSlot1.Size = new System.Drawing.Size(108, 114);
            this.lblSlot1.TabIndex = 1;
            this.lblSlot1.Text = "A";
            // 
            // lblSlot2
            // 
            this.lblSlot2.AutoSize = true;
            this.lblSlot2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblSlot2.Font = new System.Drawing.Font("Stencil", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlot2.Location = new System.Drawing.Point(440, 181);
            this.lblSlot2.Name = "lblSlot2";
            this.lblSlot2.Size = new System.Drawing.Size(108, 114);
            this.lblSlot2.TabIndex = 2;
            this.lblSlot2.Text = "A";
            // 
            // lblSlot3
            // 
            this.lblSlot3.AutoSize = true;
            this.lblSlot3.BackColor = System.Drawing.Color.Cyan;
            this.lblSlot3.Font = new System.Drawing.Font("Stencil", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlot3.Location = new System.Drawing.Point(629, 181);
            this.lblSlot3.Name = "lblSlot3";
            this.lblSlot3.Size = new System.Drawing.Size(108, 114);
            this.lblSlot3.TabIndex = 3;
            this.lblSlot3.Text = "A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(962, 634);
            this.Controls.Add(this.lblSlot3);
            this.Controls.Add(this.lblSlot2);
            this.Controls.Add(this.lblSlot1);
            this.Controls.Add(this.btnSpin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Label lblSlot1;
        private System.Windows.Forms.Label lblSlot2;
        private System.Windows.Forms.Label lblSlot3;

        public EventHandler Form1_Load { get; private set; }
    }
}

