 using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var socialNetwork = new SocialNetwork();

            #region создание примера
            var user1 = new User("John", "Snow", new List<User>(), new List<Group>());
            var user2 = new User("Sarah", "Smith", new List<User>(), new List<Group>());
            var user3 = new User("Alice", "Kinnian", new List<User>(), new List<Group>());
            var user4 = new User("Amy", "Pond", new List<User>(), new List<Group>());

            var group1 = new Group("Star dust", "space", new List<User>() { user1, user2, user4 });
            socialNetwork.CreateGroup(group1);
            var group2 = new Group("Literature club", "literature", new List<User>() { user2, user3});
            socialNetwork.CreateGroup(group2);
            var group3 = new Group("Astro", "space", new List<User>() { user4 });
            socialNetwork.CreateGroup(group3);
            var group4 = new Group("Travel tips", "travel", new List<User>() { user1, user3, user4 });
            socialNetwork.CreateGroup(group4);

            user1.Groups = new List<Group>() { group1, group4 };
            user1.Friends = new List<User>() { user2, user3, user4 };
            socialNetwork.CreatePerson(user1);
            user2.Groups = new List<Group>() { group2 };
            user2.Friends = new List<User>() { user1, user3, user4 };
            socialNetwork.CreatePerson(user2);
            user3.Groups = new List<Group>() { group1, group2, group4 };
            user3.Friends = new List<User>() { user1, user2, user4 };
            socialNetwork.CreatePerson(user3);
            user4.Groups = new List<Group>() { group1, group3, group4 };
            user4.Friends = new List<User>() { user1, user2, user3 };
            socialNetwork.CreatePerson(user4);
            #endregion

            var closedFriends = Algorithm.GetFriends(user1);
        }
    }
}
