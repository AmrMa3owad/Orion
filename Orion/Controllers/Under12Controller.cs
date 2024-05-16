using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Orion.Common;
using Orion.Domain.Models;
using Orion.Infrastructure.Services;
using Orion.Shared.Exceptions;

namespace Orion.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]

    public class Under12Controller : ControllerBase
    {
        private readonly IUnder12Service _under12Service;

        public Under12Controller(IUnder12Service under12Service)
        {
            _under12Service = under12Service;
        }

        [HttpGet]
        public async Task<List<Under12>> Get()
        {
            List<Under12> bookings = await _under12Service
                .GetAll(new CancellationToken()).ToListAsync();

            return bookings;
        }

        [HttpGet("{id}")]
        public async Task<ApiResponse<Under12>> Get(int id)
        {
            ApiResponse<Under12> response = new ApiResponse<Under12>();
            Under12 under12 = await _under12Service
                .Get(id, new CancellationToken());

            if (under12 != null)
            {
                response.Data = under12;
            }
            else
            {
                response.ErrorCode = Shared.Enums.ErrorCodes.NotFound;
            }

            return response;
        }

        [HttpPost]
        public async Task<ApiResponse<Under12>> Create(Under12 model)
        {
            ApiResponse<Under12> response = new ApiResponse<Under12>();

            model = await _under12Service.Create(model);

            response.Data = model;

            if (response.Data == null)
            {
                response.ErrorCode = Shared.Enums.ErrorCodes.CreateFailed;
            }

            return response;
        }

        [HttpDelete("{id}")]
        public async Task<ApiResponse<bool>> Delete(int id)
        {
            ApiResponse<bool> response = new ApiResponse<bool>();

            try
            {
                Under12 entity = await _under12Service
                    .Get(id, new CancellationToken());

                bool deleted = await _under12Service.Delete(entity);

                if (deleted)
                {
                    response.Data = deleted;
                }
                else
                {
                    response.ErrorCode = Shared.Enums.ErrorCodes.DeleteFailed;
                }
            }
            catch (NotFoundException)
            {
                response.ErrorCode = Shared.Enums.ErrorCodes.NotFound;
            }

            return response;
        }
    }
}
