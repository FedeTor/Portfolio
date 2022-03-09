using Microsoft.Extensions.Configuration;
using PaginaAbove.Models;
using System.Threading.Tasks;

namespace PaginaAbove.Servicios
{
    //public class ServicioEnvioDatos : IServicioEnviarDatos
    //{
    //    private readonly IConfiguration _configuration;
    //    public ServicioEnvioDatos(IConfiguration configuration)
    //    {
    //        _configuration = configuration;            
    //    }

    //    private SqlConnection con;
    //    private void Conectar()
    //    {
    //        string constr = _configuration.GetConnectionString("DefaultConnection");
    //        con = new SqlConnection(constr);
    //    }

    //    public Task<EnvioDatos> EnviarDatosAsync(EnvioDatos enviodatos)
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    public int EnvioDatos(EnvioDatos enviodatos)
    //    {
    //        Conectar();
    //        SqlCommand comando = new SqlCommand("insert into articulos(codigo,descripcion,precio) values (@codigo,@descripcion,@precio)", con);
    //        comando.Parameters.Add("@codigo", SqlDbType.Int);
    //        comando.Parameters.Add("@descripcion", SqlDbType.VarChar);
    //        comando.Parameters.Add("@precio", SqlDbType.Float);
    //        comando.Parameters["@codigo"].Value = art.Codigo;
    //        comando.Parameters["@descripcion"].Value = art.Descripcion;
    //        comando.Parameters["@precio"].Value = art.Precio;
    //        con.Open();
    //        int i = comando.ExecuteNonQuery();
    //        con.Close();
    //        return i;
    //    }
    //}
}
