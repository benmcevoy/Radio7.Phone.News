using System;
using System.Windows.Navigation;

namespace Radio7.Phone.News.Infrastructure
{
    public interface INavigationService
    {
        event NavigatingCancelEventHandler Navigating;

        void NavigateTo(Uri pageUri);

        void GoBack();
    }
}