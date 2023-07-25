using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class VideoGameController
{
    private readonly IVideoGameRepository repository;

    public VideoGameController(IVideoGameRepository repository)
    {
        this.repository = repository;
    }

    public IActionResult GetById(int id)
    {
        var videoGame = repository.GetById(id);
        if (videoGame == null)
        {
            return new NotFoundResult();
        }
        return new OkResult(videoGame);
    }
}
