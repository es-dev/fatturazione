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
	public partial class DatiTrasmissione
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
		
		private string _progressivoInvio;
		public virtual string ProgressivoInvio
		{
			get
			{
				return this._progressivoInvio;
			}
			set
			{
				this._progressivoInvio = value;
			}
		}
		
		private string _formatoTrasmissione;
		public virtual string FormatoTrasmissione
		{
			get
			{
				return this._formatoTrasmissione;
			}
			set
			{
				this._formatoTrasmissione = value;
			}
		}
		
		private string _codiceDestinatario;
		public virtual string CodiceDestinatario
		{
			get
			{
				return this._codiceDestinatario;
			}
			set
			{
				this._codiceDestinatario = value;
			}
		}
		
		private FatturaElettronicaHeader _fatturaElettronicaHeader;
		public virtual FatturaElettronicaHeader FatturaElettronicaHeader
		{
			get
			{
				return this._fatturaElettronicaHeader;
			}
			set
			{
				this._fatturaElettronicaHeader = value;
			}
		}
		
		private IList<IdFiscale> _idFiscales = new List<IdFiscale>();
		public virtual IList<IdFiscale> IdFiscales
		{
			get
			{
				return this._idFiscales;
			}
		}
		
		private IList<Contatti> _contattis = new List<Contatti>();
		public virtual IList<Contatti> Contattis
		{
			get
			{
				return this._contattis;
			}
		}
		
	}
}
#pragma warning restore 1591
