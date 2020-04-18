using System;
using System.Drawing;

namespace IMGResizer
{
    class ImageResize
    {
        private String inImagePath;
        private int afterSize;
        private int baseSide;

        //ドラッグアンドドロップしたイメージのパス
        public void setInputImagePath(String inImagePath)
        {
            this.inImagePath = inImagePath;
        }

        //リサイズ後のサイズ
        public void setAfterSize(int afterSize)
        {
            this.afterSize = afterSize;
        }

        //リサイズの
        public Boolean setBaseSide(int baseSide)
        {
            this.baseSide = baseSide;
            if (this.baseSide != 1 || this.baseSide != 2)
            {
                return false;
            }
            return true;
        }

        //リサイズ処理開始
        public Bitmap startResize()
        {
            System.Drawing.Imaging.ImageFormat imageFormat;
            //リサイズ前のイメージの読み取り
            Bitmap before = new Bitmap(inImagePath);

            int resizeWidth = 0;
            int resizeHeight = 0;
            if (baseSide == 1)
            {
                resizeWidth = afterSize;
                resizeHeight = (int)((before.Height * resizeWidth) / before.Width);
            }
            else if (baseSide == 2)
            {
                resizeHeight = afterSize;
                resizeWidth = (int)((before.Width * resizeHeight) / before.Height);
            }

            Bitmap after = null;
            try
            {
                after = new Bitmap(resizeWidth, resizeHeight);
            }
            catch (System.ArgumentException)
            {
                return after;
            }
            //リサイズ後のイメージ


            Graphics graphics = Graphics.FromImage(after);
            graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            graphics.DrawImage(before, 0, 0, resizeWidth, resizeHeight);
            graphics.Dispose();
            before.Dispose();
            return after;
        }
    }
}
