using Microsoft.AspNetCore.Mvc;
using TennisCourtBooking.Domain.Models;

[Route("api/tennis-courts")]
[ApiController]
public class TennisCourtsController : ControllerBase
{
    private readonly ITennisCourtService _tennisCourtService;

    public TennisCourtsController(ITennisCourtService tennisCourtService)
    {
        _tennisCourtService = tennisCourtService;
    }

    [HttpGet]
    public IActionResult GetTennisCourts()
    {
        var tennisCourts = _tennisCourtService.GetAllTennisCourts();
        return Ok(tennisCourts);
    }

    [HttpPost]
    public async Task<IActionResult> CreateTennisCourt([FromBody] TennisCourt model)
    {
        var result = await _tennisCourtService.CreateTennisCourtAsync(model);

        if (result.Success)
        {
            return Ok(result);
        }

        return BadRequest(result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateTennisCourt(int id, [FromBody] TennisCourt model)
    {
        var result = await _tennisCourtService.UpdateTennisCourtAsync(id, model);

        if (result.Success)
        {
            return Ok(result);
        }

        return BadRequest(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTennisCourt(int id)
    {
        var result = await _tennisCourtService.DeleteTennisCourtAsync(id);

        if (result.Success)
        {
            return Ok(result);
        }

        return BadRequest(result);
    }
}
