using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Options;
using Project.Entities;
using Project;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Security.AccessControl;
using System;
namespace CourseProject.DTOs;
public class ClassRoomDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Capacity { get; set; }
    public string Location { get; set; }
}

