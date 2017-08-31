using System;

namespace EsayTraining_Application
{
    partial class MDI_MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDI_MainForm));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnTypes = new System.Windows.Forms.ToolStripButton();
            this.btnGroups = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTypes,
            this.btnGroups,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(948, 96);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnTypes
            // 
            this.btnTypes.Image = ((System.Drawing.Image)(resources.GetObject("btnTypes.Image")));
            this.btnTypes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTypes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTypes.Name = "btnTypes";
            this.btnTypes.Size = new System.Drawing.Size(129, 93);
            this.btnTypes.Text = "بيانات الاصناف";
            this.btnTypes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTypes.Click += new System.EventHandler(this.btnTypes_Click);
            // 
            // btnGroups
            // 
            this.btnGroups.Image = ((System.Drawing.Image)(resources.GetObject("btnGroups.Image")));
            this.btnGroups.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnGroups.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGroups.Name = "btnGroups";
            this.btnGroups.Size = new System.Drawing.Size(159, 93);
            this.btnGroups.Text = "مجموعات الاصناف";
            this.btnGroups.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGroups.Click += new System.EventHandler(this.btnGroups_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 96);
            // 
            // MDI_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 662);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MDI_MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "MDI_MainForm";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnGroups;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnTypes;
        private EventHandler btnGroups_click;
    }
}



