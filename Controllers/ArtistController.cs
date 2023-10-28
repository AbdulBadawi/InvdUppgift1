using InvdUppgift1.Modelss.HP.Documents.GitHub.InvdUppgift1;
using Microsoft.AspNetCore.Mvc;

namespace InvdUppgift1.Controllers;

[ApiController]
[Route("[controller]")]

public class ArtistController : ControllerBase
{
    private readonly ArtistdbContext _DBContext;
  public ArtistController(ArtistdbContext dBContext)
  {
    this._DBContext = dBContext;
  }

  [HttpGet(Name = "Getartist")]
  public IActionResult Get()
  {
    var ArtistId = Request.Query["ArtistId"].ToString();
    
    var ArtistName = Request.Query["ArtistName"].ToString();
    
    var Description = Request.Query["Description"].ToString();
   
      
   return Ok (ArtistId + ArtistName + Description);    
  

  }

 

    [HttpPost(Name = "PostArtist")]
  public IActionResult Post()
  {
    return Ok();
  }
}