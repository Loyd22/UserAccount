using accountBusiness;
using accountmodel;
using System.Xml.Serialization;

namespace accountdata
{
    public class UserData
    {
        List<UserModel> user = new List<UserModel>();

        public UserData() 
        {
            createuserdata();
        }
        private void createuserdata()
        {
            UserModel user1 = new UserModel { username = "loyd" };
            UserModel user2 = new UserModel { username = "john " };
            UserModel user3 = new UserModel { username = "viray" };

            user.Add(user1);
            user.Add(user2);
            user.Add(user3);


        }
        public UserModel GetUser(string username)
        {
            UserModel foundUser = new UserModel();

            foreach (var real in user) 
            {
                if (username == real.username)
                {
                    foundUser = real;
                }
            }
            return foundUser;
        }

    }
}
