using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicInstruments
{
    public interface IMusicalInstrument
    {
        string Name { get; }
        string Characteristics { get; }
        void Sound();
        void Show();
        void Desc();
        void History();
    }
}
