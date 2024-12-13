using Application.Projects.DTOs;
using AutoMapper;

namespace Application.Projects.Profiles;

public class ProjectProfiles : Profile
{
    public ProjectProfiles()
    {
        CreateMap<Domain.Model.Project, ProjectDto>();
        CreateMap<CreateProjectDto, ProjectDto>();
        CreateMap<UpdateProjectDto, ProjectDto>();
    }
}
