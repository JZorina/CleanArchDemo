﻿using CleanArch.Domain.Commands;
using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArch.Domain.CommandHandlers
{
    public class CourseCommandHandler : IRequestHandler<CreateCourseCommand , bool>
    {
        private readonly ICourseRepository _courseRepository;

        public CourseCommandHandler(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public Task<bool> Handle(CreateCourseCommand req, CancellationToken cancellationToken)
        {
            var course = new Course()
            {
                Name = req.Name,
                Description = req.Description,
                ImageUrl=req.ImageUrl
            };

            _courseRepository.Add(course);
            return Task.FromResult(true);
        }
       
    }
}
