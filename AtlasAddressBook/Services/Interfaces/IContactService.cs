using AtlasAddressBook.Models;

namespace AtlasAddressBook.Services.Interfaces
{
    public interface IContactService
    {
        public Task<Contact> GetContactByIdAsync(int contactId);
    }
}
