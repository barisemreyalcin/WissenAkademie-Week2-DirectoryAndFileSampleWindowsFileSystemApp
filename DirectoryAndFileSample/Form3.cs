using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// split container ekle sayfayı 2'ye böler
// sola bir listbox ekledik, burada seçilmiş klasörün altındaki klasörleri görüntüleyeceğim
// sağa bir listView attık, burada da seçili klasörün altındaki file'ları görüntüleyeceğiz, view: details, grid-lines: true yap. (column eklemek için)
// dock özelliğiyle container'a fill edebilirsin bunları
// Form2 cntMenuDetail_Click kısmından devam ediyoruz

namespace DirectoryAndFileSample
{
    public partial class Form3 : Form
    {
        string fullPath = string.Empty; // path'e her yerde ulaşalım diye

        public Form3()
        {
            InitializeComponent();
        }

        // birden fazla constructor olabilir, overload method mantığı
        public Form3(string _path)
        {
            fullPath = _path; // böylece top-levelde kullanabiliriz
            InitializeComponent();

            this.Load += LoadFilesAndFolders;
            // form ilk açıldığında load event tetiklenir
        }

        private void LoadFilesAndFolders(object? sender, EventArgs e)
        {
            // file ve folderları almak için Directory kullanıcam, ikisi de string dizisi dönecek
            string[] directories = Directory.GetDirectories(fullPath);
            string[] files = Directory.GetFiles(fullPath);

            ListDirectories(directories);
            ListFiles(files);

        }

        private void ListFiles(string[] files)
        {
            int index = 0;

            foreach (string item in files)
            {
                // dosya bilgilerini almak için FileInfo
                FileInfo fi = new FileInfo(item);
                lvFileList.Items.Add(fi.Name);
                lvFileList.Items[index].SubItems.Add((fi.Length / 1024).ToString());
                lvFileList.Items[index].SubItems.Add((fi.Length / 1024 / 1024).ToString());
                lvFileList.Items[index].SubItems.Add(fi.CreationTime.ToLongDateString());
                lvFileList.Items[index].SubItems.Add(fi.Extension);

                index++;
            }
        }

        private void ListDirectories(string[] directories)
        {
            //foreach (string item in directories)
            //{
            //    lstFolderList.Items.Add(item);
            //}

            lstFolderList.Items.AddRange(directories);
        }
    }
}
