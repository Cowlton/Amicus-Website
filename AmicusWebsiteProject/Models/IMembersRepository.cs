namespace AmicusWebsiteProject.Models;

public interface IMembersRepository
{
    public IEnumerable<board_members> GetALlBoardMembers();
}