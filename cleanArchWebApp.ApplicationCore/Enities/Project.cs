using System;

namespace cleanArchWebApp.ApplicationCore.Enities
{
    class Project : EntityBase
    {
        public String  ProjectName { get; set; }

        public String  Description { get; set; }

        public int Budget { get; set; }

        public User Owner { get; set; }

    }





}
