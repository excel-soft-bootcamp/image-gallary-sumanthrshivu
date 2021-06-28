using System;
using System.Collections.Generic;
using System.Text;

namespace ImageShare
{
    public class ImageGallery
    {

        IService _service;
        public ImageGallery(IService service)
        {
            this._service = service;
        }
        public void Share()
        {

            _service.send();
        }

    }
}
