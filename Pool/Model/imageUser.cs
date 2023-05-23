﻿using Pool.Class;
using Pool.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pool.Class;
using System.IO;

namespace Pool.Model
{
    public partial class Employess
    {


        private bool _isImageDownloaded = false;
        public Byte[] SaveImage { get; set; } = null;

        

        public Byte[] ByteImageUser
        {
            get
            {
                if (!String.IsNullOrEmpty(AuthUser.User.image) && !_isImageDownloaded)
                {
                    Byte[] _res;
                    try
                    {
                        _res = AppData.Context.GetImage(AuthUser.User.image);
                    }
                    catch
                    {
                        _res = null;
                    }
                    SaveImage = _res;
                    _isImageDownloaded = true;
                    return _res;
                }
                else
                {
                    return SaveImage;
                }
            }
        }

        public Byte[] ByteImage
        {
            get
            {
                if (!String.IsNullOrEmpty(image) && !_isImageDownloaded)
                {
                    Byte[] _res;
                    try
                    {
                        _res = AppData.Context.GetImage(image);
                    }
                    catch
                    {
                        _res = null;
                    }
                    SaveImage = _res;
                    _isImageDownloaded = true;
                    return _res;
                }
                else
                {
                    return SaveImage;
                }
            }
        }
    }
   
}