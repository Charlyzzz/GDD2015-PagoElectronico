using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using PagoElectronico.Domain;

using PagoElectronico.Utils;

using System.Data;



namespace PagoElectronico.Repositories
{

    class ClienteRepository
    {





        internal void darDeBaja(Cliente cliente)
        {

            DBAdapter.executeProcedure("darDeBajaCliente", cliente.ID);

        }


        public List<TipoDocumento> getTipoDocumentosPosta()
        {

            List<TipoDocumento> resultado = DBAdapter.retrieveDataTable("getTipoDoc", DBNull.Value).AsEnumerable().Select(dr => new TipoDocumento(Convert.ToInt32(dr["ID"]), dr["Descripcion"] as string)).ToList();
            
            return resultado;

        }

        public List<TipoDocumento> getTipoDocumentos()
        {

            List<TipoDocumento> resultado = DBAdapter.retrieveDataTable("getTipoDoc", DBNull.Value).AsEnumerable().Select(dr => new TipoDocumento(Convert.ToInt32(dr["ID"]), dr["Descripcion"] as string)).ToList();

            resultado.Add(new TipoDocumento(-1, "Todos los tipos"));

            return resultado;

        }



        public List<Cliente> findClientes(string nombre, string apellido, TipoDocumento tipo_doc, string mail, int? nro_doc)
        {

            return parseClientes(DBAdapter.retrieveDataTable("find_clientes", nombre, apellido, tipo_doc.ID, mail, nro_doc));

        }



        public List<Cliente> getClientes()
        {

            return parseClientes(DBAdapter.retrieveDataTable("getCliente", DBNull.Value));

        }



        public Cliente getCliente(int ID)
        {

            return parse(DBAdapter.retrieveDataTable("getCliente", ID).Rows[0]);

        }

        public Cliente getClienteByUserId(int uID)
        {
            return parse(DBAdapter.retrieveDataTable("getClienteByUserId", uID).Rows[0]);
        }



        private List<Cliente> parseClientes(DataTable dataTable)
        {

            return dataTable.AsEnumerable().Select(dr => parse(dr)).ToList();

        }



        private Cliente parse(DataRow dr)
        {

            return new Cliente(Convert.ToInt32(dr["ID"]),

                               dr["Nombre"] as string,

                               dr["Apellido"] as string,

                               new Documento(getTipoDoc(Convert.ToInt32(dr["Tipo_Documento"])), Convert.ToInt64(dr["Nro_Doc"])),

                               dr["Mail"] as string,
                               new Domicilio(dr["Dom_Calle"] as string, Convert.ToInt32(dr["Dom_Nro"]), dr["Dom_Depto"] as string, Convert.ToInt32(dr["Dom_Piso"]), dr["Localidad"] as string, new PaisRepository().getPais(Convert.ToInt32(dr["Pais"]))),
                               new PaisRepository().getPais(Convert.ToInt32(dr["Nacionalidad"])),
                               Convert.ToDateTime(dr["Fecha_nac"]),

                               (Boolean)dr["Estado"]);



        }



        public static bool coincideDocumento(long tipo, string documento)
        {

            return DBAdapter.checkIfExists("COINCIDE_DOCUMENTO", tipo, documento);

        }

        private TipoDocumento getTipoDoc(int p)
        {

            DataRow tipo = DBAdapter.retrieveDataTable("getTipoDoc", p).Rows[0];

            return new TipoDocumento(Convert.ToInt32(tipo["ID"]), tipo["Descripcion"] as string);

        }



        internal int darDeAlta(Cliente cliente, Usuario usuario)
        {

            return DBAdapter.executeProcedureWithReturnValue("darDeAltaCliente",

            cliente.nombre,

            cliente.apellido,

            cliente.fechaNacimimento,

            cliente.mail,

            cliente.pais.Id,

            cliente.documento.ID,

            cliente.documento.tipo.ID,

            cliente.domicilio.calle,

            cliente.domicilio.numero,

            cliente.domicilio.departamento,

            cliente.domicilio.piso,

            cliente.domicilio.localidad,

            cliente.domicilio.nacionalidad.Id,

            usuario.nombre,

            usuario.password,

            usuario.preguntaSecreta,

            usuario.respuestaSecreta,

            usuario.fechaCreacion,

            usuario.fechaUltimaModificacion);



        }


        internal void modificar(Cliente cliente)
        {
            DBAdapter.executeProcedureWithReturnValue("modificarCliente",

            cliente.ID,

            cliente.nombre,

            cliente.apellido,

            cliente.fechaNacimimento,

            cliente.mail,

            cliente.pais.Id,

            cliente.documento.ID,

            cliente.documento.tipo.ID,

            cliente.domicilio.calle,

            cliente.domicilio.numero,

            cliente.domicilio.departamento,

            cliente.domicilio.piso,

            cliente.domicilio.localidad,

            cliente.domicilio.nacionalidad.Id,

            cliente.estado);
        }
    }

}

