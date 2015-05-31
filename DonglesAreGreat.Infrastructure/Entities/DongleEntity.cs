using System;
using System.Collections.Specialized;

namespace DonglesAreGreat.Infrastructure.Entities
{
    public class DongleEntity
    {
        public DongleEntity()
        {
            Name = "Foo";
            Color = "Barish";
            Sku = "GC123";
            var r = new Random();
            IsBroken = r.Next(1000) % 2 == 0;
            DeviceInfo = new NameValueCollection
            {
                {"Manufacturer", "Always Great Inc."},
                {"Serial", "888222111"},
                {"Assembly Date", "20/05/2015"}
            };
        }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Sku { get; set; }
        public bool IsBroken { get; set; }
        public string Owner { get; set; }

        public NameValueCollection DeviceInfo { get; set; }

    }
}