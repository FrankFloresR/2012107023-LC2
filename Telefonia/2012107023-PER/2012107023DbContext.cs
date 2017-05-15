using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telefonia.Entities;

namespace _2012107023_PER
{
    class _2012107023DbContext : DbContext
    {
        public DbSet <AdministradorEquipo> AdministradorEquipos { get; set; }

        public DbSet <AdministradorLinea> AdministradorLineas { get; set; }
        public DbSet <CentroAtencion> centrsoatencion { get; set; }
        public DbSet <Cliente> Clientes { get; set; }
        public DbSet<Contrato> Contratos { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Direccion> Direcciones { get; set; }      
        public DbSet<Distrito> Distritos { get; set; }
        public DbSet<EquipoCelular> EquiposCelulares { get; set; }
        public DbSet<EstadoEvaluacion> EstadosEvaluaciones { get; set; }
        public DbSet<Evaluacion> Evaluaciones { get; set; }
        public DbSet<LineaTelefonica> LineasTelefonicas { get; set; }
        public DbSet<Plan> Planes { get; set; }
        public DbSet<Provincia> Provincias { get; set; }
        public DbSet<TipoEvaluacion> TiposEvaluaciones { get; set; }
        public DbSet<TipoLinea> TiposLineas { get; set; }
        public DbSet<TipoPago> TiposPagos { get; set; }
        public DbSet<TipoPlan> TiposPlanes { get; set; }
        public DbSet<TipoTrabajador> TiposTrabajador { get; set; }
        public DbSet<Trabajador> Trabajadores { get; set; }
        public DbSet<Ubigeo> Ubigeof { get; set; }
        public DbSet<Venta> Ventas { get; set; }
    }
}
