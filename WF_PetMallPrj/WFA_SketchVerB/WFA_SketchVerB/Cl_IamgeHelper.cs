using System;
using System.IO;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace WFA_SketchVerB
{
    internal class Cl_IamgeHelper
    {
        /// <summary>
        /// 建立圖片縮圖
        /// </summary>
        /// <param name="originalImage">原始圖片</param>
        /// <param name="thumbnailWidth">縮圖寬度</param>
        /// <param name="thumbnailHeight">縮圖高度</param>
        /// <returns>縮圖 Image 物件</returns>
        public static Image CreateThumbnail(Image originalImage, int thumbnailWidth, int thumbnailHeight)
        {
            var thumbnail = new Bitmap(thumbnailWidth, thumbnailHeight);

            using (var graphics = Graphics.FromImage(thumbnail))
            {
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

                graphics.DrawImage(originalImage, 0, 0, thumbnailWidth, thumbnailHeight);
            }

            return thumbnail;
        }

        /// <summary>
        /// 建立並儲存圖片縮圖
        /// </summary>
        /// <param name="originalPath">原始圖片路徑</param>
        /// <param name="thumbnailPath">縮圖儲存路徑</param>
        /// <param name="thumbnailWidth">縮圖寬度</param>
        /// <param name="thumbnailHeight">縮圖高度</param>
        public static void CreateAndSaveThumbnail(string originalPath, string thumbnailPath, 
            int thumbnailWidth, int thumbnailHeight)
        {
            try
            {
                using (Image originalImage = Image.FromFile(originalPath))
                using (Image thumbnail = CreateThumbnail(originalImage, thumbnailWidth, thumbnailHeight))
                {
                    // 確保縮圖資料夾存在
                    string directory = Path.GetDirectoryName(thumbnailPath);
                    if (!Directory.Exists(directory))
                    {
                        Directory.CreateDirectory(directory);
                    }

                    thumbnail.Save(thumbnailPath, ImageFormat.Jpeg);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"建立縮圖時發生錯誤：{ex.Message}", ex);
            }
        }

    }
}
