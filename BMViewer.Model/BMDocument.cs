using System;
using System.Drawing;

namespace BMViewer.Model
{
    /// <summary>
    /// Класс описывающий BitMap изображение
    /// </summary>
    public class BMDocument
    {
        /// <summary>
        /// Исходное изображение
        /// </summary>
        public Bitmap SourceImage { get; set; }

        /// <summary>
        /// Скоректированное изображение
        /// </summary>
        public Bitmap AdjustedImage { get; set; }

        /// <summary>
        /// Название файла
        /// </summary>
        public String FileName { get; set; }

        /// <summary>
        /// Статус, открыт или закрыт файл
        /// </summary>
        public bool IsOpen { get; set; } = false;

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="sourceImage">Исходное изображение</param>
        /// <param name="fileName">Название файла</param>
        public BMDocument(Bitmap sourceImage, String fileName)
        {
            SourceImage = sourceImage;
            AdjustedImage = SourceImage;
            FileName = fileName;
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public BMDocument() { }
    }
}
