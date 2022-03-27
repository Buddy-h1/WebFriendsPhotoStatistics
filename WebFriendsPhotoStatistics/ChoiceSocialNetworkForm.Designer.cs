
namespace WebFriendsPhotoStatistics
{
    partial class MainWindowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindowForm));
            this.vkButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.instagramButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // vkButton
            // 
            this.vkButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.vkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vkButton.Depth = 0;
            this.vkButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.vkButton.FlatAppearance.BorderSize = 5;
            this.vkButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.vkButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.vkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vkButton.Location = new System.Drawing.Point(177, 121);
            this.vkButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.vkButton.Name = "vkButton";
            this.vkButton.Primary = true;
            this.vkButton.Size = new System.Drawing.Size(183, 37);
            this.vkButton.TabIndex = 3;
            this.vkButton.Text = "Вконтакте";
            this.vkButton.UseVisualStyleBackColor = false;
            this.vkButton.Click += new System.EventHandler(this.vkButton_Click);
            // 
            // instagramButton
            // 
            this.instagramButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.instagramButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.instagramButton.Depth = 0;
            this.instagramButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.instagramButton.FlatAppearance.BorderSize = 5;
            this.instagramButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.instagramButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.instagramButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instagramButton.Location = new System.Drawing.Point(177, 170);
            this.instagramButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.instagramButton.Name = "instagramButton";
            this.instagramButton.Primary = true;
            this.instagramButton.Size = new System.Drawing.Size(183, 37);
            this.instagramButton.TabIndex = 4;
            this.instagramButton.Text = "Instagram";
            this.instagramButton.UseVisualStyleBackColor = false;
            this.instagramButton.Click += new System.EventHandler(this.instagramButton_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.materialRaisedButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.materialRaisedButton1.FlatAppearance.BorderSize = 5;
            this.materialRaisedButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.materialRaisedButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.materialRaisedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialRaisedButton1.Location = new System.Drawing.Point(177, 219);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(183, 37);
            this.materialRaisedButton1.TabIndex = 5;
            this.materialRaisedButton1.Text = "Facebook";
            this.materialRaisedButton1.UseVisualStyleBackColor = false;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 319);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.instagramButton);
            this.Controls.Add(this.vkButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 319);
            this.MinimumSize = new System.Drawing.Size(550, 319);
            this.Name = "MainWindowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выберите социальную сеть";
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton vkButton;
        private MaterialSkin.Controls.MaterialRaisedButton instagramButton;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}

