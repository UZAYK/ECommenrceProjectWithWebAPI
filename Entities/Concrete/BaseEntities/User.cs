﻿using System;

namespace Entities.Concrete.BaseEntities
{
    public class User : AuditableEntity
    {
        public string UserName { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public bool Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
