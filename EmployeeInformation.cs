using System;

namespace employeeLib
{



    public class EmployeeInformation
    {    
        private string name ; 
        private int number ; 
        private double salary ;
        private int leaves ;

        private Type type ; 
        public EmployeeInformation(String name, int number, double salary, int leaves){
            this.name = name ; 
            this.number = number; 
            this.salary = salary ;
            this.leaves = leaves ;

        }

        public string  EmployeeName{
            get {return this.name;} 
            set {this.name = value;}  
        }

        public int EmployeeNumber{
            get {return this.EmployeeNumber;}
            set {this.EmployeeNumber = value;}
        }

        public double EmployeeSalary{
            get {return this.EmployeeSalary;}
            set {this.EmployeeSalary = value;}
        }

        public int EmployeeLeaves{
            get {return this.EmployeeLeaves;}
            set {this.EmployeeLeaves = value;}
        }

        public void EmployeeTypeset(Type type){
            this.type = type;
        }

        public void employeeDetails(){
            Console.WriteLine("name:" +  this.name) ;
            Console.WriteLine("Number:" + this.number);
            Console.WriteLine("Salary:" + this.salary);
            Console.WriteLine("leaves:" + this.leaves);
            Console.WriteLine("Type:" + this.type); 

        }
        public void applyLeaves(int requested){
            //for sales team 
            if(this.type == Type.sales){
               if(requested > 5){
                   Console.WriteLine("You cannot request more than 5 days of leave");
               }else if(requested > this.leaves){
                    Console.WriteLine(" not have enought leave days");
                    Console.WriteLine("number of leave days available are " + this.leaves);
               }else{
                   this.leaves -= requested ; 
                   Console.WriteLine("leaves have been granted");
                    }
                }

            //for developer team 
            else if(this.type == Type.developer){
                if(requested > 7){
                   Console.WriteLine("You cannot request more than 7 days of leave");
               }else if(requested > this.leaves){
                    Console.WriteLine(" not have enought leave days");
                    Console.WriteLine("number of leave days available are " + this.leaves);
               }else{
                   this.leaves -= requested ; 
                   Console.WriteLine("leaves have been granted");
               }
            }
            
            //for HR team 
            else if(this.type == Type.HR){
                if(requested > 10){
                    Console.WriteLine("You cannot request more than 10 days of leave");
               }else if(requested > this.leaves){
                    Console.WriteLine(" not have enought leave days");
                    Console.WriteLine("number of leave days available are " + this.leaves);
               }else{
                   this.leaves -= requested ; 
                   Console.WriteLine("leaves have been granted");
               }
            }else{
                Console.Write("Please double check your information and try again");
            }

        }

        public void increaseSalary(double raise){
            if(raise > 20){
                Console.WriteLine("Salary cannot be increase by more than 20%");
            }else{
                raise = (raise /100) + 1 ;
                this.salary *= raise ; 
                Console.WriteLine("Salary has been inreased");
            }
        }


    }
}
