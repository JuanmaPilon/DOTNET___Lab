using System.Collections.Generic;

public class UserSessionService
{
    private readonly Dictionary<string, string> _userSessions = new Dictionary<string, string>();

    public void SetUserSession(string username, string role)
    {
        _userSessions[username] = role;
    }

    public (string username, string role) GetUserSession(string username)
    {
        if (_userSessions.TryGetValue(username, out string role))
        {
            return (username, role);
        }
        return (null, null);
    }

    public void RemoveUserSession(string username)
    {
        _userSessions.Remove(username);
    }
}
