﻿using Library.Code;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService.Dto;

namespace Web.GUI.StudioProfessionale
{
    public class StudioProfessionaleViewModel : Library.Template.MVVM.TemplateViewModel<StudioProfessionaleView, StudioProfessionaleItem, StudioProfessionaleModel, StudioProfessionaleDto>
    {

        public StudioProfessionaleViewModel()
            : base() 
        {
            try
            {

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void Load(int skip, int take, string search=null, object advancedSearch=null, OrderBy orderBy=null)
        {
            try
            {
                var wcf = new WcfService.Service();
                var objs = wcf.LoadStudiProfessionali(skip, take, search, advancedSearch, orderBy);
                Load(objs);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override int Count(string search = null,  object advancedSearch=null)
        {
            try
            {
                var wcf = new WcfService.Service();
                var count = wcf.CountStudiProfessionali(search, advancedSearch);
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public override bool Save(object model, bool creating)
        {
            try
            {
                if (model != null)
                {
                    var wcf = new WcfService.Service();
                    var obj = (StudioProfessionaleDto)model;
                    bool performed = false;
                    if (creating)
                    {
                        var newObj = wcf.CreateStudioProfessionale(obj);
                        performed = (newObj != null);
                        if (performed)
                            Update(obj, newObj);
                    }
                    else //updating
                        performed = wcf.UpdateStudioProfessionale(obj);
                    return performed;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public override bool Delete(object model)
        {
            try
            {
                if (model != null)
                {
                    var wcf = new WcfService.Service();
                    var obj = (StudioProfessionaleDto)model;
                    bool performed = wcf.DeleteStudioProfessionale(obj);
                    return performed;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public override object Read(object id)
        {
            try
            {
                var wcf = new WcfService.Service();
                var obj = wcf.ReadStudioProfessionale(id);
                return obj;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        internal IEnumerable<StudioProfessionaleDto> ReadStudiProfessionali()
        {
            try
            {
                var wcf = new WcfService.Service();
                var objs = wcf.ReadStudiProfessionali();
                return objs;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        internal StudioProfessionaleDto ReadAStudioProfessionale(AccountDto account)
        {
            try
            {
                if (account != null)
                {
                    int studioProfessionaleId = account.StudioProfessionaleId;
                    var wcf = new WcfService.Service();
                    var obj = wcf.ReadStudioProfessionale(studioProfessionaleId);
                    return obj;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
    }
}