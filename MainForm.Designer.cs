namespace HammingCode
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
            this.lblSourceToCode = new System.Windows.Forms.Label();
            this.inputToCode = new System.Windows.Forms.TextBox();
            this.lblHCode = new System.Windows.Forms.Label();
            this.inputHammingCode = new System.Windows.Forms.RichTextBox();
            this.inputChecksStatus = new System.Windows.Forms.TextBox();
            this.lblChecksStatus = new System.Windows.Forms.Label();
            this.lblHCodeRepaired = new System.Windows.Forms.Label();
            this.inputHammingCodeRepaired = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputDecoded = new System.Windows.Forms.TextBox();
            this.btnCode = new System.Windows.Forms.Button();
            this.btnCheckRepair = new System.Windows.Forms.Button();
            this.btnDecode = new System.Windows.Forms.Button();
            this.btnApplyChanges = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSourceToCode
            // 
            this.lblSourceToCode.AutoSize = true;
            this.lblSourceToCode.BackColor = System.Drawing.Color.Transparent;
            this.lblSourceToCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSourceToCode.Location = new System.Drawing.Point(12, 9);
            this.lblSourceToCode.Name = "lblSourceToCode";
            this.lblSourceToCode.Size = new System.Drawing.Size(205, 17);
            this.lblSourceToCode.TabIndex = 0;
            this.lblSourceToCode.Text = "Входная строка (для кодировки):";
            // 
            // inputToCode
            // 
            this.inputToCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputToCode.Location = new System.Drawing.Point(12, 29);
            this.inputToCode.Multiline = true;
            this.inputToCode.Name = "inputToCode";
            this.inputToCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputToCode.Size = new System.Drawing.Size(500, 80);
            this.inputToCode.TabIndex = 1;
            // 
            // lblHCode
            // 
            this.lblHCode.AutoSize = true;
            this.lblHCode.BackColor = System.Drawing.Color.Transparent;
            this.lblHCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHCode.Location = new System.Drawing.Point(12, 112);
            this.lblHCode.Name = "lblHCode";
            this.lblHCode.Size = new System.Drawing.Size(96, 17);
            this.lblHCode.TabIndex = 2;
            this.lblHCode.Text = "Код Хэмминга:";
            // 
            // inputHammingCode
            // 
            this.inputHammingCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputHammingCode.Location = new System.Drawing.Point(12, 132);
            this.inputHammingCode.Name = "inputHammingCode";
            this.inputHammingCode.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.inputHammingCode.Size = new System.Drawing.Size(500, 80);
            this.inputHammingCode.TabIndex = 3;
            this.inputHammingCode.Text = "";
            // 
            // inputChecksStatus
            // 
            this.inputChecksStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputChecksStatus.Location = new System.Drawing.Point(12, 235);
            this.inputChecksStatus.Multiline = true;
            this.inputChecksStatus.Name = "inputChecksStatus";
            this.inputChecksStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputChecksStatus.Size = new System.Drawing.Size(500, 80);
            this.inputChecksStatus.TabIndex = 4;
            // 
            // lblChecksStatus
            // 
            this.lblChecksStatus.AutoSize = true;
            this.lblChecksStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblChecksStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChecksStatus.Location = new System.Drawing.Point(9, 215);
            this.lblChecksStatus.Name = "lblChecksStatus";
            this.lblChecksStatus.Size = new System.Drawing.Size(111, 17);
            this.lblChecksStatus.TabIndex = 5;
            this.lblChecksStatus.Text = "Статус проверок:";
            // 
            // lblHCodeRepaired
            // 
            this.lblHCodeRepaired.AutoSize = true;
            this.lblHCodeRepaired.BackColor = System.Drawing.Color.Transparent;
            this.lblHCodeRepaired.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHCodeRepaired.Location = new System.Drawing.Point(12, 318);
            this.lblHCodeRepaired.Name = "lblHCodeRepaired";
            this.lblHCodeRepaired.Size = new System.Drawing.Size(211, 17);
            this.lblHCodeRepaired.TabIndex = 6;
            this.lblHCodeRepaired.Text = "Код Хэмминга (с исправлениями):";
            // 
            // inputHammingCodeRepaired
            // 
            this.inputHammingCodeRepaired.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputHammingCodeRepaired.Location = new System.Drawing.Point(12, 338);
            this.inputHammingCodeRepaired.Name = "inputHammingCodeRepaired";
            this.inputHammingCodeRepaired.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.inputHammingCodeRepaired.Size = new System.Drawing.Size(500, 80);
            this.inputHammingCodeRepaired.TabIndex = 7;
            this.inputHammingCodeRepaired.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Выходная строка (декодированная):";
            // 
            // inputDecoded
            // 
            this.inputDecoded.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputDecoded.Location = new System.Drawing.Point(12, 441);
            this.inputDecoded.Multiline = true;
            this.inputDecoded.Name = "inputDecoded";
            this.inputDecoded.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputDecoded.Size = new System.Drawing.Size(500, 80);
            this.inputDecoded.TabIndex = 9;
            // 
            // btnCode
            // 
            this.btnCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCode.Location = new System.Drawing.Point(518, 30);
            this.btnCode.Name = "btnCode";
            this.btnCode.Size = new System.Drawing.Size(124, 79);
            this.btnCode.TabIndex = 10;
            this.btnCode.Text = "Закодировать";
            this.btnCode.UseVisualStyleBackColor = true;
            // 
            // btnCheckRepair
            // 
            this.btnCheckRepair.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCheckRepair.Location = new System.Drawing.Point(518, 235);
            this.btnCheckRepair.Name = "btnCheckRepair";
            this.btnCheckRepair.Size = new System.Drawing.Size(124, 80);
            this.btnCheckRepair.TabIndex = 11;
            this.btnCheckRepair.Text = "Проверить и исправить";
            this.btnCheckRepair.UseVisualStyleBackColor = true;
            // 
            // btnDecode
            // 
            this.btnDecode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDecode.Location = new System.Drawing.Point(518, 338);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(124, 80);
            this.btnDecode.TabIndex = 12;
            this.btnDecode.Text = "Декодировать";
            this.btnDecode.UseVisualStyleBackColor = true;
            // 
            // btnApplyChanges
            // 
            this.btnApplyChanges.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnApplyChanges.Location = new System.Drawing.Point(518, 133);
            this.btnApplyChanges.Name = "btnApplyChanges";
            this.btnApplyChanges.Size = new System.Drawing.Size(124, 79);
            this.btnApplyChanges.TabIndex = 13;
            this.btnApplyChanges.Text = "Применить изменения";
            this.btnApplyChanges.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(654, 531);
            this.Controls.Add(this.btnApplyChanges);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.btnCheckRepair);
            this.Controls.Add(this.btnCode);
            this.Controls.Add(this.inputDecoded);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputHammingCodeRepaired);
            this.Controls.Add(this.lblHCodeRepaired);
            this.Controls.Add(this.lblChecksStatus);
            this.Controls.Add(this.inputChecksStatus);
            this.Controls.Add(this.inputHammingCode);
            this.Controls.Add(this.lblHCode);
            this.Controls.Add(this.inputToCode);
            this.Controls.Add(this.lblSourceToCode);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hamming Codes © 2016 Tema Smirnov";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSourceToCode;
        private System.Windows.Forms.TextBox inputToCode;
        private System.Windows.Forms.Label lblHCode;
        private System.Windows.Forms.RichTextBox inputHammingCode;
        private System.Windows.Forms.TextBox inputChecksStatus;
        private System.Windows.Forms.Label lblChecksStatus;
        private System.Windows.Forms.Label lblHCodeRepaired;
        private System.Windows.Forms.RichTextBox inputHammingCodeRepaired;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputDecoded;
        private System.Windows.Forms.Button btnCode;
        private System.Windows.Forms.Button btnCheckRepair;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.Button btnApplyChanges;
    }
}

