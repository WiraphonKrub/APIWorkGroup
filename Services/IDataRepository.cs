using APIWorkGroup.Models;

namespace APIWorkGroup.Services
{
    public interface IDataRepository
    {

        IEnumerable<Admin_TB> Admin_TBs_Show();

    }
}