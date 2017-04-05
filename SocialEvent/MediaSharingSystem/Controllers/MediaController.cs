using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repositories;
using DAL.SQLContext;

namespace MediaSharingSystem.Controllers
{
    public class MediaController
    {
        MediaRepository mediaRepo;

        public MediaController()
        {
            mediaRepo = new MediaRepository(new MediaSQLContext());
        }


    }
}
