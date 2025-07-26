using AssignmentOOP03.Q12;
using System.Data;
using System.Net;

namespace AssignmentOOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01

            // What is the primary purpose of an interface in C#?

            // b) To define a blueprint for a class

            #endregion

            #region Q02

            // Which of the following is NOT a valid access modifier for interface members in C#?

            // a) private
            // b) protected

            // both are correct but if ia have to pick one then it will be "Private"

            #endregion

            #region Q03

            // Can an interface contain fields in C#?

            // b) No

            #endregion

            #region Q04

            // In C#, can an interface inherit from another interface?

            // b) Yes, interfaces can inherit from multiple interfaces

            #endregion

            #region Q05

            // Which keyword is used to implement an interface in a class in C#?

            // None of the above answers used to implement an interface but if you mean the keyword that we used to describe
            // the process of implementing then the answer is :
            // "d) implements"

            #endregion

            #region Q06

            // Can an interface contain static methods in C#?

            // a) Yes

            #endregion

            #region Q07

            // In C#, can an interface have explicit access modifiers for its members?

            // b) No, all members are implicitly public

            #endregion

            #region Q08

            // What is the purpose of an explicit interface implementation in C#?

            // b) To provide a clear separation between interface and class members

            #endregion

            #region Q09

            // In C#, can an interface have a constructor?

            // b) No, interfaces cannot have constructors

            #endregion

            #region Q10

            // How can a C# class implement multiple interfaces?

            // c) By separating interface names with commas

            #endregion

            #region Q11

            // Define an interface named IShape with a property Area and a method DisplayShapeInfo.
            // Create two interfaces, ICircle and IRectangle, that inherit from IShape.
            // Implement these interfaces in classes Circle and Rectangle.
            // Test your implementation by creating instances of both classes and displaying their shape information.

            //Rectangle rectangle = new Rectangle(5, 6);
            //rectangle.DisplayShapeInfo();

            //Circle circle = new Circle(5);
            //circle.DisplayShapeInfo();
            #endregion

            #region Q12

            // In this example, we start by defining the IAuthenticationService interface with two methods:
            // AuthenticateUser and AuthorizeUser.
            // The BasicAuthenticationService class implements this interface and provides the specific implementation
            // for these methods.In the BasicAuthenticationService class,
            // the AuthenticateUser method compares the provided username and password with the stored credentials.
            // It returns true if the user is authenticated and false otherwise.
            // The AuthorizeUser method checks if the user with the given username has the specified role.
            // It returns true if the user is authorized and false otherwise.In the Main method,
            // we create an instance of the BasicAuthenticationService class and assign it to
            // the authService variable of type IAuthenticationService.
            // We then call the AuthenticateUser and AuthorizeUser methods using this interface reference.
            // This implementation allows you to switch the authentication service implementation easily
            // by creating a new class that implements the IAuthenticationService interface and providing
            // the desired logic for authentication and authorization.

            //BasicAuthenticationService basic = new BasicAuthenticationService();

            //IAuthenticationService authService;

            //authService = basic;

            //bool isAuthenticated = authService.AuthenticateUser("admin", "123");

            //Console.WriteLine(isAuthenticated);

            //bool isAuthorized = authService.AuthorizeUser("sohila", "admin");

            //Console.WriteLine(isAuthorized);

            #endregion


        }
    }
}