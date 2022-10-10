using BtbDomain.Configuration;
using BtbDomain.Controller;
using BtbDomain.DTOs;
using BtbService.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BtbApi.Controllers.Base
{
    [ApiController]
    public class BaseController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IActiveUserService _activeUserService;
        public readonly AppSettings AppSettings;

        private ActiveUserDTO _activeUser;
        public ActiveUserDTO ActiveUser
        {
            get
            {
                if (_activeUser == null)
                {
                    var taskUser = _activeUserService.GetUser();
                    taskUser.Wait();
                    _activeUser = taskUser.Result;
                }

                return _activeUser;
            }
        }


        public BaseController(IConfiguration configuration, IActiveUserService activeUserService)
        {
            _configuration = configuration;
            _activeUserService = activeUserService;

            this.AppSettings = AppSettings.loadAppSettings(configuration);
        }
        protected IActionResult Error(string message, string detailed = null)
        {
            return new JsonResult(new ErrorResponse()
            {
                Message = message,
                Detailed = detailed
            });
        }
        protected IActionResult Error(Exception exception)
        {
            return new JsonResult(new ErrorResponse(exception))
            {
                StatusCode = StatusCodes.Status500InternalServerError
            };
        }
    }
}
