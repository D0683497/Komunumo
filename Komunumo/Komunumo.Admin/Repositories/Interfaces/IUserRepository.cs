namespace Komunumo.Admin.Repositories.Interfaces
{
    public interface IUserRepository
    {
        #region Exists

        bool ExistsUserName(string userName);

        bool ExistsEmail(string email);

        bool ExistsPhoneNumber(string phoneNumber);

        #endregion
    }
}