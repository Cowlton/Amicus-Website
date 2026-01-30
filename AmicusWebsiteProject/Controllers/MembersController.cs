using AmicusWebsiteProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace AmicusWebsite;

public class MembersController : Controller
{
    private readonly IMembersRepository repo;

    public MembersController(IMembersRepository repo)
    {
        this.repo = repo;
    }


    public IActionResult Index()
    {
        var Members = repo.GetALlBoardMembers();
        return View(Members);
    }
}