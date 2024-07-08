using AutoPrApprover.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPrApprover.Interfaces
{
    public interface IApiCall
    {
        Task<string> Approve(string apiUrl, string jsonBody, AuthModel authModel);
        Task<string> Reject();
    }
}
