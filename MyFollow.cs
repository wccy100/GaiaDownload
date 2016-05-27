/*
 * Created by SharpDevelop.
 * User: young
 * Date: 2016/2/16 星期二
 * Time: 12:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

// http://tool.sufeinet.com/  
  
using System;
using System.Collections.Generic;  
  
namespace HttpDemo  
{  
  
    public class Datum  
    {  
        public string roomUrl { get; set; }  
        public string nickname { get; set; }  
        public string uid { get; set; }  
        public string roomId { get; set; }  
        public int follows { get; set; }  
        public string status { get; set; }  
        public string avatar { get; set; }  
        public string title { get; set; }  
        public string gameId { get; set; }  
        public string gameName { get; set; }  
        public string online { get; set; }  
        public string spic { get; set; }  
        public string bpic { get; set; }  
        public string gender { get; set; }  
    }  
  
    public class MyFollow  
    {  
        public int code { get; set; }  
        public string message { get; set; }  
        public IList<Datum> data { get; set; }  
    }  
  
}  