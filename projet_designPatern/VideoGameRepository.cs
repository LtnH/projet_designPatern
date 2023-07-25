using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IVideoGameRepository
{
    VideoGame GetById(int id);
    void Save(VideoGame videoGame);
}