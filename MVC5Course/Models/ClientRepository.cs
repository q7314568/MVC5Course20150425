using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVC5Course.Models
{   
	public  class ClientRepository : EFRepository<Client>, IClientRepository
	{
        public override IQueryable<Client> All()
        {
              return base.All().Where(p=>p.IsDelete==false);
        }
        public Client Find(int id)
        {
            return this.All().FirstOrDefault(p=>p.ClientId==id);
        }
        public IEnumerable<Client> GetClientByGender(string Gender)
        {
            return this.All().Where(o => o.Gender == Gender).Take(10);
        }

        public IEnumerable<Client> GetClientByCity(string City)
        {
            if (string.IsNullOrEmpty(City))
            {
                return this.All();
            }
            return this.All().Where(o => o.City == City);
        }
	}

	public  interface IClientRepository : IRepository<Client>
	{

	}
}