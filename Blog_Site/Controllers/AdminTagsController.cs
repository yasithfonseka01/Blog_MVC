using Blog_Site.Data;
using Blog_Site.Models.Domain;
using Blog_Site.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Blog_Site.Controllers
{
    public class AdminTagsController : Controller
    {
        private DB_Context bB_Context;
        public AdminTagsController(DB_Context  dB_Context)
        {
            this.bB_Context = dB_Context;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Add")]
        //public IActionResult SubmitTag(AddTagRequest addTagRequest)
        public IActionResult Add(AddTagRequest addTagRequest)
        {
            //var name = Request.Form["name"];
            //var displayName = Request.Form["displayName"];

            //var name = addTagRequest.Name;
            //var displayName = addTagRequest.DisplayName;

            //Mapping addd tag request to tag domain model
            var tag = new Tag
            {
                Name = addTagRequest.Name,
                DisplayName = addTagRequest.DisplayName,
            };

            bB_Context.Tags.Add(tag);
            bB_Context.SaveChanges();

            return View("Add");

        }
    }
}
