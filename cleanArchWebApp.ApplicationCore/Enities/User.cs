using System;

namespace cleanArchWebApp.ApplicationCore.Enities
{
    class User : EntityBase
    {
        public String FirstName  { get; set; }
        public String lastName { get; set; }

        public String BIO { get; set; }

        public Address Address { get; set; }

    }





}
