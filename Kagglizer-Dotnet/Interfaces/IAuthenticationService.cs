namespace Kagglizer_Dotnet.Interfaces
{
    public interface IAuthenticationService<T>
    {
        bool IsAuthenticated();
        // Other authentication-related methods can be added here
    }
}
