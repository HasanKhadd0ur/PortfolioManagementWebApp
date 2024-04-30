using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using cleanArchWebApp.ApplicationCore.Enities;
using cleanArchWebApp.ApplicationCore.Interfaces;
namespace cleanArchWebApp.WebPresentation.ViewModel
{
    public class HomeViewModel
    {
        public Owner Owner { get; set; }

        public List<Project> Projects { get; set; }

    }
}
