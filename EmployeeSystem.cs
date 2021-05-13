using System;
using employeeLib; 
using System.Collections.Generic;  

namespace Employee
{
    class EmployeeSystem
    {
        static Boolean exit = false ;

        
        //make obj list with employeees

        static void EmployeeListToString(List<EmployeeInformation> list){
            for(int i = 1 ; i < list.Count ; i++){
                Console.WriteLine(i+": "+ list[i].EmployeeName);
                }
        }
        static void Main(string[] args)
        {
            List<EmployeeInformation> employeesList = new List<EmployeeInformation>(); 
            int EmployeeCount = 0 ;

            
            Console.WriteLine("Welcome to the Employee System Application!");
            
            //repeates until the user decides to leave 
            while(!exit){
                Console.WriteLine("Please chose one of the following options ");
                Console.WriteLine("1.Create new Employee");
                Console.WriteLine("2. View Employee details");
                Console.WriteLine("3. Apply leave days ");
                Console.WriteLine("4.Increase Salary");
                Console.WriteLine("5. Exit ");

                int answer = Convert.ToInt32(Console.ReadLine()); //obtains answer and coverts it into right type 
                Console.Clear();
                
                switch(answer){

                    case 1:
                        Console.WriteLine("Create a new Employee");

                        Console.WriteLine("Please enter the name of the employee ");
                        String name = Console.ReadLine() ;

                        Console.WriteLine("Please enter the salary of the employee ");
                        double salary = Convert.ToDouble(Console.ReadLine() );

                        Console.WriteLine("Please enter the number of leave days of the employee ");
                        int leaves = Convert.ToInt32(Console.ReadLine() );

                        
                        Console.WriteLine("Please choose the type of employee \n 1. Sales \n 2. Developer \n 3. HR"); 

                        int typeAnswer = Convert.ToInt32(Console.ReadLine());
                        EmployeeInformation newEmployee = new EmployeeInformation(name, EmployeeCount, salary, leaves);

                        switch(typeAnswer){
                            case 1:
                                newEmployee.EmployeeTypeset(Type.sales);
                                break;

                            case 2:
                                newEmployee.EmployeeTypeset(Type.developer);
                                break; 

                            case 3: 
                                newEmployee.EmployeeTypeset(Type.HR);
                                break;
                        }

                        employeesList.Add(newEmployee) ; 


                        break;
                    case 2:
                            Console.WriteLine("View Employees Info");

                            for(int i = 0 ; i < employeesList.Count ;i++ ){
                                employeesList[i].employeeDetails();
                            }
                            
                        break;
                    case 3:
                            Console.WriteLine("Apply leave");
                            Console.WriteLine("Please chose one of the emplopyees below");
                            EmployeeListToString(employeesList);
                            int employeeAnswer = Convert.ToInt32(Console.ReadLine());
                            
                            Console.WriteLine("Please enter the number of leave requested");
                            int leavesRequested = Convert.ToInt32(Console.ReadLine());
                            employeesList[employeeAnswer].applyLeaves(leavesRequested);
                            
                        break;
                    case 4:
                            Console.WriteLine("Increase Salary ");
                            Console.WriteLine("Please chose one of the emplopyees below");
                            EmployeeListToString(employeesList);
                            int employeeAnswerSalary = Convert.ToInt32(Console.ReadLine());
                            
                            Console.WriteLine("Please enter the percentage increase as a whole number");
                            int raise = Convert.ToInt32(Console.ReadLine());
                            employeesList[employeeAnswerSalary].increaseSalary(raise);
                        break;
                    case 5:
                            Console.WriteLine("closing application...");
                            exit = true ;
                        break;
                }
            }
       
        }
    }
}
