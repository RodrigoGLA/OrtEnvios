using LogicaNegocio.EntidadesDominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.EF
{
    public class OrtContext: DbContext
    {
        public OrtContext(DbContextOptions<OrtContext> options) : base(options)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Envio> Envios { get; set; }
        public DbSet<Agencia> Agencias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Urgente> Urgentes { get; set; }
        public DbSet<Comun> Comunes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Administrador> Administradores { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuración de las entidades
            modelBuilder.Entity<Usuario>().ToTable("Usuarios");
            modelBuilder.Entity<Envio>().ToTable("Envios");
            modelBuilder.Entity<Agencia>().ToTable("Agencias");
            modelBuilder.Entity<Cliente>().ToTable("Clientes");
            modelBuilder.Entity<Urgente>().ToTable("Urgentes");
            modelBuilder.Entity<Comun>().ToTable("Comunes");
            modelBuilder.Entity<Empleado>().ToTable("Empleados");
            modelBuilder.Entity<Funcionario>().ToTable("Funcionarios");
            modelBuilder.Entity<Administrador>().ToTable("Administradores");

        }
    }
    
    }

