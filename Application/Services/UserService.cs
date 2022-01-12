using Domain.Models;
using Domain.Repositories;

namespace Application.Services
{
    public class UserService
    {
        UserRepository userRepository;

        public UserService()
        {
            userRepository = new UserRepository();
        }

        public void AddUpdateUser(User user)
        {
            try
            {
                #region regra de negocio

                bool addFlag = user.UsrId == 0;

                #endregion

                #region adicionar user

                if (addFlag)
                    userRepository.Add(user);
                else
                    userRepository.Update(user);
                #endregion
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Erro: {ex.Message}");
            }
        }

        public User GetUser(int id)
        {
            try
            {
                return userRepository.GetById(id);
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Erro: {ex.Message}");
            }
        }

        public void DeleteUser(int id)
        {
            try
            {
                userRepository.Delete(id);
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Erro: {ex.Message}");
            }
        }

        public IEnumerable<User> GetAllUsers() => userRepository.GetAll();
    }
}
