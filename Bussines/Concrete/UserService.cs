using Bussines.Abstract;
using DataAccess.Concrete.Contexts;
using Entities.Concrete.BaseEntities;
using Entities.Dtos.UserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Concrete
{
    public class UserService : IUserService
    {
        private readonly IUserDal _userdal;
        public async Task<IEnumerable<UserDetailDto>> GetListAsync()
        {
            List<UserDetailDto> userDetailDtos = new List<UserDetailDto>();
            var response = await _userdal.GetListAsync();
            foreach (var item in response.ToList())
            {
                userDetailDtos.Add(new UserDetailDto()
                {
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Gender = item.Gender == true ? "Erkek" : "Kadın",
                    DateOfBirth = item.DateOfBirth,
                    UserName = item.UserName,
                    Address = item.Address,
                    Email = item.Email,
                    Id = item.Id,
                });
            }
            return userDetailDtos;
        }

        public async Task<UserDto> GetByIdAsync(int id)
        {
            var user = await _userdal.GetAsync(x => x.Id == id);
            UserDto userDto = new UserDto()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Gender = user.Gender,
                DateOfBirth = user.DateOfBirth,
                UserName = user.UserName,
                Address = user.Address,
                Email = user.Email,
                Id = user.Id,
            };
            return userDto;
        }

        public async Task<UserDto> AddAsync(UserAddDto userAddDto)
        {
            var user = new User()
            {
                FirstName = userAddDto.FirstName,
                LastName = userAddDto.LastName,
                Gender = userAddDto.Gender,
                DateOfBirth = userAddDto.DateOfBirth,
                UserName = userAddDto.UserName,
                Address = userAddDto.Address,
                Email = userAddDto.Email,
                //Todo: CreatedDate ve CreatedUserId düzenlenecek.
                CreatedDate = DateTime.Now,
                CreatedUserId = 1,
                Password = userAddDto.Password,
            };
            var userAdd = await _userdal.AddAsync(user);

            UserDto userDto = new UserDto()
            {
                FirstName = userAdd.FirstName,
                LastName = userAdd.LastName,
                Gender = userAdd.Gender,
                DateOfBirth = userAdd.DateOfBirth,
                UserName = userAdd.UserName,
                Address = userAdd.Address,
                Email = userAdd.Email,
                Id = userAdd.Id,
            };
            return userDto;
        }

        public async Task<bool> DeleteAsync(int id)
        {
           return await _userdal.DeleteAsync(id);
        }

        public async Task<UserUpdateDto> UpdateAsync(UserUpdateDto userUpdateDto)
        {
            var getUser = await _userdal.GetAsync(x => x.Id == userUpdateDto.Id);
            User user = new User()
            {
                Id = userUpdateDto.Id,
                FirstName = userUpdateDto.FirstName,
                LastName = userUpdateDto.LastName,
                Gender = userUpdateDto.Gender,
                DateOfBirth = userUpdateDto.DateOfBirth,
                UserName = userUpdateDto.UserName,
                Address = userUpdateDto.Address,
                Email = userUpdateDto.Email,
                //Id = userUpdateDto.Id,
                CreatedDate = DateTime.Now,
                CreatedUserId = 1,
                UpdatedDate = DateTime.Now,
                UpdatedUserId = 1,
                Password = userUpdateDto.Password,
            };
            var userUpdate = await _userdal.UpdateAsync(user);
            UserUpdateDto newUserUpdateDto = new UserUpdateDto()
            {
                FirstName = userUpdate.FirstName,
                LastName = userUpdate.LastName,
                Gender = userUpdate.Gender,
                DateOfBirth = userUpdate.DateOfBirth,
                UserName = userUpdate.UserName,
                Address = userUpdate.Address,
                Email = userUpdate.Email,
                Id = userUpdate.Id,
                Password = userUpdateDto.Password,
            };
            return newUserUpdateDto;
        }
    }
}
