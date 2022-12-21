using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DIO_dotNetMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace DIO_dotNetMVC.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }

        public DbSet<Contato> Contatos { get; set; }
    }
}