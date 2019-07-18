using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Question7
{
    public class User
    {
        private string name;

        public User(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }

        public void SendMessageToChatRoom(string message)
        {
            Chat.ShowMessageToChatRoom(this, message);
        }

        public void SendMessageToUser(User geterUser, string message)
        {
            Chat.ShowMessageToUser(this, geterUser, message);
        }
    }
}
