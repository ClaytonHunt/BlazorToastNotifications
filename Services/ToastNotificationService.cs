using System.Reactive.Subjects;
using Microsoft.AspNetCore.Components;

namespace Toast.Services
{
    public class ToastNotificationService : IToastNotificationService
    {
        public Subject<RenderFragment> toastQueue = new Subject<RenderFragment>();
        public Subject<dynamic> toastDismiss = new Subject<dynamic>();

        public  Subject<RenderFragment> watchToastQueue() 
        {
            return toastQueue;
        }

        public  Subject<dynamic> watchToastDismiss() 
        {
            return toastDismiss;
        }

        public void Show(RenderFragment fragment)
        {
            toastQueue.OnNext(fragment);
        }

        public void Close() 
        {
            toastDismiss.OnNext(null);
        }
    }
}