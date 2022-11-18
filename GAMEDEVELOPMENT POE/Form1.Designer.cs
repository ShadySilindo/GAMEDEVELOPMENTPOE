
namespace Gade6122_Part1_corrected
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
            this.lblMap = new System.Windows.Forms.Label();
            this.lblAttackInfo = new System.Windows.Forms.Label();
            this.lblHeroStats = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMap
            // 
            this.lblMap.AutoSize = true;
            this.lblMap.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMap.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMap.Location = new System.Drawing.Point(95, 60);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(0, 18);
            this.lblMap.TabIndex = 0;
            this.lblMap.Click += new System.EventHandler(this.lblMap_Click);
            // 
            // lblAttackInfo
            // 
            this.lblAttackInfo.AutoSize = true;
            this.lblAttackInfo.Location = new System.Drawing.Point(419, 138);
            this.lblAttackInfo.Name = "lblAttackInfo";
            this.lblAttackInfo.Size = new System.Drawing.Size(215, 18);
            this.lblAttackInfo.TabIndex = 1;
            this.lblAttackInfo.Text = "(attack info goes here)";
            this.lblAttackInfo.Click += new System.EventHandler(this.lblAttackInfo_Click);
            // 
            // lblHeroStats
            // 
            this.lblHeroStats.AutoSize = true;
            this.lblHeroStats.Location = new System.Drawing.Point(419, 37);
            this.lblHeroStats.Name = "lblHeroStats";
            this.lblHeroStats.Size = new System.Drawing.Size(188, 18);
            this.lblHeroStats.TabIndex = 2;
            this.lblHeroStats.Text = "(hero stats go here)";
            this.lblHeroStats.Click += new System.EventHandler(this.lblHeroStats_Click);
            // 
            // button1
            // 
            this.button1.CausesValidation = false;
            this.button1.Location = new System.Drawing.Point(429, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Start Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.CausesValidation = false;
            this.btnSave.Location = new System.Drawing.Point(429, 296);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.CausesValidation = false;
            this.btnLoad.Location = new System.Drawing.Point(584, 296);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(94, 29);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Visible = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 496);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblHeroStats);
            this.Controls.Add(this.lblAttackInfo);
            this.Controls.Add(this.lblMap);
            this.Font = new System.Drawing.Font("Monospac821 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMap;
        private System.Windows.Forms.Label lblAttackInfo;
        private System.Windows.Forms.Label lblHeroStats;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
    }
}

