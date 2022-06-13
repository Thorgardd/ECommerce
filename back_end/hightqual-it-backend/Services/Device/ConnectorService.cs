using System.Collections.Generic;
using AutoMapper;
using hightqual_it_backend.Dtos.Motherboard;
using hightqual_it_backend.Interfaces;
using hightqual_it_backend.Models;
using hightqual_it_backend.Models.Detail;
using hightqual_it_backend.Models.Motherboard;

namespace hightqual_it_backend.Services.Device;

public class ConnectorService
{
    private IRepository<Connector> _connectRepo;
    private IRepository<Brand> _brandRepo;
    private readonly IMapper _mapper;

    public ConnectorService(IRepository<Connector> connectorRepository,IRepository<Brand> brandRepository, IMapper mapper)
    {
        _connectRepo = connectorRepository;
        _brandRepo = brandRepository;
        _mapper = mapper;
    }

    #region Get Services

    public IEnumerable<ConnectorDto> GetConnectors()
    {
        var connectors = _connectRepo.GetAll();
        var connectDto = _mapper.Map<IEnumerable<ConnectorDto>>(connectors);
        return connectDto;
    }

    public Connector GetConnectorByName(string name)
    {
        var connector = _connectRepo.SearchOne(n => n.Name == name);
        return connector;
    }

    public IEnumerable<Connector> GetConnectorByNames(string name)
    {
        var connectors = _connectRepo.Search(c => c.Name.Contains(name));
        return connectors;
    }

    #endregion

    #region Post Services

    public ConnectorDto AddConnector(ConnectorDto connectorDto)
    {
        var newConnector = _mapper.Map<Connector>(connectorDto);

        if (newConnector != null)
        {
            newConnector.Name = connectorDto.Name;
            newConnector.Version = connectorDto.Version;
            newConnector.Computer = null;
        }

        var newConnectDto = _mapper.Map<ConnectorDto>(newConnector);
        _connectRepo.Save(newConnector);
        return newConnectDto;
    }

    #endregion

    #region Delete Services

    public bool DelConnector(string name)
    {
        var connectResearch = GetConnectorByName(name);
        if (connectResearch != null)
        {
            _connectRepo.Delete(connectResearch);
            return true;
        }
        return false;
    }

    #endregion
}