using EpinelPS.Utils;
using EpinelPS.Database;
namespace EpinelPS.LobbyServer.LobbyUser
{
    [PacketPath("/lobby/usertitle/set")]
    public class SetUserTitleData : LobbyMsgHandler
    {
        protected override async Task HandleAsync()
        {
            var req = await ReadData<ReqSetUserTitle>();
			var user = GetUser();
			user.TitleId = req.UserTitleId;
			JsonDb.Save();
            var response = new ResSetUserTitle();

            await WriteDataAsync(response);
        }
    }
}
