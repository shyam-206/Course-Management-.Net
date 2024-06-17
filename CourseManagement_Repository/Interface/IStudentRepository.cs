﻿using CourseManagement_Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagement_Repository.Interface
{
    public interface IStudentRepository
    {
        bool EnrollmentCourse(int CourseId,int UserId);
        List<CourseModel> GetAllCourseList(int UserId);
        List<MaterialModel> GetMaterialList(int CourseId);
        MaterialModel GetMaterial(int CourseId,int MaterialId);
        List<UserModel> GetAllStudentList();

    }
}
