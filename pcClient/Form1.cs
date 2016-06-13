using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using InTheHand.Net.Sockets;
using InTheHand.Net.Bluetooth;
using InTheHand.Windows.Forms;
using InTheHand.Net.Bluetooth.AttributeIds;
using System.IO;

// add PowerPoint namespace
using PPt = Microsoft.Office.Interop.PowerPoint;
using System.Runtime.InteropServices;
using System.Net;
using System.Resources;

namespace Bluetooth_ServerSide
{
    public partial class Form1 : Form
    {
        const int TYPE_DISCOVERING = 0;
        const int TYPE_LOST = 1;
        const int TYPE_CONNECTING = 2;
        const int TYPE_COMMUNICATING = 3;


        // Threads
        Thread AcceptAndListeningThread;
        Thread AcceptWaitingSocket;
        Thread ConnectAndListningThread;

        // helper variable
        Boolean isConnected = false;
        Boolean isConnectedServer = false;
        Boolean isConnectedIP = false;
        Boolean isBTclient = true;
        Boolean isBTServer = false;
        Boolean isIPServer = false;

        //socket
        int port = 18564;
        private Socket socket;
        Socket acceptedSocket;

        //bluetooth stuff
        BluetoothClient btClient;  //represent the bluetooth client connection
        BluetoothClient mClient;
        BluetoothListener btListener; //represent this server bluetooth device

        

        // Define PowerPoint Application object
        PPt.Application pptApplication;
        // Define Presentation object
        PPt.Presentation presentation;
        // Define Slide collection
        PPt.Slides slides;
        PPt.Slide slide;

        // Slide count
        int slidescount;
        // slide index
        int slideIndex;

        //resource
        ResourceManager rm;

        public Form1()
        {
             rm = new ResourceManager(this.GetType());

            InitializeComponent();

            FormClosing += new FormClosingEventHandler(Form1_FormClosing);


            //when the bluetooth is supported by this computer

            if (BluetoothRadio.IsSupported)
            {
                /*
                UpdateLogText("Bluetooth Supported!");
                UpdateLogText("—————————–");

                

                //getting device information
                UpdateLogText("Primary Bluetooth Radio Name : " + BluetoothRadio.PrimaryRadio.Name);
                UpdateLogText("Primary Bluetooth Radio Address : " + BluetoothRadio.PrimaryRadio.LocalAddress);
                UpdateLogText("Primary Bluetooth Radio Manufacturer : " + BluetoothRadio.PrimaryRadio.Manufacturer);
                UpdateLogText("Primary Bluetooth Radio Mode : " + BluetoothRadio.PrimaryRadio.Mode);
                UpdateLogText("Primary Bluetooth Radio Software Manufacturer : " + BluetoothRadio.PrimaryRadio.SoftwareManufacturer);
                UpdateLogText("—————————–");
                */

                //creating and starting the thread
                AcceptAndListeningThread = new Thread(AcceptAndListen);

                AcceptAndListeningThread.Start();

                ConnectAndListningThread = new Thread(ConnectAndListen);
                ConnectAndListningThread.Start();

            }
            else
            {
                UpdateLogText("Bluetooth not Supported!");
            }
            /*
            AcceptWaitingSocket = new Thread(SocketListen);
            AcceptWaitingSocket.Start();*/
        }
        StreamReader srReceiver;
        private delegate void UpdateLogCallback(string strMessage);

