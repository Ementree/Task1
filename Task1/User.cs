using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class User
    {
        // Пользователь
        // У него есть идентификатор, имя, фамилия, список друзей и список групп, на которые он подписан
        private static int count = 0;
        public int id;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<User> Friends { get; set; }
        public List<Group> Groups { get; set; }
        public User(string firstName, string lastName, List<User> friends, List<Group> groups)
        {
            id = count;
            FirstName = firstName;
            LastName = lastName;
            Friends = friends;
            Groups = groups;
            count++;
        }
    }
}
