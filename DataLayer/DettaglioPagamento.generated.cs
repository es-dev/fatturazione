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
	public partial class DettaglioPagamento
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
		
		private int _datiPagamentoId;
		public virtual int DatiPagamentoId
		{
			get
			{
				return this._datiPagamentoId;
			}
			set
			{
				this._datiPagamentoId = value;
			}
		}
		
		private string _beneficiario;
		public virtual string Beneficiario
		{
			get
			{
				return this._beneficiario;
			}
			set
			{
				this._beneficiario = value;
			}
		}
		
		private string _modalitaPagamento;
		public virtual string ModalitaPagamento
		{
			get
			{
				return this._modalitaPagamento;
			}
			set
			{
				this._modalitaPagamento = value;
			}
		}
		
		private DateTime _dataRiferimentoTerminiPagamento;
		public virtual DateTime DataRiferimentoTerminiPagamento
		{
			get
			{
				return this._dataRiferimentoTerminiPagamento;
			}
			set
			{
				this._dataRiferimentoTerminiPagamento = value;
			}
		}
		
		private int _giorniTerminiPagamento;
		public virtual int GiorniTerminiPagamento
		{
			get
			{
				return this._giorniTerminiPagamento;
			}
			set
			{
				this._giorniTerminiPagamento = value;
			}
		}
		
		private decimal _dataScadenzaPagamento;
		public virtual decimal DataScadenzaPagamento
		{
			get
			{
				return this._dataScadenzaPagamento;
			}
			set
			{
				this._dataScadenzaPagamento = value;
			}
		}
		
		private string _importoPagamento;
		public virtual string ImportoPagamento
		{
			get
			{
				return this._importoPagamento;
			}
			set
			{
				this._importoPagamento = value;
			}
		}
		
		private string _istitutoFinanziario;
		public virtual string IstitutoFinanziario
		{
			get
			{
				return this._istitutoFinanziario;
			}
			set
			{
				this._istitutoFinanziario = value;
			}
		}
		
		private string _iBAN;
		public virtual string IBAN
		{
			get
			{
				return this._iBAN;
			}
			set
			{
				this._iBAN = value;
			}
		}
		
		private string _aBI;
		public virtual string ABI
		{
			get
			{
				return this._aBI;
			}
			set
			{
				this._aBI = value;
			}
		}
		
		private string _cAB;
		public virtual string CAB
		{
			get
			{
				return this._cAB;
			}
			set
			{
				this._cAB = value;
			}
		}
		
		private string _bIC;
		public virtual string BIC
		{
			get
			{
				return this._bIC;
			}
			set
			{
				this._bIC = value;
			}
		}
		
		private DateTime _dataDecorrenzaPenale;
		public virtual DateTime DataDecorrenzaPenale
		{
			get
			{
				return this._dataDecorrenzaPenale;
			}
			set
			{
				this._dataDecorrenzaPenale = value;
			}
		}
		
		private string _codUfficioPostale;
		public virtual string CodUfficioPostale
		{
			get
			{
				return this._codUfficioPostale;
			}
			set
			{
				this._codUfficioPostale = value;
			}
		}
		
		private string _cognomeQuietanzante;
		public virtual string CognomeQuietanzante
		{
			get
			{
				return this._cognomeQuietanzante;
			}
			set
			{
				this._cognomeQuietanzante = value;
			}
		}
		
		private string _nomeQuietanzante;
		public virtual string NomeQuietanzante
		{
			get
			{
				return this._nomeQuietanzante;
			}
			set
			{
				this._nomeQuietanzante = value;
			}
		}
		
		private string _cFQuietanzante;
		public virtual string CFQuietanzante
		{
			get
			{
				return this._cFQuietanzante;
			}
			set
			{
				this._cFQuietanzante = value;
			}
		}
		
		private string _titoloQuietanzante;
		public virtual string TitoloQuietanzante
		{
			get
			{
				return this._titoloQuietanzante;
			}
			set
			{
				this._titoloQuietanzante = value;
			}
		}
		
		private decimal _scontoPagamentoAnticipato;
		public virtual decimal ScontoPagamentoAnticipato
		{
			get
			{
				return this._scontoPagamentoAnticipato;
			}
			set
			{
				this._scontoPagamentoAnticipato = value;
			}
		}
		
		private DateTime _dataLimitePagamentoAnticipato;
		public virtual DateTime DataLimitePagamentoAnticipato
		{
			get
			{
				return this._dataLimitePagamentoAnticipato;
			}
			set
			{
				this._dataLimitePagamentoAnticipato = value;
			}
		}
		
		private decimal _penalitaPagamentiRitardati;
		public virtual decimal PenalitaPagamentiRitardati
		{
			get
			{
				return this._penalitaPagamentiRitardati;
			}
			set
			{
				this._penalitaPagamentiRitardati = value;
			}
		}
		
		private string _codicePagamento;
		public virtual string CodicePagamento
		{
			get
			{
				return this._codicePagamento;
			}
			set
			{
				this._codicePagamento = value;
			}
		}
		
		private DatiPagamento _datiPagamento;
		public virtual DatiPagamento DatiPagamento
		{
			get
			{
				return this._datiPagamento;
			}
			set
			{
				this._datiPagamento = value;
			}
		}
		
	}
}
#pragma warning restore 1591
