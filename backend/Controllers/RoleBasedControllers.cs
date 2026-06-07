using backend.Middleware;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

// ----------------------------------------------------------------
// Employee routes  — Admin + Manager + Employee
// ----------------------------------------------------------------
[ApiController]
[RequireRole("Admin", "Manager", "Employee")]
public class EmployeeController : ControllerBase
{
    [HttpGet("api/employee/test")]
    public IActionResult Test() =>
        Ok(new { message = "You are authorized for employees!" });
}

// ----------------------------------------------------------------
// Manager routes  — Admin + Manager
// ----------------------------------------------------------------
[ApiController]
[RequireRole("Admin", "Manager")]
public class ManagerController : ControllerBase
{
    [HttpGet("api/manager/test")]
    public IActionResult Test() =>
        Ok(new { message = "You are authorized for managers!" });
}

// ----------------------------------------------------------------
// Admin routes  — Admin only
// ----------------------------------------------------------------
[ApiController]
[RequireRole("Admin")]
public class AdminController : ControllerBase
{
    [HttpGet("api/admin/test")]
    public IActionResult Test() =>
        Ok(new { message = "You are authorized for admin!" });
}
