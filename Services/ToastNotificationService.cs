using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using Toast.Models;

namespace Toast.Services
{
    public class ToastNotificationService : IToastNotificationService
    {
        public Subject<ToastMessage> toastQueue = new Subject<ToastMessage>();
        public Subject<dynamic> toastDismiss = new Subject<dynamic>();
        
        private List<ToastMessage> toasts = new List<ToastMessage>();
        private bool activeToast = false;

        public  Subject<ToastMessage> watchToastQueue() 
        {
            return toastQueue;
        }

        public  Subject<dynamic> watchToastDismiss() 
        {
            return toastDismiss;
        }

        public void Show(ToastMessage toast)
        {
            if (!activeToast) 
            {
                activeToast = true;
                toastQueue.OnNext(toast);
            } else {
                toasts.Add(toast);
            }
        }

        public void Dismiss() 
        {
            toastDismiss.OnNext(null);
        }

        public void Close() 
        {
            activeToast = false;
            
            if (toasts.Count > 0) 
            {
                var next = toasts.First();
                toasts.RemoveAt(0);
                Show(next);
            }
        }
    }
}