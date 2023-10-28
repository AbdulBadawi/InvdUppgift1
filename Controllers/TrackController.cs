using InvdUppgift1.Modelss.HP.Documents.GitHub.InvdUppgift1;
using Microsoft.AspNetCore.Mvc;

namespace InvdUppgift1.Controllers;

[ApiController]
[Route("[controller]")]

public class TrackController : ControllerBase
{
    private readonly ArtistdbContext _DBContext;
  public TrackController(ArtistdbContext dBContext)
  {
    this._DBContext = dBContext;
  }

  [HttpGet(Name = "GetTrack")]
  public IActionResult Get()
  {
    var TrackId = Request.Query["TrackId"].ToString();
    
    var Title = Request.Query["Title"].ToString();
    
    var TrackNumber = Request.Query["TrackNumber"].ToString();
   
    var AlbumId = Request.Query["AlbumId"].ToString();    
   return Ok (TrackId + Title + TrackNumber + AlbumId);    
  

  }

 

    [HttpPost(Name = "PostTrack")]
  public IActionResult Post()
  {
    return Ok();
  }
}