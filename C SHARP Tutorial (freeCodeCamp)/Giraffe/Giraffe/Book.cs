using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Book
    {
        public string _title;
        public string _author;
        public int _pages;
        private string _rating;

        public Book(string title, string author, int pages, string rating)
        {
            _title = title;
            _author = author;
            _pages = pages;
            Rating = rating;
        }

        public bool ReadLong()
        {
            if (_pages > 700)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Rating
        {
            get { return _rating; }
            set
            {
                if (value == "low" || value == "mid" || value == "high")
                {
                    _rating = value;
                }
                else
                {
                    _rating = null;
                }
            }
        }
    }
}
