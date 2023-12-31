﻿using WebApp.Contexts;
using WebApp.Models.Entities;

namespace WebApp.Helpers.Repositories
{
    public class ContactFormRepository : Repo<ContactFormEntity>
    {
        public ContactFormRepository(IdentityContext context) : base(context)
        {
        }
    }
}
