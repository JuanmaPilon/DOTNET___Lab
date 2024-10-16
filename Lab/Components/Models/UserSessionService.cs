public class UserSessionService
{
    private string _currentUsername;
    private string _currentRole;

    public void SetUserSession(string username, string role)
    {
        _currentUsername = username;
        _currentRole = role;

    }

    public (string username, string role) GetCurrentSession()
    {
        return (_currentUsername, _currentRole);
    }

    public void RemoveUserSession() // Sin parámetros
    {
        _currentUsername = null;
        _currentRole = null;
    }

    public bool IsUserLoggedIn() => !string.IsNullOrEmpty(_currentUsername);
}
