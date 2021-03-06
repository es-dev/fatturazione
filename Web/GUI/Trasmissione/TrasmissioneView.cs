using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.Trasmissione
{
	public partial class TrasmissioneView : TemplateView
	{
        public TrasmissioneView()
		{ 
			InitializeComponent();
		}

        public override void Init()
        {
            try
            {
                ViewModel = new TrasmissioneViewModel();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
	}
}
