﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Globalization;
using Models.Users;
using Models.ReservationSystem;
using Models.MediaSharingSystem;
using DAL.Repositories;
using DAL.SQLContext;


namespace MediaSharingSystem.Controllers
{
    public class Controller
    {
        private UserRepository userRepo;
        private MediaRepository mediaRepo;
        private ReservationRepository reservationRepo;
        public Event Event { get; private set; }
        private int userGroup;
        private Visitor visitor;
        private Employee employee;
        private Admin admin;

        public Controller()
        {
            userRepo = new UserRepository(new UserSQLContext());
            mediaRepo = new MediaRepository(new MediaSQLContext());
            reservationRepo = new ReservationRepository(new ReservationSQLContext());
            Event = new Event("Social Event");
        }

        public bool AddLocation(int number, string features, string type)
        {
            if (number > 0 && features != null && type != null)
            {
                Event.AddLocation(number, features, type);
                reservationRepo.InsertLocation(number, features, type);

                return true;
            }
            return false;
        }

        public List<Material> AddMaterial(string name, string description, double price, int quantity)
        {
            List<Material> result = new List<Material>();

            if (name != null && description != null && price > 0 && quantity > 0)
            {
                for (int i = 0; i < quantity; i++)
                {
                    result.Add(Event.AddMaterial(name, description, price));
                    reservationRepo.InsertMaterial(name, description, price);
                }

                return result;
            }
            return null;
        }

        public List<Material> GetAndShowMaterialFromDatabase()
        {
            List<Material> result = new List<Material>();

            List<double> price = new List<double>();
            List<string> name = new List<string>();
            List<string> description = new List<string>();

            price = reservationRepo.GetAllMaterialsPrice();
            name = reservationRepo.GetAllMaterialsName();
            description = reservationRepo.GetAllMaterialsDescription();

            for (int i = 0; i < name.Count; i++)
            {
                Material material = new Material(name[i], description[i], price[i]);
                Event.Material.Add(material);
                result.Add(material);
            }

            return result;
        }

        // VISITOR, EMPLOYEE AND ADMIN
        public int Login(string username, string password)
        {
            userGroup = userRepo.GetUserGroup(username);

            List<string> userDataString = userRepo.GetUserDataString(username);
            List<int> userDataInt = userRepo.GetUserDataInt(username);
            DateTime? userDate = userRepo.GetUserDataDateTime(username);

            if (userGroup == 1)
            {
                if (userRepo.CheckLogin(username, password) == true)
                {
                    if (userDate != null)
                    {
                        visitor = new Visitor(userDataString[0], userDataString[1], userDataString[2], userDataString[3], userDataString[4], userDate, userDataInt[0], userDataInt[1]);
                        Event.Visitors.Add(visitor);
                    }
                    else
                    {
                        visitor = new Visitor(userDataString[0], userDataString[1], userDataString[2], userDataInt[0], userDataInt[1]);
                        Event.Visitors.Add(visitor);
                    }
                    // OPEN FORM VISITOR

                    return 1;
                }
            }
            else if (userGroup == 2)
            {
                if (userRepo.CheckLogin(username, password) == true)
                {
                    employee = new Employee(userDataString[0], userDataString[1], userDataString[2], userDataString[3], userDataString[4], userDate, userDataInt[0], userDataInt[1]);
                    // OPEN FORM EMPLOYEE

                    return 2;
                }
            }
            else if (userGroup == 3)
            {
                if (userRepo.CheckLogin(username, password) == true)
                {
                    admin = new Admin(userDataString[0], userDataString[1], userDataString[2], userDataString[3], userDataString[4], userDate, userDataInt[0], userDataInt[1]);
                    // OPEN FORM ADMIN

                    return 3;
                }
            }
            return -1;
        }

        public Post AddAndShowPost(string text, string path)
        {
            switch (userGroup)
            {
                case 1:
                    Post post1 = visitor.PlacePost(0, text, path);
                    mediaRepo.InsertPost(post1.ID, text, path);
                    return post1;
                case 2:
                    Post post2 = employee.PlacePost(0, text, path);
                    mediaRepo.InsertPost(post2.ID, text, path);
                    return post2;

                case 3:
                    Post post3 = admin.PlacePost(0, text, path);
                    mediaRepo.InsertPost(post3.ID, text, path);
                    return post3;
            }
            return null;
        }

