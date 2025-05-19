using Microsoft.AspNetCore.Mvc;

namespace aula1_Controller.controller;

[ApiController]
[Route("[controller]")]

public class WeatherForecastController : ControllerBase{
    [HttpGet]
    public IActionResult Get(){
        var produtos = new List<string>(){
            "Produto 1",
            "Produto 2"
        };
        return Ok(produtos);
    }
}
