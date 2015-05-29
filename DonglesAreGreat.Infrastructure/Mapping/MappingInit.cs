using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonglesAreGreat.Infrastructure.Mapping
{
    public static class Profiles
    {
        public static void Initialize()
        {
            AutoMapper.Mapper.AddProfile<DongleEntityToDongleProfile>();
            AutoMapper.Mapper.AssertConfigurationIsValid();
        }
    }
}
