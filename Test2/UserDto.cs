using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class UserDto
    {
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }

        public UserDto GetUservalid()
        {
            var validUserDto = new UserDto();
            if (this.UserEmail != null)
                validUserDto.UserEmail = UserEmail;
            else
                validUserDto.UserEmail = string.Empty;

            if (this.UserPassword != null)
                validUserDto.UserPassword = UserPassword;
            else
                validUserDto.UserPassword = string.Empty;

            return validUserDto;
        }
    }
}