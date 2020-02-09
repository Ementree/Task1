using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class SocialNetwork
    {
        public static List<User> AllUsers { get; private set; } = new List<User>();
        public static List<Group> AllGroups { get; private set; } = new List<Group>();
        public void CreatePerson(string firstName, string lastName, List<User> friends, List<Group> groups)
        {
            AllUsers.Add(new User(firstName, lastName, friends, groups));
        }
        public void CreatePerson(User user)
        {
            AllUsers.Add(user);
        }
        public void CreateGroup(string name, string subject, List<User> followers)
        {
            AllGroups.Add(new Group(name, subject, followers));
        }
        public void CreateGroup(Group group)
        {
            AllGroups.Add(group);
        }
    }
}
