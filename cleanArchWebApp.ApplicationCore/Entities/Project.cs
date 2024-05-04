using System;

namespace cleanArchWebApp.ApplicationCore.Enities
{
    public class Project : EntityBase
    {
        public String  ProjectName { get; set; }

        public String  Description { get; set; }

        public String  ImagePath { get; set; }
        public int Budget { get; set; }

        public Owner Owner { get; set; }

    }





}
