using accountModel;
using accountData;

namespace accountBusiness
{
    public class Class1
    {
        public bool Verifyuser(string username)
        {
            UserData dataservice = new UserData();
            var result = dataservice.GetUser(username);

            return result.username != null ? true : false;
        }
    }
}
