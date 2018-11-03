using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabJoker
{
    public interface IStorable
    {
        List<int> List { get; set; }
        int Joker { get; set; }

        List<int> GenerateRaNdomNumbers();
        int GenerateJoker();
    }
}
