using WebApplication1.Dto.SubjectClass;

namespace WebApplication1.Services.Interfaces
{
    public interface ISubjectClass
    {
        void Create(CreateSubjectClassDto input);
        List<SubjectClassDto> GetAll();
        void Update(UpdateSubjectClassDto input);
       
    }
}
