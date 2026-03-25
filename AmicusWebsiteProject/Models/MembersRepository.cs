using System.Data;
using Dapper;

namespace AmicusWebsiteProject.Models;

public class MembersRepository : IMembersRepository
{
    
    public readonly IDbConnection _conn;

    public MembersRepository(IDbConnection conn)
    {
        _conn = conn;
    }
    
    public IEnumerable<board_members> GetALlBoardMembers()
    {
        return _conn.Query<board_members>("SELECT * FROM Board_Members;");
    }

    public board_members GetMember(int id)
    {
        return _conn.QuerySingle<board_members>("SELECT * FROM Board_Members WHERE MemberID = @id", new {id});
    }
    
    public void UpdateProfileImage(board_members member, string url)
    {
        _conn.Execute("UPDATE products SET MemberImage = @MemberImage",
            new {MemberImage = url});
    }
    
}