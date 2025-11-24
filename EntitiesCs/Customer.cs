using System;
using System.Collections.Generic;

namespace EntitiesCs
{
    public class Customer
    {
        private List<Account> accounts = new List<Account>();
        public Customer()
        {
            Nationality = "Argentino";
        }
        public Customer(string Name, int id) : this()
        {
            this.Name = Name;
            this.Id = id;
        }
        public Customer(string name, int id, DateTime BirthDate) : this(name, id)
        {
            this.BirthDay = BirthDate;
        }
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value.ToUpper();
            }
        }
        private int id;
        public int Id { get => id; set => id = value; }
        private DateTime? birthDay;
        public DateTime? BirthDay
        {
            get
            {
                return birthDay;
            }
            set
            {
                birthDay = value;
            }
		}
        // Propiedad autoimplementada
        public String Nationality { get; set; }

        private List<Account> accounts;
        public void AddAccount(Account account)
        {
            accounts.Add(account);
        }
        public List<Account> GetAccounts()
        {
            return accounts;
        }
        public void RemoveAccount(Account account)
        {
            accounts.Remove(account);
        }
        public override string ToString()
        {
            return name;
        }
        //public void AddAccount(Account account)
        internal void AddAccount(Account account)
        {
            //account.Customer = this;
			accounts.Add(account);
        }
        public void RemoveAccount(Account account)
        {
            account.Customer = null;
			accounts.Remove(account);
        }
        public List<Account> GetAccounts()
        {
            return accounts;
        }
    }
}
