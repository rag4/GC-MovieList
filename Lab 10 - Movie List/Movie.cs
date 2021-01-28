using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_10___Movie_List
{
    class Movie
    {
        private string _title;
        private string _category;

        public string Title { get { return _title; } set { _title = value; } }
        public string Category { get { return _category; } set { _category = value; } }

        public Movie(string title, string category)
        {
            this._title = title;
            this._category = category;
        }
    }
}
