#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ClassGenerator.ttinclude code generation file.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;
using DataLayer;

namespace DataLayer	
{
	public partial class DatiGeneraliDocumento
	{
		private int _id;
		public virtual int Id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}
		
		private string _tipoDocumento;
		public virtual string TipoDocumento
		{
			get
			{
				return this._tipoDocumento;
			}
			set
			{
				this._tipoDocumento = value;
			}
		}
		
		private string _divisa;
		public virtual string Divisa
		{
			get
			{
				return this._divisa;
			}
			set
			{
				this._divisa = value;
			}
		}
		
		private DateTime _data;
		public virtual DateTime Data
		{
			get
			{
				return this._data;
			}
			set
			{
				this._data = value;
			}
		}
		
		private string _nUmero;
		public virtual string NUmero
		{
			get
			{
				return this._nUmero;
			}
			set
			{
				this._nUmero = value;
			}
		}
		
		private string _importotTotaleDocumento;
		public virtual string ImportotTotaleDocumento
		{
			get
			{
				return this._importotTotaleDocumento;
			}
			set
			{
				this._importotTotaleDocumento = value;
			}
		}
		
		private string _arrotondamento;
		public virtual string Arrotondamento
		{
			get
			{
				return this._arrotondamento;
			}
			set
			{
				this._arrotondamento = value;
			}
		}
		
		private string _causale;
		public virtual string Causale
		{
			get
			{
				return this._causale;
			}
			set
			{
				this._causale = value;
			}
		}
		
		private DatiGenerali _datiGenerali;
		public virtual DatiGenerali DatiGenerali
		{
			get
			{
				return this._datiGenerali;
			}
			set
			{
				this._datiGenerali = value;
			}
		}
		
		private DatiRitenuta _datiRitenuta;
		public virtual DatiRitenuta DatiRitenuta
		{
			get
			{
				return this._datiRitenuta;
			}
			set
			{
				this._datiRitenuta = value;
			}
		}
		
	}
}
#pragma warning restore 1591
