using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Examen3_Lilliam.Clases
{
    public class ClaseEncuesta
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }

        private void BindGrid()
        {
            using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-BCS0DN23\\SQL2022;Initial Catalog=BD_Lilliam;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Encuesta", con))
                {
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    GridViewEncuesta.DataSource = rdr;
                    GridViewEncuesta.DataBind();
                }
            }
        }

        protected void btnAgregarEquipo_Click(object sender, EventArgs e)
        {
            // Datos del nuevo equipo
            string Nombre = ObtenerNuevoNombre();
            string CorreoElectronico = ObtenerNuevoCorreoElectronico();
            int IDencuesta = ObtenerNuevoIDencuesta();

            // Inserta el nuevo equipo en la base de datos
            using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-BCS0DN23\\SQL2022;Initial Catalog=BD_Lilliam;Integrated Security=True"))
            {
                con.Open();
                string query = "INSERT INTO Encuesta(Nombre, CorreoElectronico , IDencuesta) VALUES (@Nombre, @CorreoElectronico, @IDencuesta)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Nombre", Nombre);
                    cmd.Parameters.AddWithValue("@CorreoElectronico", CorreoElectronico);
                    cmd.Parameters.AddWithValue("@IDencuesta", IDencuesta);
                    cmd.ExecuteNonQuery();
                }
            }

            // Actualiza la GridView
            BindGrid();
        }

        // Métodos auxiliares para obtener datos
        private string ObtenerNuevoNombre()
        {
            return "NuevoNombre";
        }

        private string ObtenerNuevo()
        {
            return "NuevoCorreoElectronico";
        }

        private int ObtenerIDencuestao()
        {
            return 1;
        }

        protected void GridViewEquipos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewEncuestas.EditIndex = e.NewEditIndex;
            BindGrid();
        }

        protected void GridViewEquipos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewEncuestas.EditIndex = -1;
            BindGrid();
        }

      

       
    }
}