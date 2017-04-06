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

        public List<List<string>> GetAndShowReportedPostsCommentsFromDatabase()
        {
            return mediaRepo.GetReportedPostsComments();
        }

        public List<List<string>> GetAndShowPostComments()
        {
            return mediaRepo.GetPostsComments();
        }
    }
}
