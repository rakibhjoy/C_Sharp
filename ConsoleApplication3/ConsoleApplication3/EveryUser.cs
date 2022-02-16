using System;


namespace ConsoleApplication3
{
    interface EveryUser
    {
        bool Login();
        void View_attendance(int total1);
        bool LogOut();

    }

    interface AdminUser
    {
        void AddBranch(Branch Ab);
        void Addstff(Staff Adds);
        bool ModifyBranch();
        
    }

    interface StaffUser
    {
        void AddStudent(Student addS);
        void AddAttandance(int att);
        bool ModifyAttandance();
        void ManageLeave(Student leave);
        bool ManageComplain();
        bool ChangePass(bool a);

    }

    interface StudentUser
    {
        void ApplyLeave(string Id);
        void ApplyComplain();

    }
}
