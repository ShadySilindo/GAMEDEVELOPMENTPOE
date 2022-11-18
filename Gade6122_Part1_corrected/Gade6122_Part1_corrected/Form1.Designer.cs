
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.lblPickUpInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMap
            // 
            this.lblMap.AutoSize = true;
            this.lblMap.Location = new System.Drawing.Point(95, 60);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(143, 18);
            this.lblMap.TabIndex = 0;
            this.lblMap.Text = "(map goes here)";
            this.lblMap.Click += new System.EventHandler(this.lblMap_Click);
            // 
            // lblAttackInfo
            // 
            this.lblAttackInfo.AutoSize = true;
            this.lblAttackInfo.Location = new System.Drawing.Point(576, 281);
            this.lblAttackInfo.Name = "lblAttackInfo";
            this.lblAttackInfo.Size = new System.Drawing.Size(215, 18);
            this.lblAttackInfo.TabIndex = 1;
            this.lblAttackInfo.Text = "(attack info goes here)";
            this.lblAttackInfo.Click += new System.EventHandler(this.lblAttackInfo_Click);
            // 
            // lblHeroStats
            // 
            this.lblHeroStats.AutoSize = true;
            this.lblHeroStats.Location = new System.Drawing.Point(567, 42);
            this.lblHeroStats.Name = "lblHeroStats";
            this.lblHeroStats.Size = new System.Drawing.Size(188, 18);
            this.lblHeroStats.TabIndex = 2;
            this.lblHeroStats.Text = "(hero stats go here)";
            this.lblHeroStats.Click += new System.EventHandler(this.lblHeroStats_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(567, 202);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(567, 240);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(659, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnShop
            // 
            this.btnShop.Location = new System.Drawing.Point(648, 224);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(75, 23);
            this.btnShop.TabIndex = 8;
            this.btnShop.Text = "button2";
            this.btnShop.UseVisualStyleBackColor = true;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // lblPickUpInfo
            // 
            this.lblPickUpInfo.AutoSize = true;
            this.lblPickUpInfo.Location = new System.Drawing.Point(576, 342);
            this.lblPickUpInfo.Name = "lblPickUpInfo";
            this.lblPickUpInfo.Size = new System.Drawing.Size(224, 18);
            this.lblPickUpInfo.TabIndex = 9;
            this.lblPickUpInfo.Text = "(pick up info goes here)";
            this.lblPickUpInfo.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(567, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "(weapon info goes here)";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPickUpInfo);
            this.Controls.Add(this.btnShop);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Label lblPickUpInfo;
        private System.Windows.Forms.Label label1;
    }
}

