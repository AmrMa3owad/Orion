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

    public class Above12Controller : ControllerBase
    {
        private readonly IAbove12Service _above12Service;

        public Above12Controller(IAbove12Service above12Service)
        {
            _above12Service = above12Service;
        }

        [HttpGet]
        public async Task<List<Above12>> Get()
        {
            List<Above12> bookings = await _above12Service
                .GetAll(new CancellationToken()).ToListAsync();

            return bookings;
        }

        [HttpGet("{id}")]
        public async Task<ApiResponse<Above12>> Get(int id)
        {
            ApiResponse<Above12> response = new ApiResponse<Above12>();
            Above12 above12 = await _above12Service
                .Get(id, new CancellationToken());

            if (above12 != null)
            {
                response.Data = above12;
            }
            else
            {
                response.ErrorCode = Shared.Enums.ErrorCodes.NotFound;
            }

            return response;
        }

        [HttpPost]
        public async Task<ApiResponse<Above12>> Create(Above12 model)
        {
            ApiResponse<Above12> response = new ApiResponse<Above12>();

            model = await _above12Service.Create(model);

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
                Above12 entity = await _above12Service
                    .Get(id, new CancellationToken());

                bool deleted = await _above12Service.Delete(entity);

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
