using DAL.Dto;
using DAL.Entities;
using DAL.Entities.QueryParameters;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Services
{
    public interface IClientTypeService
    {
        Task<(bool created, ClientTypes clientType)> CreateClientType(ClientTypeDto clientTypeDto);
        Task<(bool updated, ClientTypes clientType)> UpdateClientType(Guid clientTypeId, ClientTypeDto clientTypeDto);
        Task<(bool deleted, ClientTypes clientType)> DeleteClientType(Guid clientTypeId);
        Task<ClientTypeDto> GetClientType(Guid clientTypeId);
        (IEnumerable<ClientTypeDto> clientTypes, int totalCount) GetAllClientTypes(Pagination pagination);
    }
}
