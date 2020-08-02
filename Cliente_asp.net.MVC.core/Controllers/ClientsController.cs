using Cliente_asp.net.MVC.core.Models;
using Cliente_asp.net.MVC.core.Models.ViewModels;
using Cliente_asp.net.MVC.core.Services;
using Cliente_asp.net.MVC.core.Services.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Cliente_asp.net.MVC.core.Controllers
{
    public class ClientsController : Controller
    {
        private readonly ClientService _clientService;

        public ClientsController(ClientService clientService)
        {
            _clientService = clientService;
        }


        public async Task<IActionResult> Index()
        {
            return View(await _clientService.FindAllAsync());
        }


        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Client client, Address address)
        {
            bool cnpj = Validacao.ValidaCNPJ(client.Cnpj);

            if (cnpj == false)
            {
                return RedirectToAction(nameof(Error), new { message = "Cnpj não validado!" });
            }
            else
            {
                await _clientService.InsertAsync(client, address);
                return RedirectToAction(nameof(Index));
            }
        }


        public async Task<IActionResult> Edit(int? id)
        {
            var obj = await _clientService.FindByIdAsync(id.Value);

            bool cnpj = Validacao.ValidaCNPJ(obj.Cnpj);

            if (cnpj == false)
            {
                return RedirectToAction(nameof(Error), new { message = "Cnpj não validado!" });
            }
            else
            {
                ClientAddressViewModel clientAddressView = new ClientAddressViewModel { Client = obj };
                return View(clientAddressView);
            }        
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Client client, Address address)
        {
            if (id != client.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não corresponde!" });
            }

            await _clientService.UpdateAsync(client, address);

            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido!" });
            }

            var obj = await _clientService.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado!" }); ;
            }

            ClientAddressViewModel clientAddressView = new ClientAddressViewModel { Client = obj };
            return View(clientAddressView);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _clientService.RemoveAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (IntegrityException e)
            {

                return RedirectToAction(nameof(Error), new { message = e.Message });
            }

        }

        public IActionResult Error(string message)
        {
            var viewModel = new ErrorViewModel
            {
                Message = message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };

            return View(viewModel);
        }

    }
}
