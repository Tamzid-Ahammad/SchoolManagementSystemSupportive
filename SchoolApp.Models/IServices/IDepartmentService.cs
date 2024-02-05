using SchoolApp.Core.ViewModels;
using SchoolApp.Models.Models;

namespace SchoolApp.Core.IServices
{
    public interface IDepartmentService
    {
        Task<IEnumerable<DepartmentResource>> Get();
        Task<Department> Get(int id);
        Task<Department> Create(SaveDepartmentResource model);
        Task<IEnumerable<Department>> CreateRange(IEnumerable<SaveDepartmentResource> modles);
        Task Update(Department modelToBeUpdated, UpdateDepartmentResource model);
        Task Delete(Department model);
    }
}
