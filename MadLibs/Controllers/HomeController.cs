using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Selector() { return View(); }


    [Route("/TeacherForm")]
    public ActionResult TeacherForm() { return View(); }

    [Route("/teachermadlib")]
    public ActionResult TeacherMadLib(string teacherName, string adjective, string programmingLanguage, string adjective2)
    {
      MadLibVariable newMadlibVariable = new MadLibVariable();
      newMadlibVariable.TeacherName = teacherName;
      newMadlibVariable.Adjective = adjective;
      newMadlibVariable.ProgrammingLanguage = programmingLanguage;
      newMadlibVariable.Adjective2 = adjective2;
      return View(newMadlibVariable);
    }
  }
}
