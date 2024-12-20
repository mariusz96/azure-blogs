﻿using MediatR;

namespace AzureBlogs.Core.Commands
{
    public class AddPostCommand : IRequest<int>
    {
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public int BlogId { get; set; }
    }
}
