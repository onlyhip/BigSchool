using BigSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigSchool.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcomingCourses { get; set; }
    
        public IEnumerable<ApplicationUser> Follows { get; set; }
    
        public List<Following> FollowingUser { get; set; }


        public List<Attendance> AttendanceCourse { get; set; }

        public bool ShowAction { get; set; }

    }
}