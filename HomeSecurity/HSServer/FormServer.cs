using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSServer
{
    public partial class FormServer : Form
    {
        private IPAddress _serverAddress;
        //privet Port _serverPortNumber;

        private StatusType _serverStatus;
        private int _connectedClients;
        private int _numberOfFiles;
        private double _sizeOfFiles;

        public FormServer()
        {
            InitializeComponent();
            InitValues();
        }

        private void InitValues()
        {
            List<IPAddress> addresses=  Dns.GetHostAddresses(Dns.GetHostName()).ToList();
            _serverAddress = addresses[2];
            _serverAddress.Address = addresses[2].Address;
            //_serverPortNumber = ;

            _serverStatus = StatusType.Offline;
            _connectedClients = 0;
            _numberOfFiles = 0;
            _sizeOfFiles = 0;

            ServerLog.Write(ref richTextBoxLogWindow,"");
        }

        private void ShowValues()
        {

        }
    }
}
