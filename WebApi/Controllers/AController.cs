using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
  public abstract class AController : ControllerBase
  {
    protected bool OperacaoValida { get; set; }
    public AController()
    {

    }

    protected ActionResult CustomResponse(object objeto = null)
    {
      if (OperacaoValida)
        return Ok(new
        {
          success = true,
          data = objeto
        });

      return BadRequest(new
      {
        success = false,
        data = objeto
      });
    }
  }
}
