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
	public partial class DatiRitenuta
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
		
		private string _tipoRitenuta;
		public virtual string TipoRitenuta
		{
			get
			{
				return this._tipoRitenuta;
			}
			set
			{
				this._tipoRitenuta = value;
			}
		}
		
		private decimal _importoRitenuta;
		public virtual decimal ImportoRitenuta
		{
			get
			{
				return this._importoRitenuta;
			}
			set
			{
				this._importoRitenuta = value;
			}
		}
		
		private decimal _aliquotaRitenuta;
		public virtual decimal AliquotaRitenuta
		{
			get
			{
				return this._aliquotaRitenuta;
			}
			set
			{
				this._aliquotaRitenuta = value;
			}
		}
		
		private string _causalePagamento;
		public virtual string CausalePagamento
		{
			get
			{
				return this._causalePagamento;
			}
			set
			{
				this._causalePagamento = value;
			}
		}
		
		private DatiGeneraliDocumento _datiGeneraliDocumento;
		public virtual DatiGeneraliDocumento DatiGeneraliDocumento
		{
			get
			{
				return this._datiGeneraliDocumento;
			}
			set
			{
				this._datiGeneraliDocumento = value;
			}
		}
		
	}
}
#pragma warning restore 1591
