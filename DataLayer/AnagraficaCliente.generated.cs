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
	public partial class AnagraficaCliente
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
		
		private int _aziendaId;
		public virtual int AziendaId
		{
			get
			{
				return this._aziendaId;
			}
			set
			{
				this._aziendaId = value;
			}
		}
		
		private string _ragioneSociale;
		public virtual string RagioneSociale
		{
			get
			{
				return this._ragioneSociale;
			}
			set
			{
				this._ragioneSociale = value;
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
		
		private string _codice;
		public virtual string Codice
		{
			get
			{
				return this._codice;
			}
			set
			{
				this._codice = value;
			}
		}
		
		private Azienda _azienda;
		public virtual Azienda Azienda
		{
			get
			{
				return this._azienda;
			}
			set
			{
				this._azienda = value;
			}
		}
		
		private IList<Cliente> _clientes = new List<Cliente>();
		public virtual IList<Cliente> Clientes
		{
			get
			{
				return this._clientes;
			}
		}
		
	}
}
#pragma warning restore 1591
