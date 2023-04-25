﻿using AkademiPlusApi.BusinessLayer.Abstract;
using AkademiPlusApi.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusApi.PresantationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet]
        public IActionResult CustomerList()
        {
            var values = _customerService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CustomerAdd(Customer customer)
        {
            _customerService.TInsert(customer);
            return Ok();
        }
        [HttpDelete]
        public IActionResult CustomerDelete(int id)
        {
            var values = _customerService.TGetbyID(id);
            _customerService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult CustomerUpdate(Customer customer)
        {
            _customerService.TUpdate(customer);
            return Ok();
        }
    }
}
