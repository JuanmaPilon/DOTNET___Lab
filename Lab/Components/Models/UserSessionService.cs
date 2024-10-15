public class UserSessionService
{
    private readonly Dictionary<string, string> _userSessions = new Dictionary<string, string>();
    private string _currentUser; // Variable para almacenar el usuario actual

    public void SetUserSession(string username, string role)
    {
        _userSessions[username] = role;
        _currentUser = username; // Guardar el usuario actual
    }

    public (string username, string role) GetCurrentSession()
    {
        if (_currentUser != null && _userSessions.TryGetValue(_currentUser, out string role))
        {
            return (_currentUser, role);
        }
        return (null, null);
    }

    public void RemoveUserSession(string username)
    {
        _userSessions.Remove(username);
        if (_currentUser == username)
        {
            _currentUser = null; // Limpiar el usuario actual si se elimina
        }
    }
}
