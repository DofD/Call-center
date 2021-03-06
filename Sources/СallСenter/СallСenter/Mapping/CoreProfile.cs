﻿using AutoMapper;
using СallСenter.Core.Tasks;
using СallСenter.Tasks;

namespace СallСenter.Mapping
{
    public class CoreProfile : Profile
    {
        public CoreProfile()
        {
            CreateMap<TaskAddModel, Task>().ConstructUsing(model => new Task(model.Name, model.Phone, model.Body, null, string.Empty));
        }
    }
}
