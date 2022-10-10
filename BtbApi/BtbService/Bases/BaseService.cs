using BtbDomain.Configuration;
using BtbDomain.DTOs;
using BtbService.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtbService.Bases
{
    public class BaseService
    {
        public readonly AppSettings AppSettings;

        public readonly IConfiguration Configuration;

        public readonly IActiveUserService ActiveUserService;

        private ActiveUserDTO _activeUser;
        public ActiveUserDTO ActiveUser
        {
            get
            {
                if (_activeUser == null && ActiveUserService != null)
                {
                    var taskUser = ActiveUserService.GetUser();
                    taskUser.Wait();
                    _activeUser = taskUser.Result;
                }

                return _activeUser;
            }
        }

        public BaseService(IConfiguration configuration, IActiveUserService activeUserService)
        {
            this.Configuration = configuration;
            this.AppSettings = AppSettings.loadAppSettings(configuration);
            this.ActiveUserService = activeUserService;
        }
    }
}
