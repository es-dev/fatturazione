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
	public partial class FatturaElettronicaBody
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
		
		private int _fatturaId;
		public virtual int FatturaId
		{
			get
			{
				return this._fatturaId;
			}
			set
			{
				this._fatturaId = value;
			}
		}
		
		private Fattura _fattura;
		public virtual Fattura Fattura
		{
			get
			{
				return this._fattura;
			}
			set
			{
				this._fattura = value;
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
		
	}
}
#pragma warning restore 1591
