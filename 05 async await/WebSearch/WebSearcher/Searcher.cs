using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace BFH.WebSearch
{
    public delegate void StatusCallback(string msg);

    public class Searcher
    {
        public static StatusCallback Status { get; set; }

        public static void ShowStatus(string msg)
        {
            if (Status != null)
                Status(msg);
        }

        public static string DownloadHtml(string url)
        {
            using (var client = new WebClient())
            {
                try
                {
                    return client.DownloadString(url);
                }
                catch
                {
                    return "";
                }
            }
        }

        public async static Task<string> DownloadHtmlAsync(string url)
        {
            ShowStatus(String.Format("start downloading '{0}'", url));

            var download = await Task.Run<string>(() => DownloadHtml(url));

            ShowStatus(String.Format("finished downloading '{0}'", url));

            return download;
        }

        public static string[] ExtractWords(string html)
        {
            var res = new List<string>();
            var pos = 0;
            while (pos < html.Length)
            {
                var endPos = html.IndexOf('<', pos);
                if (endPos >= pos)
                {
                    var text = html.Substring(pos, endPos - pos).Trim().ToLower();
                    if (!String.IsNullOrEmpty(text))
                        foreach (var w in text.Split(' ', '.', ',', ':', ';', '!', '?', '\t', '\n', '\r'))
                        {
                            var word = w.Trim();
                            if (!String.IsNullOrEmpty(word))
                                res.Add(word);
                        }

                    pos = endPos + 1;
                    endPos = html.IndexOf('>', endPos + 1);
                    pos = (endPos > pos) ? endPos + 1 : Int32.MaxValue;
                }
                else
                    pos = Int32.MaxValue;
            }

            return res.ToArray();
        }

        public async static Task<string[]> ExtractWordsAsync(string html)
        {
            return await Task.Run<string[]>(() => ExtractWords(html));
        }

        public static string[] DownloadWords(string url)
        {
            ShowStatus(String.Format("start downloading words from '{0}'", url));

            var html = DownloadHtml(url);

            var res = ExtractWords(html);

            ShowStatus(String.Format("finished downloading words from'{0}'", url));

            return res;
        }

        public async static Task<string[]> DownloadWordsAsync(string url)
        {
            ShowStatus(String.Format("start downloading words from '{0}'", url));

            var html = await DownloadHtmlAsync(url);

            var words = await ExtractWordsAsync( html);

            ShowStatus(String.Format("finished downloading words from'{0}'", url));

            return  words;
        }

        public static int FindWord(string word, string url)
        {
            var count = 0;
            word = word.ToLower();

            var words = DownloadWords(url);

            foreach (var w in words)
                if (word == w)
                    count++;

            return count;
        }

        public static async Task<int> FindWordAsync(string word, string url)
        {
            var count = 0;
            word = word.ToLower();

            var words = await DownloadWordsAsync(url);

            foreach (var w in words)
            {
                if (word == w)
                    count++;
            }

            return count;
        }

        public class SearchResult
        {
            public string Url {get; set;}
            public int Count {get; set;}
        }

        public static SearchResult[] FindWord(string word)
        {
            var res = new List<SearchResult>();

            for (int i = 0; i < TheWeb.URLs.Length; i++)
            {
                var count = FindWord(word, TheWeb.URLs[i]);
                if (count > 0)
                    res.Add(new SearchResult { Count = count, Url = TheWeb.URLs[i] });
            }

            return res.OrderByDescending(r => r.Count).ToArray();
        }

        public static async Task<SearchResult[]> FindWordAsync(string word)
        {
            var res = new List<SearchResult>();
            var task = new Task<int>[TheWeb.URLs.Length];

            for (int i = 0; i < TheWeb.URLs.Length; i++)
                task[i] = FindWordAsync(word, TheWeb.URLs[i]);

            for (int i=0; i< task.Length; i++)
            {
                var count = await task[i];
                if (count > 0)
                    res.Add(new SearchResult { Count = count, Url = TheWeb.URLs[i] });
            }

            return res.OrderByDescending(r => r.Count).ToArray();
        }
    }
}
