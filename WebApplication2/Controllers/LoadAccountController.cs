using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LoadCommon;
using Load_BusinessDataLogic;
namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoadAccountController : ControllerBase
    {
        LoadBusinessService loadBusinessService = new LoadBusinessService();
        [HttpGet("Get All Accounts")]
        public IEnumerable<LoadAccount> GetData()
        {
            var accounts = loadBusinessService.GetAccounts();
            return accounts;
        }

        [HttpPost("Add Account")]
        public void AddLoadAccount(string phoneNum, string name, string PIN)
        {
            loadBusinessService.AddUserAccount(phoneNum, name, PIN);
        }

        [HttpPatch("Cash In")]
        public bool CashIn(double amount, string phoneNum, string pin)
        {
            var result = loadBusinessService.UpdateBalance(1, amount, phoneNum, pin);

            return result;
        }

        [HttpPatch("Send Cash")]
        public bool SendCash(double amount, string phoneNum, string pin)
        {
            var result = loadBusinessService.UpdateBalance(2, amount, phoneNum, pin);

            return result;
        }

        [HttpPatch("Change Username")]
        public void ChangeName(string phoneNumber, string pin, string newName)
        {
            loadBusinessService.ChangeName(phoneNumber, pin, newName);
        }

        [HttpPatch("Change PIN")]
        public void ChangePIN(string phoneNumber, string pin, string newPIN)
        {
            loadBusinessService.ChangePIN(phoneNumber, pin, newPIN);
        }
    }
}

