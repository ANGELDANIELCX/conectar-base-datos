using Microsoft.AspNetCore.Mvc;
[ApiController]
[Route("conexion")]

public class Conexion : Controller {
    [HttpGet("sql")]
    public IActionResult ListarCarrerasSql(){
        List<CarreraSQL> Lista = new List <CarreraSQL>();
        SqlConnection conn = new SqlConnection(CadenasConexion.SQL_SERVER);
        SqlComand cmd = new SqlComand(" Select IdCarrera, Carrera from carreras ")

        return Ok(lista);
    }

    [HttpGet("mongo")]
    public IActionResult ListarSalonesMongoDb(){
        return Ok("Me estoy conectando MongoDb");
    }
}