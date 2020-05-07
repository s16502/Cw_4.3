using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cw4_3.Services
{
    public interface IStudentDbService
    {
        IActionResult EnrollStudent(EnrollStudentRequest request);
        //void PromoteStudents(int semester, string studies);
    }
}
