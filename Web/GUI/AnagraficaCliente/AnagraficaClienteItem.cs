using Library.Code;
using Library.Interfaces;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using WcfService.Dto;
using Web.Code;

namespace Web.GUI.AnagraficaCliente
{
	public partial class AnagraficaClienteItem : TemplateItem
	{
        public AnagraficaClienteItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (AnagraficaClienteDto)model;
                    var ragioneSociale = UtilityValidation.GetStringND(obj.RagioneSociale);
                    var codice = UtilityValidation.GetStringND(obj.Codice);
                    var partitaIVA = UtilityValidation.GetStringND(obj.PartitaIva);
                    var indirizzo = UtilityValidation.GetStringND(obj.Indirizzo);
                    var cap = UtilityValidation.GetStringND(obj.CAP);
                    var comune = UtilityValidation.GetStringND(obj.Comune);
                   var provincia = UtilityValidation.GetStringND(obj.Provincia);

                   infoImage.Image = "Images.dashboard.anagraficacommittente.png";
                   infoRagioneSociale.Text = ragioneSociale;
                   infoCodice.Text = "CT-" + codice;
                   infoPartitaIVA.Text = "P.IVA " + partitaIVA;
                   infoIndirizzo.Text = indirizzo + " - " + cap + " - " + comune + " (" + provincia + ")";

                    infoRagioneSociale.Text = ragioneSociale.ToUpper();
                    infoIndirizzo.Text = indirizzo;

                    var studioProfessionale = obj.StudioProfessionale;
                    if (studioProfessionale != null)
                        infoStudioProfessionale.Text = "Studio professionale: " + studioProfessionale.RagioneSociale;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

       
	}
}
