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
	public partial class IdFiscale
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
		
		private string _idPaese;
		public virtual string IdPaese
		{
			get
			{
				return this._idPaese;
			}
			set
			{
				this._idPaese = value;
			}
		}
		
		private string _idCodice;
		public virtual string IdCodice
		{
			get
			{
				return this._idCodice;
			}
			set
			{
				this._idCodice = value;
			}
		}
		
		private int _datiTrasmissioneId;
		public virtual int DatiTrasmissioneId
		{
			get
			{
				return this._datiTrasmissioneId;
			}
			set
			{
				this._datiTrasmissioneId = value;
			}
		}
		
		private int _datiAnagraficiCedenteId;
		public virtual int DatiAnagraficiCedenteId
		{
			get
			{
				return this._datiAnagraficiCedenteId;
			}
			set
			{
				this._datiAnagraficiCedenteId = value;
			}
		}
		
		private int _datiAnagraficiCessionarioId;
		public virtual int DatiAnagraficiCessionarioId
		{
			get
			{
				return this._datiAnagraficiCessionarioId;
			}
			set
			{
				this._datiAnagraficiCessionarioId = value;
			}
		}
		
		private DatiAnagraficiCedente _datiAnagraficiCedente;
		public virtual DatiAnagraficiCedente DatiAnagraficiCedente
		{
			get
			{
				return this._datiAnagraficiCedente;
			}
			set
			{
				this._datiAnagraficiCedente = value;
			}
		}
		
		private DatiAnagraficiCessionario _datiAnagraficiCessionario;
		public virtual DatiAnagraficiCessionario DatiAnagraficiCessionario
		{
			get
			{
				return this._datiAnagraficiCessionario;
			}
			set
			{
				this._datiAnagraficiCessionario = value;
			}
		}
		
		private DatiTrasmissione _datiTrasmissione;
		public virtual DatiTrasmissione DatiTrasmissione
		{
			get
			{
				return this._datiTrasmissione;
			}
			set
			{
				this._datiTrasmissione = value;
			}
		}
		
	}
}
#pragma warning restore 1591
