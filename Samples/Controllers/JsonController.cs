using Microsoft.AspNetCore.Mvc;

namespace ActionResultsSamples.Controllers
{
    public class JsonController : Controller
    {
        Client[] clients = new Client[] {
                new Client(){Id=1,Email = "1@gmail.com", Login="Login1" },
                new Client(){Id=2,Email = "2@gmail.com", Login="Login2" },
                new Client(){Id=3,Email = "3@gmail.com", Login="Login3" },
                new Client(){Id=4,Email = "4@gmail.com", Login="Login4" },
                new Client(){Id=5,Email = "5@gmail.com", Login="Login5" },
                new Client(){Id=6,Email = "6@gmail.com", Login="Login6" },
                new Client(){Id=7,Email = "7@gmail.com", Login="Login7" },
                new Client(){Id=8,Email = "8@gmail.com", Login="Login8" },
                new Client(){Id=9,Email = "9@gmail.com", Login="Login9" },
                new Client(){Id=10,Email = "10@gmail.com", Login="Login10" },
            };

        public Client[] GetData()
        {
            return clients;
        }

        public IActionResult Index()
        {
            return View();
        }

        //    public IActionResult ClientInfo()
        //    {
        //        var client = new Client()
        //        {
        //            Id = 100,
        //            Login = "user1",
        //            Email = "user1@example.com"
        //        };

        //        // Json - Сериализует объект переданный в параметрах в JSON и возвращает клиенту ответ.
        //        return Json(client);
        //    }

        //    public IActionResult ClientInfo2()
        //    {
        //        // использование анонимных типов для формирования JSON ответа
        //        return Json(new
        //        {
        //            Id = 100,
        //            Login = "user1",
        //            Email = "user1@example.com"
        //        });
        //    }
    }

    public class Client
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
    }
}