        public Post AddAndShowPost(string text, string path, List<string> tags)
        {
            switch (userGroup)
            {
                case 1:
                    Post post1 = visitor.PlacePost(0, text, path, tags);
                    mediaRepo.InsertPost(post1.ID, text, path);
                    for (int i = 0; i < tags.Count; i++)
                    {
                        mediaRepo.InsertTag(post1.ID, tags[i]);
                    }
                    return post1;
                case 2:
                    Post post2 = employee.PlacePost(0, text, path, tags);
                    mediaRepo.InsertPost(post2.ID, text, path);
                    for (int i = 0; i < tags.Count; i++)
                    {
                        mediaRepo.InsertTag(post2.ID, tags[i]);
                    }
                    return post2;
                case 3:
                    Post post3 = employee.PlacePost(0, text, path, tags);
                    mediaRepo.InsertPost(post3.ID, text, path);
                    for (int i = 0; i < tags.Count; i++)
                    {
                        mediaRepo.InsertTag(post3.ID, tags[i]);
                    }
                    return post3;
            }
            return null;
        }

        public Comment AddAndShowComment(string text, Post post)
        {
            switch (userGroup)
            {
                case 1:
                    Comment comment1 = visitor.PlaceComment(0, text, post);
                    mediaRepo.InsertComment(comment1.ID, post.ID, text);
                    return comment1;
                case 2:
                    Comment comment2 = employee.PlaceComment(0, text, post);
                    mediaRepo.InsertComment(comment2.ID, post.ID, text);
                    return comment2;
                case 3:
                    Comment comment3 = admin.PlaceComment(0, text, post);
                    mediaRepo.InsertComment(comment3.ID, post.ID, text);
                    return comment3;
            }
            return null;
        }

        public bool AddAndShowLike(Post post)
        {
            if (post != null)
            {
                post.Like(visitor);

                return true;
            }
            return false;
        }

        public bool ReportComment(Comment comment, string reason)
        {
            switch (userGroup)
            {
                case 1:
                    comment.ReportComment(0, visitor, reason);
                    mediaRepo.InsertReportComment(visitor.ID, comment.ID, reason);
                    return true;
                case 2:
                    comment.ReportComment(0, employee, reason);
                    mediaRepo.InsertReportComment(employee.ID, comment.ID, reason);
                    return true;
                case 3:
                    comment.ReportComment(0, admin, reason);
                    mediaRepo.InsertReportComment(admin.ID, comment.ID, reason);
                    return true;
            }
            return false;
        }

        public bool Reportpost(Post post, string reason)
        {
            switch (userGroup)
            {
                case 3:
                    post.ReportPost(0, visitor, reason);
                    mediaRepo.InsertReportPost(visitor.ID, post.ID, reason);
                    return true;
                case 2:
                    post.ReportPost(0, employee, reason);
                    mediaRepo.InsertReportPost(employee.ID, post.ID, reason);
                    return true;
                case 1:
                    post.ReportPost(0, admin, reason);
                    mediaRepo.InsertReportPost(admin.ID, post.ID, reason);
                    return true;
            }
            return false;
        }

        public bool ChangePassword(string password1, string password2)
        {
            switch (userGroup)
            {
                case 1:
                    visitor.ChangePassword(password1, password2);
                    return true;
                case 2:
                    employee.ChangePassword(password1, password2);
                    return true;
                case 3:
                    admin.ChangePassword(password1, password2);
                    return true;
            }
            return false;
        }

        public bool ChangeUsername(string newUsername)
        {
            switch (userGroup)
            {
                case 1:
                    visitor.ChangeUsername(newUsername);
                    return true;
                case 2:
                    employee.ChangeUsername(newUsername);
                    return true;
                case 3:
                    admin.ChangeUsername(newUsername);
                    return true;
            }
            return false;
        }

        public bool ChangeName(string newName)
        {
            switch (userGroup)
            {
                case 1:
                    visitor.ChangeName(newName);
                    return true;
                case 2:
                    employee.ChangeName(newName);
                    return true;
                case 3:
                    admin.ChangeName(newName);
                    return true;
            }
            return false;
        }

