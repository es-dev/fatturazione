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
	public partial class Anagrafica
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
		
		private string _denominazione;
		public virtual string Denominazione
		{
			get
			{
				return this._denominazione;
			}
			set
			{
				this._denominazione = value;
			}
		}
		
		private string _nome;
		public virtual string Nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				this._nome = value;
			}
		}
		
		private string _cognome;
		public virtual string Cognome
		{
			get
			{
				return this._cognome;
			}
			set
			{
				this._cognome = value;
			}
		}
		
		private string _titolo;
		public virtual string Titolo
		{
			get
			{
				return this._titolo;
			}
			set
			{
				this._titolo = value;
			}
		}
		
		private string _codEORI;
		public virtual string CodEORI
		{
			get
			{
				return this._codEORI;
			}
			set
			{
				this._codEORI = value;
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
		
	}
}
#pragma warning restore 1591