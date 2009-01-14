using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Drawing;

namespace LenHandler.objects
{
    


    public class Connection
    {

        #region Variables de classe

        private string _name;
        private IPEndPoint _IPEndPoint;
        private string _password;
        private static TcpClient _socket;
        private List<string> _log;
        
		private static NetworkStream _nStream; 
		private static StreamReader _rStream; 
		private static StreamWriter _wStream; 
		private static Thread _thread;
        private static List<string> _received;

        public delegate void Event_MessageReceived(string msg);
        public event Event_MessageReceived MessageReceived;

        #endregion


        #region Constructeurs

        public Connection()
        {
            _name = "";
            _IPEndPoint = new IPEndPoint(IPAddress.Parse("0.0.0.0"), 0);
            _password = "";
            _socket = new TcpClient();
            _log = new List<string>();
        }

        public Connection(string name, IPAddress ip, int port, string password)
        {
            _name = name;
            _IPEndPoint = new IPEndPoint(ip, port);
            _password = password;
            _socket = new TcpClient();
            _log = new List<string>();
        }

        #endregion


        #region Propiétés

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public IPAddress IP
        {
            get
            {
                return _IPEndPoint.Address;
            }
            set {  _IPEndPoint.Address = value; }
        }

        public int Port
        {
            get
            {
                return _IPEndPoint.Port;
            }
            set { _IPEndPoint.Port = value; }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set { _password = value; }
        }

        public bool Status
        {
            get
            {
                return _socket.Connected;
            }
        }

        public bool Created
        {
            get
            {
                return _IPEndPoint.Address.ToString() != "0.0.0.0" && _IPEndPoint.Port > 0;
            }
        }

        public List<string> Log
        {
            get { return _log; }
        }

        #endregion


        #region Fonctions

        public void Connect()
        {
            try
            {
                _socket = new TcpClient();
                _socket.Connect(_IPEndPoint);
                _log.Add(DateTime.Now.ToString() + ": Connected to " + _IPEndPoint.ToString());
                _nStream = _socket.GetStream();
			    _wStream = new StreamWriter(_nStream);
			    _rStream = new StreamReader(_nStream);
                _received = new List<string>();

                _thread = new Thread(new ThreadStart(Receive));
                _thread.Start();
                if (_password.Length > 0)
                {
                    Send(_password);
                }
                Send("/status");
                Send("/log all");
                //Send("/log status");
                //Send("/log chatraw");
                //Send("/log gliderlog");
            }
            catch (Exception)
            {
            }

        }

        public void Disconnect()
        {
            try
            {
                _log.Add(DateTime.Now.ToString() + ": Disconnected from " + _IPEndPoint.ToString());
                _socket.Close();
                _nStream.Close();
                _rStream.Close();
                _wStream.Close();
            }
            catch (Exception)
            {
            }
        }

        public void Dispose()
        {
            Disconnect();
        }

		public void Receive()
		{
			while(_socket.Connected)
			{
				try
				{
                    string msg = _rStream.ReadLine();
                    _log.Add(DateTime.Now.ToString() + ": " + msg);
                    MessageReceived(msg);
				}
				catch(Exception)
				{
				}
			}
		}

		public void Send(string msg)
		{
            try
            {
                _wStream.WriteLine(msg);
                _wStream.Flush();
            }
            catch (Exception) { }
		}

        public object[] ToParams()
        {
            object[] _obj = new object[6];
            _obj[0] = this;
            _obj[1] = null;
            _obj[2] = _name;
            _obj[3] = _IPEndPoint.Address.ToString();
            _obj[4] = _IPEndPoint.Port.ToString();
            _obj[5] = _password;

            return _obj;
        }

        override
        public string ToString()
        {
            return Directory.GetCurrentDirectory() + "\\" + (_socket.Connected ? "connected.png" : "disconnected.png");
        }

        #endregion
    }
}
