using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface ITick
{
    void Tick();

    void FixedTick();

    void LateTick();
}