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
                if ((int)value < 0 || (int)value > Enum.GetNames(typeof(CategoryEnum)).Length)
                    currentCategory = CategoryEnum.Acustic;
                else {
                    currentCategory = value;
                }
                Invalidate();
                categoryChangeEvent?.Invoke(currentCategory);
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
            CategoryImages.Add(new Tuple<CategoryEnum, Bitmap>(CategoryEnum.Acustic, new Bitmap(Properties.Resources.acustic)));
            CategoryImages.Add(new Tuple<CategoryEnum, Bitmap>(CategoryEnum.Blues, new Bitmap(Properties.Resources.blues)));
            CategoryImages.Add(new Tuple<CategoryEnum, Bitmap>(CategoryEnum.Classical, new Bitmap(Properties.Resources.classical)));
            CategoryImages.Add(new Tuple<CategoryEnum, Bitmap>(CategoryEnum.Jazz, new Bitmap(Properties.Resources.jazz)));
            CategoryImages.Add(new Tuple<CategoryEnum, Bitmap>(CategoryEnum.Metal, new Bitmap(Properties.Resources.metal)));
            CategoryImages.Add(new Tuple<CategoryEnum, Bitmap>(CategoryEnum.Pop, new Bitmap(Properties.Resources.pop)));
            CategoryImages.Add(new Tuple<CategoryEnum, Bitmap>(CategoryEnum.Rock, new Bitmap(Properties.Resources.rock)));
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
            currentCategory = (CategoryEnum)(((int)currentCategory + 1) % Enum.GetNames(typeof(CategoryEnum)).Length);
            categoryChangeEvent?.Invoke(currentCategory);
            Invalidate();
        }

    }
}
