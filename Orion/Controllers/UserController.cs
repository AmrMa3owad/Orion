//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Identity.UI.Services;
//using Microsoft.AspNetCore.Mvc;
//using Asp.Versioning;
//using Orion.Common;
//using Orion.Handlers;
//using Orion.Shared.Exceptions;
//using Orion.Infrastructure.Services;
//using Orion.Domain.Models;
//using Orion.Models;
//using AutoMapper;

//namespace Doablelink.FSM.WebApi.Controller
//{
//    [AllowAnonymous]
//    [ApiController]
//    [Route("api/v{version:apiVersion}/[controller]")]
//    [ApiVersion("1.0")]
//    public class UserController : BaseController
//    {
//        private readonly IMapper Mapper;
//        private ITokenHandler _TokenHandler;
//        private readonly IUserService _userService;
//        private readonly IEmailSender _sender;

//        public UserController(
//            IMapper mapper,
//            IUserService userService,
//            ITokenHandler tokenHandler,
//            IEmailSender sender,
//            ILogger<UserController> logger,
//            IClaimHandler claimHandler)
//            : base(logger, claimHandler)
//        {
//             Mapper = mapper;
//            _userService = userService;
//            _TokenHandler = tokenHandler;
//            _sender = sender;
//        }

//        [HttpPost]
//        [Route("Authorize")]
//        public async Task<ApiResponse<UserLoginResponseModel>> Authorize(UserLoginRequestModel model)
//        {
//            ApiResponse<UserLoginResponseModel> apiResponse =
//                new ApiResponse<UserLoginResponseModel>();

//            User? user
//                = await _userService
//                .GetByEmail(
//                    model.Email, new CancellationToken());

//            //Log(LogLevel.Information, "Getting User by Email {0}", model.Email);
//            if (user != null)
//            {
//                //Log(LogLevel.Information, "Check User Email and password {0}", model.Email);

//                try
//                {
//                    var correct
//                   = await _userService
//                   .SignIn(
//                       model.Email, model.Password, new CancellationToken());

//                    if (correct.Succeeded)
//                    {
//                        // Log(LogLevel.Information, "User Email and password {0} are correct", model.Email);
//                        user =
//                            await _userService
//                            .Get(user.Id,
//                            new CancellationToken());
//                        bool inOrg = user.UserRoles.Any();
//                        List<PermissionDTO> permissions = new List<PermissionDTO>();
//                        if (inOrg)
//                        {
//                            List<PermissionDTO> rolePermission = user.UserRoles.First().Role.RolePermissions.Select(x => x.Permission).ToList();
//                            List<PermissionDTO> userPermission = user.UserPermissions.Select(x => x.Permission).ToList();
//                            permissions = rolePermission.Union(userPermission).ToList();
//                        }

//                        Guid? orgId = null;
//                        List<string> roleNames = null;
//                        if (inOrg)
//                        {
//                            roleNames = user.UserRoles
//                                .Select(x => x.Role.Name)
//                                .ToList();

//                            //Handle one Role assignment
//                            //and one organization Assignment per user
//                            //TODO: Handle Multiple organization assignments
//                            orgId = user.UserRoles.First().OrganizationId;
//                        }
//                        // Log(LogLevel.Information, "Generating user token {0}", model.Email);

//                        var tokenString =
//                             _TokenHandler
//                             .GenerateJSONWebToken(user, orgId, roleNames, permissions.Select(p => p.Name).ToList());

//                        //Log(LogLevel.Information, "User Token generated {0}", model.Email);

//                        apiResponse.Data = new UserLoginResponseModel
//                        {
//                            Token = tokenString,
//                            Email = user.Email
//                        };
//                    }
//                    else
//                    {
//                        apiResponse.ErrorCode = Orion.Shared.Enums.ErrorCodes.UserInfoNotMatch;
//                        // Log(LogLevel.Error, "User Email and password {0} are incorrect", model.Email);
//                    }
//                }
//                catch (UserLockedOutException ex)
//                {
//                    apiResponse.ErrorCode = Orion.Shared.Enums.ErrorCodes.UserLockedOut;
//                }
//                catch (UserNotAllowedExecption ex)
//                {
//                    apiResponse.ErrorCode = Orion.Shared.Enums.ErrorCodes.UserNotAllowed;
//                }
//            }
//            else
//            {
//                apiResponse.ErrorCode
//                    = Orion.Shared.Enums.ErrorCodes.UserInfoNotMatch;

