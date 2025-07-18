namespace time_converter
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
            txt_input = new TextBox();
            txt_output = new TextBox();
            cbo_input = new ComboBox();
            cbo_output = new ComboBox();
            btn_convert = new Button();
            SuspendLayout();
            // 
            // txt_input
            // 
            txt_input.Location = new Point(51, 113);
            txt_input.Name = "txt_input";
            txt_input.Size = new Size(185, 27);
            txt_input.TabIndex = 0;
            // 
            // txt_output
            // 
            txt_output.Location = new Point(298, 113);
            txt_output.Name = "txt_output";
            txt_output.Size = new Size(185, 27);
            txt_output.TabIndex = 0;
            txt_output.TextChanged += textBox2_TextChanged;
            // 
            // cbo_input
            // 
            cbo_input.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_input.FormattingEnabled = true;
            cbo_input.Items.AddRange(new object[] { "seconds", "minutes", "hours", "HH:MM:SS or MM:SS", "HH:MM", "MM:SS" });
            cbo_input.Location = new Point(51, 53);
            cbo_input.Name = "cbo_input";
            cbo_input.Size = new Size(185, 28);
            cbo_input.TabIndex = 1;
            cbo_input.SelectedIndexChanged += cbo_input_SelectedIndexChanged;
            // 
            // cbo_output
            // 
            cbo_output.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_output.FormattingEnabled = true;
            cbo_output.Items.AddRange(new object[] { "seconds", "minutes", "hours", "HH:MM:SS", "HH:MM", "MM:SS" });
            cbo_output.Location = new Point(298, 53);
            cbo_output.Name = "cbo_output";
            cbo_output.Size = new Size(185, 28);
            cbo_output.TabIndex = 2;
            // 
            // btn_convert
            // 
            btn_convert.Location = new Point(389, 176);
            btn_convert.Name = "btn_convert";
            btn_convert.Size = new Size(94, 29);
            btn_convert.TabIndex = 3;
            btn_convert.Text = "Convert";
            btn_convert.UseVisualStyleBackColor = true;
            btn_convert.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 253);
            Controls.Add(btn_convert);
            Controls.Add(cbo_output);
            Controls.Add(cbo_input);
            Controls.Add(txt_output);
            Controls.Add(txt_input);
            Name = "Form1";
            Text = "Time Converter";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_input;
        private TextBox txt_output;
        private ComboBox cbo_input;
        private ComboBox cbo_output;
        private Button btn_convert;
    }
}
