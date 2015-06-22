using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service {
    public class UserService : BaseService {

        public IQueryable<User> GetByUsername(string username) {
            return base.GetList<User>().Where(o => o.UserName == username);
        }

        public IQueryable<User> GetByUsernameAndPsd(string username, string psd) {
            return GetByUsername(username).Where(o => o.Password == psd);
        }
    }
}
