using System;
using System.Collections.Generic;
using System.Text;
using SoftwareHouse.Contract.Common;
using SoftwareHouse.Contract.DataContracts;

namespace SoftwareHouse.Contract.Services
{
    public interface IProjectsService
    {
        List<ProjectDto> GetAll();
        CommonResult<ProjectDto> GetById(int id);
        CommonResult Add(AddProjectDto project);
        void Delete(int id);
    }



}
