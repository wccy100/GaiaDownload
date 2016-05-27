/*
 * Created by SharpDevelop.
 * User: young
 * Date: 2016/5/11 星期三
 * Time: 22:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Net.Sockets;  
using System.Net;  
using System.Threading;
using HttpDemo.UserLogin;  
namespace HttpDemo
{
	/// <summary>
	/// Description of ATestDanmuku.
	/// </summary>
	public partial class ATestDanmuku : Form
	{
		public ATestDanmuku()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			RoomDetail roomdetail  = worklog.GetRoomDetail();
			richTextBox1.Text= roomdetail.data.sid+"\n"+roomdetail.data.uid;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
//		123.57.10.197
		
//		  private   int myProt = 15010;   //端口  
//           Socket serverSocket;  
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		WorkLogin worklog = new WorkLogin();
		void BtnSendClick(object sender, EventArgs e)
		{
			string strMessage = txtMessage.Text;
			
			
			lblInfo.Text = strMessage;
			LoginChatRoom();
			SendMessage(strMessage);
			
		}
		void SendMessage(string paramString)
		{
			JObject localJSONObject1 = new JObject();
			JArray localJSONArray = new JArray();
			JObject localJSONObject2 = new JObject();
			localJSONObject2.Add("color", "black");
			localJSONArray.Add(localJSONObject2);
			localJSONObject1.Add("style", localJSONArray);
			localJSONObject1.Add("extra", "Android");
			localJSONObject1.Add("cmdid", "chatmessage");
			localJSONObject1.Add("toid", 0);
			localJSONObject1.Add("content", paramString);
			 localJSONObject1.Add("hot", 0);
			 localJSONObject1.Add("useemot","1#0;");
			SendJsonToServer(localJSONObject1);

			
			
		}
		byte[] arrayOfByte2 ;
		void SendJsonToServer(JObject localJSONObject1)
		{
			string jsonstring = localJSONObject1.ToString();
			
			byte[] arrayOfByte1 = Encoding.Unicode.GetBytes(jsonstring);
//			arrayOfByte2=arrayOfByte1;
		arrayOfByte2= new byte[12 + arrayOfByte1.Length];
		
			arrayOfByte2[0] = 0xcc;
			arrayOfByte2[1] = 0xbb;
			fromIntToByteArray(arrayOfByte2, 2, 4, 0);
			fromIntToByteArray(arrayOfByte2, 6, 4, arrayOfByte1.Length);
			fromIntToByteArray(arrayOfByte2, 10, 2, 10000);
			InsertBytsToByteArray(arrayOfByte2, 10, ShortToBytes(10000));
			ConnectToServer();
			
			
			
		}
		void LoginChatRoom()
		{
			string loginstring="{\"uid\":107616417,\"os\":\"4.4.2\",\"sid\":\"NzM1ZGEzNjM1MjBmZTE3ZGUwZWM3Njg1OWU0YWYwMzc=\",\"model\":\"NX403A\",\"nickname\":\"\",\"imei\":\"zhanqi863396021453806\",\"cmdid\":\"loginreq\",\"ver\":\"2\",\"chatroomid\":83,\"timestamp\":1463389329,\"roomid\":203,\"fhost\":\"android\",\"t\":0,\"r\":0,\"device\":1,\"gid\":1832132009,\"ssid\":\"YWMyMzQ5MWE4YzJlZWFiYzM0M2VkZGM4NzA4MjU4NWQ=\",\"roomdata\":{\"slevel\":{\"uid\":\"107616417\",\"opp\":0,\"curexp\":\"2958\",\"levelexp\":\"0\",\"type\":\"0\",\"consume\":2958,\"pos\":\"0\",\"level\":\"0\",\"etime\":\"1448896181\",\"name\":\"\",\"nextexp\":\"15000\",\"leftexp\":\"12042\",\"nextname\":\"青铜5\",\"keep\":\"\"},\"vdesc\":\"\",\"vlevel\":0}}";
			JObject jsonObject=JObject.Parse(loginstring);
			SendJsonToServer(jsonObject);
		}
   private static byte[] result = new byte[1024];  
		void ConnectToServer()
		{
			 
            //设定服务器IP地址  
            IPAddress ip = IPAddress.Parse("112.126.84.65");  
            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);  
            try  
            {  
                clientSocket.Connect(new IPEndPoint(ip, 15010)); //配置服务器IP与端口  
               lblInfo.Text=("连接服务器成功");  
            }  
            catch  
            {  
                lblInfo.Text=("连接服务器失败，请按回车键退出！");  
                return;  
            }  
//            //通过clientSocket接收数据  
//            int receiveLength = clientSocket.Receive(result);  
//            Console.WriteLine("接收服务器消息：{0}",Encoding.ASCII.GetString(result,0,receiveLength));  
//            通过 clientSocket 发送数据  
            
                try  
                {  
                     
//                	byte[]buffer=new byte[1024*8];
//                	int len=-1;
//                	while((len=clientSocket.Send(buffer,0,buffer.Length)!=0)
//                	{
                		  clientSocket.Send(arrayOfByte2); 
//                	}
                   
                   lblInfo.Text=("向服务器发送消息：{0}" + txtMessage.Text);  
                }  
                catch  
                {  
                    clientSocket.Shutdown(SocketShutdown.Both);  
                    clientSocket.Close();  
                      
                }  
           
        
		}

		public void fromIntToByteArray(byte[] paramArrayOfByte, int paramInt1, int paramInt2, int paramInt3)
		{
			int i = 0;
			for (int j = paramInt1;; ++j) {
				if (j >= paramInt1 + paramInt2)
					return;
				paramArrayOfByte[j] = (byte)(0xFF & paramInt3 >> i);
				i += 8;
			}
		}
		public int fromByteArrayToInt(byte[] paramArrayOfByte, int paramInt1, int paramInt2)
		{
			int i = 0;
			int j = 0;
			for (int k = paramInt1;; ++k) {
				if (k >= paramInt1 + paramInt2)
					return i;
				i += ((0xFF & paramArrayOfByte[k]) << j);
				j += 8;
			}
		}
		public void InsertBytsToByteArray(byte[] paramArrayOfByte1, int paramInt, byte[] paramArrayOfByte2)
		{
			for (int i = paramInt;; ++i) {
				if (i >= paramArrayOfByte2.Length)
					return;
				paramArrayOfByte1[paramInt] = paramArrayOfByte2[(i - paramInt)];
			}
		}
		public static byte[] ShortToBytes(int paramInt)
		{
			return Int2Bytes(paramInt);
			  
			 
		}
		
		
		
		
		
		/**
		 * 将一个Int 数据，转换为byte数组.
		 * JAVA直接使用
		 * @param intValue Int 数据
		 * @return byte数组.
		 */
		public static byte[] Int2Bytes(int intValue)
		{
			byte[] result = new byte[4];
			result[0] = (byte)((intValue & 0xFF000000) >> 24);
			result[1] = (byte)((intValue & 0x00FF0000) >> 16);
			result[2] = (byte)((intValue & 0x0000FF00) >> 8);
			result[3] = (byte)((intValue & 0x000000FF));
			return result;
		}
		
		/**
		 * 将int转为低字节在前，高字节在后的byte数组
		 * 转为C#需要的的数组顺序
		 *
		 */
		private static byte[] Int2BytesLH(int n)
		{
			byte[] b = new byte[4];
			b[0] = (byte)(n & 0xff);
			b[1] = (byte)(n >> 8 & 0xff);
			b[2] = (byte)(n >> 16 & 0xff);
			b[3] = (byte)(n >> 24 & 0xff);
			return b;
		}
		
		/**
		 * 将byte[]转为低字节在前，高字节在后的byte数组
		 * 从C#收包后转换为JAVA的数组顺序
		 */
		private static byte[] BytestoHL(byte[] n)
		{
			byte[] b = new byte[4];
			b[3] = n[0];
			b[2] = n[1];
			b[1] = n[2];
			b[0] = n[3];
			return b;
		}
		
		/**
		 * 将byte数组的数据，转换成Int值.
		 * JAVA直接使用
		 * @param byteVal byte数组
		 * @return Int值.
		 */
		public static int Bytes2Int(byte[] byteVal)
		{
			int result = 0;
			for (int i = 0; i < byteVal.Length; i++) {
				int tmpVal = (byteVal[i] << (8 * (3 - i)));
				switch (i) {
					case 0:
						tmpVal = (int)(tmpVal & 0xFF000000);
						break;
					case 1:
						tmpVal = tmpVal & 0x00FF0000;
						break;
					case 2:
						tmpVal = tmpVal & 0x0000FF00;
						break;
					case 3:
						tmpVal = tmpVal & 0x000000FF;
						break;
				}
				result = result | tmpVal;
			}
			return result;
		}
	}
}
