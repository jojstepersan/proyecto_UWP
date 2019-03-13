using EncounterChatBoot.Services;
using EncounterChatBoot.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EncounterChatBoot.ViewModels
{
    class LoginViewModel : ViewModelBase
    {
        public LoginViewModel(ILoginService loginService, ISettingsService settingsService, ICommonServices commonServices) : base(commonServices)
        {
            LoginService = loginService;
            SettingsService = settingsService;
        }

        public ILoginService LoginService { get; }
        public ISettingsService SettingsService { get; }

        private ShellArgs ViewModelArgs { get; set; }
    }
}
