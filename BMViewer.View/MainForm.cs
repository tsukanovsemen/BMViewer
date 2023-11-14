using BMViewer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMViewer.View
{
    /// <summary>
    /// Главная форма приложения
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Константное значение размытия изображения
        /// </summary>
        private const Int32 BLUR_VALUE = 3;

        /// <summary>
        /// Документ изображения
        /// </summary>
        public BMDocument BMIamge { get; private set; }

        public MainForm()
        {
            InitializeComponent();
            BMIamge = new BMDocument();
            UpdateMenu();
            UpdatePictureBox(BMIamge.SourceImage);
        }

        private void BrightnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckIsOpenFile())
            {
                BrightnessToolStripMenuItem.Checked = !BrightnessToolStripMenuItem.Checked;
                BrightnesTrackBar.Enabled = BrightnessToolStripMenuItem.Checked;
                ContrastToolStripMenuItem.Enabled = !BrightnessToolStripMenuItem.Checked;
                BlurToolStripMenuItem.Enabled = !BrightnessToolStripMenuItem.Checked;
            } 
            else
            {
                DialogResult rezult = MessageBox.Show("Изображение не открыто",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckIsOpenFile())
            {
                BlurToolStripMenuItem.Checked = !BlurToolStripMenuItem.Checked;
                ContrastToolStripMenuItem.Enabled = !BlurToolStripMenuItem.Checked;
                BrightnessToolStripMenuItem.Enabled = !BlurToolStripMenuItem.Checked;
                if (BlurToolStripMenuItem.Checked)
                {
                    BMIamge.AdjustedImage = Filters.AdjusBlur(BMIamge.SourceImage,
                        new Rectangle(0, 0, BMIamge.SourceImage.Width, BMIamge.SourceImage.Height), BLUR_VALUE);

                    UpdatePictureBox(BMIamge.AdjustedImage);
                }
                else
                {
                    UpdatePictureBox(BMIamge.SourceImage);
                }
            } 
            else
            {
                DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ContrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckIsOpenFile())
            {
                ContrastToolStripMenuItem.Checked = !ContrastToolStripMenuItem.Checked;
                ContrastTrackBar.Enabled = ContrastToolStripMenuItem.Checked;
                BlurToolStripMenuItem.Enabled = !ContrastToolStripMenuItem.Checked;
                BrightnessToolStripMenuItem.Enabled = !ContrastToolStripMenuItem.Checked;
            }
            else
            {
                DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog(); //создание диалогового окна для выбора файла
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"; //формат загружаемого файла
            if (open_dialog.ShowDialog() == DialogResult.OK) //если в окне была нажата кнопка "ОК"
            {
                try
                {
                    BMIamge.SourceImage = new Bitmap(open_dialog.FileName);
                    BMIamge.AdjustedImage = BMIamge.SourceImage;
                    BMIamge.FileName = open_dialog.FileName;
                    BMIamge.IsOpen = true;
                    UpdateMenu(); 
                    UpdatePictureBox(BMIamge.AdjustedImage);
                    LoadedImage.Invalidate();
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BMIamge.SourceImage = null;
            BMIamge.AdjustedImage = null;
            BMIamge.FileName = null;
            BMIamge.IsOpen = false;
            UpdateMenu();
            UpdatePictureBox(BMIamge.AdjustedImage);
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoadedImage.Image != null) 
            {
                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Title = "Сохранить картинку как...";         
                savedialog.OverwritePrompt = true;  
                savedialog.CheckPathExists = true;
                savedialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";      
                savedialog.ShowHelp = true;
                if (savedialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        BMIamge.AdjustedImage.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BrightnesTrackBar_Scroll(object sender, EventArgs e)
        {
            BMIamge.AdjustedImage = Filters.AdjustBrightness(BMIamge.SourceImage, BrightnesTrackBar.Value * 5);
            UpdatePictureBox(BMIamge.AdjustedImage);
        }

        private void ContrastTrackBar_Scroll(object sender, EventArgs e)
        {
            BMIamge.AdjustedImage = Filters.AdjusContrast(BMIamge.SourceImage, ContrastTrackBar.Value * 5);
            UpdatePictureBox(BMIamge.AdjustedImage);
        }

        /// <summary>
        /// Проверка открыт файл или нет
        /// </summary>
        /// <returns>true - если да, false - если нет</returns>
        private bool CheckIsOpenFile()
        {
            return BMIamge.IsOpen;
        }

        /// <summary>
        /// Обновляет поля меню
        /// </summary>
        private void UpdateMenu()
        {
            if(BMIamge.IsOpen)
            {
                OpenToolStripMenuItem.Enabled = false;
                CloseToolStripMenuItem.Enabled = true;
                SaveAsToolStripMenuItem.Enabled = true;
            }
            else
            {
                OpenToolStripMenuItem.Enabled = true;
                CloseToolStripMenuItem.Enabled = false;
                SaveAsToolStripMenuItem.Enabled = false;
            }
        }

        /// <summary>
        /// Обновляет картинку приложения
        /// </summary>
        /// <param name="image">Картинка</param>
        private void UpdatePictureBox(Bitmap image)
        {
            LoadedImage.Image = image;
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработчик: Цуканов Семен Сергеевич, 580-1 г. 2023г", "О программе",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
