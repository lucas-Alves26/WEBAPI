using Cliente_asp.net.MVC.core.Models;
using Cliente_asp.net.MVC.core.Services.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cliente_asp.net.MVC.core.Services
{
    public class ClientService
    {
        private readonly Cliente_aspnetMVCcoreContext _contex;

        public ClientService(Cliente_aspnetMVCcoreContext context)
        {
            _contex = context;
        }

        public async Task<List<Client>> FindAllAsync()
        {
            var result = from obj in _contex.Client select obj;

            return await result
                .Include(x => x.Address).OrderBy(x => x.Date).ToListAsync();
        }

        public async Task InsertAsync(Client obj, Address address)
        {
            _contex.Add(address);
            await _contex.SaveChangesAsync();

            int id = _contex.Address.Last().Id;
            obj.AddressId = id;

            _contex.Add(obj);
            await _contex.SaveChangesAsync();
        }

        public async Task<Client> FindByIdAsync(int id)
        {
            //expressão lambida para trazer o Adress junto
            return await _contex.Client.Include(obj => obj.Address).FirstOrDefaultAsync(obj => obj.Id == id);
        }


        public async Task UpdateAsync(Client obj, Address address)
        {
            bool hasAny = await _contex.Client.AnyAsync(x => x.Id == obj.Id);

            if (!hasAny)
            {
                throw new NotFoundException("Id não encontrado");
            }
            try
            {
                _contex.Update(obj);
                await _contex.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var client = await _contex.Client.FindAsync(id);
                int addressId = client.AddressId;

                var address = await _contex.Address.FindAsync(addressId);

                _contex.Client.Remove(client);
                await _contex.SaveChangesAsync();

                _contex.Address.Remove(address);
                await _contex.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException("Não pode deletar o vendedor porque ele/ela tem vendas!");
            }

        }
    }
}
