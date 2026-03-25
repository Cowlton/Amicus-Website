namespace AmicusWebsiteProject.Models;

public interface IMembersRepository
{
    public IEnumerable<board_members> GetALlBoardMembers();
    public board_members GetMember(int id);
}