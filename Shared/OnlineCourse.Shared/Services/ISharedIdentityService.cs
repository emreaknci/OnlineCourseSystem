﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace OnlineCourse.Shared.Services;

public interface ISharedIdentityService
{
    public string GetUserId { get; }


}
public class SharedIdentityService:ISharedIdentityService
{
    private IHttpContextAccessor _httpContextAccessor;

    public SharedIdentityService(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public string GetUserId =>
        _httpContextAccessor.HttpContext!.User.FindFirst("sub")!.Value;
}
