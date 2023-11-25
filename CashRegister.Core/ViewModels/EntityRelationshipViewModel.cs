using CashRegister.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CashRegister.Core.ViewModels
{
    public class EntityRelationshipViewModel : SamplePageViewModel
    {
        public EntityRelationshipViewModel(IFilesService filesService) : base(filesService)
        {
        }
    }
}
