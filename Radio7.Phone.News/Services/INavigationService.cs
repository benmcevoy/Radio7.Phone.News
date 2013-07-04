using System;
using System.Windows.Navigation;

namespace Radio7.Phone.News.Services
{
    public interface INavigationService
    {
        event NavigatingCancelEventHandler Navigating;

        void NavigateTo(Uri pageUri);

        void GoBack();
    }
}