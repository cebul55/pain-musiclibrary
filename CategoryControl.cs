using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pik_biblioteka_muzyczna {
    public partial class CategoryControl : UserControl {
        private List<Tuple<CategoryEnum , Bitmap> > CategoryImages;
        public event Action<CategoryEnum> categoryChangeEvent;
        private CategoryEnum currentCategory;

        [Editor(typeof(CategoryControlEditor),
            typeof(System.Drawing.Design.UITypeEditor))]
        [Category("Category Control")]
        [Browsable(true)]



        public CategoryEnum CurrentCategory {
            get { return currentCategory;  }
            set {
                //todo implement setting currentCategory
            }
        }
        public CategoryControl() {
            InitializeComponent();
            setUpCategoryImages();
            currentCategory = CategoryEnum.Acustic;
        }
        public CategoryControl(string value) {
            InitializeComponent();
            setUpCategoryImages();
            Enum.TryParse(value, false, out CategoryEnum result);
            if (!Enum.IsDefined(typeof(CategoryEnum), result))
                currentCategory = CategoryEnum.Acustic;
            else
                currentCategory = result;
        }
        private void CategoryControlLoad(object sender, EventArgs e) {
            categoryChangeEvent?.Invoke(currentCategory);
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

        protected override void OnPaint(PaintEventArgs e) {
            float width = Size.Width;
            float height = Size.Height;
            var image = CategoryImages[(int)currentCategory].Item2;
            float scale = Math.Min(width / image.Width, height / image.Height);

            var newImage = new Bitmap((int)width, (int)height);
            var scaleWidth = (int)(image.Width * scale);
            var scaleHeight = (int)(image.Height * scale);

            e.Graphics.DrawImage(image, ((int)width - scaleWidth) / 2, ((int)height - scaleHeight) / 2, scaleWidth, scaleHeight);
        }
        protected override void OnClick(EventArgs e) {
            //todo changing to next element !
            categoryChangeEvent?.Invoke(currentCategory);
            Invalidate();
        }

    }
}
