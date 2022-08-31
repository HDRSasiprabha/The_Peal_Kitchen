using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using ThePealKitchen.Manager_View_Images;
using System.Data;
using System.Net.Mail;
using System.Net.Mime;
using System.Drawing;
using System.Drawing.Imaging;
using QRCoder;
using System.IO;

namespace ThePealKitchen
{
    /// <summary>
    /// Interaction logic for UserControlJoin.xaml
    /// </summary>
    public partial class UserControlJoin : UserControl
    {
        public UserControlJoin()
        {
            InitializeComponent();
        }
        ConnectDB obj = new ConnectDB();

        private void btn_sub_Click(object sender, RoutedEventArgs e)
        {
            if (txt_fname.Text.Length == 0)

                error_msg.Text = "First name cannot be blank";

            else if (txt_fname.Text.Any(char.IsDigit))

                error_msg.Text = "first name cannot have numbers";




            else if (!Regex.IsMatch(txt_email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))

                error_msg.Text = "email should be a valid one.";

            else if (txt_pwd.Password.Length == 0)

                error_msg.Text = "password cannot be blank";

            else if (txt_confirm.Password.Length == 0)

                error_msg.Text = "confirm password cannot be blank";

            else if (txt_pwd.Password != txt_confirm.Password)

                error_msg.Text = "both password should same";

            else if (txt_address.Text.Length == 0)

                error_msg.Text = "adsress cannot be blank";

            else if (!Regex.IsMatch(txt_phone.Text, @"^7|0|(?:\+94)[0-9]{9,10}$"))

                error_msg.Text = "TP must have 10 numbers";

            else
            {
                error_msg.Text = "";
                MessageBox.Show("succesfully registered", "info", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            try
            {

                string a = " insert into Customers values ( '" + txt_fname.Text + "'  ,  '" + txt_email.Text + "' , '" + txt_phone.Text + "' , '" + txt_address.Text + "' , '"+txt_pwd.Password+"', 1  )";
                int line = obj.save_update_delete(a); // line=i int i send from class to here, a sending to class, 
                if (line == 1)
                {
                    DbClass.openConnection();

                    DbClass.sql = "SELECT TOP (1) [ID],[Customer_ID],[Name],[Email],[TP],[Address],[cus_password] FROM [ThePealKitchen].[dbo].[Customers] ORDER BY [ID] DESC";
                    //DbClass.cmd.CommandType = CommandType.Text;
                    DbClass.cmd.CommandText = DbClass.sql;

                    DbClass.da = new SqlDataAdapter(DbClass.cmd);
                    DbClass.dt = new DataTable();
                    DbClass.da.Fill(DbClass.dt);

                    if (DbClass.dt.Rows.Count > 0)
                    {
                        string customerId,email;
                        customerId = DbClass.dt.Rows[0]["Customer_ID"].ToString();
                        email = DbClass.dt.Rows[0]["Email"].ToString();
                        sendMail(customerId,email);
                    }
                    MessageBox.Show("data saved"); 
                }
                else
                    MessageBox.Show("cant save");
            }
            catch (SqlException)
            {
                MessageBox.Show("Database Errors", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception)
            {
                MessageBox.Show(" Errors", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_clear_Click(object sender, RoutedEventArgs e)
        {
            error_msg.Clear();
            txt_pwd.Clear();
            txt_confirm.Clear();
            txt_fname.Clear();
            txt_email.Clear();
            txt_phone.Clear();
            txt_address.Clear();
        }

        private void sendMail(string customerId,string email)
        {

            QRCodeGenerator qRCodeGenerator = new QRCoder.QRCodeGenerator();
            QRCoder.QRCodeData qRCodeData = qRCodeGenerator.CreateQrCode(customerId, QRCoder.QRCodeGenerator.ECCLevel.Q);
            QRCoder.QRCode qRCode = new QRCoder.QRCode(qRCodeData);
            Bitmap bmp = qRCode.GetGraphic(5);
            using (MemoryStream ms = new MemoryStream())
            {
                bmp.Save(ms, ImageFormat.Bmp);
                DataSet1 reportData = new DataSet1();
                DataSet1.QRCodeRow qRCodeRow = reportData.QRCode.NewQRCodeRow();
                qRCodeRow.Image = ms.ToArray();
                reportData.QRCode.AddQRCodeRow(qRCodeRow);



                //Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new Microsoft.Reporting.WinForms.ReportDataSource();
                //reportDataSource.Name = "DataSet1";
                //reportDataSource.Value = reportData.QRCode;
                //reportViewer1.LocalReport.DataSources.Clear();
                //reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                //reportViewer1.RefreshReport();


                //QRimage.Source = BitmapToBitmapImage(bmp);

                sendMail(bmp,email);
            }
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

        public static Bitmap BitmapImageToBitmap(BitmapImage bitmapImage)
        {
            // BitmapImage bitmapImage = new BitmapImage(new Uri("../Images/test.png", UriKind.Relative));

            using (MemoryStream outStream = new MemoryStream())
            {
                BitmapEncoder enc = new BmpBitmapEncoder();
                enc.Frames.Add(BitmapFrame.Create(bitmapImage));
                enc.Save(outStream);
                Bitmap bitmap = new Bitmap(outStream);

                return new Bitmap(bitmap);
            }
        }

        public void sendMail(Bitmap bmp, string toMail)
        {

            //Mail
            try
            {
                Graphics oGraphic;
                // Here create a new bitmap object of the same height and width of the image.
                Bitmap bmpNew = new Bitmap(bmp.Width, bmp.Height);
                oGraphic = Graphics.FromImage(bmpNew);
                oGraphic.DrawImage(bmp, new System.Drawing.Rectangle(0, 0, bmpNew.Width, bmpNew.Height), 0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel);
                // Release the lock on the image file. Of course,
                // image from the image file is existing in Graphics object
                bmp.Dispose();
                bmp = bmpNew;

                SolidBrush oBrush = new SolidBrush(System.Drawing.Color.Black);
                Font ofont = new Font("Arial", 8);
                oGraphic.DrawString("Some text to write", ofont, oBrush, 10, 10);
                oGraphic.Dispose();
                ofont.Dispose();
                oBrush.Dispose();
                bmp.Save(@"C:\ThePealKitchen\test.jpg", ImageFormat.Jpeg);
                bmp.Dispose();

                MailMessage newMail = new MailMessage();
                newMail.From = new MailAddress("milindascania@gmail.com"); //email vari
                newMail.To.Add(new MailAddress(toMail));
                newMail.Subject = "Test Subject";
                newMail.IsBodyHtml = true;

                var inlineLogo = new LinkedResource(@"C:\ThePealKitchen\test.jpg", "image/png");
                inlineLogo.ContentType = new ContentType(MediaTypeNames.Image.Jpeg);
                inlineLogo.ContentId = Guid.NewGuid().ToString();

                string body = string.Format(@"
            <p>Lorum Ipsum Blah Blah</p>
            <img src=""cid:{0}"" />
            <p>Lorum Ipsum Blah Blah</p>
        ", inlineLogo.ContentId);

                var view = AlternateView.CreateAlternateViewFromString(body, null, "text/html");
                view.LinkedResources.Add(inlineLogo);
                newMail.AlternateViews.Add(view);

                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("milindascania@gmail.com", "scania678");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(newMail);
                //attachment.Dispose();
                MessageBox.Show("mail Send");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
