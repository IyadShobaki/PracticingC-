using System;

namespace Mosh1
{
    public class PhotoProcessor
    {
        //public delegate void PhotoFilterHandler(Photo photo);
        public void Process(string path, Action<Photo> filterHandler)// PhotoFilterHandler filterHandler)
        {
            var photo = Photo.Load(path);

            filterHandler(photo);
            //var filters = new PhotoFilters();
            //filters.ApplyBrightness(photo);
            //filters.ApplyContrast(photo);
            //filters.ApplyResize(photo);

            photo.Save();
        }

    }
}
