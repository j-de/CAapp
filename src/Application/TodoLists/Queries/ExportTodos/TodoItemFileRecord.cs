﻿using CAapp.Application.Common.Mappings;
using CAapp.Domain.Entities;

namespace CAapp.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
