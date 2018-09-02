using AutoMapper;
using DAL.Dto;
using DAL.Entities;
using DAL.Entities.QueryParameters;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Dynamic.Core;
using AutoMapper.QueryableExtensions;

namespace BLL.Services
{
    public class ClientTypeService : IClientTypeService
    {
        private IEthioRemitEntitiesRepository<ClientTypes> _clientTypeRepository;

        public ClientTypeService(IEthioRemitEntitiesRepository<ClientTypes> clientTypeRepository)
        {
            _clientTypeRepository = clientTypeRepository;
        }

        public async Task<(bool created, ClientTypes clientType)> CreateClientType(ClientTypeDto clientTypeDto)
        {
            var clientType = Mapper.Map<ClientTypes>(clientTypeDto);
            if (clientTypeDto.ClientTypeId == Guid.Empty)
                clientType.SetNewId();
            var result = await _clientTypeRepository.Add(clientType);

            return (result, clientType);
        }

        public async Task<(bool deleted, ClientTypes clientType)> DeleteClientType(Guid clientTypeId)
        {
            var existingClientType = await _clientTypeRepository.GetSingle(clientTypeId);
            if (existingClientType == null)
            {
                return (false, null);
            }

            var result = await _clientTypeRepository.Delete(existingClientType);

            return (result, existingClientType);
        }

        public (IEnumerable<ClientTypeDto> clientTypes, int totalCount) GetAllClientTypes(Pagination pagination)
        {
            IQueryable<ClientTypes> allClientTypes = _clientTypeRepository.GetAll().Where(q => q.IsDeleted == false)
               .OrderBy(pagination.OrderBy, pagination.Descending);

            if (pagination.HasQuery)
            {
                allClientTypes = allClientTypes.Where(t => t.Name.Contains(pagination.Query.ToLowerInvariant()));
            }

            allClientTypes.Skip(pagination.PageCount * (pagination.Page - 1))
                .Take(pagination.PageCount);

            var allClientTypesDto = allClientTypes.ProjectTo<ClientTypeDto>();

            //var allClientTypesDto = allClientTypesList.Select(t => Mapper.Map<ClientTypeDto>(t));
            return (allClientTypesDto, allClientTypes.Count());
        }

        public async Task<ClientTypeDto> GetClientType(Guid clientTypeId)
        {
            var clientType = await _clientTypeRepository.GetSingle(clientTypeId);

            var clientTypeDto = Mapper.Map<ClientTypeDto>(clientType);

            return clientTypeDto;
        }

        public async Task<(bool updated, ClientTypes clientType)> UpdateClientType(Guid clientTypeId, ClientTypeDto clientTypeDto)
        {
            var existingClientType = await _clientTypeRepository.GetSingle(clientTypeId);

            if (existingClientType == null)
            {
                return (false, null);
            }

            Mapper.Map(clientTypeDto, existingClientType);

            var result = await _clientTypeRepository.Update(existingClientType);

            return (result, existingClientType);
        }
    }
}
