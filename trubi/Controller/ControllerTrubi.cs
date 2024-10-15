using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trubi.Model;
using trubi.View;

namespace trubi.Controller
{
    public class ControllerTrubi
    {
         ModelTrubi model=new ModelTrubi();
         Display display = new Display();
        public ControllerTrubi()
        {
            display.Input();
            model.Obem = display.Obem;
            model.P1 = display.P1;
            model.P2 = display.P2;
            model.H = display.H;
            display.Output();
        }

    }
}

