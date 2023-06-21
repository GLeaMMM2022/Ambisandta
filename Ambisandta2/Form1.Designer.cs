namespace OssetianProverbsApp
{
    partial class MainForm
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
            this.ossetianListBox = new System.Windows.Forms.ListBox();
            this.russianListBox = new System.Windows.Forms.ListBox();
            this.proverbsListView = new System.Windows.Forms.ListView();
            this.addButton = new System.Windows.Forms.Button();
            this.checkButton = new System.Windows.Forms.Button();
            this.rulesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ossetianListBox
            // 
            this.ossetianListBox.FormattingEnabled = true;
            this.ossetianListBox.ItemHeight = 25;
            this.ossetianListBox.Location = new System.Drawing.Point(177, 295);
            this.ossetianListBox.Name = "ossetianListBox";
            this.ossetianListBox.Size = new System.Drawing.Size(315, 254);
            this.ossetianListBox.TabIndex = 0;
            // 
            // russianListBox
            // 
            this.russianListBox.FormattingEnabled = true;
            this.russianListBox.ItemHeight = 25;
            this.russianListBox.Location = new System.Drawing.Point(643, 295);
            this.russianListBox.Name = "russianListBox";
            this.russianListBox.Size = new System.Drawing.Size(315, 254);
            this.russianListBox.TabIndex = 1;
            // 
            // proverbsListView
            // 
            this.proverbsListView.FullRowSelect = true;
            this.proverbsListView.HideSelection = false;
            this.proverbsListView.Location = new System.Drawing.Point(1030, 246);
            this.proverbsListView.Name = "proverbsListView";
            this.proverbsListView.Size = new System.Drawing.Size(995, 369);
            this.proverbsListView.TabIndex = 2;
            this.proverbsListView.UseCompatibleStateImageBehavior = false;
            this.proverbsListView.View = System.Windows.Forms.View.Details;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(317, 674);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(175, 66);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(643, 674);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(146, 66);
            this.checkButton.TabIndex = 4;
            this.checkButton.Text = "Проверить";
            this.checkButton.UseVisualStyleBackColor = true;
            // 
            // rulesButton
            // 
            this.rulesButton.Location = new System.Drawing.Point(856, 56);
            this.rulesButton.Name = "rulesButton";
            this.rulesButton.Size = new System.Drawing.Size(146, 66);
            this.rulesButton.TabIndex = 5;
            this.rulesButton.Text = "button1";
            this.rulesButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2083, 937);
            this.Controls.Add(this.rulesButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.proverbsListView);
            this.Controls.Add(this.russianListBox);
            this.Controls.Add(this.ossetianListBox);
            this.Name = "MainForm";
            this.Text = "Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ossetianListBox;
        private System.Windows.Forms.ListBox russianListBox;
        private System.Windows.Forms.ListView proverbsListView;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button rulesButton;
    }
}

