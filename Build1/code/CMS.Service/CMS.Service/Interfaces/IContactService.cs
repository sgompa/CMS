using System;
using CMS.Service.DTO;
namespace CMS.Service.Interfaces
{
    interface IContactService
    {
        void CloseContact(int contactId);
        int CreateContact(ContactDTO contact);
        bool DeleteContact(int contactId);
        bool UpdateContact(ContactDTO contact);
    }
}
