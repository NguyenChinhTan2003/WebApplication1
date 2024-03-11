using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TodoList.Models
{
    public class TodoItem
    {
        [DisplayName("Mã công việc")]
        public int Id { get; set; }

        [DisplayName("Tên công việc")]
        [Required(ErrorMessage = "Bắt buộc nhập tên công việc")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Tên công việc phải từ 3 đến 50 ký tự")]
        public string Title { get; set; }

        [DisplayName("Trạng thái hoàn thành")]
        public bool IsCompleted { get; set; }
    }
}
