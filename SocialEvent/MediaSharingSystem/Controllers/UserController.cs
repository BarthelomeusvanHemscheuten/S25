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
    public class UserController
    {
        UserRepository userRepo;
        int userGroup;
        Visitor visitor;
        Employee employee;
        Admin admin;

        public UserController()
        {
            userRepo = new UserRepository(new UserSQLContext());
        }

        // VISITOR, EMPLOYEE AND ADMIN
        public bool Login(string username, string password)
        {
            userGroup = userRepo.GetUserGroup(username);

            List<string> userDataString = userRepo.GetUserDataString(username);
            List<int> userDataInt = userRepo.GetUserDataInt(username);
            DateTime? userDate = userRepo.GetUserDataDateTime(username);

            if (userGroup == 3)
            {
                if (userRepo.CheckLogin(username, password) == true)
                {
                    if(userDate != null)
                    {
                        visitor = new Visitor(userDataString[0], userDataString[1], userDataString[2], userDataString[3], userDataString[4], userDataString[5], userDate, userDataInt[0], userDataInt[1]);
                    } else
                    {
                        visitor = new Visitor(userDataString[0], userDataString[1], userDataString[2], userDataString[3], userDataInt[0], userDataInt[1]);
                    }
                    // OPEN FORM VISITOR

                    return true;
                }
            }
            else if (userGroup == 2)
            {
                if (userRepo.CheckLogin(username, password) == true)
                {
                    employee = new Employee(userDataString[0], userDataString[1], userDataString[2], userDataString[3], userDataString[4], userDataString[5], userDate, userDataInt[0], userDataInt[1]);
                    // OPEN FORM EMPLOYEE

                    return true;
                }
            }
            else if(userGroup == 1)
            {
                if (userRepo.CheckLogin(username, password) == true)
                {
                    admin = new Admin(userDataString[0], userDataString[1], userDataString[2], userDataString[3], userDataString[4], userDataString[5], userDate, userDataInt[0], userDataInt[1]);
                    // OPEN FORM ADMIN

                    return true;
                }
            }
            return false;
        }

        public List<string> AddAndShowPost(string text, string path)
        {
            switch (userGroup)
            {
                case 3:
                    return visitor.PlacePost(text, path);
                case 2:
                    return employee.PlacePost(text, path);
                    
                case 1:
                    return admin.PlacePost(text, path);
            }
            return null;
        }

        public List<string> AddAndShowPost(string text, string path, List<string> tags)
        {
            switch (userGroup)
            {
                case 3:
                    return visitor.PlacePost(text, path, tags);
                case 2:
                    return employee.PlacePost(text, path, tags);

                case 1:
                    return admin.PlacePost(text, path, tags);
            }
            return null;
        }

        public string AddAndShowComment(string text, Post post)
        {
            switch (userGroup)
            {
                case 3:
                    return visitor.PlaceComment(text, post);
                case 2:
                    return employee.PlaceComment(text, post);
                case 1:
                    return admin.PlaceComment(text, post);
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

        public bool ChangePassword(string password1, string password2)
        {
            switch (userGroup)
            {
                case 3:
                    visitor.ChangePassword(password1, password2);
                    return true;
                case 2:
                    employee.ChangePassword(password1, password2);
                    return true;
                case 1:
                    admin.ChangePassword(password1, password2);
                    return true;
            }
            return false;
        }

        public bool ChangeUsername(string newUsername, string password1, string password2)
        {
            
            switch (userGroup)
            {
                case 3:
                    visitor.ChangeUsername(newUsername, password1, password2);
                    return true;
                case 2:
                    employee.ChangeUsername(newUsername, password1, password2);
                    return true;
                case 1:
                    admin.ChangeUsername(newUsername, password1, password2);
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
                    case 1:
                        admin.DeleteVisitor(visitor);
                        return true;
                }
            }
            return false;
        }

        
        // EMPLOYEE
        public bool Reserve(List<Location> locations, int quantityVisitors, int quantityLocations, List<string> username, List<string> name, List<string> password, List<string> emailAddress, List<string> telnr, List<string> address, List<string> dateOfBirth )
        {
            if(locations != null && quantityVisitors > 0 && quantityLocations > 0 && username != null && name != null && password != null && emailAddress != null && telnr != null && address != null && dateOfBirth != null)
            {
                employee.Reserve(ReservationController.GetEvent, locations, quantityVisitors, quantityLocations, username, name, password, emailAddress, telnr, address, dateOfBirth);

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
            if(post != null && deleteOrShow != null)
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

        // get visitors from database

    }
}
