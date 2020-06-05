//Synchronous Method

private void Button_Click(Object ......
{
    Download("http://msdn.microsoft.com")
}

public void Download(string url)
{
    var webClient = new WebClient();
    var html = webClient.DownloadString(url);
    
    using(var streamWriter = new StreamWriter(@"c\project\result.html"))
    {
        streamWriter.Write(html);
    }
}

//Asynchronous Method

private void Button_Click(Object ......
{
    Download("http://msdn.microsoft.com")
}

public async Task void Download(string url)
{
    var webClient = new WebClient();
    var html = await webClient.DownloadStringAsync(url);//Marker - await
    
    using(var streamWriter = new StreamWriter(@"c\project\result.html"))
    {
        streamWriter.Write(html);
    }
}
