namespace DonglesAreGreat.Infrastructure.Mapping
{
    public static class AutoMapperConfiguration
    {
        public static void Initialize()
        {
            AutoMapper.Mapper.AddProfile<DongleEntityToDongleProfile>();
            
            AutoMapper.Mapper.AssertConfigurationIsValid();
        }
    }
}