        private void ReceiveMessages()
        {
            string ConResponse = "";
            if (isConnected) {
                NetworkStream stream = btClient.GetStream();

                Byte[] bytes = new Byte[512];

                

                stream.Read(bytes, 0, 512);

                stream.Flush();

                for (int i = 0; i < bytes.Length; i++)
                {
                    ConResponse += Convert.ToChar(bytes[i]);

                }

                UpdateLogTextFromThread(btClient.RemoteMachineName + " : " + ConResponse);
                UpdateLogTextFromThread("");
            }
            if (isConnectedIP)
            {
                Byte[] bytes = new Byte[512];
                acceptedSocket.Receive(bytes);
                for (int i = 0; i < bytes.Length; i++)
                {
                    ConResponse += Convert.ToChar(bytes[i]);

                }
                UpdateLogTextFromThread("user"+ " : " + ConResponse);
                UpdateLogTextFromThread("");
            }

            // If the first character is a 1, connection was successful
            if (ConResponse[0] == '1')
            {
                // Update the form to tell it we are now connected
                this.Invoke(new UpdateLogCallback(this.UpdateLogText), new object[] { "Connected Successfully!" });
            }
            else // If the first character is not a 1 (probably a 0), the connection was unsuccessful
            {
                string Reason = "Not Connected: ";

                // Extract the reason out of the response message. The reason starts at the 3rd character
                Reason += ConResponse.Substring(2, ConResponse.Length - 2);

                // Exit the method
                return;
            }

            try
            {
                // Get Running PowerPoint Application object
                pptApplication = Marshal.GetActiveObject("PowerPoint.Application") as PPt.Application;
               
            }
            catch
            {
                this.Invoke(new UpdateLogCallback(this.UpdateLogText), new object[] { "Please Run PowerPoint Firstly" });

                return;
            }
            if (pptApplication != null)
            {
                // Get Presentation Object
                presentation = pptApplication.ActivePresentation;
                // Get Slide collection object
                slides = presentation.Slides;
                // Get Slide count
                slidescount = slides.Count;
                // Get current selected slide 
                try
                {
                    // Get selected slide object in normal view
                    slide = slides[pptApplication.ActiveWindow.Selection.SlideRange.SlideNumber];
                }
                catch
                {
                    // Get selected slide object in reading view
                    slide = pptApplication.SlideShowWindows[1].View.Slide;
                }
            }

            // While we are successfully connected, read incoming lines from the server
            while (isConnected)
            {
                NetworkStream stream = btClient.GetStream();

                Byte[] bytes = new Byte[512];



                stream.Read(bytes, 0, 512);

                stream.Flush();

                for (int i = 0; i < bytes.Length; i++)
                {
                    ConResponse += Convert.ToChar(bytes[i]);

                }
                //분석
                //
                this.Invoke(new UpdateLogCallback(this.DecidePptAction), new object[] { ConResponse });
                // Show the messages in the log TextBox
                this.Invoke(new UpdateLogCallback(this.UpdateLogText), new object[] { ConResponse });
            }
        }

