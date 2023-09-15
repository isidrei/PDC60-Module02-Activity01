using System;
using System.Collections.Generic;
using System.Text;
using MVVM.Model;

namespace MVVM.ViewModel
{
    class TaskViewModel
    {
        public TaskModel TaskModelSet { get; set; }

        public TaskViewModel()
        {
            TaskModelSet = new TaskModel
            {
                SubjectCode ="PDC06",
                SubjectTitle ="Xamarin Mobile Programming",
                Unit =3,    

            };
        }
    }
}
