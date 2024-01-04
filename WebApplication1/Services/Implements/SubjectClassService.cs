using WebApplication1.Dto.SubjectClass;
using WebApplication1.Entities;
using WebApplication1.Services.Interfaces;

namespace WebApplication1.Services.Implements
{
    public class SubjectClassService : ISubjectClass
    {
        private static List<SubjectClass> _subjectclass = new List<SubjectClass>();
        private static int _id = 0;

        //thêm, sửa, xoá, xem danh sách

        public void Create(CreateSubjectClassDto input)
        {
            // thêm môn học  vào list
            _subjectclass.Add(new SubjectClass
            {
                Id = ++_id,
                //NameClass= input.NameClass,
            });
        }

        public void Update(UpdateSubjectClassDto input)
        {
            var subjectclass = _subjectclass.FirstOrDefault(s => s.Id == input.Id);
            if (subjectclass == null)
            {
                throw new Exception($"Không tìm thấy môn học có id = {input.Id}");
            }
            subjectclass.NameClass = input.NameClass;
            subjectclass.CodeClass = input.CodeClass;
        }
        public void Delete(int id)
        {
            var existingStudent = _subjectclass.FirstOrDefault(s => s.Id == id);

            _subjectclass.Remove(existingStudent);
        }


        public List<SubjectClassDto> GetAll()
        {
            var results = new List<SubjectClassDto>();
            foreach (var subjectclass in _subjectclass)
            {
                results.Add(new SubjectClassDto
                {
                    Id = subjectclass.Id,
                    NameClass = subjectclass.NameClass,
                    CodeClass = subjectclass.CodeClass
                });
            }
            return results;
        }
    }
}
