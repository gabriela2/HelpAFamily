using HelpAFamily.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpAFamily.Repositories.PictureRepository
{
    interface IPictureRepositry
    {
        List<Picture> GetAll();
        Picture Get(int Id);
        Picture Create(Picture Picture);
        Picture Update(Picture Picture);
        Picture Delete(Picture Picture);
    }
}
