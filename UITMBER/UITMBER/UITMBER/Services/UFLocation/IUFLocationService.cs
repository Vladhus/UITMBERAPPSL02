using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UITMBER.Models.Authentication;

namespace UITMBER.Services.UFLocation
{
    public  interface IUFLocationService
    {
        Task<bool> DeleteLocation(long id);
    }
}
