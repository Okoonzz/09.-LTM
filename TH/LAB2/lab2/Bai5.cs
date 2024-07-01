using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{

    public partial class Bai5 : Form
    {

        static class NativeMethods
        {
            [StructLayout(LayoutKind.Sequential)]
            public struct SHFILEINFO
            {
                public IntPtr hIcon;
                public int iIcon;
                public uint dwAttributes;
                [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
                public string szDisplayName;
                [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
                public string szTypeName;
            };
            public const uint SHGFI_ICON = 0x100;
            public const uint SHGFI_LARGEICON = 0x0;
            public const uint SHGFI_SMALLICON = 0x1;
            public const uint FILE_ATTRIBUTE_NORMAL = 0x80;
            public const uint SHGFI_TYPENAME = 0x000000400;
            public const uint SHGFI_USEFILEATTRIBUTES = 0x000000010;


            [DllImport("C:\\Windows\\System32\\shell32.dll")]
            public static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi, uint cbSizeFileInfo, uint uFlags);

            [DllImport("C:\\Windows\\System32\\user32.dll", SetLastError = true)]
            public static extern bool DestroyIcon(IntPtr hIcon);
            public static Icon GetFileIcon(string name, uint flags)
            {
                SHFILEINFO shfi = new SHFILEINFO();
                uint x = (uint)SHGetFileInfo(name,
                    FILE_ATTRIBUTE_NORMAL,
                    ref shfi,
                    (uint)System.Runtime.InteropServices.Marshal.SizeOf(shfi),
                    SHGFI_ICON | flags);

                Icon icon = (Icon)Icon.FromHandle(shfi.hIcon).Clone();
                DestroyIcon(shfi.hIcon);
                return icon;
            }
        }
        public Bai5()
        {
            InitializeComponent();
        }

        private int _icon(string path, out string typeName)
        {
            NativeMethods.SHFILEINFO shinfo = new NativeMethods.SHFILEINFO();
            NativeMethods.SHGetFileInfo(path, 0, ref shinfo, (uint)Marshal.SizeOf(shinfo),NativeMethods.SHGFI_ICON | NativeMethods.SHGFI_TYPENAME);
            using (Icon icon = Icon.FromHandle(shinfo.hIcon))
            {
                Icon iconCp = (Icon)icon.Clone();

                if (listView1.SmallImageList == null)
                {
                    listView1.SmallImageList = new ImageList();
                }
                listView1.SmallImageList.Images.Add(iconCp);
                typeName = shinfo.szTypeName;
                int index = listView1.SmallImageList.Images.Count - 1;
                NativeMethods.DestroyIcon(shinfo.hIcon);
                return index;
            }
        }

        private void DisplayFile(FileInfo files)
        {
            string nametype;
            int imageIdx = _icon(files.FullName, out nametype);
            ListViewItem item = new ListViewItem(" "+files.Name);
            item.SubItems.Add(files.LastWriteTime.ToString("dd/MM/yyyy HH:mm tt"));
            item.SubItems.Add(nametype);
            item.SubItems.Add($"{(files.Length / 1024)+1} KB");
            item.ImageIndex = imageIdx;
            listView1.Items.Add(item);
        }

        private void DisplayFolder(DirectoryInfo files)
        {
            string nametype;
            int imageIdx = _icon(files.FullName, out nametype);
            ListViewItem item = new ListViewItem(" "+ files.Name);
            item.SubItems.Add(files.LastWriteTime.ToString("dd/MM/yyyy HH:mm tt"));
            item.SubItems.Add("File Folder");   
            item.ImageIndex = imageIdx;
            listView1.Items.Add(item);
        }



        private void brow_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                path.Text = fbd.SelectedPath;
                DirectoryInfo di = new DirectoryInfo(path.Text);

                DirectoryInfo[] directories = di.GetDirectories();
                foreach (DirectoryInfo dir in directories)
                {
                    DisplayFolder(dir);
                }

                FileInfo[] files = di.GetFiles();
                foreach( FileInfo fi in files)
                {
                    DisplayFile(fi);
                }

            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            string currentDirectory = path.Text;
            string parentDirectory = Directory.GetParent(currentDirectory)?.FullName;
            if (!string.IsNullOrEmpty(parentDirectory))
            {
                path.Text= parentDirectory;
                DirectoryInfo di = new DirectoryInfo(parentDirectory);
                DirectoryInfo[] directories = di.GetDirectories();
                listView1.Items.Clear();
                foreach (DirectoryInfo dir in directories)
                {
                    DisplayFolder(dir);
                }

                FileInfo[] files = di.GetFiles();
                foreach (FileInfo fi in files)
                {
                    DisplayFile(fi);
                }
            }
            else
            {
                this.Close();
            }
        }
    }
}
