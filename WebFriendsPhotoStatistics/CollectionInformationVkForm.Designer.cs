
namespace WebFriendsPhotoStatistics
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
            this.friendsListBox = new System.Windows.Forms.ListBox();
            this.dateTimePhotosFriendListBox = new System.Windows.Forms.ListBox();
            this.listFriendsLabel = new MaterialSkin.Controls.MaterialLabel();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.listDateLabel = new MaterialSkin.Controls.MaterialLabel();
            this.mostInactivePeriodLabel = new MaterialSkin.Controls.MaterialLabel();
            this.periodLabel = new MaterialSkin.Controls.MaterialLabel();
            this.nameAuthorizedLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.nameAuthorizedLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.loadingPictureBox = new System.Windows.Forms.PictureBox();
            this.backButton = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.loadingPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // friendsListBox
            // 
            this.friendsListBox.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.friendsListBox.FormattingEnabled = true;
            this.friendsListBox.ItemHeight = 14;
            this.friendsListBox.Location = new System.Drawing.Point(12, 138);
            this.friendsListBox.Name = "friendsListBox";
            this.friendsListBox.Size = new System.Drawing.Size(246, 368);
            this.friendsListBox.TabIndex = 0;
            this.friendsListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.friendsListBox_MouseDoubleClick);
            // 
            // dateTimePhotosFriendListBox
            // 
            this.dateTimePhotosFriendListBox.FormattingEnabled = true;
            this.dateTimePhotosFriendListBox.Location = new System.Drawing.Point(264, 138);
            this.dateTimePhotosFriendListBox.Name = "dateTimePhotosFriendListBox";
            this.dateTimePhotosFriendListBox.Size = new System.Drawing.Size(218, 316);
            this.dateTimePhotosFriendListBox.TabIndex = 2;
            // 
            // listFriendsLabel
            // 
            this.listFriendsLabel.AutoSize = true;
            this.listFriendsLabel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.listFriendsLabel.Depth = 0;
            this.listFriendsLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.listFriendsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listFriendsLabel.Location = new System.Drawing.Point(12, 116);
            this.listFriendsLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.listFriendsLabel.Name = "listFriendsLabel";
            this.listFriendsLabel.Size = new System.Drawing.Size(150, 19);
            this.listFriendsLabel.TabIndex = 5;
            this.listFriendsLabel.Text = "Ваш список друзей:";
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(488, 80);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(473, 427);
            this.webBrowser.TabIndex = 6;
            this.webBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // listDateLabel
            // 
            this.listDateLabel.AutoSize = true;
            this.listDateLabel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.listDateLabel.Depth = 0;
            this.listDateLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.listDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listDateLabel.Location = new System.Drawing.Point(263, 116);
            this.listDateLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.listDateLabel.Name = "listDateLabel";
            this.listDateLabel.Size = new System.Drawing.Size(140, 19);
            this.listDateLabel.TabIndex = 7;
            this.listDateLabel.Text = "Даты публикации:";
            // 
            // mostInactivePeriodLabel
            // 
            this.mostInactivePeriodLabel.AutoSize = true;
            this.mostInactivePeriodLabel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.mostInactivePeriodLabel.Depth = 0;
            this.mostInactivePeriodLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.mostInactivePeriodLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mostInactivePeriodLabel.Location = new System.Drawing.Point(264, 464);
            this.mostInactivePeriodLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mostInactivePeriodLabel.Name = "mostInactivePeriodLabel";
            this.mostInactivePeriodLabel.Size = new System.Drawing.Size(218, 19);
            this.mostInactivePeriodLabel.TabIndex = 8;
            this.mostInactivePeriodLabel.Text = "Самый безактивный период:";
            // 
            // periodLabel
            // 
            this.periodLabel.AutoSize = true;
            this.periodLabel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.periodLabel.Depth = 0;
            this.periodLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.periodLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.periodLabel.Location = new System.Drawing.Point(264, 487);
            this.periodLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.periodLabel.Name = "periodLabel";
            this.periodLabel.Size = new System.Drawing.Size(84, 19);
            this.periodLabel.TabIndex = 9;
            this.periodLabel.Text = "Не найден";
            // 
            // nameAuthorizedLabel1
            // 
            this.nameAuthorizedLabel1.AutoSize = true;
            this.nameAuthorizedLabel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.nameAuthorizedLabel1.Depth = 0;
            this.nameAuthorizedLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.nameAuthorizedLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nameAuthorizedLabel1.Location = new System.Drawing.Point(12, 79);
            this.nameAuthorizedLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.nameAuthorizedLabel1.Name = "nameAuthorizedLabel1";
            this.nameAuthorizedLabel1.Size = new System.Drawing.Size(114, 19);
            this.nameAuthorizedLabel1.TabIndex = 12;
            this.nameAuthorizedLabel1.Text = "Вы вошли как:";
            // 
            // nameAuthorizedLabel2
            // 
            this.nameAuthorizedLabel2.AutoSize = true;
            this.nameAuthorizedLabel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.nameAuthorizedLabel2.Depth = 0;
            this.nameAuthorizedLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.nameAuthorizedLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nameAuthorizedLabel2.Location = new System.Drawing.Point(132, 79);
            this.nameAuthorizedLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.nameAuthorizedLabel2.Name = "nameAuthorizedLabel2";
            this.nameAuthorizedLabel2.Size = new System.Drawing.Size(109, 19);
            this.nameAuthorizedLabel2.TabIndex = 13;
            this.nameAuthorizedLabel2.Text = "Имя Фамилия";
            // 
            // loadingPictureBox
            // 
            this.loadingPictureBox.BackgroundImage = global::WebFriendsPhotoStatistics.Properties.Resources.loading;
            this.loadingPictureBox.Location = new System.Drawing.Point(12, 78);
            this.loadingPictureBox.Name = "loadingPictureBox";
            this.loadingPictureBox.Size = new System.Drawing.Size(949, 428);
            this.loadingPictureBox.TabIndex = 14;
            this.loadingPictureBox.TabStop = false;
            // 
            // backButton
            // 
            this.backButton.Depth = 0;
            this.backButton.Location = new System.Drawing.Point(865, 31);
            this.backButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.backButton.Name = "backButton";
            this.backButton.Primary = true;
            this.backButton.Size = new System.Drawing.Size(99, 23);
            this.backButton.TabIndex = 15;
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
            this.Controls.Add(this.loadingPictureBox);
            this.Controls.Add(this.nameAuthorizedLabel2);
            this.Controls.Add(this.nameAuthorizedLabel1);
            this.Controls.Add(this.periodLabel);
            this.Controls.Add(this.mostInactivePeriodLabel);
            this.Controls.Add(this.listDateLabel);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.listFriendsLabel);
            this.Controls.Add(this.dateTimePhotosFriendListBox);
            this.Controls.Add(this.friendsListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(976, 519);
            this.MinimumSize = new System.Drawing.Size(976, 519);
            this.Name = "YourAccountVkForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ваш аккаунт Вконтакте";
            this.Shown += new System.EventHandler(this.YourAccountVk_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.loadingPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox friendsListBox;
        private System.Windows.Forms.ListBox dateTimePhotosFriendListBox;
        private MaterialSkin.Controls.MaterialLabel listFriendsLabel;
        private System.Windows.Forms.WebBrowser webBrowser;
        private MaterialSkin.Controls.MaterialLabel listDateLabel;
        private MaterialSkin.Controls.MaterialLabel mostInactivePeriodLabel;
        private MaterialSkin.Controls.MaterialLabel periodLabel;
        private MaterialSkin.Controls.MaterialLabel nameAuthorizedLabel1;
        private MaterialSkin.Controls.MaterialLabel nameAuthorizedLabel2;
        private System.Windows.Forms.PictureBox loadingPictureBox;
        private MaterialSkin.Controls.MaterialRaisedButton backButton;
    }
}