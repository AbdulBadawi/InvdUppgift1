using InvdUppgift1.Modelss.HP.Documents.GitHub.InvdUppgift1;
using Microsoft.AspNetCore.Mvc;

namespace InvdUppgift1.Controllers;

[ApiController]
[Route("[controller]")]

public class AlbumController : ControllerBase
{
    private readonly ArtistdbContext _DBContext;
  public AlbumController(ArtistdbContext dBContext)
  {
    this._DBContext = dBContext;
  }

  [HttpGet(Name = "GetAlbum")]
  public IActionResult Get()
  {
    using (var context = new ArtistdbContext())
    {
      return (IActionResult)context.Albuminfo.ToList();
    }

  }

 

    [HttpPost(Name = "PostAlbum")]
  public IActionResult Post()
  {
    return Ok();
  }
}