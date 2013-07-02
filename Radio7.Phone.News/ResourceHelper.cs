using System;
using System.Text;
using System.Windows;

namespace Radio7.Phone.Common.IO
{
    public class ResourceHelper
    {
        /// <summary>
        ///     Load a file from an application Resouce.
        /// </summary>
        /// <param name="path">Uri to resource, similar to new Uri("/ApplicationName;component/myfile.txt", UriKind.Relative)</param>
        /// <returns></returns>
        /// <remarks>Ensure the Build Action has been set to Resource</remarks>
        public static string LoadStringFromResource(Uri path)
        {
            var data = Application.GetResourceStream(path);
            var length = (int)data.Stream.Length;
            var buffer = new byte[length];

            data.Stream.Read(buffer, 0, length);

            return Encoding.UTF8.GetString(buffer, 0, length);
        }
    }
}