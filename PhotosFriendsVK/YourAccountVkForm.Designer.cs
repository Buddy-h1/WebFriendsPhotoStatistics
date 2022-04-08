
namespace PhotosFriendsVK
{
    partial class YourAccountVkForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YourAccountVkForm));
            this.nameAuthorizedLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.nameAuthorizedLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.friendsListBox = new System.Windows.Forms.ListBox();
            this.datesPhotosFriendsListBox = new System.Windows.Forms.ListBox();
            this.listFriendsLabel = new MaterialSkin.Controls.MaterialLabel();
            this.listDateLabel = new MaterialSkin.Controls.MaterialLabel();
            this.mostInactivePeriodLabel = new MaterialSkin.Controls.MaterialLabel();
            this.periodLabel = new MaterialSkin.Controls.MaterialLabel();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.backButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // nameAuthorizedLabel1
            // 
            this.nameAuthorizedLabel1.AutoSize = true;
            this.nameAuthorizedLabel1.Depth = 0;
            this.nameAuthorizedLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.nameAuthorizedLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nameAuthorizedLabel1.Location = new System.Drawing.Point(8, 75);
            this.nameAuthorizedLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.nameAuthorizedLabel1.Name = "nameAuthorizedLabel1";
            this.nameAuthorizedLabel1.Size = new System.Drawing.Size(114, 19);
            this.nameAuthorizedLabel1.TabIndex = 0;
            this.nameAuthorizedLabel1.Text = "Вы вошли как:";
            // 
            // nameAuthorizedLabel2
            // 
            this.nameAuthorizedLabel2.AutoSize = true;
            this.nameAuthorizedLabel2.Depth = 0;
            this.nameAuthorizedLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.nameAuthorizedLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nameAuthorizedLabel2.Location = new System.Drawing.Point(128, 75);
            this.nameAuthorizedLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.nameAuthorizedLabel2.Name = "nameAuthorizedLabel2";
            this.nameAuthorizedLabel2.Size = new System.Drawing.Size(109, 19);
            this.nameAuthorizedLabel2.TabIndex = 1;
            this.nameAuthorizedLabel2.Text = "Имя Фамилия";
            // 
            // friendsListBox
            // 
            this.friendsListBox.FormattingEnabled = true;
            this.friendsListBox.Location = new System.Drawing.Point(12, 159);
            this.friendsListBox.Name = "friendsListBox";
            this.friendsListBox.Size = new System.Drawing.Size(246, 342);
            this.friendsListBox.TabIndex = 2;
            this.friendsListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.friendsListBox_MouseDoubleClick);
            // 
            // datesPhotosFriendsListBox
            // 
            this.datesPhotosFriendsListBox.FormattingEnabled = true;
            this.datesPhotosFriendsListBox.Location = new System.Drawing.Point(264, 159);
            this.datesPhotosFriendsListBox.Name = "datesPhotosFriendsListBox";
            this.datesPhotosFriendsListBox.Size = new System.Drawing.Size(218, 303);
            this.datesPhotosFriendsListBox.TabIndex = 3;
            // 
            // listFriendsLabel
            // 
            this.listFriendsLabel.AutoSize = true;
            this.listFriendsLabel.Depth = 0;
            this.listFriendsLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.listFriendsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listFriendsLabel.Location = new System.Drawing.Point(12, 137);
            this.listFriendsLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.listFriendsLabel.Name = "listFriendsLabel";
            this.listFriendsLabel.Size = new System.Drawing.Size(150, 19);
            this.listFriendsLabel.TabIndex = 4;
            this.listFriendsLabel.Text = "Ваш список друзей:";
            // 
            // listDateLabel
            // 
            this.listDateLabel.AutoSize = true;
            this.listDateLabel.Depth = 0;
            this.listDateLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.listDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listDateLabel.Location = new System.Drawing.Point(265, 137);
            this.listDateLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.listDateLabel.Name = "listDateLabel";
            this.listDateLabel.Size = new System.Drawing.Size(140, 19);
            this.listDateLabel.TabIndex = 5;
            this.listDateLabel.Text = "Даты публикации:";
            // 
            // mostInactivePeriodLabel
            // 
            this.mostInactivePeriodLabel.AutoSize = true;
            this.mostInactivePeriodLabel.Depth = 0;
            this.mostInactivePeriodLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.mostInactivePeriodLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mostInactivePeriodLabel.Location = new System.Drawing.Point(264, 468);
            this.mostInactivePeriodLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mostInactivePeriodLabel.Name = "mostInactivePeriodLabel";
            this.mostInactivePeriodLabel.Size = new System.Drawing.Size(218, 19);
            this.mostInactivePeriodLabel.TabIndex = 6;
            this.mostInactivePeriodLabel.Text = "Самый безактивный период:";
            // 
            // periodLabel
            // 
            this.periodLabel.AutoSize = true;
            this.periodLabel.Depth = 0;
            this.periodLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.periodLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.periodLabel.Location = new System.Drawing.Point(264, 491);
            this.periodLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.periodLabel.Name = "periodLabel";
            this.periodLabel.Size = new System.Drawing.Size(84, 19);
            this.periodLabel.TabIndex = 7;
            this.periodLabel.Text = "Не найден";
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(488, 75);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(473, 427);
            this.webBrowser.TabIndex = 8;
            // 
            // backButton
            // 
            this.backButton.Depth = 0;
            this.backButton.Location = new System.Drawing.Point(873, 31);
            this.backButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.backButton.Name = "backButton";
            this.backButton.Primary = true;
            this.backButton.Size = new System.Drawing.Size(91, 23);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "Выйти";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // YourAccountVkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 519);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.periodLabel);
            this.Controls.Add(this.mostInactivePeriodLabel);
            this.Controls.Add(this.listDateLabel);
            this.Controls.Add(this.listFriendsLabel);
            this.Controls.Add(this.datesPhotosFriendsListBox);
            this.Controls.Add(this.friendsListBox);
            this.Controls.Add(this.nameAuthorizedLabel2);
            this.Controls.Add(this.nameAuthorizedLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(976, 519);
            this.MinimumSize = new System.Drawing.Size(976, 519);
            this.Name = "YourAccountVkForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ваш аккаунт Вконтакте";
            this.Shown += new System.EventHandler(this.YourAccountVkForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel nameAuthorizedLabel1;
        private MaterialSkin.Controls.MaterialLabel nameAuthorizedLabel2;
        private System.Windows.Forms.ListBox friendsListBox;
        private System.Windows.Forms.ListBox datesPhotosFriendsListBox;
        private MaterialSkin.Controls.MaterialLabel listFriendsLabel;
        private MaterialSkin.Controls.MaterialLabel listDateLabel;
        private MaterialSkin.Controls.MaterialLabel mostInactivePeriodLabel;
        private MaterialSkin.Controls.MaterialLabel periodLabel;
        private System.Windows.Forms.WebBrowser webBrowser;
        private MaterialSkin.Controls.MaterialRaisedButton backButton;
    }
}