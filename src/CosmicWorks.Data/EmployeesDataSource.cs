﻿using CosmicWorks.Data.Extensions;
using CosmicWorks.Data.Models;

namespace CosmicWorks.Data;

public sealed class EmployeesDataSource : IDataSource<Employee>
{
    public IReadOnlyList<Employee> GetItems(int count = 234)
    {
        int generatedEmployeesCount = count switch
        {
            > 234 => throw new ArgumentOutOfRangeException(nameof(count), "You cannot generate more than 234 employees."),
            < 1 => throw new ArgumentOutOfRangeException(nameof(count), "You must generate at least one employee"),
            _ => count
        };

        IEnumerable<Employee> employees = Raw.People.Get()
            .OrderBy(i => i.Id)
            .ToEmployees();

        return employees.Take(generatedEmployeesCount).ToList();
    }
}
