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
	public partial class Sede
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
		
		private int _cedentePrestatoreId;
		public virtual int CedentePrestatoreId
		{
			get
			{
				return this._cedentePrestatoreId;
			}
			set
			{
				this._cedentePrestatoreId = value;
			}
		}
		
		private int _cessionarioCommittenteId;
		public virtual int CessionarioCommittenteId
		{
			get
			{
				return this._cessionarioCommittenteId;
			}
			set
			{
				this._cessionarioCommittenteId = value;
			}
		}
		
		private string _indirizzo;
		public virtual string Indirizzo
		{
			get
			{
				return this._indirizzo;
			}
			set
			{
				this._indirizzo = value;
			}
		}
		
		private string _numeroCivico;
		public virtual string NumeroCivico
		{
			get
			{
				return this._numeroCivico;
			}
			set
			{
				this._numeroCivico = value;
			}
		}
		
		private string _cAP;
		public virtual string CAP
		{
			get
			{
				return this._cAP;
			}
			set
			{
				this._cAP = value;
			}
		}
		
		private string _comune;
		public virtual string Comune
		{
			get
			{
				return this._comune;
			}
			set
			{
				this._comune = value;
			}
		}
		
		private string _provincia;
		public virtual string Provincia
		{
			get
			{
				return this._provincia;
			}
			set
			{
				this._provincia = value;
			}
		}
		
		private string _nazione;
		public virtual string Nazione
		{
			get
			{
				return this._nazione;
			}
			set
			{
				this._nazione = value;
			}
		}
		
		private CedentePrestatore _cedentePrestatore;
		public virtual CedentePrestatore CedentePrestatore
		{
			get
			{
				return this._cedentePrestatore;
			}
			set
			{
				this._cedentePrestatore = value;
			}
		}
		
		private CessionarioCommittente _cessionarioCommittente;
		public virtual CessionarioCommittente CessionarioCommittente
		{
			get
			{
				return this._cessionarioCommittente;
			}
			set
			{
				this._cessionarioCommittente = value;
			}
		}
		
	}
}
#pragma warning restore 1591
