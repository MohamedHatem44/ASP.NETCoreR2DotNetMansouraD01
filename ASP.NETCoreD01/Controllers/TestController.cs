using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCoreD01.Controllers
{
    public class TestController : Controller
    {
        /*------------------------------------------------------------------*/
        // Actions
        //public IActionResult Index()
        //{
        //    return View();
        //}
        /*------------------------------------------------------------------*/
        // Actions Rules
        // 1- Actions must be public - Can't be private, protected, or internal
        // 2- Actions Can't be static - Can't be static methods
        // 3- Actions Can't be overloaded - Can't have 2 Actions with same name
        /*------------------------------------------------------------------*/
        // Action
        // Controller/Action
        // https://localhost:7117/Test/ShowHello1
        public string ShowHello1()
        {
            return "Hello from ShowHello1 Action";
        }
        /*------------------------------------------------------------------*/
        //// Action
        //// Controller/Action
        //// https://localhost:7117/Test/ShowHello1/5
        //// No Overloading Allowed for Actions
        //public string ShowHello1(int id)
        //{
        //    return $"Hello from ShowHello1 Action with ID: {id}";
        //}
        /*------------------------------------------------------------------*/
        // Action
        // Controller/Action
        // https://localhost:7117/Test/ShowHello2
        public ContentResult ShowHello2()
        {
            // Decalre Object
            ContentResult contentResult = new ContentResult();

            // Set Return
            contentResult.Content = "Hello from ShowHello2 Action";

            // Return Object
            return contentResult;
        }
        /*------------------------------------------------------------------*/
        // Action
        // Controller/Action
        // https://localhost:7117/Test/ShowHello3
        public JsonResult ShowHello3()
        {
            // Decalre Object and Set Return
            JsonResult jsonResult = new JsonResult(new { Message = "Hello from ShowHello3 Action" });


            // Return Object
            return jsonResult;
        }
        /*------------------------------------------------------------------*/
        // Action
        // Controller/Action
        // https://localhost:7117/Test/ShowHello4
        public ViewResult ShowHello4()
        {
            // Decalre Object 
            ViewResult viewResult = new ViewResult();

            // Set Return
            viewResult.ViewName = "ShowHello4";

            // Return Object
            return viewResult;
        }
        /*------------------------------------------------------------------*/
        // Action
        // Controller/Action
        // https://localhost:7117/Test/ShowHello5
        public IActionResult ShowHello5(int id)
        {
            if (id % 2 == 0)
            {
                // Decalre Object
                ContentResult contentResult = new ContentResult();

                // Set Return
                contentResult.Content = "Hello from ShowHello2 Action";

                // Return Object
                return contentResult;
            }
            else
            {
                // Decalre Object 
                ViewResult viewResult = new ViewResult();

                // Set Return
                viewResult.ViewName = "ShowHello4";

                // Return Object
                return viewResult;
            }
        }
        /*------------------------------------------------------------------*/
        // Action
        // Controller/Action
        // https://localhost:7117/Test/ShowHello6
        public ViewResult ShowHello6()
        {
            return View("ShowHello6");
        }
        /*------------------------------------------------------------------*/
        // Action
        // Controller/Action
        // https://localhost:7117/Test/ShowHello7
        public ViewResult ShowHello7()
        {
            // Best Practice
            // View Name should be same as Action Name
            return View();
        }
        /*------------------------------------------------------------------*/
        // Types of Action Results (Return)
        // 1- Content "String"            => ContentResult
        // 2- View "ShowHello.cshtml"     => ViewResult
        // 3- JavaScript                  => JavaScriptResult
        // 4- Json                        => JsonResult
        // 5- File                        => FileResult
        // 6- Redirect                    => RedirectResult
        // 7- Not Found                   => NotFoundResult
        /*------------------------------------------------------------------*/
        // Action
        // Controller/Action
        // https://localhost:7117/Test/ShowHello8
        public ViewResult ShowHello8()
        {
            // Best Practice
            // View Name should be same as Action Name
            return View();
        }
        /*------------------------------------------------------------------*/
    }
}