        public Image ChangePicture(Image image)
        {
            switch (userGroup)
            {
                case 1:
                    return visitor.ChangePicture(image);
                case 2:
                    return employee.ChangePicture(image);
                case 3:
                    return admin.ChangePicture(image);
            }
            return null;
        }
        public bool ChangeEmail(string email)
        {
            switch (userGroup)
            {
                case 1:
                    visitor.ChangeEmail(email);
                    return true;
                case 2:
                    employee.ChangeEmail(email);
                    return true;
                case 3:
                    admin.ChangeEmail(email);
                    return true;
            }
            return false;
        }
        public bool ChangeTelnr(string telnr)
        {
            switch (userGroup)
            {
                case 1:
                    visitor.ChangeTelnr(telnr);
                    return true;
                case 2:
                    visitor.ChangeTelnr(telnr);
                    return true;
                case 3:
                    visitor.ChangeTelnr(telnr);
                    return true;
            }
            return false;
        }

        // EMPLOYEE AND ADMIN
        public bool DeleteVisitor(Visitor visitor)
        {
            if (visitor != null)
            {
                switch (userGroup)
                {
                    case 2:
                        employee.DeleteVisitor(visitor);
                        return true;
                    case 3:
                        admin.DeleteVisitor(visitor);
                        return true;
                }
            }
            return false;
        }


        // EMPLOYEE
        public bool Reserve(List<Location> locations, int quantityVisitors, int quantityLocations, List<string> username, List<string> name, List<string> password, List<string> emailAddress, List<string> telnr, List<string> address, List<string> dateOfBirth)
        {
            if (locations != null && quantityVisitors > 0 && quantityLocations > 0 && username != null && name != null && password != null && emailAddress != null && telnr != null && address != null && dateOfBirth != null)
            {
                employee.Reserve(Event, locations, quantityVisitors, quantityLocations, username, name, password, emailAddress, telnr, address, dateOfBirth);

                return true;
            }
            return false;
        }

        public bool RentMaterial(Visitor visitor, Material material, string startDate, string endDate, int quantity)
        {
            if (visitor != null && material != null && startDate != null && endDate != null && quantity > 0)
            {
                for (int i = 0; i < quantity; i++)
                {
                    employee.RentMaterial(visitor, material, startDate, endDate);
                }

                return true;
            }
            return false;
        }

        // ADMIN
        public bool AddEvent(string name, string description)
        {
            if (name != null && description != null)
            {
                admin.AddEvent(name, description);

                return true;
            }
            return false;
        }

        public bool AddSwearWord(string swearWord)
        {
            if (swearWord != null)
            {
                userRepo.InsertSwearWord(swearWord);
            }
            return false;
        }

        public bool DeleteShowPost(Post post, string deleteOrShow)
        {
            if (post != null && deleteOrShow != null)
            {
                admin.DeleteShowPost(post, deleteOrShow);

                return true;
            }
            return false;
        }

        public bool DeleteShowComment(Comment comment, string deleteOrShow)
        {
            if (comment != null && deleteOrShow != null)
            {
                admin.DeleteShowComment(comment, deleteOrShow);

                return true;
            }
            return false;
        }

        // VISITOR

        public List<Visitor> GetAndShowVisitorsFromDatabase()
        {
            List<Visitor> result = new List<Visitor>();
            List<int> Visitor_id = userRepo.GetAllVisitorID();
            foreach (int id in Visitor_id)
            {
                DateTime? dateTime = userRepo.GetUserDataDateTime(id);
                List<int> userDataInt = userRepo.GetUserDataInt(id);
                List<string> userDataString = userRepo.GetUserDataString(id);
                if (dateTime != null)
                {
                    result.Add(new Visitor(userDataString[0], userDataString[1], userDataString[2], userDataString[3], userDataString[4], dateTime, userDataInt[0], userDataInt[1]));
                }
                else
                {
                    result.Add(new Visitor(userDataString[0], userDataString[1], userDataString[4], userDataInt[0], userDataInt[1]));
                }
            }

            return result;
        }

        // POSTS, COMMENTS, REPORTED

        public List<Post> GetAndShowReportedPostsFromDatabase()
        {
            List<Post> result = new List<Post>();

            int quantity = mediaRepo.CountReportedPosts();
            List<int> listPostsID = mediaRepo.GetReportedPostsId();

            // int GetUserIdPost(int id); om te laten zien van wie de post is

            for (int i = 0; i < quantity; i++)
            {
                List<string> textPathPost = mediaRepo.GetTextPathPost(listPostsID[i]);
                Post post = visitor.PlacePost(listPostsID[i], textPathPost[0], textPathPost[1]);
                visitor.Posts.Add(post);
                result.Add(post);
            }
            return result;
        }

