using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.gcr_codebase.csharp_linked_list
{
    internal class SocialMedia
    {
        static void Main(String[] args)
        {
            SocialNetwork network = new SocialNetwork();

            network.AddUser(1, "Aryan", 25);
            network.AddUser(2, "Aman", 24);
            network.AddUser(3, "Arjun", 27);

            network.AddFriend(1, 2);
            network.AddFriend(1, 3);
            network.DisplayFriends(1);

            network.FindMutualFriends(2, 3);
            network.CountFriends();

            network.SearchByName("Aman");
        }
    }

    // Friend Node
    class Friend
    {
        public int FriendId;
        public Friend Next;

        public Friend(int friendId)
        {
            FriendId = friendId;
            Next = null;
        }
    }

    // User Node
    class User
    {
        public int UserId;
        public string Name;
        public int Age;
        public Friend FriendHead; // head of friend list
        public User Next;

        public User(int userId, string name, int age)
        {
            UserId = userId;
            Name = name;
            Age = age;
            FriendHead = null;
            Next = null;
        }
    }

    class SocialNetwork
    {
        private User head;

        // Add a user
        public void AddUser(int userId, string name, int age)
        {
            User newUser = new User(userId, name, age);
            newUser.Next = head;
            head = newUser;
        }

        // Add a friend connection
        public void AddFriend(int userId1, int userId2)
        {
            User u1 = FindUserById(userId1);
            User u2 = FindUserById(userId2);

            if (u1 == null || u2 == null)
            {
                Console.WriteLine("One or both users not found.");
                return;
            }

            if (!IsFriend(u1, userId2))
                AddFriendNode(u1, userId2);
            if (!IsFriend(u2, userId1))
                AddFriendNode(u2, userId1);

            Console.WriteLine($"Friend connection added between {u1.Name} and {u2.Name}.");
        }

        // Remove a friend connection
        public void RemoveFriend(int userId1, int userId2)
        {
            User u1 = FindUserById(userId1);
            User u2 = FindUserById(userId2);

            if (u1 == null || u2 == null)
            {
                Console.WriteLine("One or both users not found.");
                return;
            }

            RemoveFriendNode(u1, userId2);
            RemoveFriendNode(u2, userId1);

            Console.WriteLine($"Friend connection removed between {u1.Name} and {u2.Name}.");
        }

        // Display all friends of a user
        public void DisplayFriends(int userId)
        {
            User u = FindUserById(userId);
            if (u == null)
            {
                Console.WriteLine("User not found.");
                return;
            }

            Console.Write($"Friends of {u.Name}: ");
            Friend temp = u.FriendHead;
            if (temp == null)
            {
                Console.WriteLine("No friends.");
                return;
            }

            while (temp != null)
            {
                Console.Write($"{temp.FriendId} ");
                temp = temp.Next;
            }
            Console.WriteLine();
        }

        // Find mutual friends
        public void FindMutualFriends(int userId1, int userId2)
        {
            User u1 = FindUserById(userId1);
            User u2 = FindUserById(userId2);

            if (u1 == null || u2 == null)
            {
                Console.WriteLine("One or both users not found.");
                return;
            }

            Console.Write($"Mutual friends of {u1.Name} and {u2.Name}: ");
            Friend f1 = u1.FriendHead;
            bool found = false;
            while (f1 != null)
            {
                if (IsFriend(u2, f1.FriendId))
                {
                    Console.Write($"{f1.FriendId} ");
                    found = true;
                }
                f1 = f1.Next;
            }
            if (!found) Console.Write("None");
            Console.WriteLine();
        }

        // Search user by Name
        public void SearchByName(string name)
        {
            User temp = head;
            bool found = false;
            while (temp != null)
            {
                if (temp.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"User Found: ID={temp.UserId}, Name={temp.Name}, Age={temp.Age}");
                    found = true;
                }
                temp = temp.Next;
            }
            if (!found) Console.WriteLine("User not found.");
        }

        // Search user by ID
        public void SearchById(int userId)
        {
            User u = FindUserById(userId);
            if (u != null)
                Console.WriteLine($"User Found: ID={u.UserId}, Name={u.Name}, Age={u.Age}");
            else
                Console.WriteLine("User not found.");
        }

        // Count friends for each user
        public void CountFriends()
        {
            User temp = head;
            while (temp != null)
            {
                int count = 0;
                Friend f = temp.FriendHead;
                while (f != null)
                {
                    count++;
                    f = f.Next;
                }
                Console.WriteLine($"{temp.Name} has {count} friends.");
                temp = temp.Next;
            }
        }

        private User FindUserById(int userId)
        {
            User temp = head;
            while (temp != null)
            {
                if (temp.UserId == userId) return temp;
                temp = temp.Next;
            }
            return null;
        }

        private bool IsFriend(User user, int friendId)
        {
            Friend temp = user.FriendHead;
            while (temp != null)
            {
                if (temp.FriendId == friendId) return true;
                temp = temp.Next;
            }
            return false;
        }

        private void AddFriendNode(User user, int friendId)
        {
            Friend newFriend = new Friend(friendId);
            newFriend.Next = user.FriendHead;
            user.FriendHead = newFriend;
        }

        private void RemoveFriendNode(User user, int friendId)
        {
            Friend temp = user.FriendHead;
            Friend prev = null;
            while (temp != null)
            {
                if (temp.FriendId == friendId)
                {
                    if (prev == null)
                        user.FriendHead = temp.Next;
                    else
                        prev.Next = temp.Next;
                    return;
                }
                prev = temp;
                temp = temp.Next;
            }
        }
    }
}