        public void ConnectAndListen()
        {
            UpdateButtonStateFromThread(false);
            while (isBTclient)
            {
                if (isConnectedServer)
                {
                    //TODO: if there is a device connected
                    //listening
                    try
                    {
                        NetworkStream stream = mClient.GetStream();

                        Byte[] bytes = new Byte[512];

                        String retrievedMsg = "";

                        int size = stream.Read(bytes, 0, 512);

                        if (size == 0)
                        {
                            isConnectedServer = false;
                            Exception e = new Exception();
                            throw e;
                        }

                        stream.Flush();

                        for (int i = 0; i < bytes.Length; i++)
                        {
                            retrievedMsg += Convert.ToChar(bytes[i]);

                        }

                        UpdateLogTextFromThread(mClient.RemoteMachineName + " : " + retrievedMsg);

                        if (!retrievedMsg.Contains("servercheck"))
                        {

                            sendMessage("Message Received!");
                        }
                        this.Invoke(new UpdateLogCallback(this.DecidePptAction), new object[] { retrievedMsg });
                        //ReceiveMessages();
                    }
                    catch (Exception ex)
                    {
                        UpdateLogTextFromThread("There is an error while connecting server"+Environment.NewLine+
                            "press dicovering button to connect");
                        mClient.Close();
                        isConnectedServer = false;
                    }
                }
                else
                {
                    //TODO: if there is no connection
                    // select device and connect
                    try
                    {
                        OnConnectionStateChangedFromThread(TYPE_DISCOVERING);
                        UpdateLogTextFromThread("Discorvering devices...");
                        mClient = new BluetoothClient();

                        BluetoothDeviceInfo[] arry =  mClient.DiscoverDevices();
                        BluetoothDeviceInfo inf;

                        int watchCount = 0;
                        foreach (BluetoothDeviceInfo item in arry)
                        {
                            if (item.ClassOfDevice.Device.ToString().Equals("WearableWristWatch") || item.ClassOfDevice.Device.ToString().Equals("Miscellaneous"))
                                watchCount++;
                        }

                        BluetoothDeviceInfo[] arry2 = new BluetoothDeviceInfo[watchCount];
                        int i = 0;
                        foreach (BluetoothDeviceInfo item in arry)
                        {
                            if (item.ClassOfDevice.Device.ToString().Equals("WearableWristWatch") || item.ClassOfDevice.Device.ToString().Equals("Miscellaneous"))
                            {
                                arry2[i] = item;
                                i++;
                            }
                        }

                        if (watchCount == 1)
                        {
                            inf = arry2[0];
                        } else if (watchCount > 1) { 
                            Form2 form2 = new Form2(arry2);
                            Application.Run(form2);
                            UpdateLogTextFromThread("select"+arry2[form2.a].DeviceName);
                            inf = arry[form2.a];
                        } else
                        {
                            UpdateLogTextFromThread("nothing to connected");
                            OnConnectionStateChangedFromThread(TYPE_LOST);
                            UpdateButtonStateFromThread(true);
                            UpdateButtonText("discovering");
                            break;
                        }
                        OnConnectionStateChangedFromThread(TYPE_CONNECTING);
                        mClient.Connect(inf.DeviceAddress, BluetoothService.SerialPort);
                        
                        UpdateLogTextFromThread("Connecting Success to : " + mClient.RemoteMachineName);
                        OnConnectionStateChangedFromThread(TYPE_COMMUNICATING);

                        isConnectedServer = mClient.Connected;
                        UpdateButtonTextFromThread("Disconnecting");
                        UpdateButtonStateFromThread(true);
                        UpdateLogTextFromThread("A Bluetooth Device Connected!");
                        
                    }
                    catch (Exception e)
                    {
                        OnConnectionStateChangedFromThread(TYPE_LOST);
                        UpdateLogTextFromThread("There is an error while connecting server");
                        UpdateLogTextFromThread(e.Message);
                        UpdateLogTextFromThread("Retrying….");
                    }
                }
            }
        }

        //the function of the thread
        public void AcceptAndListen()
        {
            while (isBTServer)
            {
                if (isConnected)
                {
                    //TODO: if there is a device connected
                    //listening
                    try
                    {
                        UpdateLogTextFromThread("Listening….");
                        NetworkStream stream = btClient.GetStream();

                        Byte[] bytes = new Byte[512];

                        String retrievedMsg = "";

                        stream.Read(bytes, 0, 512);

                        stream.Flush();

                        for (int i = 0; i < bytes.Length; i++)
                        {
                            retrievedMsg += Convert.ToChar(bytes[i]);

                        }

                        UpdateLogTextFromThread(btClient.RemoteMachineName + " : " + retrievedMsg);
                        UpdateLogTextFromThread("");

                        if (!retrievedMsg.Contains("servercheck"))
                        {

                            sendMessage("Message Received!");
                        }
                        this.Invoke(new UpdateLogCallback(this.DecidePptAction), new object[] { retrievedMsg });
                        //ReceiveMessages();
                    }
                    catch (Exception ex)
                    {
                        UpdateLogTextFromThread("There is an error while listening connection");
                        UpdateLogTextFromThread(ex.Message);
                        isConnected = btClient.Connected;
                    }
                }
                else
                {
                    //TODO: if there is no connection
                    // accepting
                    try
                    {
                        btListener = new BluetoothListener(BluetoothService.SerialPort);
                        
                        UpdateLogTextFromThread("Listener created with TCP Protocol service " + BluetoothService.SerialPort);
                        UpdateLogTextFromThread("Starting Listener….");
                        btListener.Start();
                        UpdateLogTextFromThread("Listener Started!");
                        UpdateLogTextFromThread("Accepting incoming connection….");
                        btClient = btListener.AcceptBluetoothClient();
                        isConnected = btClient.Connected;
                        UpdateLogTextFromThread("A Bluetooth Device Connected!");
                    }
                    catch (Exception e)
                    {
                        UpdateLogTextFromThread("There is an error while accepting connection");
                        UpdateLogTextFromThread(e.Message);
                        UpdateLogTextFromThread("Retrying….");
                    }
                }
            }
        }

