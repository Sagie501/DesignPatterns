using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Question7
{
    public class Chat
    {
        public static void ShowMessageToChatRoom(User user, string message)
        {
            Console.WriteLine(DateTime.Now + " [" + user.getName() + "] : " + message);
        }

        public static void ShowMessageToUser(User senderUser, User geterUser, string message)
        {
            Console.WriteLine("Message in private chat to [" + geterUser.getName() + "]:");
            Console.WriteLine(DateTime.Now + " [" + senderUser.getName() + "] : " + message);
        }
    }
}
