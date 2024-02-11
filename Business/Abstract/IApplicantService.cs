using Entities.Concrete;

namespace Business.Abstract;

public interface IApplicantService
{
    void ApplyForMask(Person person);

    public List<Person> GetList();
    public bool CheckPerson(Person person);
}