//                // Log(LogLevel.Error, "Getting User by Email {0} failed", model.Email);
//            }

//            return apiResponse;
//        }

//        [Authorize]
//        [HttpPost]
//        [Route("Reauthorize")]
//        public async Task<UserLoginResponseModel> Reauthorize()
//        {
//            if (ClaimHandler.UserId != null)
//            {
//                User user
//                = await _userService
//                .Get(ClaimHandler.UserId.Value,
//                     new CancellationToken());

//                //Log(LogLevel.Information, "Getting User by Email {0}", model.Email);
//                if (user != null)
//                {
//                    bool inOrg = user.UserRoles.Any();

//                    Guid? orgId = null;
//                    List<string> roleNames = null;
//                    var rolePermission = user.UserRoles.First().Role.RolePermissions.Select(x => x.Permission).ToList();
//                    var userPermission = user.UserPermissions.Select(x => x.Permission).ToList();
//                    var permissions = rolePermission.Union(userPermission).ToList();
//                    if (inOrg)
//                    {
//                        roleNames = user.UserRoles
//                            .Select(x => x.Role.Name).ToList();
//                        orgId = user.UserRoles.First().OrganizationId;

//                    }
//                    // Log(LogLevel.Information, "Generating user token {0}", model.Email);

//                    var tokenString =
//                        _TokenHandler
//                        .GenerateJSONWebToken(user, orgId, roleNames, permissions.Select(p => p.Name).ToList());

//                    //Log(LogLevel.Information, "User Token generated {0}", model.Email);

//                    UserLoginResponseModel result = new UserLoginResponseModel
//                    {
//                        Token = tokenString,
//                        Email = user.Email
//                    };
//                    return result;
//                }
//                else
//                {
//                    // Log(LogLevel.Error, "User Email and password {0} are incorrect", model.Email);
//                }

//            }
//            else
//            {
//                // Log(LogLevel.Error, "Getting User by Email {0} failed", model.Email);
//            }

//            return null;
//        }

//        [Authorize]
//        [HttpGet]
//        public async Task<ApiResponse<User>> Get(int userId)
//        {
//            ApiResponse<User> response = new ApiResponse<User>();
//            try
//            {
//                User? userDTO = await _userService
//                    .Get(userId, new CancellationToken());
//                if (userDTO != null)
//                {
//                    User userModel = Mapper.Map<User>(userDTO);
//                    response.Data = userModel;
//                }
//            }

//            catch (NotFoundException)
//            {
//                response.ErrorCode = Orion.Shared.Enums.ErrorCodes.NotFound;
//            }
//            return response;
//        }

//        [Authorize]
//        [HttpGet]
//        [Route("GetUsers")]
//        public async Task<List<User>> Get()
//        {
//            if (ClaimHandler.OrgId != null)
//            {
//                List<User> userDTOs
//             = await _userService
//             .GetAll(new CancellationToken(), ClaimHandler.OrgId.Value);

//                return Mapper.Map<List<User>>(userDTOs);
//            }
//            return null;
//        }

//        [Authorize]
//        [HttpPut]
//        public async Task<ApiResponse<User>> Update(User userModel)
//        {
//            ApiResponse<User> apiResponse = new ApiResponse<User>();

//            try
//            {
//                if (ClaimHandler.OrgId != null)
//                {
//                    User userDTO =
//                        Mapper.Map<User>(userModel);

//                    bool updated = await _userService
//                        .Update(userDTO, userModel.Id.Value,
//                        ClaimHandler.OrgId);

//                    if (updated)
//                    {
//                        apiResponse.Data = Mapper.Map<User>(userDTO);
//                    }
//                    else
//                    {
//                        apiResponse.ErrorCode = Orion.Shared.Enums.ErrorCodes.UpdateFailed;
//                    }
//                }
//            }
//            catch (NotFoundException)
//            {
//                apiResponse.ErrorCode = Orion.Shared.Enums.ErrorCodes.NotFound;
//            }

