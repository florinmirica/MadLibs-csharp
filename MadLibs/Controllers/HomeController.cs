using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/madlibs")]
    public ActionResult MadLibs(string name, string sillyword, string lastname, string illness, string nounplural, string adjective, string adjective2, string sillyword2, string place, string number, string adjective3)
    {
      MadLibsVariable madLibs = new MadLibsVariable();
      madLibs.SetName(name);
      madLibs.SetSillyWord(sillyword);
      madLibs.SetLastName(lastname);
      madLibs.SetIllness(illness);
      madLibs.SetNounPlural(nounplural);
      madLibs.SetAdjective(adjective);
      madLibs.SetAdjective2(adjective2);
      madLibs.SetSillyWord2(sillyword2);
      madLibs.SetPlace(place);
      madLibs.SetNumber(number);
      madLibs.SetAdjective3(adjective3);
      return View(madLibs);
    }

  }
}
