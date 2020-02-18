using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banks.ApiUI.Models;
using Banks.Data.Unit;
using Banks.Entity.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Banks.ApiUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private IUnitOfWork _unitOfWork;
        public PersonController(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public ActionResult<List<PersonViewModel>> Get()
        {
            return _unitOfWork.peopleResptory.GetAll()
                 .Select(x => new PersonViewModel
                 {
                     UserName = x.Name,
                     SurName = x.Surname,
                     Email = x.Email,
                     passNum = x.passnum
                 }).ToList();

        }
        [HttpPost]
        public void Add(Person person)
        {
            if (ModelState.IsValid)
            {
 _unitOfWork.peopleResptory.Add(person);
            }
           
        }
      
    }
}