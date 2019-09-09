﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackoverflowPost
{
    class Post
    {

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreateTime { get; set; }

        private int _currentVote;

        public Post(string title,string description)
        {
            Title = title;
            Description = description;
            CreateTime = DateTime.Now;
            _currentVote = 0;
        }

        public void upVote()
        {
            _currentVote++;

        }

        public void downVote()
        {
            _currentVote--;

        }

        public int showVotes()
        {
            return _currentVote;
        }

    }
}
