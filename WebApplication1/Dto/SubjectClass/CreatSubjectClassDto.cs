using System.ComponentModel.DataAnnotations;
using WebApplication1.Validations;

namespace WebApplication1.Dto.SubjectClass
{
    public class CreateSubjectClassDto
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Tên không được bỏ trống")]
        [StringLength(maximumLength: 50, MinimumLength = 10, ErrorMessage = "Tên lớp phải được có độ dài từ 10 đến 50 ký tự ")]
        public string NameClass { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Mã lớp không được bỏ trống")]
        [StringLength(maximumLength: 50, MinimumLength = 5, ErrorMessage = "Mã lớp phải có tối thiểu 5 ký tự ")]
        public string CodeClass { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Số sinh viên phải lớn hơn 0")]
        public int MaxStudent { get; set; }
    }
}
