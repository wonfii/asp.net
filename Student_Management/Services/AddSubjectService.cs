using business_logic.Interfaces;
using data_access.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_Management;

namespace business_logic.Services
{
    //public class AddSubjectService : IAddSubjectService
    //{

    //    private readonly ISubjectService subjectService;
    //    private readonly HttpContext ? httpContext;

    //    public AddSubjectService(ISubjectService subjectService, IHttpContextAccessor httpContextAccessor)
    //    {
    //        this.subjectService = subjectService;
    //        this.httpContext = httpContextAccessor.HttpContext;
    //    }

    //    public void AddSubject(int subjectId)
    //    {
    //        var subjectIds = httpContext.Session.GetObject<List<int>>("subject") ?? new List<int>();

    //        if (!subjectIds.Contains(subjectId))
    //        {
    //            subjectIds.Add(subjectId);
    //            httpContext.Session.SetObject("subject", subjectIds);
    //        }
    //    }

    //    public List<Subject> GetSubjects()
    //    {
    //        var subjectIds = httpContext.Session.GetObject<List<int>>("subject");

    //        List<Subject> subjects = new List<Subject>();

    //        if (subjectIds != null)
    //        {
    //            subjects = subjectService.GetSelectedOptionalSubjects(subjectIds);
    //        }
    //        return subjects; 
    //    }

    //    public bool IsSubjectAdded(int subjectId)
    //    {
    //        var subjectIds = httpContext.Session.GetObject<List<int>>("addedSubjects");
    //        if (subjectIds == null) { return false; }
    //        return subjectIds.Contains(subjectId);
    //    }

    //    public void RemoveSubject(int subjectId)
    //    {
    //        var subjectIds = httpContext.Session.GetObject<List<int>>("subject") ?? new List<int>();

    //        if (subjectIds.Contains(subjectId))
    //        {
    //            subjectIds.Remove(subjectId);
    //            httpContext.Session.SetObject("subject", subjectIds);
    //        }
    //    }
    //}
}
