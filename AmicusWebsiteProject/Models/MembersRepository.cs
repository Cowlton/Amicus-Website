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
}