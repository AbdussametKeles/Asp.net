using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Veri_Cekme_Botu
{
    public partial class AnaSayfa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnVeriCek_Click(object sender, EventArgs e)
        {
            string adres = txtAdres.Text;

            WebRequest istek = HttpWebRequest.Create(adres);
            WebResponse cevap = istek.GetResponse();

            CultureInfo tr = new CultureInfo("tr-TR");

            StreamReader donenDeger = new StreamReader(cevap.GetResponseStream(),Encoding.GetEncoding(tr.TextInfo.ANSICodePage));

            String gelenBilgi = donenDeger.ReadToEnd();

            int haberBaslangic = gelenBilgi.IndexOf("< div class=\"showCaseBox h-card\">") + 30;

            int haberBitis = gelenBilgi.Substring(haberBaslangic).IndexOf("<i class=\"clear_0\">");

            lblVeriler.Text = gelenBilgi.Substring(haberBaslangic, haberBitis);

            string git = "github deneme";
        }
    }
}