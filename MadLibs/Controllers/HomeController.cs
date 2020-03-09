using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form() { return View(); }
    
    [Route("/madlib")]
    public ActionResult MadLib(string teacherName, string adjective, string programmingLanguage, string adjective2)
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
