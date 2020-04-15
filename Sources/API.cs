using Newtonsoft.Json.Linq;

public class API
{
    public HTTP Http = new HTTP();
    protected string url = "https://api.vk.com/method";
    protected string version = "5.103"; // 5.92
    protected string token;
    public bool Isauth = false;

    public string user_id;

    public string getToken()
    {
        return token;
    }

    public void setToken(string token)
    {
        this.token = token;
    }

    public bool CheckToken(string token)
    {
        string a_token = this.token;

        Isauth = true;
        setToken(token);

        var response = Inquiry("users.get");

        Isauth = false;
        this.token = a_token;

        if (response != null) return true; else return false;
    }

    public bool auth(string login, string password)
    {
        string response = Http.Post("https://oauth.vk.com/token", $"username={login}&password={password}&"
            + "scope=offline,groups,photos,wall,notify,friends,audio,video,stories,pages,status,notes,messages,ads,docs,notifications,stats,email,market&"
            + "client_id=3140623&client_secret=VeWdmVclDCtn6ihuP1nt&grant_type=password");

        if (response == null || !response.Contains("access_token"))
        {
            user_id = null;
            token = null;

            Isauth = false;
            return false;
        }
        else
        {
            JObject account = JObject.Parse(response);
            token = account["access_token"].ToString();
            user_id = account["user_id"].ToString();


            Isauth = true;
            return true;
        }
    }

    public JToken Inquiry(string method, string _params = null)
    {
        try
        {
            if (Isauth)
            {
                string response = Http.Post(url + "/" + method, $"{(_params == null ? "access_token=" : $"{_params}&access_token=")}{token}&v={version}");

                if (response != null && response.Contains("response") && !response.Contains("error"))
                    return JObject.Parse(response)["response"];
            }
        }
        catch { }

        return null;
    }
}
