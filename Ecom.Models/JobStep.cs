using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Models
{
    public enum JobStep
    {
        PRC, 
        Plate_Making,
        Plate_Heating,
        Printing,
        Gathering,
        Handfold_Stitching,
        Machine_stitching,
        Covering,
        Binding,
        Cutting,
            Packing,
        
    }
}
//Pre-press- prc,plate making and heating
//press- printing 
//, post press- folding,gathering(bhag uthaune),stitching,covering,cutting } - binding
//Packing,