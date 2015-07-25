using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.Utils;
using System.Data;
using PagoElectronico.Domain;

namespace PagoElectronico.Repositories
{
    class TarjetaRepository
    {
        public bool coincideTarjeta(string numero )
        {                    
            return DBAdapter.checkIfExists("coincideTarjeta",numero);
        }

        public  List<Tarjeta> getTarjetasHabilitadas(int idUser, DateTime fecha)
        {
            return parseTarjetas(DBAdapter.retrieveDataTable("getTarjetas", idUser, fecha,true));
        }

        public List<Tarjeta> getTarjetas(int idUser)
        {
            return parseTarjetas(DBAdapter.retrieveDataTable("getTarjetas", idUser, null,null));
        }

        public List<Tarjeta> getTarjetasByCliente(int cliId)
        {
            return parseTarjetas(DBAdapter.retrieveDataTable("getTarjetaByCliente", cliId));
        }

        private  List<Tarjeta> parseTarjetas(DataTable tabla)
        {
            return tabla.AsEnumerable().Select(row => parseTarjeta(row)).ToList();
        }

        private Tarjeta parseTarjeta(DataRow fila)
        {
            return new Tarjeta(Convert.ToInt64(fila["ID"]),
                               fila["Ultimos_Digitos"] as string,
                               null,
                               getEmisor(Convert.ToInt32(fila["Banco_Emisor"])),
                               new ClienteRepository().getCliente(Convert.ToInt32(fila["Cliente"])),
                               Convert.ToDateTime(fila["Fecha_Emision"]),
                               Convert.ToDateTime(fila["Fecha_Vencimiento"]),
                               null, (Boolean) fila["Estado"],fila["Titular"] as string);
        }

        private Banco getBanco(int p)
        {
            return DBAdapter.retrieveDataTable("getBanco",p).AsEnumerable().Select(dr => parseBanco(dr) ).First();
        }

        private Banco parseBanco(DataRow banco)
        {
            return new Banco(Convert.ToInt32(banco["Id"]), banco["Direccion"] as string, banco["Nombre"] as string);
        }

        private BancoSoloNombre parseBancoSoloNombre(DataRow banco)
        {
            return new BancoSoloNombre(Convert.ToInt32(banco["Id"]), banco["Direccion"] as string, banco["Nombre"] as string);
        }

        public List<BancoSoloNombre> getBancosSoloNombre()
        {
            return DBAdapter.retrieveDataTable("getBanco", DBNull.Value).AsEnumerable().Select(dr => parseBancoSoloNombre(dr)).ToList();
        }

        public List<Banco> getBancos()
        {
            return DBAdapter.retrieveDataTable("getBanco",DBNull.Value).AsEnumerable().Select(dr => parseBanco(dr)).ToList();
        }

        private Emisor parseEmisor(DataRow emisor)
        {
            return new Emisor(Convert.ToInt32(emisor["Id"]),
                              emisor["Descripcion"] as string);
        }

        public List<Emisor> getEmisores()
        {
            return DBAdapter.retrieveDataTable("getEmisor", DBNull.Value).AsEnumerable().Select(dr => parseEmisor(dr)).ToList();
        }

        public Emisor getEmisor(int id)
        {
            return parseEmisor(DBAdapter.retrieveDataTable("getEmisor", id).Rows[0]);
        }

        internal void asociar(Tarjeta tarjeta)
        {
            DBAdapter.executeProcedure("asociarTarjeta", tarjeta.cliente.ID,
                                       tarjeta.fechaEmision,
                                       tarjeta.fechaVencimiento,
                                       tarjeta.numero,
                                       tarjeta.ultimosCuatroDigitos,
                                       tarjeta.codigoDeSeguridad,
                                       tarjeta.bancoEmisor.ID,tarjeta.Titular);
        }

        internal void modificar(Tarjeta tj)
        {
            if (tj.numero == "" || tj.numero == null)
            {
                if (tj.codigoDeSeguridad == "" || tj.codigoDeSeguridad == null)
                {
                    DBAdapter.executeProcedure("modificarTarjeta", tj.id, DBNull.Value, DBNull.Value, tj.ultimosCuatroDigitos,
                                                         tj.fechaEmision, tj.fechaVencimiento, tj.Titular, tj.bancoEmisor.ID,
                                                         tj.estado);
                }
                else
                {
                    DBAdapter.executeProcedure("modificarTarjeta", tj.id, DBNull.Value, tj.codigoDeSeguridad, tj.ultimosCuatroDigitos,
                                                         tj.fechaEmision, tj.fechaVencimiento, tj.Titular, tj.bancoEmisor.ID,
                                                         tj.estado);
                }
            }
            else
            {
                if (tj.codigoDeSeguridad == "" || tj.codigoDeSeguridad == null)
                {
                    DBAdapter.executeProcedure("modificarTarjeta", tj.id, tj.numero, DBNull.Value, tj.ultimosCuatroDigitos,
                                                         tj.fechaEmision, tj.fechaVencimiento, tj.Titular, tj.bancoEmisor.ID,
                                                         tj.estado);
                }
                else
                {
                    DBAdapter.executeProcedure("modificarTarjeta", tj.id, tj.numero, tj.codigoDeSeguridad, tj.ultimosCuatroDigitos,
                                                         tj.fechaEmision, tj.fechaVencimiento, tj.Titular, tj.bancoEmisor.ID,
                                                         tj.estado);
                }
            }
        }
    }
}
