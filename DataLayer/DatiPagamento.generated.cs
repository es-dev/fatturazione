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
	public partial class DatiPagamento
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
		
		private int _fatturaElettronicaBodyId;
		public virtual int FatturaElettronicaBodyId
		{
			get
			{
				return this._fatturaElettronicaBodyId;
			}
			set
			{
				this._fatturaElettronicaBodyId = value;
			}
		}
		
		private string _condizioniPagamento;
		public virtual string CondizioniPagamento
		{
			get
			{
				return this._condizioniPagamento;
			}
			set
			{
				this._condizioniPagamento = value;
			}
		}
		
		private FatturaElettronicaBody _fatturaElettronicaBody;
		public virtual FatturaElettronicaBody FatturaElettronicaBody
		{
			get
			{
				return this._fatturaElettronicaBody;
			}
			set
			{
				this._fatturaElettronicaBody = value;
			}
		}
		
		private IList<DettaglioPagamento> _dettaglioPagamentos = new List<DettaglioPagamento>();
		public virtual IList<DettaglioPagamento> DettaglioPagamentos
		{
			get
			{
				return this._dettaglioPagamentos;
			}
		}
		
	}
}
#pragma warning restore 1591
