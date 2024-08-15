using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// folder browser dialog sadece folderları gösterir
// context menu strip sağ tıkla buton gösterir, opening event'i vardır
// list view full row select true yap

namespace DirectoryAndFileSample
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            if (fbdGetFolder.ShowDialog() == DialogResult.OK)
            {
                txtFolderPath.Text = fbdGetFolder.SelectedPath; // SelectedPath özelliği kullanıcının seçtiği path'e ulaşır
            }
        }

        private void btnGetFolderNames_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFolderPath.Text))
            {
                string path = txtFolderPath.Text;
                string[] directories = Directory.GetDirectories(path); // path'teki folderları str dizisi olarak döndürür
                ListDirectories(directories);
            }
        }

        private void ListDirectories(string[] directories)
        {
            lvFolderList.Items.Clear();
            if (directories.Length > 0)
            {
                int index = 0;
                int rowCount = 0;

                foreach (string item in directories)
                {
                    rowCount++;
                    DirectoryInfo di = new DirectoryInfo(item);
                    lvFolderList.Items.Add(rowCount.ToString());
                    lvFolderList.Items[index].SubItems.Add(di.Name);
                    lvFolderList.Items[index].SubItems.Add(di.FullName);
                    index++;
                }
            }
        }

        private void cntMenuDetail_Opening(object sender, CancelEventArgs e)
        {
            if (lvFolderList.Items.Count == 0)
                cntMenuDetail.Enabled = false;
            else
                cntMenuDetail.Enabled = true;

        }

        private void cntMenuDetail_Click(object sender, EventArgs e)
        {
            if (lvFolderList.Items.Count > 0)
            {
                if (lvFolderList.SelectedItems.Count > 0)
                {
                    string path = lvFolderList.SelectedItems[0].SubItems[2].Text;
                    //MessageBox.Show(path);
                    // path form3e gidecek
                    // Aşağıda form3ü açmak için gerekli işlemler
                    Form3 frm = new Form3(path);
                    frm.ShowDialog();
                }
            }
        }
    }
}
