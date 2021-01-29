using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_10___Movie_List
{
    class Movie
    {
        private string _title;          // movie title field
        private string _category;       // movie category field

        public string Title { get { return _title; } set { _title = value; } }              // movie title property
        public string Category { get { return _category; } set { _category = value; } }     // movie category property

        // movie constructor
        public Movie(string title, string category)
        {
            this._title = title;
            this._category = category;
        }
    }
}
