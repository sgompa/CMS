using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.Service.DTO;
using CMS.Service.Interfaces;
namespace CMS.Service.Implementations
{
    public class ContactService : IContactService
    {

        /// <summary>
        /// Creates contact and returns contact id
        /// </summary>
        /// <returns></returns>
        public int CreateContact(ContactDTO contact)
        {
            return 0;
        }

        public bool UpdateContact(ContactDTO contact)
        {
            return true;
        }
        public bool DeleteContact(int contactId)
        {
            return true;
        }
        public void CloseContact(int contactId)
        {

        }
    }
}
