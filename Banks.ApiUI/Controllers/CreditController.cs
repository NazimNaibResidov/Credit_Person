using Banks.ApiUI.Models;
using Banks.Data.Unit;
using Banks.Entity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Banks.ApiUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreditController : ControllerBase
    {
        private IUnitOfWork _unitOfWork;
        public CreditController(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        [HttpGet]
        public ActionResult<List<CreadetPersonViewModel>> Get()
        {
            return _unitOfWork.peopleResptory.GetAll()
                .Include(x => x.Credit)
              .Select(x => new CreadetPersonViewModel
              {
                  Id=x.Id,
                  UserName = x.Name,
                  SurName = x.Surname,
                  passNum = x.passnum,
                  Email = x.Email,
                  StartDate = x.Credit.StartDate,
                  EndDate = x.Credit.EndDate,
                  Amount = x.Credit.Amount

              }).ToList();
        }
        [HttpPost]
        public void Add(CreditPerson cn)
        {

            if (ModelState.IsValid)
            {
                Person person = new Person();
                Credit credit = new Credit();
                if (cn.endDate>=DateTime.Now)
                {
                    credit.EndDate = cn.endDate;
                }
                else
                {
                    credit.EndDate = cn.endDate.AddMonths(12);
                }
                
                credit.Amount = cn.amount;
                person.Name = cn.UserName;
                person.Surname = cn.SurName;
                person.Email = cn.Email;
                person.passnum = cn.passNum;
                _unitOfWork.creditResptory.Add(credit);
                person.CreditId = credit.Id;
                _unitOfWork.peopleResptory.Add(person);
            }
           
                

        }

        [HttpDelete("{id}")]
        public  void Delete(int id)
        {
            Credit credit = _unitOfWork.creditResptory.GetAll().FirstOrDefault(x => x.Id == id);
            _unitOfWork.creditResptory.Remove(credit);

        }
    }
}