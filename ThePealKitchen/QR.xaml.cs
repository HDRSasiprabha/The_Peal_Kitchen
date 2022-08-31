using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AForge.Video;
using AForge.Video.DirectShow;
using ThePealKitchen.Manager_View_Images;
using ZXing;

namespace ThePealKitchen
{
    /// <summary>
    /// Interaction logic for QR.xaml
    /// </summary>
    public partial class QR : Window
    {
        FilterInfoCollection FilterInfoCollection;
        VideoCaptureDevice CaptureDevice;
        System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        string QR_out;

        public QR()
        {
            InitializeComponent();
            FilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in FilterInfoCollection)
            {
                cboDevice.Items.Add(filterInfo.Name);
            }
            cboDevice.SelectedIndex = 0;

            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }




        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Source != null)
            {
                BarcodeReader Reader = new BarcodeReader();
                Result result = Reader.Decode((BitmapImage)pictureBox1.Source);
                if (result != null)
                {
                         //variable for the qr login out put
                    txtQRCode.Text = result.Text;
                    QR_out = Convert.ToString(txtQRCode.Text);  //out put to the QR_out

                    DbClass.openConnection();

                    DbClass.sql = "SELECT [Customer_ID],[Name],[Email],[TP],[Address] FROM Customers WHERE [Customer_ID]= @CustomerId";
                    //DbClass.cmd.CommandType = CommandType.Text;
                    DbClass.cmd.CommandText = DbClass.sql;
                    DbClass.cmd.Parameters.Clear();
                    DbClass.cmd.Parameters.AddWithValue("@CustomerId", QR_out);

                    DbClass.da = new SqlDataAdapter(DbClass.cmd);
                    DbClass.dt = new DataTable();
                    DbClass.da.Fill(DbClass.dt);

                    if(DbClass.dt.Rows.Count > 0)
                    {
                        //System.Windows.Forms.MessageBox.Show("Success");
                        string Name;
                        Name = DbClass.dt.Rows[0]["Name"].ToString();
                        App.Current.Properties["NameOfProperty"] = Name;
                        Cart_invoice_window cart = new Cart_invoice_window();
                        //NavigationService.(cart);
                        cart.Show();
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Wrong QR Code");
                    }


                    DbClass.closeConnection();
                }
            }
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            CaptureDevice = new VideoCaptureDevice(FilterInfoCollection[cboDevice.SelectedIndex].MonikerString);
            CaptureDevice.NewFrame += CaptureDevice_NewFrame;
            CaptureDevice.Start();
        }
        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            this.Dispatcher.Invoke(() =>
            {
                pictureBox1.Source = BitmapToBitmapImage((Bitmap)eventArgs.Frame.Clone());
            });
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
           // if (CaptureDevice.IsRunning)
           //   CaptureDevice.Stop();
        }

        public static BitmapImage BitmapToBitmapImage(Bitmap bitmap)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                bitmap.Save(stream, ImageFormat.Png);

                stream.Position = 0;
                BitmapImage result = new BitmapImage();
                result.BeginInit();
                // According to MSDN, "The default OnDemand cache option retains access to the stream until the image is needed."
                // Force the bitmap to load right now so we can dispose the stream.
                result.CacheOption = BitmapCacheOption.OnLoad;
                result.StreamSource = stream;
                result.EndInit();
                result.Freeze();
                return result;
            }
        }

        private void btn_win_Click(object sender, RoutedEventArgs e)
        {
            UserControlSignin uc = new UserControlSignin("user","passwd");
            this.Content = uc;
        }
    }
}
