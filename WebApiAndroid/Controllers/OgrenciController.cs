using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace WebApiAndroid.Controllers
{
    public class OgrenciController : ApiController
    {
		//normal zamanda entity fremawork kullanarak bağlamalıyız
		//fakat macta onu tam çözemedim daha şimdilik custom bir listei ile bağlıyoruz

		private List<Ogrenci> TumKayitlar()
		{
			List<Ogrenci> result = new List<Ogrenci>();

			for (int i = 0; i < 10; i++)
			{
				result.Add(new Ogrenci() { id = i + 1, age = i + 20, name = "VB" + i, school = "SAU" + i });

			}
			return result;
			//listemiz tamam şimdi web servisimizin get metodunu tamamlıyoruz
		}

		public HttpResponseMessage Get()
		{
			var ogrencilist = TumKayitlar();
			return Request.CreateResponse(HttpStatusCode.OK, new { ogrenciler = ogrencilist });
			//artik kayitlarımızı eklediğimiz ve json formatında çağırdıgımız kayıtlar hazır şimdi deneyelim
			//kayitlarımız json formatında elimizde artık android cihazımızdan bu kayıtları kullanma zamanı

		}
    }
}