        public List<Comment> GetAndShowReportedCommentsFromDatabase()
        {
            List<Comment> result = new List<Comment>();

            int quantity = mediaRepo.CountReportedComments();
            List<int> listCommentsID = mediaRepo.GetReportedCommentsId();

            // int GetUserIdComment(int id); om te laten zien van wie de post is

            for (int i = 0; i < quantity; i++)
            {
                string textComment = mediaRepo.GetTextComment(listCommentsID[i]);
                User user = visitor as User;
                Comment comment = user.PlaceComment(listCommentsID[i], textComment);
                result.Add(comment);
            }
            return result;
        }

        public List<Post> GetAndShowPostComments()
        {
            List<Post> output = new List<Post>();
            List<int> postsID = mediaRepo.GetPostsID();
            List<int> commentsID = mediaRepo.GetCommentsID();

            for (int i = 0; i < postsID.Count; i++)
            {
                List<string> postTextPath = mediaRepo.GetTextPathPost(postsID[i]);
                Post post = new Post(postsID[i], postTextPath[0], postTextPath[1]);
                output.Add(post);
            }

            for (int i = 0; i < commentsID.Count; i++)
            {
                string textComment = mediaRepo.GetTextComment(commentsID[i]);
                Comment comment = new Comment(commentsID[i], textComment);
                int postID = mediaRepo.GetPostIdFromComment(commentsID[i]);

                foreach (Post post in output)
                {
                    if (post.ID == postID)
                    {
                        post.Comments.Add(comment);
                    }
                }
                for (int j = 0; j < postsID.Count; j++)
                {
                    int userID = mediaRepo.GetUserIdPost(postsID[i]);

                    DateTime? dateTime = userRepo.GetUserDataDateTime(userID);
                    List<int> userDataInt = userRepo.GetUserDataInt(userID);
                    List<string> userDataString = userRepo.GetUserDataString(userID);

                    if (dateTime != null)
                    {
                        comment.User = new Visitor(userDataString[0], userDataString[1], userDataString[3], userDataString[4], userDataString[6], dateTime, userDataInt[0], userDataInt[1]);
                    }
                    else
                    {
                        comment.User = new Visitor(userDataString[0], userDataString[1], userDataString[2], userDataInt[0], userDataInt[1]);
                    }

                    if (dateTime != null)
                    {
                        foreach (Post post in output)
                        {
                            if (post.ID == postID)
                            {
                                post.User = new Visitor(userDataString[0], userDataString[1], userDataString[3], userDataString[4], userDataString[6], dateTime, userDataInt[0], userDataInt[1]);
                            }
                        }
                    }
                    else
                    {
                        foreach (Post post in output)
                        {
                            if (post.ID == postID)
                            {
                                post.User = new Visitor(userDataString[0], userDataString[1], userDataString[2], userDataInt[0], userDataInt[1]);
                            }
                        }
                    }

                }
            }
            return output;
        }
        public List<string> GetAllSwearwords()
        {
            return mediaRepo.GetAllSwearwords();
        }

        public List<Visitor> GetVisitors()
        {
            List<Visitor> visitors = new List<Visitor>();
            foreach (Visitor v in Event.Visitors)
            {
                visitors.Add(v);
            }
            return visitors;
        }

        public List<Material> GetMaterials()
        {
            List<Material> materials = new List<Material>();
            foreach (Material m in Event.Material)
            {
                materials.Add(m);
            }
            return materials;
        }

        public string[] GetMaterialInfo(string name)
        {
            string[] info = null;
            foreach (Material m in Event.Material)
            {
                if (m.Name == name)
                {
                    info[0] = (Convert.ToString(m.Price));
                    info[1] = (m.Description);
                }
            }
            return info;
        }

        public string[] GetGebruikersInfo(string name)
        {
            string[] info = null;
            foreach (Visitor v in Event.Visitors)
            {
                if (v.Name == name)
                {
                    info[0] = (v.EmailAddress);
                    info[1] = (v.Telnr);
                }
            }
            return info;
        }

        public bool DeleteGebruiker(string name)
        {
            foreach (Visitor visitor in Event.Visitors)
            {
                if (visitor.Name == name)
                {
                    DeleteVisitor(visitor);
                    return true;
                }
            }
            return false;
        }

        public bool VerhuurItem(string visitor, string material, string eindDatum, int hoeveelheid)
        {
            foreach (Visitor v in Event.Visitors)
            {
                if (v.Name == visitor)
                {
                    foreach (Material m in Event.Material)
                    {
                        if (m.Name == material)
                        {
                            RentMaterial(v, m, DateTime.Now.ToString(), eindDatum, hoeveelheid);
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
