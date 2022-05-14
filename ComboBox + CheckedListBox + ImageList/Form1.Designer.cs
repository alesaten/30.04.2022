namespace ComboBox___CheckedListBox___ImageList
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DisplayChoice_comboBox = new System.Windows.Forms.ComboBox();
            this.DisplayChoice_label = new System.Windows.Forms.Label();
            this.Countries_checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.Output_button = new System.Windows.Forms.Button();
            this.Output_label = new System.Windows.Forms.Label();
            this.Countries_imageList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // DisplayChoice_comboBox
            // 
            this.DisplayChoice_comboBox.FormattingEnabled = true;
            this.DisplayChoice_comboBox.Location = new System.Drawing.Point(238, 6);
            this.DisplayChoice_comboBox.Name = "DisplayChoice_comboBox";
            this.DisplayChoice_comboBox.Size = new System.Drawing.Size(121, 21);
            this.DisplayChoice_comboBox.TabIndex = 1;
            // 
            // DisplayChoice_label
            // 
            this.DisplayChoice_label.AutoSize = true;
            this.DisplayChoice_label.Location = new System.Drawing.Point(12, 9);
            this.DisplayChoice_label.Name = "DisplayChoice_label";
            this.DisplayChoice_label.Size = new System.Drawing.Size(220, 13);
            this.DisplayChoice_label.TabIndex = 2;
            this.DisplayChoice_label.Text = "Выберите способ представления вывода:";
            // 
            // Countries_checkedListBox
            // 
            this.Countries_checkedListBox.FormattingEnabled = true;
            this.Countries_checkedListBox.Location = new System.Drawing.Point(15, 33);
            this.Countries_checkedListBox.Name = "Countries_checkedListBox";
            this.Countries_checkedListBox.Size = new System.Drawing.Size(344, 94);
            this.Countries_checkedListBox.TabIndex = 3;
            // 
            // Output_button
            // 
            this.Output_button.Location = new System.Drawing.Point(169, 136);
            this.Output_button.Name = "Output_button";
            this.Output_button.Size = new System.Drawing.Size(190, 30);
            this.Output_button.TabIndex = 4;
            this.Output_button.Text = "Вывод";
            this.Output_button.UseVisualStyleBackColor = true;
            this.Output_button.Click += new System.EventHandler(this.Output_button_Click);
            // 
            // Output_label
            // 
            this.Output_label.AutoSize = true;
            this.Output_label.Location = new System.Drawing.Point(12, 145);
            this.Output_label.Name = "Output_label";
            this.Output_label.Size = new System.Drawing.Size(138, 13);
            this.Output_label.TabIndex = 5;
            this.Output_label.Text = "Нажмите кнопку \"Вывод\"";
            // 
            // Countries_imageList
            // 
            this.Countries_imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Countries_imageList.ImageStream")));
            this.Countries_imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.Countries_imageList.Images.SetKeyName(0, "australia.png");
            this.Countries_imageList.Images.SetKeyName(1, "greece.png");
            this.Countries_imageList.Images.SetKeyName(2, "iceland.png");
            this.Countries_imageList.Images.SetKeyName(3, "norway.jpg");
            this.Countries_imageList.Images.SetKeyName(4, "russia.png");
            this.Countries_imageList.Images.SetKeyName(5, "united_kingdom.png");
            this.Countries_imageList.Images.SetKeyName(6, "usa.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 174);
            this.Controls.Add(this.Output_label);
            this.Controls.Add(this.Output_button);
            this.Controls.Add(this.Countries_checkedListBox);
            this.Controls.Add(this.DisplayChoice_label);
            this.Controls.Add(this.DisplayChoice_comboBox);
            this.Name = "Form1";
            this.Text = "Названия и флаги стран";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox DisplayChoice_comboBox;
        private System.Windows.Forms.Label DisplayChoice_label;
        private System.Windows.Forms.CheckedListBox Countries_checkedListBox;
        private System.Windows.Forms.Button Output_button;
        private System.Windows.Forms.Label Output_label;
        private System.Windows.Forms.ImageList Countries_imageList;
    }
}

