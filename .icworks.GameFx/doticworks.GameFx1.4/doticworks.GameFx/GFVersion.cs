﻿/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2021/2/8
 * 时间: 15:55
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace doticworks.GameFx
{
	/// <summary>
	/// Description of Version.
	/// </summary>
	public static class GFVersion
	{
		static Version ver= System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
		static Version ver= System.Reflection.Assembly.GetExecutingAssembly().Version;
		public static int AvailablePlatform{get{return ver.Major;}}
		public static int MajorV{get{return ver.Minor;}}
		public static int MinorV{get{return ver.Revision;}}
		public static int BuildV{get{return ver.Build;}}
		public static string FullStr{
			get{
				string tmp="";
				switch(ver.Major){
						case 1:{tmp=tmp+"Universal ";break;}
						case 2:{tmp=tmp+"Windows7 ";break;}
						case 4:{tmp=tmp+"Windows10 ";break;}
						case 5:{tmp=tmp+".NET 5";break;}
				}
				tmp=tmp+ver.Minor.ToString()+"."+ver.Revision.ToString()+"."+ver.Build.ToString()+"."+
			}
		}
		public static string SimpStr{
			get{
				return ver.ToString();
			}
		}
	}
}
