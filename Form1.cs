using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace Viewing_Images
{
    public partial class ViewingImagesForm : Form
    {
        public ViewingImagesForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string query="insert into ImageInfo(Name,Address,Email)values('"+txtName.Text.ToString()+"','"+ txtAddress.Text.ToString() + "','" + txtEmail.Text.ToString() + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
           

            MessageBox.Show("Success");
        }

        private void FolderTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string path = @"C:\Users\Mustafa\Documents\Visual Studio 2015\Projects\Viewing Images\Viewing Images\bin\Debug\";
         
                                     string filePath = Application.StartupPath +@"\"+ FolderTreeView.SelectedNode.FullPath;
            try
            {
             if(  File.Exists(filePath))
                picViewer.Image = Image.FromFile(filePath);
            }
            catch(Exception ex)
            {

            }



        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=Database1.mdf;Integrated Security=True");


        private void ViewingImagesForm_Load(object sender, EventArgs e)
        {
           
          
        }
    }
}
