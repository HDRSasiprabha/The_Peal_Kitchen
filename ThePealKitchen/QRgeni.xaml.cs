using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Mail;
using QRCoder;
using System.Net.Mime;

namespace ThePealKitchen
{
    /// <summary>
    /// Interaction logic for QRgeni.xaml
    /// </summary>
    public partial class QRgeni : Window
    {
        public QRgeni()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

            QRCodeGenerator qRCodeGenerator = new QRCoder.QRCodeGenerator();
            QRCoder.QRCodeData qRCodeData = qRCodeGenerator.CreateQrCode(textBox1.Text, QRCoder.QRCodeGenerator.ECCLevel.Q);
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


                QRimage.Source = BitmapToBitmapImage(bmp);

                sendMail(bmp);
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

        public void sendMail(Bitmap bmp)
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
                bmp.Save(@"C:\Users\Madushan Colonne\Desktop\ThePealKitchen\ThePealKitchen\test,jpg", ImageFormat.Jpeg);
                bmp.Dispose();
                //MemoryStream memStream = new MemoryStream();
                //bmp.Save(@"C:\\test,jpg", ImageFormat.Jpeg);
                //ContentType contentType = new ContentType();
                //contentType.MediaType = MediaTypeNames.Image.Jpeg;
                //contentType.Name = "screen";

                //MailMessage mail = new MailMessage();
                //SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                //mail.From = new MailAddress("milindascania@gmail.com"); //email vari
                //mail.To.Add("jn8899@gmail.com");
                //mail.Subject = "Test Mail";
                //mail.Body = "This is for testing SMTP mail from GMAIL";

                //Attachment attachment = new Attachment(memStream, contentType);

                //LinkedResource LinkedImage = new LinkedResource(memStream, contentType);
                //LinkedImage.ContentId = "MyPic";
                ////Added the patch for Thunderbird as suggested by Jorge
                //LinkedImage.ContentType = new ContentType(MediaTypeNames.Image.Jpeg);

                //AlternateView htmlView = AlternateView.CreateAlternateViewFromString(
                //  "You should see image next to this line. <img src=cid:MyPic>",
                //  null, "text/html");

                //htmlView.LinkedResources.Add(LinkedImage);
                //mail.AlternateViews.Add(htmlView);

                //mail.Attachments.Add(attachment);

                //SmtpServer.Port = 587;
                //SmtpServer.Credentials = new System.Net.NetworkCredential("milindascania@gmail.com", "scania678");
                //SmtpServer.EnableSsl = true;

                //SmtpServer.Send(mail);
                //attachment.Dispose();
                //MessageBox.Show("mail Send");

                MailMessage newMail = new MailMessage();
                newMail.From = new MailAddress("milindascania@gmail.com"); //email vari
                newMail.To.Add(new MailAddress("jn8899@gmail.com"));
                newMail.Subject = "Test Subject";
                newMail.IsBodyHtml = true;

                var inlineLogo = new LinkedResource(@"C:\Users\Madushan Colonne\Desktop\ThePealKitchen\ThePealKitchen\test,jpg", "image/png");
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