//            return apiResponse;
//        }

//        /// <summary>
//        /// Add User to an organization
//        /// </summary>
//        /// <param name="model"></param>
//        /// <returns></returns>
//        [HttpPost]
//        [Authorize]
//        [Route("AddUser")]
//        public async Task<ApiResponse<User>> Add(User model)
//        {
//            ApiResponse<User> apiResponse = new ApiResponse<User>();

//            try
//            {
//                if (ClaimHandler.OrgId != null)
//                {
//                    User user = Mapper.Map<User>(model);
//                    user.UserRoles.ForEach(ur =>
//                    {
//                        ur.OrganizationId = ClaimHandler.OrgId.Value;
//                        ur.UserId = ClaimHandler.UserId.Value;
//                    });

//                    user = await _userService.Create(user);

//                    if (user.Id == 0)
//                    {
//                        model.Id = user.Id;
//                        apiResponse.Data = model;
//                    }
//                    else
//                    {
//                        apiResponse.ErrorCode = Orion.Shared.Enums.ErrorCodes.CreateFailed;
//                    }
//                }
//            }
//            catch (CreateException ex)
//            {
//                apiResponse.ErrorCode = Orion.Shared.Enums.ErrorCodes.CreateRequiresFields;
//                apiResponse.ErrorMessages = ex.ErrorCodes;
//            }

//            return apiResponse;
//        }


//        [HttpPost]
//        [Authorize]
//        public async Task<ApiResponse<User>> Create(
//         UserRegisterModel model)
//        {
//            ApiResponse<User> apiResponse = new ApiResponse<User>();

//            Log(LogLevel.Information, "CreateUser", "");

//            User user = Mapper.Map<User>(model);
//            try
//            {
//                user = await _userService.Create(user);
//                apiResponse.Data = Mapper.Map<User>(user);

//            }
//            catch (CreateException ex)
//            {
//                apiResponse.ErrorCode = Orion.Shared.Enums.ErrorCodes.CreateRequiresFields;
//                apiResponse.ErrorMessages = ex.ErrorCodes;
//            }

//            return apiResponse;
//        }

//        [Route("SendConfirmationEmail")]
//        [HttpGet]
//        public async Task<ApiResponse<string>> SendConfirmationEmail(
//            string email, string ConfirmEmailUrl)
//        {
//            ApiResponse<string> response = new ApiResponse<string>();

//            User user =
//            await _userService.
//            GetByEmail(email, new CancellationToken());

//            if (user != null)
//            {

//                string code
//                = await _userService
//                .GenerateEmailConfirmationToken(user.Id);

//                //TODO Enable URL Token Validation through Email
//                //string url = Url.Page(
//                //          ConfirmEmailUrl,
//                //          pageHandler: null,
//                //          values: new
//                //          {
//                //              userId = user.Id,
//                //              code = code
//                //          }, protocol: Request.Scheme);

//                //await _sender
//                //    .SendEmailAsync(
//                //    "ai.elhakim@gmail.com",
//                //    "Confirm Email",
//                //    url);

//                response.Data = code;
//            }
//            else
//            {
//                response.ErrorCode = Orion.Shared.Enums.ErrorCodes.NotFound;

//            }


//            return response;
//        }

//        [Route("SendResetPasswordEmail")]
//        [HttpGet]
//        public async Task<ApiResponse<string>> SendResetPasswordEmail(
//            string email, string ResetEmailUrl)
//        {
//            ApiResponse<string> response = new ApiResponse<string>();
//            try
//            {
//                User user =
//              await _userService.
//              GetByEmail(email, new CancellationToken());
//                if (user != null)
//                {
//                    string code = await _userService
//                    .GeneratePasswordResetToken(user.Id);
//                    response.Data = code;
//                }
//                else
//                {
//                    response.ErrorCode = Orion.Shared.Enums.ErrorCodes.NotFound;
//                }
//            }
//            catch (NotFoundException)
//            {
//                response.ErrorCode = Orion.Shared.Enums.ErrorCodes.NotFound;
//            }
//            return response;
//        }

