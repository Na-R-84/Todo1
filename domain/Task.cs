using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo.domain
{
    class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? Completed { get; set; }
        //public bool IsCompleted
        //{
        //    get
        //    {
        //        return Completed != null;
        //    }
        //}

        //string title;  vi behöver inte de mer på grund av dem redan står där uppe
        //DateTime dueDate;


        public Task(int id,string title,DateTime dueDate)
        {
            Id = id;
            Title = title;
            DueDate = dueDate;
        }
    }
}