        public void setPptState()
        {
            // Get Presentation Object
            presentation = pptApplication.ActivePresentation;
            // Get Slide collection object
            slides = presentation.Slides;
            // Get Slide count
            slidescount = slides.Count;
            // Get current selected slide 
            try
            {
                // Get selected slide object in normal view
                slide = slides[pptApplication.ActiveWindow.Selection.SlideRange.SlideNumber];
            }
            catch
            {
                // Get selected slide object in reading view
                slide = pptApplication.SlideShowWindows[1].View.Slide;
            }
        }

        public void DecidePptAction(String msg)
        {
            try
            {
                // Get Running PowerPoint Application object
                pptApplication = Marshal.GetActiveObject("PowerPoint.Application") as PPt.Application;

            }
            catch
            {
                this.Invoke(new UpdateLogCallback(this.UpdateLogText), new object[] { "Please Run PowerPoint Firstly" });
                sendMessage("Please Run PowerPoint Firstly");
                return;
            }
            if (pptApplication != null)
            {
                setPptState();
            }
            if (msg.Contains("next"))
            {
                slideIndex = slide.SlideIndex + 1;
                if (slideIndex > slidescount)
                {
                    this.Invoke(new UpdateLogCallback(this.UpdateLogText), new object[] { "It is already last page" });
                    sendMessage("It is already last page");
                }
                else
                {
                    try
                    {
                        slide = slides[slideIndex];
                        slides[slideIndex].Select();
                    }
                    catch
                    {
                        pptApplication.SlideShowWindows[1].View.Next();
                        slide = pptApplication.SlideShowWindows[1].View.Slide;
                    }
                }
            }    
            else if (msg.Contains("prev"))
            {
                slideIndex = slide.SlideIndex - 1;
                if (slideIndex <= 0)
                {
                    this.Invoke(new UpdateLogCallback(this.UpdateLogText), new object[] { "It is already first page" });
                    sendMessage("It is already first page");
                }
                else
                {
                    try
                    {
                        slide = slides[slideIndex];
                        slides[slideIndex].Select();
                    }
                    catch
                    {
                        pptApplication.SlideShowWindows[1].View.Previous();
                        slide = pptApplication.SlideShowWindows[1].View.Slide;
                    }
                }
            }
            else if (msg.Contains("move")) {
                String index = "" + msg.Substring("move".Length);
                try
                {
                    slideIndex = int.Parse(index);
                }
                catch
                {
                    index = "Non insert position!";
                    slideIndex = 0;
                }
                
                if(slideIndex > slidescount || slideIndex <= 0)
                {
                    this.Invoke(new UpdateLogCallback(this.UpdateLogText), new object[] { "con't move this position : " + index });
                    sendMessage("con't move this position : " + index);
                } else
                {
                    try
                    {
                        slide = slides[slideIndex];
                        slides[slideIndex].Select();
                    }
                    catch
                    {
                        pptApplication.SlideShowWindows[1].View.GotoSlide(slideIndex);
                        slide = pptApplication.SlideShowWindows[1].View.Slide;
                    }
                }
            }
            else if (msg.Contains("home"))
            {
                slideIndex = 1;
                try
                {
                    slide = slides[slideIndex];
                    slides[slideIndex].Select();
                }
                catch
                {
                    pptApplication.SlideShowWindows[1].View.GotoSlide(1);
                    slide = pptApplication.SlideShowWindows[1].View.Slide;
                }
            }
            else if (msg.Contains("end"))
            {
                slideIndex = slidescount;
                try
                {
                    slide = slides[slideIndex];
                    slides[slideIndex].Select();
                }
                catch
                {
                    pptApplication.SlideShowWindows[1].View.GotoSlide(slidescount);
                    slide = pptApplication.SlideShowWindows[1].View.Slide;
                }
            }
            
        }

