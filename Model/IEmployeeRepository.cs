namespace WebApi.Model
{
    public interface IEmployeeRepository
    {
        void add(Employee employee);

        List<Employee> Get();
    }
}
