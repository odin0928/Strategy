namespace Homework01
{
    partial class TicketSaleSytemWindow
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
            this.comboBoxStudentDiscountSolution = new System.Windows.Forms.ComboBox();
            this.comboBoxChildrenDiscountSolution = new System.Windows.Forms.ComboBox();
            this.comboBoxCustomList = new System.Windows.Forms.ComboBox();
            this.numericUpDownTicketNumber = new System.Windows.Forms.NumericUpDown();
            this.buttonCash = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBoxVIPDiscountSolution = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTicketNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxStudentDiscountSolution
            // 
            this.comboBoxStudentDiscountSolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStudentDiscountSolution.FormattingEnabled = true;
            this.comboBoxStudentDiscountSolution.Location = new System.Drawing.Point(34, 28);
            this.comboBoxStudentDiscountSolution.Name = "comboBoxStudentDiscountSolution";
            this.comboBoxStudentDiscountSolution.Size = new System.Drawing.Size(195, 20);
            this.comboBoxStudentDiscountSolution.TabIndex = 0;
            // 
            // comboBoxChildrenDiscountSolution
            // 
            this.comboBoxChildrenDiscountSolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChildrenDiscountSolution.FormattingEnabled = true;
            this.comboBoxChildrenDiscountSolution.Location = new System.Drawing.Point(265, 28);
            this.comboBoxChildrenDiscountSolution.Name = "comboBoxChildrenDiscountSolution";
            this.comboBoxChildrenDiscountSolution.Size = new System.Drawing.Size(195, 20);
            this.comboBoxChildrenDiscountSolution.TabIndex = 1;
            // 
            // comboBoxCustomList
            // 
            this.comboBoxCustomList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCustomList.FormattingEnabled = true;
            this.comboBoxCustomList.Location = new System.Drawing.Point(35, 133);
            this.comboBoxCustomList.Name = "comboBoxCustomList";
            this.comboBoxCustomList.Size = new System.Drawing.Size(195, 20);
            this.comboBoxCustomList.TabIndex = 2;
            this.comboBoxCustomList.SelectedIndexChanged += new System.EventHandler(this.comboBoxCustomList_SelectedIndexChanged);
            // 
            // numericUpDownTicketNumber
            // 
            this.numericUpDownTicketNumber.Location = new System.Drawing.Point(266, 134);
            this.numericUpDownTicketNumber.Name = "numericUpDownTicketNumber";
            this.numericUpDownTicketNumber.Size = new System.Drawing.Size(57, 22);
            this.numericUpDownTicketNumber.TabIndex = 3;
            // 
            // buttonCash
            // 
            this.buttonCash.Location = new System.Drawing.Point(346, 134);
            this.buttonCash.Name = "buttonCash";
            this.buttonCash.Size = new System.Drawing.Size(115, 23);
            this.buttonCash.TabIndex = 4;
            this.buttonCash.Text = "訂票";
            this.buttonCash.UseVisualStyleBackColor = true;
            this.buttonCash.Click += new System.EventHandler(this.buttonCash_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(35, 171);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(425, 188);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // comboBoxVIPDiscountSolution
            // 
            this.comboBoxVIPDiscountSolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVIPDiscountSolution.FormattingEnabled = true;
            this.comboBoxVIPDiscountSolution.Location = new System.Drawing.Point(35, 78);
            this.comboBoxVIPDiscountSolution.Name = "comboBoxVIPDiscountSolution";
            this.comboBoxVIPDiscountSolution.Size = new System.Drawing.Size(195, 20);
            this.comboBoxVIPDiscountSolution.TabIndex = 6;
            // 
            // TicketSaleSytemWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 395);
            this.Controls.Add(this.comboBoxVIPDiscountSolution);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonCash);
            this.Controls.Add(this.numericUpDownTicketNumber);
            this.Controls.Add(this.comboBoxCustomList);
            this.Controls.Add(this.comboBoxChildrenDiscountSolution);
            this.Controls.Add(this.comboBoxStudentDiscountSolution);
            this.Name = "TicketSaleSytemWindow";
            this.Text = "TicketSaleSytemWindow";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTicketNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxStudentDiscountSolution;
        private System.Windows.Forms.ComboBox comboBoxChildrenDiscountSolution;
        private System.Windows.Forms.ComboBox comboBoxCustomList;
        private System.Windows.Forms.NumericUpDown numericUpDownTicketNumber;
        private System.Windows.Forms.Button buttonCash;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBoxVIPDiscountSolution;
    }
}