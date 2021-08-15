namespace Viewing_Images
{
    partial class ViewingImagesForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Sub Folder 1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("1.jpg");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Sub Folder 2", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("1.jpg");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("2.jpg");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("3.jpg");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Pictures", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewingImagesForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.FolderTreeView = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picViewer = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picViewer)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSelectFolder);
            this.panel1.Controls.Add(this.FolderTreeView);
            this.panel1.Location = new System.Drawing.Point(2, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 446);
            this.panel1.TabIndex = 0;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(3, 411);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(173, 23);
            this.btnSelectFolder.TabIndex = 2;
            this.btnSelectFolder.Text = "Select Folder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            // 
            // FolderTreeView
            // 
            this.FolderTreeView.FullRowSelect = true;
            this.FolderTreeView.Location = new System.Drawing.Point(3, 3);
            this.FolderTreeView.Name = "FolderTreeView";
            treeNode1.Name = "Node2";
            treeNode1.Text = "Sub Folder 1";
            treeNode2.Name = "Node7";
            treeNode2.Text = "1.jpg";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Sub Folder 2";
            treeNode4.Name = "Node4";
            treeNode4.Text = "1.jpg";
            treeNode5.Name = "Node5";
            treeNode5.Text = "2.jpg";
            treeNode6.Name = "Node6";
            treeNode6.Text = "3.jpg";
            treeNode7.Name = "FolderNode";
            treeNode7.Text = "Pictures";
            this.FolderTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7});
            this.FolderTreeView.Size = new System.Drawing.Size(294, 401);
            this.FolderTreeView.TabIndex = 1;
            this.FolderTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.FolderTreeView_AfterSelect);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picViewer);
            this.panel2.Location = new System.Drawing.Point(308, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 446);
            this.panel2.TabIndex = 1;
            // 
            // picViewer
            // 
            this.picViewer.Location = new System.Drawing.Point(4, 5);
            this.picViewer.Name = "picViewer";
            this.picViewer.Size = new System.Drawing.Size(370, 409);
            this.picViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picViewer.TabIndex = 2;
            this.picViewer.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.lblEmail);
            this.panel3.Controls.Add(this.lblAddress);
            this.panel3.Controls.Add(this.lblName);
            this.panel3.Controls.Add(this.txtEmail);
            this.panel3.Controls.Add(this.txtAddress);
            this.panel3.Controls.Add(this.txtName);
            this.panel3.Location = new System.Drawing.Point(688, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 446);
            this.panel3.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(75, 243);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 28);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(179, 140);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(179, 99);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "Address";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(179, 59);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEmail.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtEmail.Location = new System.Drawing.Point(25, 130);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(128, 23);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.WordWrap = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAddress.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtAddress.Location = new System.Drawing.Point(25, 94);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(128, 23);
            this.txtAddress.TabIndex = 4;
            this.txtAddress.WordWrap = false;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtName.Location = new System.Drawing.Point(25, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(128, 23);
            this.txtName.TabIndex = 3;
            this.txtName.WordWrap = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.jpg");
            this.imageList1.Images.SetKeyName(1, "2.jpg");
            this.imageList1.Images.SetKeyName(2, "3.png");
            // 
            // ViewingImagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 496);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ViewingImagesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Viewing Images";
            this.Load += new System.EventHandler(this.ViewingImagesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picViewer)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TreeView FolderTreeView;
        private System.Windows.Forms.PictureBox picViewer;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

