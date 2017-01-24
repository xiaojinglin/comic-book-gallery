using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
    public class ComicBook:IComparable<ComicBook>

    {
        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public Artist[] Artists { get; set; }
        public string DescriptionHtml { get; set; }
        public bool Favorite { get; set; }

        public string DesplayText
        {
            get
            {
                return SeriesTitle + " #" + IssueNumber;
            }
        }

        public string CoverImageFileName
        {
            get
            {
                return SeriesTitle.Replace(" ", "-").ToLower() + "-" + IssueNumber + ".jpg";
            }
        }

        public int CompareTo(ComicBook other)
        {
            return this.SeriesTitle.Replace(" ", "").ToLower().CompareTo(other.SeriesTitle.Replace(" ", "").ToLower());
        }
    }
}