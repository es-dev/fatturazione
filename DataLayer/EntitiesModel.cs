﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ContextGenerator.ttinclude code generation file.
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
	public partial class EntitiesModel : OpenAccessContext, IEntitiesModelUnitOfWork
	{
		private static string connectionStringName = @"";
			
		private static BackendConfiguration backend = GetBackendConfiguration();
				
		private static MetadataSource metadataSource = XmlMetadataSource.FromAssemblyResource("EntitiesModel.rlinq");
		
		public EntitiesModel()
			:base(connectionStringName, backend, metadataSource)
		{ }
		
		public EntitiesModel(string connection)
			:base(connection, backend, metadataSource)
		{ }
		
		public EntitiesModel(BackendConfiguration backendConfiguration)
			:base(connectionStringName, backendConfiguration, metadataSource)
		{ }
			
		public EntitiesModel(string connection, MetadataSource metadataSource)
			:base(connection, backend, metadataSource)
		{ }
		
		public EntitiesModel(string connection, BackendConfiguration backendConfiguration, MetadataSource metadataSource)
			:base(connection, backendConfiguration, metadataSource)
		{ }
			
		public IQueryable<Azienda> Aziendas 
		{
			get
			{
				return this.GetAll<Azienda>();
			}
		}
		
		public IQueryable<Cliente> Clientes 
		{
			get
			{
				return this.GetAll<Cliente>();
			}
		}
		
		public IQueryable<Fattura> Fatturas 
		{
			get
			{
				return this.GetAll<Fattura>();
			}
		}
		
		public IQueryable<Trasmissione> Trasmissiones 
		{
			get
			{
				return this.GetAll<Trasmissione>();
			}
		}
		
		public IQueryable<AnagraficaCliente> AnagraficaClientes 
		{
			get
			{
				return this.GetAll<AnagraficaCliente>();
			}
		}
		
		public IQueryable<Incasso> Incassos 
		{
			get
			{
				return this.GetAll<Incasso>();
			}
		}
		
		public IQueryable<Socio> Socios 
		{
			get
			{
				return this.GetAll<Socio>();
			}
		}
		
		public IQueryable<AnagraficaPA> AnagraficaPAs 
		{
			get
			{
				return this.GetAll<AnagraficaPA>();
			}
		}
		
		public IQueryable<FatturaElettronicaHeader> FatturaElettronicaHeaders 
		{
			get
			{
				return this.GetAll<FatturaElettronicaHeader>();
			}
		}
		
		public IQueryable<FatturaElettronicaBody> FatturaElettronicaBodies 
		{
			get
			{
				return this.GetAll<FatturaElettronicaBody>();
			}
		}
		
		public IQueryable<DatiTrasmissione> DatiTrasmissiones 
		{
			get
			{
				return this.GetAll<DatiTrasmissione>();
			}
		}
		
		public IQueryable<IdFiscale> IdFiscales 
		{
			get
			{
				return this.GetAll<IdFiscale>();
			}
		}
		
		public IQueryable<Contatti> Contattis 
		{
			get
			{
				return this.GetAll<Contatti>();
			}
		}
		
		public IQueryable<CedentePrestatore> CedentePrestatores 
		{
			get
			{
				return this.GetAll<CedentePrestatore>();
			}
		}
		
		public IQueryable<DatiAnagraficiCedente> DatiAnagraficiCedentes 
		{
			get
			{
				return this.GetAll<DatiAnagraficiCedente>();
			}
		}
		
		public IQueryable<Anagrafica> Anagraficas 
		{
			get
			{
				return this.GetAll<Anagrafica>();
			}
		}
		
		public IQueryable<Indirizzo> Indirizzos 
		{
			get
			{
				return this.GetAll<Indirizzo>();
			}
		}
		
		public IQueryable<Account> Accounts 
		{
			get
			{
				return this.GetAll<Account>();
			}
		}
		
		public IQueryable<CessionarioCommittente> CessionarioCommittentes 
		{
			get
			{
				return this.GetAll<CessionarioCommittente>();
			}
		}
		
		public IQueryable<DatiGenerali> DatiGeneralis 
		{
			get
			{
				return this.GetAll<DatiGenerali>();
			}
		}
		
		public IQueryable<DatiGeneraliDocumento> DatiGeneraliDocumentos 
		{
			get
			{
				return this.GetAll<DatiGeneraliDocumento>();
			}
		}
		
		public IQueryable<DatiRitenuta> DatiRitenutas 
		{
			get
			{
				return this.GetAll<DatiRitenuta>();
			}
		}
		
		public IQueryable<DatiBeniServizi> DatiBeniServizis 
		{
			get
			{
				return this.GetAll<DatiBeniServizi>();
			}
		}
		
		public IQueryable<DettaglioLinee> DettaglioLinees 
		{
			get
			{
				return this.GetAll<DettaglioLinee>();
			}
		}
		
		public IQueryable<DatiRiepilogo> DatiRiepilogos 
		{
			get
			{
				return this.GetAll<DatiRiepilogo>();
			}
		}
		
		public IQueryable<DatiPagamento> DatiPagamentos 
		{
			get
			{
				return this.GetAll<DatiPagamento>();
			}
		}
		
		public IQueryable<DettaglioPagamento> DettaglioPagamentos 
		{
			get
			{
				return this.GetAll<DettaglioPagamento>();
			}
		}
		
		public IQueryable<Allegati> Allegatis 
		{
			get
			{
				return this.GetAll<Allegati>();
			}
		}
		
		public IQueryable<Sede> Sedes 
		{
			get
			{
				return this.GetAll<Sede>();
			}
		}
		
		public IQueryable<DatiAnagraficiCessionario> DatiAnagraficiCessionarios 
		{
			get
			{
				return this.GetAll<DatiAnagraficiCessionario>();
			}
		}
		
		public static BackendConfiguration GetBackendConfiguration()
		{
			BackendConfiguration backend = new BackendConfiguration();
			backend.Backend = "MsSql";
			backend.ProviderName = "System.Data.SqlClient";
		
			CustomizeBackendConfiguration(ref backend);
		
			return backend;
		}
		
		/// <summary>
		/// Allows you to customize the BackendConfiguration of EntitiesModel.
		/// </summary>
		/// <param name="config">The BackendConfiguration of EntitiesModel.</param>
		static partial void CustomizeBackendConfiguration(ref BackendConfiguration config);
		
	}
	
	public interface IEntitiesModelUnitOfWork : IUnitOfWork
	{
		IQueryable<Azienda> Aziendas
		{
			get;
		}
		IQueryable<Cliente> Clientes
		{
			get;
		}
		IQueryable<Fattura> Fatturas
		{
			get;
		}
		IQueryable<Trasmissione> Trasmissiones
		{
			get;
		}
		IQueryable<AnagraficaCliente> AnagraficaClientes
		{
			get;
		}
		IQueryable<Incasso> Incassos
		{
			get;
		}
		IQueryable<Socio> Socios
		{
			get;
		}
		IQueryable<AnagraficaPA> AnagraficaPAs
		{
			get;
		}
		IQueryable<FatturaElettronicaHeader> FatturaElettronicaHeaders
		{
			get;
		}
		IQueryable<FatturaElettronicaBody> FatturaElettronicaBodies
		{
			get;
		}
		IQueryable<DatiTrasmissione> DatiTrasmissiones
		{
			get;
		}
		IQueryable<IdFiscale> IdFiscales
		{
			get;
		}
		IQueryable<Contatti> Contattis
		{
			get;
		}
		IQueryable<CedentePrestatore> CedentePrestatores
		{
			get;
		}
		IQueryable<DatiAnagraficiCedente> DatiAnagraficiCedentes
		{
			get;
		}
		IQueryable<Anagrafica> Anagraficas
		{
			get;
		}
		IQueryable<Indirizzo> Indirizzos
		{
			get;
		}
		IQueryable<Account> Accounts
		{
			get;
		}
		IQueryable<CessionarioCommittente> CessionarioCommittentes
		{
			get;
		}
		IQueryable<DatiGenerali> DatiGeneralis
		{
			get;
		}
		IQueryable<DatiGeneraliDocumento> DatiGeneraliDocumentos
		{
			get;
		}
		IQueryable<DatiRitenuta> DatiRitenutas
		{
			get;
		}
		IQueryable<DatiBeniServizi> DatiBeniServizis
		{
			get;
		}
		IQueryable<DettaglioLinee> DettaglioLinees
		{
			get;
		}
		IQueryable<DatiRiepilogo> DatiRiepilogos
		{
			get;
		}
		IQueryable<DatiPagamento> DatiPagamentos
		{
			get;
		}
		IQueryable<DettaglioPagamento> DettaglioPagamentos
		{
			get;
		}
		IQueryable<Allegati> Allegatis
		{
			get;
		}
		IQueryable<Sede> Sedes
		{
			get;
		}
		IQueryable<DatiAnagraficiCessionario> DatiAnagraficiCessionarios
		{
			get;
		}
	}
}
#pragma warning restore 1591
