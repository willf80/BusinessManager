<%@ WebHandler Language="C#" Class="Test" %>

using System;
using System.Web;
using Newtonsoft.Json;
using BusinessEngine.Manager;

public class Test : IHttpHandler {

    private readonly SampleManager _sampleService = SampleManager.GetInstance();
    
    public void ProcessRequest (HttpContext context) {
        
        context.Response.ContentType = "application/json";
        context.Response.Write(JsonConvert.SerializeObject(_sampleService.GetData()));
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}