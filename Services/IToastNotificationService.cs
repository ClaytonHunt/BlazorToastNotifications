using System.Reactive.Subjects;
using Microsoft.AspNetCore.Components;

namespace Toast.Services
{
    public interface IToastNotificationService
    {
        Subject<RenderFragment> watchToastQueue();
        Subject<dynamic> watchToastDismiss();
        void Show(RenderFragment fragment);
        void Close();
    }
}