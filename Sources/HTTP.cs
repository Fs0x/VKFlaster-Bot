using System.Net;
using System.Text;

public class HTTP
{
    protected string Proxy = null;
    protected int type = -1;

    public void setProxy(string IPPort = null, int type = -1)
    {
        if (IPPort != null && type >= 0)
        {
            Proxy = IPPort;
            this.type = type;
        }
        else
        {
            Proxy = null;
            type = -1;
        }
    }

    public string Post(string url, string _params)
    {
        try
        {
            string content = null;

            using (var Sender = new WebClient())
            {
                try
                {
                    if (!string.IsNullOrEmpty(Proxy) && type >= 0)
                        Sender.Proxy = new WebProxy(Proxy.Split(':')[0], int.Parse(Proxy.Split(':')[1]));
                }
                catch { }

                System.Collections.Specialized.NameValueCollection preq = new System.Collections.Specialized.NameValueCollection();

                foreach (string _string in _params.Split(new char[] { '&' }))
                {
                    string[] Params = _string.Split(new char[] { '=' });
                    preq.Add(Params[0], Params[1]);
                }

                content = Encoding.UTF8.GetString(Sender.UploadValues(url, preq));
            }

            return content;
        }
        catch {}

        return null;
    }
}