//        [Route("ConfirmEmail")]
//        [HttpPost]
//        public async Task<ApiResponse<IActionResult>> ConfirmEmail(string token, string email)
//        {
//            ApiResponse<IActionResult> response = new ApiResponse<IActionResult>();
//            try
//            {
//                var result = await _userService.ConfirmEmail(email, token);
//            }
//            catch (TokenInvalidException ex)
//            {
//                response.ErrorCode = Orion.Shared.Enums.ErrorCodes.TokenInvalid;
//            }
//            catch (NotFoundException ex)
//            {
//                response.ErrorCode = Orion.Shared.Enums.ErrorCodes.NotFound;
//            }
//            return response;
//        }

//        [Route("ResetPassword")]
//        [HttpPost]
//        public async Task<ApiResponse<IActionResult>> ResetPassword(string token, string email, string password)
//        {
//            ApiResponse<IActionResult> response = new ApiResponse<IActionResult>();
//            try
//            {
//                var result = await _userService.ResetPassword(email, token, password);
//            }
//            catch (TokenInvalidException ex)
//            {
//                response.ErrorCode = Orion.Shared.Enums.ErrorCodes.TokenInvalid;
//            }
//            catch (NotFoundException ex)
//            {
//                response.ErrorCode = Orion.Shared.Enums.ErrorCodes.NotFound;
//            }
//            catch (PasswordRequirementException ex)
//            {
//                response.ErrorCode = Orion.Shared.Enums.ErrorCodes.UserPasswordRequirementNotMet;
//                response.ErrorMessages = ex.Errors;
//            }
//            return response;
//        }

//        [Route("AddPassword")]
//        [HttpPost]
//        public async Task<ApiResponse<bool>> AddPassword(
//          Guid UserId, string password)
//        {
//            ApiResponse<bool> response = new ApiResponse<bool>();
//            try
//            {
//                var result = await _userService
//                 .AddPassword(UserId, password);
//                if (result)
//                {
//                    response.Data = true;
//                }
//                else
//                {
//                    response.ErrorCode = Orion.Shared.Enums.ErrorCodes.UserPasswordNotValid;
//                }
//            }
//            catch (NotFoundException ex)
//            {
//                response.ErrorCode = Orion.Shared.Enums.ErrorCodes.NotFound;
//            }
//            catch (PasswordRequirementException ex)
//            {
//                response.ErrorCode = Orion.Shared.Enums.ErrorCodes.UserPasswordRequirementNotMet;
//                response.ErrorMessages = ex.Errors;
//            }

//            return response;
//        }

//        [Route("ChangePassword")]
//        [Authorize]
//        [HttpPost]
//        public async Task<ApiResponse<bool>> ChangePassword(string currentPassword, string newPassword)
//        {
//            ApiResponse<bool> apiResponse = new ApiResponse<bool>();

//            try
//            {
//                if (ClaimHandler.UserId != null)
//                {
//                    var result = await _userService.ChangePassword(ClaimHandler.UserId.Value, newPassword, currentPassword);

//                    if (result)
//                    {
//                        apiResponse.Data = true;
//                    }
//                    else
//                    {
//                        apiResponse.ErrorCode = Orion.Shared.Enums.ErrorCodes.UserPasswordRequirementNotMet;
//                    }
//                }
//            }
//            catch (PasswordIncorrectException ex)
//            {
//                apiResponse.ErrorCode = Orion.Shared.Enums.ErrorCodes.UserPasswordNotValid;
//            }
//            catch (PasswordRequirementException ex)
//            {
//                apiResponse.ErrorCode = Orion.Shared.Enums.ErrorCodes.UserPasswordRequirementNotMet;
//                apiResponse.ErrorMessages = ex.Errors;
//            }

//            return apiResponse;
//        }


//        [HttpDelete]
//        public async Task<ApiResponse<bool>> Delete(Guid id)
//        {
//            ApiResponse<bool> apiResponse = new ApiResponse<bool>();

//            try
//            {
//                User user = await _userService
//                    .Get(id, new CancellationToken());

//                bool deleted = await _userService.Delete(user);

//                apiResponse.Data = deleted;
//            }
//            catch (NotFoundException ex)
//            {
//                apiResponse.ErrorCode = Orion.Shared.Enums.ErrorCodes.NotFound;
//            }

//            return apiResponse;
//        }
//    }
//}
