using System.Collections.Generic;

interface Role
{
	bool CanAccess(string resource);
}

class AdminRole : Role
{
	public bool CanAccess(string resource) => true;
}

class UserRole : Role
{
	public bool CanAccess(string resource) => resource == "Profile";
}

class AuthSystem
{
	Dictionary<string, Role> roles = new Dictionary<string, Role>();

	public void Assign(string user, Role role) => roles[user] = role;

	public bool CheckAccess(string user, string resource)
	{
		return roles.ContainsKey(user) && roles[user].CanAccess(resource);
	}
}
