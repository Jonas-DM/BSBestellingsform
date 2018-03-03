using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN.BUSSINESS
{
	class order
	{
		private int _orderid;

		public int Orderid
		{
			get { return _orderid; }
			set { _orderid = value; }
		}

		private DateTime _datum;

		public DateTime Datum
		{
			get { return _datum; }
			set { _datum = value; }
		}

		private DateTime _afhaaltijdstip;

		public DateTime Afhaaltijdstip
		{
			get { return _afhaaltijdstip; }
			set { _afhaaltijdstip = value; }
		}

		private Boolean _verwerkt;

		public Boolean Verwerkt
		{
			get { return _verwerkt; }
			set { _verwerkt = value; }
		}
		


	}
}
