using System.Reactive.Subjects;
using Toast.Models;

namespace Toast.Services
{
    public interface IToastNotificationService
    {
        Subject<ToastMessage> watchToastQueue();
        Subject<dynamic> watchToastDismiss();
        void Show(ToastMessage toast);
        void Dismiss();
        void Close();
    }
}