        public void SocketListen()
        {
            while (true)
            {
                if (isConnectedIP)
                {
                    //TODO: if there is a device connected
                    //listening
                    try
                    {
                        UpdateLogTextFromThread("Listening….");
                        
                        Byte[] bytes = new Byte[512];
                        int size = acceptedSocket.Receive(bytes);
                        String retrievedMsg = "";

                        for (int i = 0; i < bytes.Length; i++)
                        {
                            retrievedMsg += Convert.ToChar(bytes[i]);

                        }

                        UpdateLogTextFromThread(btClient.RemoteMachineName + " : " + retrievedMsg);
                        UpdateLogTextFromThread("");

                        if (!retrievedMsg.Contains("servercheck"))
                        {

                            sendMessage("Message Received!");
                        }
                        ReceiveMessages();
                    }
                    catch (Exception ex)
                    {
                        UpdateLogTextFromThread("There is an error while listening connection");
                        UpdateLogTextFromThread(ex.Message);
                        isConnectedIP = false;
                    }
                }
                else
                {
                    //TODO: if there is no connection
                    // accepting
                    try
                    {
                        IPAddress ipAddress = IPAddress.Any;
                        IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, port);
                        socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        UpdateLogTextFromThread("TCP Starting Listener….");
                        socket.Bind(ipEndPoint);
                        socket.Listen(10);
                        acceptedSocket = socket.Accept();
                        isConnectedIP = true;
                        UpdateLogTextFromThread("A TCP Device Connected!");
                        string acceptedIP = ((IPEndPoint)acceptedSocket.RemoteEndPoint).Address.ToString();
                        UpdateLogTextFromThread("Accepted IP is : " + acceptedIP);
                    }
                    catch (Exception e)
                    {
                        UpdateLogTextFromThread("There is an error while accepting connection");
                        UpdateLogTextFromThread(e.Message);
                        UpdateLogTextFromThread("Retrying….");
                    }
                }
            }
        }


        //this section is to create a method that allow thread accessing form’s component
        //we can’t update the text of the textbox directly from thread, so, we use this delegate function

        delegate void UpdateLogTextFromThreadDelegate(String msg);
        public void UpdateLogTextFromThread(String msg)
        {
            if (!this.IsDisposed && logsText.InvokeRequired) 
            {
                logsText.Invoke(new UpdateLogTextFromThreadDelegate(UpdateLogText), new Object[]{msg});
            }
        }

        delegate void UpdateButtonStateFromThreadDelegate(Boolean b);
        public void UpdateButtonStateFromThread(Boolean b)
        {
            if (!this.IsDisposed && button2.InvokeRequired)
            {
                logsText.Invoke(new UpdateButtonStateFromThreadDelegate(UpdateButtonState), new Object[] { b });
            }
        }

        public void UpdateButtonState(Boolean b)
        {
            button2.Enabled = b;
        }

        delegate void UpdateButtonTextFromThreadDelegate(String text);
        public void UpdateButtonTextFromThread(String text)
        {
            if (!this.IsDisposed && button2.InvokeRequired)
            {
                logsText.Invoke(new UpdateButtonTextFromThreadDelegate(UpdateButtonText), new Object[] { text });
            }
        }

