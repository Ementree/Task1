using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Group
    {
        //Группа
        //У нее есть название, тематика и список людей, подписанных на эту группу
        public string Subject { get; set; }
        public string Name { get; set; }
        public List<User> Followers { get; set; }
        public Group(string name, string subject, List<User> followers)
        {
            Name = name;
            Subject = subject.Trim().ToLower();
            Followers = followers;
        }
    }
}
