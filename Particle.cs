using System;
using System.Collections.Generic;
using System.Text;

namespace Vertisan.Nebula.Entities
{
    public class Particle : IParticle
    {
        public string ParticleId { get; set; }
        public long gMass { get; set; }
    }
}
