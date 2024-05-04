using System;

namespace cleanArchWebApp.ApplicationCore.Enities
{
    public class Owner : EntityBase
    {
        public String FirstName  { get; set; }
        public String lastName { get; set; }

        public String  ImagePath { get; set; }

        public String BIO { get; set; }

        public Address Address { get; set; }

    }





}
