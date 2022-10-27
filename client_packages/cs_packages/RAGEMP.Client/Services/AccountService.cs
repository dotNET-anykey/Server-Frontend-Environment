using RAGE;
using RAGE.Ui;

namespace RAGEMP.Client.Services
{
    public class AccountService : Events.Script
    {
        private readonly HtmlWindow _accountWindow = new HtmlWindow("package://CEF/index.html");

        public AccountService()
        {
            _accountWindow.Active = false;
            Input.Bind(VirtualKeys.M, false, () =>
            {
                _accountWindow.Active = _accountWindow.Active != true;
                Cursor.Visible = Cursor.Visible != true;
                Chat.Show(!Cursor.Visible);
            });
        }
    }
}
