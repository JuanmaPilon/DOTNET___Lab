public class UserSessionService
{
    private string _currentUsername;
    private string _currentRole;

    public void SetUserSession(string username, string role)
    {
        _currentUsername = username;
        _currentRole = role;
        // Puedes aquí guardar los datos en Scoped Storage si lo deseas para persistencia de sesión.
    }

    public (string username, string role) GetCurrentSession()
    {
        return (_currentUsername, _currentRole);
    }

    public void RemoveUserSession()
    {
        _currentUsername = null;
        _currentRole = null;
    }

    public bool IsUserLoggedIn() => !string.IsNullOrEmpty(_currentUsername);

    public bool HasRole(string requiredRole)
    {
        return _currentRole == requiredRole;
    }
}
