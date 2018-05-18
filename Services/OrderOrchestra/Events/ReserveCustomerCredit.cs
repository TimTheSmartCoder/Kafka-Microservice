// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen, version 1.7.7.4
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Order.Api.Application.Events
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using global::Avro;
	using global::Avro.Specific;
	
	public partial class ReserveCustomerCredit : ISpecificRecord
	{
		public static Schema _SCHEMA = Schema.Parse("{\"type\":\"record\",\"name\":\"ReserveCustomerCredit\",\"namespace\":\"Order.Api.Applicatio" +
				"n.Events\",\"fields\":[{\"name\":\"OrderId\",\"type\":\"string\"},{\"name\":\"CustomerId\",\"typ" +
				"e\":\"string\"},{\"name\":\"Amount\",\"type\":\"double\"}]}");
		private string _OrderId;
		private string _CustomerId;
		private double _Amount;
		public virtual Schema Schema
		{
			get
			{
				return ReserveCustomerCredit._SCHEMA;
			}
		}
		public string OrderId
		{
			get
			{
				return this._OrderId;
			}
			set
			{
				this._OrderId = value;
			}
		}
		public string CustomerId
		{
			get
			{
				return this._CustomerId;
			}
			set
			{
				this._CustomerId = value;
			}
		}
		public double Amount
		{
			get
			{
				return this._Amount;
			}
			set
			{
				this._Amount = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.OrderId;
			case 1: return this.CustomerId;
			case 2: return this.Amount;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.OrderId = (System.String)fieldValue; break;
			case 1: this.CustomerId = (System.String)fieldValue; break;
			case 2: this.Amount = (System.Double)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
