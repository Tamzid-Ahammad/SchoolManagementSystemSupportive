using SchoolApp.Core;
using SchoolApp.Core.IServices;
using SchoolApp.Core.ViewModels;
using SchoolApp.Models.Models;

namespace SchoolApp.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IUnitOfWork<Department> _department;

        public DepartmentService(IUnitOfWork<Department> department)
        {
            _department = department;
        }

        public async Task<Department> Create(SaveDepartmentResource model)
        {
            // Here you can use AutoMapper
            var department = new Department
            {
                Name = model.Name
            };
            await _department.Entity.AddAsync(department);
            _department.Commit();
            return department;
        }

        public async Task<IEnumerable<Department>> CreateRange(IEnumerable<SaveDepartmentResource> models)
        {
            List<Department> departmentList = [];
            foreach (var department in models)
            {
                departmentList.Add(new Department
                {
                    Name = department.Name,
                });
            }
            await _department.Entity
                 .AddRangeAsync(departmentList);
            _department.Commit();
            return departmentList;
        }


        public async Task Delete(Department model)
        {
            _department.Entity.Remove(model);
            await _department.CommitAsync();
        }

        public async Task<IEnumerable<DepartmentResource>> Get()
        {
            return await _department.Entity.GetAndSelectAsync(it => new DepartmentResource
            {
                Id = it.Id,
                Name = it.Name
            });
        }

        public async Task<Department> Get(int id)
        {
            return await _department.Entity.SingleOrDefaultAsync(id);
        }

        public async Task Update(Department modelToBeUpdated, UpdateDepartmentResource model)
        {
            modelToBeUpdated.Name = model.Name;
            await _department.CommitAsync();
        }
    }
}
