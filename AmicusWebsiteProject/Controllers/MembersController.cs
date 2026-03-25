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
    
    public IActionResult ViewMember(int id)
    {
        var Member = repo.GetMember(id);
        
        return View(Member);
    }

    public IActionResult AddProfileImage(int id)
    {
        board_members member = repo.GetMember(id);
        if (member == null)
        {
            return NotFound();
        }
        return View(member);
    }
    
    
}