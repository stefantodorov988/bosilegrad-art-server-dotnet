using AutoMapper;

namespace bosilegrad_art_server_dotnet.Application.Common.Mappings;

public interface IMapFrom<T>
{
    void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType());
}
