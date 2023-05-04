using WelcomeExtended.Others;
using Welcome.Others;
using Welcome.Model;
using Welcome.View;
using Welcome.ViewModel;
using WelcomeExtended.Data;

try
{


    UserData userData = new UserData();
    User studentUser = new User()
    {
        Names = "student",
        Password = "123",
        Role = UserRolesEnum.STUDENT,

         
    };

    userData.AddUser(studentUser);

    User student2 = new User
    {
        Names = "Student2",
        Password = "123",
        Role = UserRolesEnum.STUDENT
    };
    userData.AddUser(student2);

    User Teacher = new User
    {
        Names = "Teacher",
        Password = "1234",
        Role = UserRolesEnum.PROFESSOR
    };
    userData.AddUser(Teacher);


    User Admin = new User
    {
        Names = "Admin",
        Password = "12345",
        Role = UserRolesEnum.ADMIN
    };
    userData.AddUser(Admin);


}
catch (Exception e)
{
    var log = new Delegates.ActionOnError(Delegates.Log);
    log(e.Message);
}
finally
{
    Console.WriteLine("Executed in any case!");
}