using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Drawing;
using MessagingToolkit.QRCode.Codec;

namespace SuperMundoHiperMegaRed
{
    public partial class qrcode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGeneraQR_Click(object sender, EventArgs e)
        {

            QRCodeEncoder encoder = new QRCodeEncoder();
            Bitmap img = encoder.Encode(textCode.Text);
            System.Drawing.Image QR = (System.Drawing.Image)img;
            using (MemoryStream ms = new MemoryStream()) 
            {
                QR.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] imageBytes = ms.ToArray();
                imgCtrl.Src = "data:image/gif;base64," + Convert.ToBase64String(imageBytes);
                imgCtrl.Height = 200;
                imgCtrl.Width = 200;
            
            }

        }
    }
}