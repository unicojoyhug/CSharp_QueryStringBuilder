using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Net;

/// <summary>
/// Summary description for Class1
/// </summary>
public class QueryStringBuilder {
    private string url;
    private Dictionary<string, object> qsb = new Dictionary<string, object>();
    private string text;
    public QueryStringBuilder(string url) {
        this.url = url;
    }

    public void Add(string identifier, object value) {
        qsb.Add(identifier, value);

    }

    public string BuildQuery() {
        StringBuilder sb = new StringBuilder();
        sb.Append(url);

        int queryLength = qsb.Count();
        if (queryLength != 0) {
            sb.Append("?");
            if (queryLength == 1) {
                sb.Append(qsb.ElementAt(0).Key + "=" + WebUtility.UrlEncode(qsb.ElementAt(0).Value.ToString()));

            }
            else {
                for (int i = 0; i < queryLength-1; i++) {
                    sb.Append(qsb.ElementAt(i).Key + "=" + WebUtility.UrlEncode(qsb.ElementAt(i).Value.ToString()));
                    sb.Append("&");
                }
                sb.Append(qsb.ElementAt(queryLength-1).Key + "=" + WebUtility.UrlEncode(qsb.ElementAt(queryLength-1).Value.ToString()));

            }
        }

        return sb.ToString();
    }

   
    public override string ToString() {
        return BuildQuery();
    }

}
