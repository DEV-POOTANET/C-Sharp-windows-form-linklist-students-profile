
namespace Assignment1
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
            this.PanMin = new System.Windows.Forms.Panel();
            this.PanData = new System.Windows.Forms.Panel();
            this.LabList = new System.Windows.Forms.Label();
            this.LabNmaeTopic = new System.Windows.Forms.Label();
            this.PanMenu = new System.Windows.Forms.Panel();
            this.LabNumber = new System.Windows.Forms.Label();
            this.BtnDel = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnLast = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnPr = new System.Windows.Forms.Button();
            this.Btnfirst = new System.Windows.Forms.Button();
            this.PanInput = new System.Windows.Forms.Panel();
            this.BtnView = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.Txtname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LabName = new System.Windows.Forms.Label();
            this.PanTopic = new System.Windows.Forms.Panel();
            this.LabTopic = new System.Windows.Forms.Label();
            this.PanMin.SuspendLayout();
            this.PanData.SuspendLayout();
            this.PanMenu.SuspendLayout();
            this.PanInput.SuspendLayout();
            this.PanTopic.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanMin
            // 
            this.PanMin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PanMin.Controls.Add(this.PanData);
            this.PanMin.Controls.Add(this.PanMenu);
            this.PanMin.Controls.Add(this.PanInput);
            this.PanMin.Controls.Add(this.PanTopic);
            this.PanMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanMin.Location = new System.Drawing.Point(0, 0);
            this.PanMin.Name = "PanMin";
            this.PanMin.Size = new System.Drawing.Size(459, 483);
            this.PanMin.TabIndex = 0;
            // 
            // PanData
            // 
            this.PanData.Controls.Add(this.LabList);
            this.PanData.Controls.Add(this.LabNmaeTopic);
            this.PanData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanData.Location = new System.Drawing.Point(0, 209);
            this.PanData.Name = "PanData";
            this.PanData.Size = new System.Drawing.Size(459, 274);
            this.PanData.TabIndex = 2;
            // 
            // LabList
            // 
            this.LabList.AutoSize = true;
            this.LabList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.LabList.Location = new System.Drawing.Point(53, 42);
            this.LabList.Name = "LabList";
            this.LabList.Size = new System.Drawing.Size(96, 16);
            this.LabList.TabIndex = 7;
            this.LabList.Text = "No Student List";
            // 
            // LabNmaeTopic
            // 
            this.LabNmaeTopic.AutoSize = true;
            this.LabNmaeTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.LabNmaeTopic.Location = new System.Drawing.Point(43, 15);
            this.LabNmaeTopic.Name = "LabNmaeTopic";
            this.LabNmaeTopic.Size = new System.Drawing.Size(87, 16);
            this.LabNmaeTopic.TabIndex = 6;
            this.LabNmaeTopic.Text = "Student List";
            // 
            // PanMenu
            // 
            this.PanMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PanMenu.Controls.Add(this.LabNumber);
            this.PanMenu.Controls.Add(this.BtnDel);
            this.PanMenu.Controls.Add(this.BtnExit);
            this.PanMenu.Controls.Add(this.BtnAdd);
            this.PanMenu.Controls.Add(this.BtnLast);
            this.PanMenu.Controls.Add(this.BtnNext);
            this.PanMenu.Controls.Add(this.BtnPr);
            this.PanMenu.Controls.Add(this.Btnfirst);
            this.PanMenu.Location = new System.Drawing.Point(0, 132);
            this.PanMenu.Name = "PanMenu";
            this.PanMenu.Size = new System.Drawing.Size(459, 79);
            this.PanMenu.TabIndex = 2;
            // 
            // LabNumber
            // 
            this.LabNumber.AutoSize = true;
            this.LabNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.LabNumber.Location = new System.Drawing.Point(418, 17);
            this.LabNumber.Name = "LabNumber";
            this.LabNumber.Size = new System.Drawing.Size(28, 16);
            this.LabNumber.TabIndex = 6;
            this.LabNumber.Text = "0/0";
            // 
            // BtnDel
            // 
            this.BtnDel.BackColor = System.Drawing.Color.IndianRed;
            this.BtnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDel.FlatAppearance.BorderSize = 0;
            this.BtnDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDel.Location = new System.Drawing.Point(316, 43);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(131, 23);
            this.BtnDel.TabIndex = 12;
            this.BtnDel.Text = "Delete";
            this.BtnDel.UseVisualStyleBackColor = false;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.IndianRed;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnExit.Location = new System.Drawing.Point(163, 43);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(131, 23);
            this.BtnExit.TabIndex = 11;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAdd.Location = new System.Drawing.Point(9, 43);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(131, 23);
            this.BtnAdd.TabIndex = 10;
            this.BtnAdd.Text = "Add Item";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnLast
            // 
            this.BtnLast.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLast.FlatAppearance.BorderSize = 0;
            this.BtnLast.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLast.Location = new System.Drawing.Point(317, 14);
            this.BtnLast.Name = "BtnLast";
            this.BtnLast.Size = new System.Drawing.Size(95, 23);
            this.BtnLast.TabIndex = 9;
            this.BtnLast.Text = "Last";
            this.BtnLast.UseVisualStyleBackColor = false;
            this.BtnLast.Click += new System.EventHandler(this.BtnLast_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNext.FlatAppearance.BorderSize = 0;
            this.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnNext.Location = new System.Drawing.Point(213, 14);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(95, 23);
            this.BtnNext.TabIndex = 8;
            this.BtnNext.Text = ">";
            this.BtnNext.UseVisualStyleBackColor = false;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnPr
            // 
            this.BtnPr.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnPr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPr.FlatAppearance.BorderSize = 0;
            this.BtnPr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPr.Location = new System.Drawing.Point(113, 14);
            this.BtnPr.Name = "BtnPr";
            this.BtnPr.Size = new System.Drawing.Size(95, 23);
            this.BtnPr.TabIndex = 7;
            this.BtnPr.Text = "<";
            this.BtnPr.UseVisualStyleBackColor = false;
            this.BtnPr.Click += new System.EventHandler(this.BtnPr_Click);
            // 
            // Btnfirst
            // 
            this.Btnfirst.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btnfirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnfirst.FlatAppearance.BorderSize = 0;
            this.Btnfirst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btnfirst.Location = new System.Drawing.Point(9, 14);
            this.Btnfirst.Name = "Btnfirst";
            this.Btnfirst.Size = new System.Drawing.Size(95, 23);
            this.Btnfirst.TabIndex = 6;
            this.Btnfirst.Text = "First";
            this.Btnfirst.UseVisualStyleBackColor = false;
            this.Btnfirst.Click += new System.EventHandler(this.Btnfirst_Click);
            // 
            // PanInput
            // 
            this.PanInput.Controls.Add(this.BtnView);
            this.PanInput.Controls.Add(this.BtnClear);
            this.PanInput.Controls.Add(this.TxtPhone);
            this.PanInput.Controls.Add(this.Txtname);
            this.PanInput.Controls.Add(this.label1);
            this.PanInput.Controls.Add(this.LabName);
            this.PanInput.Location = new System.Drawing.Point(0, 59);
            this.PanInput.Name = "PanInput";
            this.PanInput.Size = new System.Drawing.Size(459, 72);
            this.PanInput.TabIndex = 1;
            // 
            // BtnView
            // 
            this.BtnView.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnView.FlatAppearance.BorderSize = 0;
            this.BtnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnView.Location = new System.Drawing.Point(372, 44);
            this.BtnView.Name = "BtnView";
            this.BtnView.Size = new System.Drawing.Size(75, 23);
            this.BtnView.TabIndex = 5;
            this.BtnView.Text = "View All";
            this.BtnView.UseVisualStyleBackColor = false;
            this.BtnView.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.LightCoral;
            this.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClear.FlatAppearance.BorderSize = 0;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnClear.Location = new System.Drawing.Point(372, 16);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 4;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // TxtPhone
            // 
            this.TxtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.TxtPhone.Location = new System.Drawing.Point(88, 44);
            this.TxtPhone.Multiline = true;
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(266, 20);
            this.TxtPhone.TabIndex = 3;
            // 
            // Txtname
            // 
            this.Txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Txtname.Location = new System.Drawing.Point(88, 17);
            this.Txtname.Multiline = true;
            this.Txtname.Name = "Txtname";
            this.Txtname.Size = new System.Drawing.Size(266, 20);
            this.Txtname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(1, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Telephone";
            // 
            // LabName
            // 
            this.LabName.AutoSize = true;
            this.LabName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.LabName.Location = new System.Drawing.Point(34, 19);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(48, 16);
            this.LabName.TabIndex = 0;
            this.LabName.Text = "Name";
            this.LabName.Click += new System.EventHandler(this.label1_Click);
            // 
            // PanTopic
            // 
            this.PanTopic.BackColor = System.Drawing.SystemColors.Highlight;
            this.PanTopic.Controls.Add(this.LabTopic);
            this.PanTopic.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanTopic.Location = new System.Drawing.Point(0, 0);
            this.PanTopic.Name = "PanTopic";
            this.PanTopic.Size = new System.Drawing.Size(459, 59);
            this.PanTopic.TabIndex = 0;
            // 
            // LabTopic
            // 
            this.LabTopic.AutoSize = true;
            this.LabTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.LabTopic.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabTopic.Location = new System.Drawing.Point(114, 10);
            this.LabTopic.Name = "LabTopic";
            this.LabTopic.Size = new System.Drawing.Size(220, 33);
            this.LabTopic.TabIndex = 0;
            this.LabTopic.Text = "Student Profile";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 483);
            this.Controls.Add(this.PanMin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Studen List";
            this.PanMin.ResumeLayout(false);
            this.PanData.ResumeLayout(false);
            this.PanData.PerformLayout();
            this.PanMenu.ResumeLayout(false);
            this.PanMenu.PerformLayout();
            this.PanInput.ResumeLayout(false);
            this.PanInput.PerformLayout();
            this.PanTopic.ResumeLayout(false);
            this.PanTopic.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanMin;
        private System.Windows.Forms.Panel PanInput;
        private System.Windows.Forms.Panel PanTopic;
        private System.Windows.Forms.Label LabTopic;
        private System.Windows.Forms.Label LabName;
        private System.Windows.Forms.Panel PanMenu;
        private System.Windows.Forms.Label LabNumber;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnLast;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnPr;
        private System.Windows.Forms.Button Btnfirst;
        private System.Windows.Forms.Button BtnView;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.TextBox Txtname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanData;
        private System.Windows.Forms.Label LabNmaeTopic;
        private System.Windows.Forms.Label LabList;
    }
}

