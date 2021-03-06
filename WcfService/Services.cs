#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace WcfService.Services
{
	using Telerik.OpenAccess;
	using System.Linq.Dynamic;
	using DataLayer;
	using WcfService.Dto;
	using WcfService.Assemblers;
	using WcfService.Repositories;
	using WcfService.Converters;
	using System;
	using System.Linq;
	using System.Linq.Expressions;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.Serialization;

	
	public partial interface IService<TDto, TEntity>
	    where TEntity : class
		where TDto : IDtoWithKey
	{
	    IAssembler<TDto, TEntity> Assembler { get; }
	    IRepository<TEntity> Repository { get; }
	
	    IEnumerable<TDto> Find(Expression<Func<TEntity, bool>> filter);
	    IEnumerable<TDto> GetAll();
		
		IEnumerable<TDto> Find(int startRowIndex, int maximumRows);
	    IEnumerable<TDto> Find(string sortExpression, string filterExpression);
	    IEnumerable<TDto> Find(int? startRowIndex, int? maximumRows, string sortExpression, string filterExpression);
	    
		int Count();
	    int Count(string filterExpression);
		
		TDto GetByKey(string dtoKey);
	    string Add(TDto dto);
		void Update(TDto dto);
	    void Delete(TDto dto);	
	}
	
	public abstract partial class Service<TDto, TEntity> : IService<TDto, TEntity>
	    where TEntity : class
		where TDto : IDtoWithKey
	{
	    IAssembler<TDto, TEntity> assembler;
	    IRepository<TEntity> repository;
	
	    public Service(IAssembler<TDto, TEntity> assembler,
	        IRepository<TEntity> repository)
	    {
	        this.assembler = assembler;
	        this.repository = repository;
	    }
	
	    public IAssembler<TDto, TEntity> Assembler 
	    { 
	        get 
	        {
	            return this.assembler; 
	        } 
	    }
	
	    public IRepository<TEntity> Repository 
	    { 
	        get 
	        {
	            return this.repository; 
	        }
	    }
		
		public virtual IEnumerable<TDto> GetAll()
	    {
	        return this.assembler.Assemble(this.Repository.GetAll());
	    }
	
	    public virtual IEnumerable<TDto> Find(Expression<Func<TEntity, bool>> filter)
	    {
	        return this.Assembler.Assemble(this.Repository.Find(filter));
	    }
	
	    public virtual IEnumerable<TDto> Find(int startRowIndex, int maximumRows)
	    {
	        return this.Find(startRowIndex, maximumRows, null, null);
	    }
	
	    public virtual IEnumerable<TDto> Find(string sortExpression, string filterExpression)
	    {
	        return this.Find(null, null, sortExpression, filterExpression);
	    }
	
	    public virtual IEnumerable<TDto> Find(int? startRowIndex, int? maximumRows, string sortExpression, string filterExpression)
	    {
	        IQueryable<TEntity> query = this.Repository.GetAll();
	
	        if (!string.IsNullOrEmpty(filterExpression))
	        {
	            query = query.Where(filterExpression);
	        }
	        if (!string.IsNullOrEmpty(sortExpression))
	        {
	            query = query.OrderBy(sortExpression);
	        }
	        if (startRowIndex.HasValue)
	        {
	            query = query.Skip(startRowIndex.Value);
	        }
	        if (maximumRows.HasValue)
	        {
	            query = query.Take(maximumRows.Value);
	        }
	
	        return this.Assembler.Assemble(query);
	    }
	
	    public virtual int Count()
	    {
	        return this.Count(string.Empty);
	    }
	
	    public virtual int Count(string filterExpression)
	    {
	        IQueryable<TEntity> query = this.Repository.GetAll();
	
	        if (!string.IsNullOrEmpty(filterExpression))
	        {
	            query = query.Where(filterExpression);    
	        }
	
	        return query.Count();
	    }
	
	    
	    public virtual TDto GetByKey(string dtoKey)
	    {
	        ObjectKey key = KeyUtility.Instance.Convert<TEntity>(dtoKey);
			
	        return this.assembler.Assemble(this.Repository.Get(key));
	    }
	
	    public virtual string Add(TDto dto)
	    {
	        TEntity entity = this.assembler.Assemble(null, dto);
	
	        this.repository.Add(entity);
	
	        ObjectKey key = KeyUtility.Instance.Create(entity);
	
	        return KeyUtility.Instance.Convert(key);
	    }
	
	    public virtual void Update(TDto dto)
	    {
	        ObjectKey key = KeyUtility.Instance.Convert<TEntity>(dto.DtoKey);
	        TEntity entity = this.repository.Get(key);
	
	        this.assembler.Assemble(entity, dto);
	    }
	
	    public virtual void Delete(TDto dto)
	    {
			ObjectKey key = KeyUtility.Instance.Convert<TEntity>(dto.DtoKey);
	        TEntity entity = this.repository.Get(key);
	
	        this.Repository.Remove(entity);
	    }
	}
	
	public partial interface IStudioProfessionaleService : IService<StudioProfessionaleDto, StudioProfessionale>
	{
	
	}
	
	public partial class StudioProfessionaleService : Service<StudioProfessionaleDto, StudioProfessionale>, IStudioProfessionaleService
	{
	    public StudioProfessionaleService(IStudioProfessionaleAssembler assembler, IStudioProfessionaleRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface IClienteService : IService<ClienteDto, Cliente>
	{
	
	}
	
	public partial class ClienteService : Service<ClienteDto, Cliente>, IClienteService
	{
	    public ClienteService(IClienteAssembler assembler, IClienteRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface IFatturaService : IService<FatturaDto, Fattura>
	{
	
	}
	
	public partial class FatturaService : Service<FatturaDto, Fattura>, IFatturaService
	{
	    public FatturaService(IFatturaAssembler assembler, IFatturaRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface ITrasmissioneService : IService<TrasmissioneDto, Trasmissione>
	{
	
	}
	
	public partial class TrasmissioneService : Service<TrasmissioneDto, Trasmissione>, ITrasmissioneService
	{
	    public TrasmissioneService(ITrasmissioneAssembler assembler, ITrasmissioneRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface IAnagraficaClienteService : IService<AnagraficaClienteDto, AnagraficaCliente>
	{
	
	}
	
	public partial class AnagraficaClienteService : Service<AnagraficaClienteDto, AnagraficaCliente>, IAnagraficaClienteService
	{
	    public AnagraficaClienteService(IAnagraficaClienteAssembler assembler, IAnagraficaClienteRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface IIncassoService : IService<IncassoDto, Incasso>
	{
	
	}
	
	public partial class IncassoService : Service<IncassoDto, Incasso>, IIncassoService
	{
	    public IncassoService(IIncassoAssembler assembler, IIncassoRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface ISocioService : IService<SocioDto, Socio>
	{
	
	}
	
	public partial class SocioService : Service<SocioDto, Socio>, ISocioService
	{
	    public SocioService(ISocioAssembler assembler, ISocioRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface IAnagraficaPAService : IService<AnagraficaPADto, AnagraficaPA>
	{
	
	}
	
	public partial class AnagraficaPAService : Service<AnagraficaPADto, AnagraficaPA>, IAnagraficaPAService
	{
	    public AnagraficaPAService(IAnagraficaPAAssembler assembler, IAnagraficaPARepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface IFatturaElettronicaHeaderService : IService<FatturaElettronicaHeaderDto, FatturaElettronicaHeader>
	{
	
	}
	
	public partial class FatturaElettronicaHeaderService : Service<FatturaElettronicaHeaderDto, FatturaElettronicaHeader>, IFatturaElettronicaHeaderService
	{
	    public FatturaElettronicaHeaderService(IFatturaElettronicaHeaderAssembler assembler, IFatturaElettronicaHeaderRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface IFatturaElettronicaBodyService : IService<FatturaElettronicaBodyDto, FatturaElettronicaBody>
	{
	
	}
	
	public partial class FatturaElettronicaBodyService : Service<FatturaElettronicaBodyDto, FatturaElettronicaBody>, IFatturaElettronicaBodyService
	{
	    public FatturaElettronicaBodyService(IFatturaElettronicaBodyAssembler assembler, IFatturaElettronicaBodyRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface IDatiTrasmissioneService : IService<DatiTrasmissioneDto, DatiTrasmissione>
	{
	
	}
	
	public partial class DatiTrasmissioneService : Service<DatiTrasmissioneDto, DatiTrasmissione>, IDatiTrasmissioneService
	{
	    public DatiTrasmissioneService(IDatiTrasmissioneAssembler assembler, IDatiTrasmissioneRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface IIdFiscaleService : IService<IdFiscaleDto, IdFiscale>
	{
	
	}
	
	public partial class IdFiscaleService : Service<IdFiscaleDto, IdFiscale>, IIdFiscaleService
	{
	    public IdFiscaleService(IIdFiscaleAssembler assembler, IIdFiscaleRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface ICedentePrestatoreService : IService<CedentePrestatoreDto, CedentePrestatore>
	{
	
	}
	
	public partial class CedentePrestatoreService : Service<CedentePrestatoreDto, CedentePrestatore>, ICedentePrestatoreService
	{
	    public CedentePrestatoreService(ICedentePrestatoreAssembler assembler, ICedentePrestatoreRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface IDatiAnagraficiCedenteService : IService<DatiAnagraficiCedenteDto, DatiAnagraficiCedente>
	{
	
	}
	
	public partial class DatiAnagraficiCedenteService : Service<DatiAnagraficiCedenteDto, DatiAnagraficiCedente>, IDatiAnagraficiCedenteService
	{
	    public DatiAnagraficiCedenteService(IDatiAnagraficiCedenteAssembler assembler, IDatiAnagraficiCedenteRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface IAnagraficaService : IService<AnagraficaDto, Anagrafica>
	{
	
	}
	
	public partial class AnagraficaService : Service<AnagraficaDto, Anagrafica>, IAnagraficaService
	{
	    public AnagraficaService(IAnagraficaAssembler assembler, IAnagraficaRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface IAccountService : IService<AccountDto, Account>
	{
	
	}
	
	public partial class AccountService : Service<AccountDto, Account>, IAccountService
	{
	    public AccountService(IAccountAssembler assembler, IAccountRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface ICessionarioCommittenteService : IService<CessionarioCommittenteDto, CessionarioCommittente>
	{
	
	}
	
	public partial class CessionarioCommittenteService : Service<CessionarioCommittenteDto, CessionarioCommittente>, ICessionarioCommittenteService
	{
	    public CessionarioCommittenteService(ICessionarioCommittenteAssembler assembler, ICessionarioCommittenteRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface IDatiGeneraliService : IService<DatiGeneraliDto, DatiGenerali>
	{
	
	}
	
	public partial class DatiGeneraliService : Service<DatiGeneraliDto, DatiGenerali>, IDatiGeneraliService
	{
	    public DatiGeneraliService(IDatiGeneraliAssembler assembler, IDatiGeneraliRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface IDatiGeneraliDocumentoService : IService<DatiGeneraliDocumentoDto, DatiGeneraliDocumento>
	{
	
	}
	
	public partial class DatiGeneraliDocumentoService : Service<DatiGeneraliDocumentoDto, DatiGeneraliDocumento>, IDatiGeneraliDocumentoService
	{
	    public DatiGeneraliDocumentoService(IDatiGeneraliDocumentoAssembler assembler, IDatiGeneraliDocumentoRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface IDatiRitenutaService : IService<DatiRitenutaDto, DatiRitenuta>
	{
	
	}
	
	public partial class DatiRitenutaService : Service<DatiRitenutaDto, DatiRitenuta>, IDatiRitenutaService
	{
	    public DatiRitenutaService(IDatiRitenutaAssembler assembler, IDatiRitenutaRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface IDatiBeniServiziService : IService<DatiBeniServiziDto, DatiBeniServizi>
	{
	
	}
	
	public partial class DatiBeniServiziService : Service<DatiBeniServiziDto, DatiBeniServizi>, IDatiBeniServiziService
	{
	    public DatiBeniServiziService(IDatiBeniServiziAssembler assembler, IDatiBeniServiziRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface IDettaglioLineeService : IService<DettaglioLineeDto, DettaglioLinee>
	{
	
	}
	
	public partial class DettaglioLineeService : Service<DettaglioLineeDto, DettaglioLinee>, IDettaglioLineeService
	{
	    public DettaglioLineeService(IDettaglioLineeAssembler assembler, IDettaglioLineeRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface IDatiRiepilogoService : IService<DatiRiepilogoDto, DatiRiepilogo>
	{
	
	}
	
	public partial class DatiRiepilogoService : Service<DatiRiepilogoDto, DatiRiepilogo>, IDatiRiepilogoService
	{
	    public DatiRiepilogoService(IDatiRiepilogoAssembler assembler, IDatiRiepilogoRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface IDatiPagamentoService : IService<DatiPagamentoDto, DatiPagamento>
	{
	
	}
	
	public partial class DatiPagamentoService : Service<DatiPagamentoDto, DatiPagamento>, IDatiPagamentoService
	{
	    public DatiPagamentoService(IDatiPagamentoAssembler assembler, IDatiPagamentoRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface IDettaglioPagamentoService : IService<DettaglioPagamentoDto, DettaglioPagamento>
	{
	
	}
	
	public partial class DettaglioPagamentoService : Service<DettaglioPagamentoDto, DettaglioPagamento>, IDettaglioPagamentoService
	{
	    public DettaglioPagamentoService(IDettaglioPagamentoAssembler assembler, IDettaglioPagamentoRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface ISedeService : IService<SedeDto, Sede>
	{
	
	}
	
	public partial class SedeService : Service<SedeDto, Sede>, ISedeService
	{
	    public SedeService(ISedeAssembler assembler, ISedeRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface IDatiAnagraficiCessionarioService : IService<DatiAnagraficiCessionarioDto, DatiAnagraficiCessionario>
	{
	
	}
	
	public partial class DatiAnagraficiCessionarioService : Service<DatiAnagraficiCessionarioDto, DatiAnagraficiCessionario>, IDatiAnagraficiCessionarioService
	{
	    public DatiAnagraficiCessionarioService(IDatiAnagraficiCessionarioAssembler assembler, IDatiAnagraficiCessionarioRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface IDatiBolloService : IService<DatiBolloDto, DatiBollo>
	{
	
	}
	
	public partial class DatiBolloService : Service<DatiBolloDto, DatiBollo>, IDatiBolloService
	{
	    public DatiBolloService(IDatiBolloAssembler assembler, IDatiBolloRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface IDatiCassaPrevidenzialeService : IService<DatiCassaPrevidenzialeDto, DatiCassaPrevidenziale>
	{
	
	}
	
	public partial class DatiCassaPrevidenzialeService : Service<DatiCassaPrevidenzialeDto, DatiCassaPrevidenziale>, IDatiCassaPrevidenzialeService
	{
	    public DatiCassaPrevidenzialeService(IDatiCassaPrevidenzialeAssembler assembler, IDatiCassaPrevidenzialeRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface IScontoMaggiorazioneService : IService<ScontoMaggiorazioneDto, ScontoMaggiorazione>
	{
	
	}
	
	public partial class ScontoMaggiorazioneService : Service<ScontoMaggiorazioneDto, ScontoMaggiorazione>, IScontoMaggiorazioneService
	{
	    public ScontoMaggiorazioneService(IScontoMaggiorazioneAssembler assembler, IScontoMaggiorazioneRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
}
#pragma warning restore 1591
