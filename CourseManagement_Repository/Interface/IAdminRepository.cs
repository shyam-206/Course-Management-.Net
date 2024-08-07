﻿using CourseManagement_Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagement_Repository.Interface
{
    public interface IAdminRepository
    {
        List<CourseModel> GetALLCourseList();
        List<AssignmentModel> GetAssignmentList();
        int GetTotalNumberOfInstructorCount();
        int GetTotalNumberOfStudentCount();
        int GetSubmissionCount();
        int GetMaterialCount();
        List<SubmitAssignmentModel> GetSubmissionModelList();
        List<MaterialModel> GetAllMaterial();
        List<EnrollmentModel> GetAllEnrollmentList();
        List<UserModel> InstructorList();
        List<UserModel> StudentList();
        DashboardModel GetDashboardService();
    }
}
