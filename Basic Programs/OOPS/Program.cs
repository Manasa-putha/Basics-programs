using System;
// Abstraction
// Encapsulation
// Inheritance
// Polymorphism
//Interface
//Generics
//Delegates
//Abstract
//Collections--arraylist(inbuilt methods),Hashmap(put,get,),Hashset(),add,addall,remove,removeall,Contains,Isempty,V getOrDefault(Object key, V defaultValue),,
//Extensions Method
//ordered and unordered
//Homogenous and Hetrogenous
//-------------------------------------------------------------------//

public class Project
{
    interface IProject
    {
        public void Role();
    }
    public  class PermananetRole : IProject
    {
       public void Role()
        {
            Console.WriteLine("Developer");
        }
    }

    public static void Main(string[] args)
    {
        PermananetRole permananetRole = new PermananetRole();
        permananetRole.Role();
    }

}