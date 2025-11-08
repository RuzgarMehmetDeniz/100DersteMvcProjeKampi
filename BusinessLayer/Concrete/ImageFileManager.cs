using BusinessLayer.Abstarct;
using DataAccesLayer.Abstract;
using EntityLayer.Concreta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ImageFileManager : IImageFileService
    {
        IImageFileDal _imagefileDal;
        public ImageFileManager(IImageFileDal imageFileDal)
        {
            _imagefileDal = imageFileDal;
        }

        public List<ImageFile> GetList()
        {
            return _imagefileDal.List();
        }
    }
}
