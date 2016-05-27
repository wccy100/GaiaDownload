/*
 * Created by SharpDevelop.
 * User: young
 * Date: 02/08/2016
 * Time: 20:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace HttpDemo
{
	/// <summary>
	/// Description of Fans.
	/// </summary>
	 
	public class Week  
    {  
        public int uid { get; set; }  
        public int score { get; set; }  
        public string nickname { get; set; }  
        public string avatar { get; set; }  
        public int gender { get; set; }  
        public string level { get; set; }  
    }  
  
    public class Total  
    {  
        public int uid { get; set; }  
        public int score { get; set; }  
        public string nickname { get; set; }  
        public string avatar { get; set; }  
        public int gender { get; set; }  
        public string level { get; set; }  
    }  
  
    public class Data  
    {  
        public IList<Week> week { get; set; }  
        public IList<Total> total { get; set; }  
    }  
  
    public class Fans  
    {  
        public int code { get; set; }  
        public string message { get; set; }  
        public Data data { get; set; }  
    }  
}
