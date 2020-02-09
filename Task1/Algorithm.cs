using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task1
{
    class Algorithm
    {
        public static HashSet<string> GetAllSubjects()
        {
            var subjects = new HashSet<string>();
            foreach (var group in SocialNetwork.AllGroups)
            {
                if (!subjects.Contains(group.Subject))
                    subjects.Add(group.Subject);
            }
            return subjects;
        }

        public static Dictionary<string, double> GetHobbies(User user)
        {
            var result = new Dictionary<string, double>();
            var subjects = GetAllSubjects();
            foreach (var subject in subjects)
            {
                result.Add(subject, 0.0);
            }
            double allGroupsCount = user.Groups.Count();
            foreach (var group in user.Groups)
            {
                result[group.Subject] += 1 / allGroupsCount;
            }
            return result;
        }

        public static Dictionary<User, Dictionary<string, double>> GetHobbiesForUsers(List<User> users)
        {
            var result = new Dictionary<User, Dictionary<string, double>>();
            foreach (var user in users)
            {
                result.Add(user, GetHobbies(user));
            }
            return result;
        }

        public static List<User> GetFriends(User user)
        {
            var friendsWithCoef = new Dictionary<User, double>();
            var hobbies = GetHobbies(user);
            var friendsHobbies = GetHobbiesForUsers(user.Friends);
            var subjects = GetAllSubjects();

            foreach (var friend in user.Friends)
            {
                double coef = 0;
                foreach (var subject in subjects)
                {
                    coef += friendsHobbies[friend][subject] * hobbies[subject];
                }
                friendsWithCoef.Add(friend, coef);
            }

            return friendsWithCoef
                .OrderByDescending(pair => pair.Value)
                .Select(pair => pair.Key)
                .ToList();
        }
    }
}
