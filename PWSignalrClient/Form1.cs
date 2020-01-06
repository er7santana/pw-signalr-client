using Microsoft.AspNet.SignalR.Client;
using System;
using System.Threading;
using System.Windows.Forms;

namespace PWSignalrClient
{
    public partial class Form1 : Form
    {
        HubConnection hubConnection;
        IHubProxy hubProxy;
        Thread reconnectThread;
        bool shouldReconnect = false;

        public Form1()
        {
            InitializeComponent();
            reconnectThread = new Thread(ReconnectThread);
        }

        private void OnConectarButtonClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(server_text.Text))
            {
                MessageBox.Show("Preencha o endereço do server");
                return;
            }

            if (hubConnection == null)
            {
                hubConnection = new HubConnection(server_text.Text.Trim());
            }

            if (hubProxy == null)
            {
                hubProxy = hubConnection.CreateHubProxy("chatHub");

                hubProxy.On<string>("FalaAlgumaCoisa", message =>
                {
                    ReceberMensagem(message);
                });
            }

            hubConnection.StateChanged -= OnHubConnectionStateChanged;
            hubConnection.StateChanged += OnHubConnectionStateChanged;

            try
            {
                hubConnection.Start().Wait();

                if (reconnectThread.IsAlive == false)
                {
                    reconnectThread.Start();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void OnHubConnectionStateChanged(StateChange stateChange)
        {
            Console.WriteLine($"Old State => {stateChange.OldState.ToString()} ||| New State => {stateChange.NewState.ToString()}");

            if (stateChange.NewState == ConnectionState.Connected)
            {
                shouldReconnect = false;
            }

            if (stateChange.OldState == ConnectionState.Connecting && stateChange.NewState == ConnectionState.Connected)
            {
                
            }

            if ((stateChange.OldState == ConnectionState.Reconnecting || stateChange.OldState == ConnectionState.Connecting) && stateChange.NewState == ConnectionState.Disconnected)
            {
                shouldReconnect = true;
            }
        }

        delegate void ReceberMensagemCallback(string msg);
        void ReceberMensagem(string message)
        {
            if (InvokeRequired)
            {
                ReceberMensagemCallback callback = ReceberMensagem;
                Invoke(callback, message);
            }
            else
            {
                resultado_text.Text += $"{message} {Environment.NewLine}";
            }
        }

        private void OnLimparClicked(object sender, EventArgs e)
        {
            resultado_text.Text = "";
        }

        void ReconnectThread()
        {
            if (hubConnection == null || hubProxy == null)
            {
                return;
            }

            while (true)
            {
                if (shouldReconnect)
                {
                    try
                    {
                        hubConnection.Start().Wait();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                Thread.Sleep(5000);
            }
        }

        private void desconectar_button_Click(object sender, EventArgs e)
        {
            if (hubConnection != null && hubConnection.State != ConnectionState.Disconnected)
            {
                hubConnection.Stop();
            }
        }
    }
}
