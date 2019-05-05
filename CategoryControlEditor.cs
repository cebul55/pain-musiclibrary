using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace pik_biblioteka_muzyczna {
    class CategoryControlEditor: UITypeEditor{
        private List<Tuple<CategoryEnum, Bitmap>> CategoryImages;
        private CategoryEnum currentCategory;
        public CategoryControlEditor() {
            setUpCategoryImages();
    }
        private void setUpCategoryImages() {
            CategoryImages = new List<Tuple<CategoryEnum, Bitmap>>();
            CategoryImages.Add(new Tuple<CategoryEnum, Bitmap>(CategoryEnum.Acustic, new Bitmap(Properties.Resources.acustic)));
            CategoryImages.Add(new Tuple<CategoryEnum, Bitmap>(CategoryEnum.Blues, new Bitmap(Properties.Resources.blues)));
            CategoryImages.Add(new Tuple<CategoryEnum, Bitmap>(CategoryEnum.Classical, new Bitmap(Properties.Resources.classical)));
            CategoryImages.Add(new Tuple<CategoryEnum, Bitmap>(CategoryEnum.Jazz, new Bitmap(Properties.Resources.jazz)));
            CategoryImages.Add(new Tuple<CategoryEnum, Bitmap>(CategoryEnum.Metal, new Bitmap(Properties.Resources.metal)));
            CategoryImages.Add(new Tuple<CategoryEnum, Bitmap>(CategoryEnum.Pop, new Bitmap(Properties.Resources.pop)));
            CategoryImages.Add(new Tuple<CategoryEnum, Bitmap>(CategoryEnum.Rock, new Bitmap(Properties.Resources.rock)));
        }
        public override void PaintValue(PaintValueEventArgs e) {
            float width = e.Bounds.Width;
            float height = e.Bounds.Height;


            currentCategory = (CategoryEnum)e.Value;

            var image = CategoryImages[(int)currentCategory].Item2;
            float scale = Math.Min(width / image.Width, height / image.Height);

            var bmp = new Bitmap((int)width, (int)height);

            var scaleWidth = (int)(image.Width * scale);
            var scaleHeight = (int)(image.Height * scale);

            e.Graphics.DrawImage(image, ((int)width - scaleWidth) / 2, ((int)height - scaleHeight) / 2, scaleWidth, scaleHeight);
        }
        public override bool GetPaintValueSupported(System.ComponentModel.ITypeDescriptorContext
        context) { return true; }

        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, IServiceProvider provider, object value) {
            IWindowsFormsEditorService edSvc =
            (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
            if (edSvc != null) {
                CategoryControl genreControl = new CategoryControl((string)value);
                edSvc.DropDownControl(genreControl);

                return genreControl.CurrentCategory;
            }
            return value;
        }
    }
}
