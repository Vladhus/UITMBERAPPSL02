using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UITMBER.Models.Authentication;
using UITMBER.Services.Request;
using Xamarin.Forms;

namespace UITMBER.Services.UFLocation
{
    public class UFLocationService : IUFLocationService
    {

        public IRequestService _requestService => DependencyService.Get<IRequestService>();


        public async Task<bool> DeleteLocation(long id)
        {
            var uri = $"{Settings.SERVER_ENDPOINT}/UFLocations/DeleteLocation/{id}";

            return await _requestService.DeleteAsync<bool>(uri);
        }
    }
}
