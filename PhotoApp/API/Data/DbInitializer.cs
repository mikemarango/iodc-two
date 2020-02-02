using DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationContext context)
        {
            if (context.Photos.Any()) return;

            var photos = new Photo[]
            {
                new Photo()
                {
                    //ID = 1,
                    Title = "An image by Frank",
                    Filename = "3fbe2aea-2257-44f2-b3b1-3d8bacade89c.jpg",
                    OwnerId = "d860efca-22d9-47fd-8249-791ba61b07c7"
                },
                new Photo()
                {
                    //ID = 2,
                    Title = "An image by Frank",
                    Filename = "43de8b65-8b19-4b87-ae3c-df97e18bd461.jpg",
                    OwnerId = "d860efca-22d9-47fd-8249-791ba61b07c7"
                },
                new Photo()
                {
                    //ID = 3,
                    Title = "An image by Frank",
                    Filename = "46194927-ccda-432f-bc95-4820318c08c7.jpg",
                    OwnerId = "d860efca-22d9-47fd-8249-791ba61b07c7"
                },
                new Photo()
                {
                    //ID = 4,
                    Title = "An image by Frank",
                    Filename = "4cdd494c-e6e1-4af1-9e54-24a8e80ea2b4.jpg",
                    OwnerId = "d860efca-22d9-47fd-8249-791ba61b07c7"
                },
                new Photo()
                {
                    //ID = 5,
                    Title = "An image by Frank",
                    Filename = "5c20ca95-bb00-4ef1-8b85-c4b11e66eb54.jpg",
                    OwnerId = "d860efca-22d9-47fd-8249-791ba61b07c7"
                },
                new Photo()
                {
                    //ID = 6,
                    Title = "An image by Frank",
                    Filename = "6b33c074-65cf-4f2b-913a-1b2d4deb7050.jpg",
                    OwnerId = "d860efca-22d9-47fd-8249-791ba61b07c7"
                },
                new Photo()
                {
                    //ID = 7,
                    Title = "An image by Frank",
                    Filename = "7e80a4c8-0a8a-4593-a16f-2e257294a1f9.jpg",
                    OwnerId = "d860efca-22d9-47fd-8249-791ba61b07c7"
                },
                new Photo()
                {
                    //ID = 8,
                    Title = "An image by Claire",
                    Filename = "8d351bbb-f760-4b56-9d4e-e8d61619bf70.jpg",
                    OwnerId = "b7539694-97e7-4dfe-84da-b4256e1ff5c7"
                },
                new Photo()
                {
                    //ID = 9,
                    Title = "An image by Claire",
                    Filename = "b2894002-0b7c-4f05-896a-856283012c87.jpg",
                    OwnerId = "b7539694-97e7-4dfe-84da-b4256e1ff5c7"
                },
                new Photo()
                {
                    //ID = 10,
                    Title = "An image by Claire",
                    Filename = "cc412f08-2a7b-4225-b659-07fdb168302d.jpg",
                    OwnerId = "b7539694-97e7-4dfe-84da-b4256e1ff5c7"
                },
                new Photo()
                {
                    //ID = 11,
                    Title = "An image by Claire",
                    Filename = "cd139111-c82e-4bc8-9f7d-43a1059bfe73.jpg",
                    OwnerId = "b7539694-97e7-4dfe-84da-b4256e1ff5c7"
                },
                new Photo()
                {
                    //ID = 12,
                    Title = "An image by Claire",
                    Filename = "dc3f39bf-d1da-465d-9ea4-935902c2e3d2.jpg",
                    OwnerId = "b7539694-97e7-4dfe-84da-b4256e1ff5c7"
                },
                new Photo()
                {
                    //ID = 13,
                    Title = "An image by Claire",
                    Filename = "e0e32179-109c-4a8a-bf91-3d65ff83ca29.jpg",
                    OwnerId = "b7539694-97e7-4dfe-84da-b4256e1ff5c7"
                },
                new Photo()
                {
                    //ID = 14,
                    Title = "An image by Claire",
                    Filename = "fdfe7329-e05c-41fb-a7c7-4f3226d28c49.jpg",
                    OwnerId = "b7539694-97e7-4dfe-84da-b4256e1ff5c7"
                }
            };

            context.AddRange(photos);
            context.SaveChanges();
        }
    }
}
