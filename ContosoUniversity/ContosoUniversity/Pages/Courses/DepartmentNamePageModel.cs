﻿using ContosoUniversity.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ContosoUniversity.Pages.Courses
{
    public class DepartmentNamePageModel : PageModel
    {
        public SelectList DepartmentNameSL { get; set; }

        public void PopulateDepartmentsDropDownList(SchoolContext _context,
            object selectedDepartment = null)
        {
            var departmentsQuerry = from d in _context.Departments orderby d.Name select d;

            DepartmentNameSL = new SelectList(departmentsQuerry.AsNoTracking(),
                "DepartmentID", "Name", selectedDepartment);
        }
    }
}
