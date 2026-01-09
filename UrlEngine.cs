using System.Collections.Generic;

interface URLStorage
{
	void Put(string shortUrl, string longUrl);
	string Get(string shortUrl);
}

class MemoryURLStorage : URLStorage
{
	Dictionary<string, string> map = new Dictionary<string, string>();

	public void Put(string s, string l) => map[s] = l;

	public string Get(string s) => map.ContainsKey(s) ? map[s] : null;
}
