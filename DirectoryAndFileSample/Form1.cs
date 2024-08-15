namespace DirectoryAndFileSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDriveInfo_Click(object sender, EventArgs e)
        {
            // Disk �zerindeki s�r�c� bilgilerini almak i�in kullan�lan s�n�f DriveInfo s�n�f�
            DriveInfo di = new DriveInfo(@"C:\");
            string driveInfo = string.Empty;
            driveInfo = $"Drive Name: {di.Name}\n" +
                $"Drive Prefix: {di.VolumeLabel}\n" +
                $"Total Free Space: {di.TotalSize}\n" +
                $"Available Free Space: {di.AvailableFreeSpace}";

            MessageBox.Show(driveInfo);
        }

        private void btnDirectoryInfo_Click(object sender, EventArgs e)
        {
            // Bir klas�r�n bilgilerini i�letim sisteminden alabilmek i�in kullan�lan s�n�f DirectoryInfo s�n�f�d�r
            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\AppContent");
            string directoryInfo = string.Empty;
            directoryInfo = $"Folder Path: {dirInfo.FullName}\n" +
                $"Directory Name: {dirInfo.Name}\n" +
                $"Parent Directory Name: {dirInfo.Parent}\n" +
                $"File Type: {dirInfo.Attributes}\n" +
                $"Creation Time: {dirInfo.CreationTime.ToString("yyyy-MM-dd HH:mm:ss")}\n" +
                $"Last Write Time: {dirInfo.LastWriteTime.ToString("yyyy-MM-dd HH:mm:ss")}\n";

            MessageBox.Show(directoryInfo);
        }

        private void btnDirectoryOperations_Click(object sender, EventArgs e)
        {
            // Directory static class, �rne�ini almaya gerek yok (Math gibi)
            if (Directory.Exists(@"C:\NewDirectory"))
                Directory.Delete(@"C:\NewDirectory");
            // Varsa sil, yoksa olu�tur
            Directory.CreateDirectory(@"C:\NewDirectory");
        }

        private void btnMoveDirectory_Click(object sender, EventArgs e)
        {
            string sourceDir = @"C:\AppContent";
            string destinationDir = @"C:\NewDirectory\MoveHere";
            Directory.Move(sourceDir, destinationDir);
        }

        private void btnMoveF�le_Click(object sender, EventArgs e)
        {

            string sourceFile = @"C:\NewDirectory\MoveHere\People.txt";
            string destinationFile = @"C:\NewDirectory\NewPeople.txt";
            File.Move(sourceFile, destinationFile);
        }
    }
}
