using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    //MicroService: Bu servis içerisinde başka bir servisin kullanılması
    class GamerManager : IGamerService
    {
        //Bu sınıf içerisinde doğrulama sınıfını kullanalım
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            // Doğruysa ekle 
            if (_userValidationService.Validation(gamer)==true)
            {
                Console.WriteLine("Kayıt olundu");
            }
            else
            {
                Console.WriteLine("Doğrulamma yapılamadı");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }
    }
}
