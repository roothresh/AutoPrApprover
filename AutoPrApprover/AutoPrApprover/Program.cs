using AutoPrApprover;
using AutoPrApprover.Helper;
using AutoPrApprover.Models;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        
        Console.WriteLine(Consts.InitializeString);
        int initSelection = Convert.ToInt32(Console.ReadLine());

        if (initSelection == 1)
        {
            InitializeDefault initializeDefault = new InitializeDefault();

            UserInputModel inputModel = initializeDefault.GetUserInput();

            AuthModel authModel = initializeDefault.GetAuth();

            string apiUrl = initializeDefault.GetApiUrl(inputModel);

            string jsonBody = initializeDefault.GetJsonStringBody(inputModel.ReviewerId);

            ApiCall apiCall = new ApiCall();
            Console.WriteLine(await apiCall.Approve(apiUrl, jsonBody, authModel));
        }
        else if (initSelection == 2)
        {
            InitializeAdvanced initializeAdvanced = new InitializeAdvanced();

            UserInputModel inputModel = initializeAdvanced.GetUserInput();

            AuthModel authModel = initializeAdvanced.GetAuth();

            string apiUrl = initializeAdvanced.GetApiUrl(inputModel);

            string jsonBody = initializeAdvanced.GetJsonStringBody(inputModel.ReviewerId);

            ApiCall apiCall = new ApiCall();
            Console.WriteLine(await apiCall.Approve(apiUrl, jsonBody, authModel));

        }


        Console.ReadKey();
    }
}
