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
            CategoryImages.Add(new Tuple<CategoryEnum, Bitmap>(CategoryEnum.Acustic, new Bitmap("acustic.png")));
            CategoryImages.Add(new Tuple<CategoryEnum, Bitmap>(CategoryEnum.Blues, new Bitmap("blues.png")));
            CategoryImages.Add(new Tuple<CategoryEnum, Bitmap>(CategoryEnum.Classical, new Bitmap("classical.png")));
            CategoryImages.Add(new Tuple<CategoryEnum, Bitmap>(CategoryEnum.Jazz, new Bitmap("jazz.png")));
            CategoryImages.Add(new Tuple<CategoryEnum, Bitmap>(CategoryEnum.Metal, new Bitmap("metal.png")));
            CategoryImages.Add(new Tuple<CategoryEnum, Bitmap>(CategoryEnum.Pop, new Bitmap("pop.png")));
            CategoryImages.Add(new Tuple<CategoryEnum, Bitmap>(CategoryEnum.Rock, new Bitmap("rock.png")));
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