        public void UpdateButtonText(String text)
        {
            button2.Text = text;
            if (text.Equals("discovering"))
                button2.BackColor = Color.CadetBlue;
            if (text.Equals("Disconnecting"))
                button2.BackColor = Color.Gray;
        }
        //just ordinary function to update the log text.
        //after updating, we move the cursor to the end of text and scroll it to the cursor.
        public void UpdateLogText(String msg)
        {
            logsText.Text += Environment.NewLine + msg;
            logsText.SelectionStart = logsText.Text.Length;
            logsText.ScrollToCaret();
        }
        //function to send message to the client
        public Boolean sendMessage(String msg) 
        {
            try
            {
                if (!msg.Equals(""))
                {
                    UTF8Encoding encoder = new UTF8Encoding();
                    if (isConnected)
                    {
                        NetworkStream stream = btClient.GetStream();
                        stream.Write(encoder.GetBytes(msg + "\n"), 0, encoder.GetBytes(msg).Length);
                        stream.Flush();
                    } 
                    if(isConnectedIP)
                    {
                        int bufferCount = 0;
                        byte[] buffer = new byte[4096];
                        buffer = ASCIIEncoding.UTF8.GetBytes(msg);
                        bufferCount = ASCIIEncoding.UTF8.GetByteCount(msg);
                        acceptedSocket.Send(buffer, 0, bufferCount, SocketFlags.None);
                    }
                    if (isConnectedServer)
                    {
                        NetworkStream stream = mClient.GetStream();
                        stream.Write(encoder.GetBytes(msg + "\n"), 0, encoder.GetBytes(msg).Length);
                        stream.Flush();
                    }
}
            }
            catch (Exception ex)
            {
                UpdateLogTextFromThread("There is an error while sending message");
                UpdateLogTextFromThread(ex.Message);
                try
                {
                    isConnected = btClient.Connected;
                    btClient.GetStream().Close();
                    btClient.Dispose();
                    btListener.Server.Dispose();
                    btListener.Stop();
                }
                catch (Exception)
                {
                }
            
                return false;
            }
            
            return true;
        }
        //when closing or exiting application, we have to close connection and aborting the thread.
        //Otherwise, the process of the thread still running in the background.
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                btListener.Stop();
                AcceptAndListeningThread.Abort();
                ConnectAndListningThread.Abort();
                btClient.GetStream().Close();
                mClient.GetStream().Close();
                btClient.Dispose();
                mClient.Dispose();
                btListener.Stop();
                FormClosed += new FormClosedEventHandler(Form1_FormClosed);
            }
            catch (Exception)
            {
            }
        }

        void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
        
        private void Onclick(object sender, EventArgs e)
        {
            if (isConnectedServer)
            {
                mClient.Close();
                if (ConnectAndListningThread.IsAlive)
                {
                    ConnectAndListningThread.Abort();
                    isConnectedServer = false;
                }
                UpdateButtonText( "discovering");
            } else
            {
                ConnectAndListningThread = new Thread(ConnectAndListen);
                ConnectAndListningThread.Start();
            }
        }


        delegate void OnConnectionStateChangedFromThreadDelegate(int type);
        private void OnConnectionStateChangedFromThread(int type)
        {
            if (!this.IsDisposed && button1.InvokeRequired)
            {
                logsText.Invoke(new OnConnectionStateChangedFromThreadDelegate(OnConnectionStateChanged), new Object[] { type });
            }
        }
        private void OnConnectionStateChanged(int type)
        {
            switch(type)
            {
                case TYPE_COMMUNICATING:
                    button1.Text = rm.GetString("communicating");
                    button1.BackColor = Color.AliceBlue;
                    break;
                case TYPE_CONNECTING:
                    button1.Text = rm.GetString("connecting");
                    button1.BackColor = Color.LightYellow;
                    break;
                case TYPE_DISCOVERING:
                    button1.Text = rm.GetString("discovering");
                    button1.BackColor = Color.SandyBrown;
                    break;
                case TYPE_LOST:
                    button1.Text = rm.GetString("connection_lost");
                    button1.BackColor = Color.OrangeRed;
                    break;

            }
        }
    }
}


