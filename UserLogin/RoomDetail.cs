/*
 * Created by SharpDevelop.
 * User: young
 * Date: 2016/5/20
 * Time: 22:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace HttpDemo.UserLogin
{
	/// <summary>
	/// Description of RoomDetail.
	/// </summary>
 public class Prop  
    {  
        public int speaker { get; set; }  
        public int ticket { get; set; }  
    }  
  
    public class Slevel  
    {  
        public string name { get; set; }  
        public string pos { get; set; }  
        public string keep { get; set; }  
        public string nextname { get; set; }  
        public string level { get; set; }  
        public string nextexp { get; set; }  
        public string leftexp { get; set; }  
        public string levelexp { get; set; }  
        public string curexp { get; set; }  
        public string uid { get; set; }  
        public int consume { get; set; }  
        public int opp { get; set; }  
        public string type { get; set; }  
        public string etime { get; set; }  
    }  
  
    public class Roomdata  
    {  
        public int vlevel { get; set; }  
        public string vdesc { get; set; }  
        public Slevel slevel { get; set; }  
    }  
  
    public class Rt  
    {  
        public double init { get; set; }  
        public double session { get; set; }  
        public string redis { get; set; }  
        public double all { get; set; }  
        public string elapsed { get; set; }  
    }  
  
    public class Data  
    {  
        public int uid { get; set; }  
        public int gid { get; set; }  
        public string sid { get; set; }  
        public int timestamp { get; set; }  
        public Prop prop { get; set; }  
        public bool isFollow { get; set; }  
        public Roomdata roomdata { get; set; }  
        public Rt rt { get; set; }  
    }  
  
    public class RoomDetail  
    {  
        public int code { get; set; }  
        public string message { get; set; }  
        public Data data { get; set; }  
    }  
}
