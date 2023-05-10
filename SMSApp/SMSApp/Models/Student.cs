using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMSApp.Models
{
    public class Student
    {
        private int _StdId;
        private String _StdName;
        private String _StdCourse;
        private String _BatchId;

        public String BatchId
        {
            get { return _BatchId; }
            set { _BatchId = value; }
        }

        public String Course
        {
            get { return _StdCourse; }
            set { _StdCourse = value; }
        }

        public String StudentName
        {
            get { return _StdName; }
            set { _StdName = value; }
        }

        public int StudentId
        {
            get { return _StdId; }
            set { _StdId = value; }
        }

    }
}