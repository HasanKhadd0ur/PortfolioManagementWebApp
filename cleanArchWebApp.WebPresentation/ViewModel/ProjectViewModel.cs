using cleanArchWebApp.ApplicationCore.Enities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cleanArchWebApp.WebPresentation.ViewModel
{
    public class ProjectViewModel
    {
        public int Id { get; set; }
        public String ProjectName { get; set; }

        public String Description { get; set; }

        public String ImagePath { get; set; }
        public int Budget { get; set; }

        public Owner Owner { get; set; }

        public IFormFile File { get; set; }

    }
}
