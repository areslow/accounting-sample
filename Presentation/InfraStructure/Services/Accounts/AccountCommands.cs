using Applicaation.Common.DTOs;
using Application.Account;
using Application.Common.Utilities;
using AutoMapper;
using Domain.Entities;
using InfraStructure;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Net;
using System.Reflection.Metadata.Ecma335;

namespace Presentation.InfraStructure.Services.Accounts
{
    public class AccountCommands : IAccountCommands
    {

        private readonly ApplicationDatabaseContext _db;
        public AccountCommands(ApplicationDatabaseContext db)
        {
            _db = db;
        }

        /// <summary>
        ///  create a reccord in accounts table in database
        /// </summary>
        /// <param name="account">
        ///     the account te be created
        ///     contains the details to be stored
        /// </param>
        /// <returns>returns an apiresponse object that contains the success or failure of the operation</returns>
        public Task<ApiResponse> CreateAccountAsync(AccountDTO account)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///    delete an account record from accounts table by the given id
        ///    removing the account by setting its "IsDeleted" value to true;
        /// </summary>
        /// <param name="accountId"> id of the account to be deleted</param>
        /// <returns>returns a "TaskResut<ApiResponse>" object that contains the success or failure of the operation</returns>
        public async Task<ApiResponse> DeleteAccountAsync(long accountId)
        {
            ApiResponse response = new();
            try
            {
                Account? acc = await _db.accounts.FindAsync(accountId);
                if (acc == null || acc.IsDeleted == true)
                {
                    response.StatusCode = HttpStatusCode.NotFound;
                    response.IsSuccess = false;
                    response.Messages
                        .Add($"account with the given id : {accountId} was not fount");
                    return response;
                }
                if(acc!.IsReadOnly == true)
                {
                    response.StatusCode = HttpStatusCode.BadRequest;
                    response.IsSuccess = false;
                    response.Messages
                        .Add("the specified account can't be removed. contact with system admin");
                    return response;
                }
                acc.IsDeleted = true;
                var res = await _db.SaveChangesAsync();

                if (res <= 0)
                {
                    response.StatusCode = HttpStatusCode.BadRequest;
                    response.IsSuccess = false;
                    response.Messages
                        .Add("Nothing happened");
                    return response;
                }

                // if successfully updated database then return a success object
                response.StatusCode = HttpStatusCode.OK;
                response.IsSuccess = true;
                response.Messages.Add("item successfully has been removed from the database!");
                return response;
            }
            catch (Exception ex)
            {
                response.StatusCode = HttpStatusCode.BadRequest;
                response.IsSuccess = false;
                response.Messages.Add($"{ex.Message}");
                return response;
            }
        }

        public async Task<ApiResponse> UpdateAccountAsync(AccountDTO account)
        {
            ApiResponse response = new();
            try
            {
                // acc : the account to be updated
                Account? acc = await _db.accounts.Include(a=>a.Parent).SingleOrDefaultAsync(a => a.Id == account.Id);
                if (acc == null || acc.IsDeleted == true)
                {
                    response.StatusCode = HttpStatusCode.NotFound;
                    response.IsSuccess = false;
                    response.Messages
                        .Add($"can't find the account!");
                    return response;
                }
                if (acc.IsReadOnly)
                {
                    response.StatusCode = HttpStatusCode.NotFound;
                    response.IsSuccess = false;
                    response.Messages
                        .Add($"can't edit this account. contact the admin");
                    return response;
                }

                // change any parameter that is needed
                acc.Name = account.Name;
                acc.ParentId = account.ParentId;
                acc.MaxDebt = account.MaxDebt;
                acc.MaxCredit = account.MaxCredit;
                var res = await _db.SaveChangesAsync();
                //checked if any record has changed or not
                if (res <= 0)
                {
                    response.StatusCode = HttpStatusCode.BadRequest;
                    response.IsSuccess = false;
                    response.Messages
                        .Add("Nothing happened");
                    return response;
                }

                // if successfully updated database then return a success object
                response.StatusCode = HttpStatusCode.OK;
                response.IsSuccess = true;
                response.Messages.Add("item successfully has been removed from the database!");
                return response;
            }
            catch (Exception ex)
            {
                response.StatusCode = HttpStatusCode.BadRequest;
                response.IsSuccess = false;
                response.Messages.Add($"{ex.Message}");
                return response;
            }
        }
    }
}
