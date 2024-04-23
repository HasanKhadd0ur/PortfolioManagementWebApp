using System;

namespace cleanArchWebApp.ApplicationCore.Enities
{
    class Address : EntityBase
    {
        public int StreetNumber { get; set; }

        public int ZipCode { get; set; }

        public String  StreetName { get; set; }

        public String City { get; set; }
    }





}
