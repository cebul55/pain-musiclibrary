using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pik_biblioteka_muzyczna{
    public class Song{
        public string Title{
            get;
            set;
        }

        public string Author{
            get;
            set;
        }

        public DateTime RecordDate {
            get;
            set;
        }

        public String Category {
            get;
            set;
        }

        Song(string title, string author, DateTime recordDate, string Category) {
            this.Title = title;
            this.Author = author;
            this.RecordDate = recordDate;
            this.Category = Category;
        }

    }
}
