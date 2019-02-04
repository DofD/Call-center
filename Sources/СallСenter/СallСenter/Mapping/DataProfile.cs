using AutoMapper;
using СallСenter.Core.Tasks;
using СallСenter.Data.Tasks;

namespace СallСenter.Mapping
{
    public class DataProfile : Profile
    {
        public DataProfile()
        {
            CreateMap<Task, TaskDto>().ForMember(task => task.Id, expression => expression.Ignore());
        }
    }
}
