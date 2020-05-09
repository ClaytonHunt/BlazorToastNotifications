using Microsoft.AspNetCore.Components;

namespace Toast.Models
{
    public class ToastMessage
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public RenderFragment Template { get; set; }
        public ToastTypes Type { get; set; }
    }
}