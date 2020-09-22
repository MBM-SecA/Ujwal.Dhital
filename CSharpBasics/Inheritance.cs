using System;
 
public interface IShapeWithSides
{
    public double GetDiagonal();
}
 
public abstract class Shape
{
    //define abstract members when you want to force derived classes to implement their own logic
    public abstract double GetArea();
 
    public abstract double GetCircumference(); //we can do like this if there is only one line of code.
 
    public virtual void Display()
    {
        Console.WriteLine($"Displaying result for some shape.");
    }
 
}
 
public class Rectangle : Shape, IShapeWithSides //this is how we inherit, using colon
{
    public Rectangle(double length, double breadth)
    {
        Length = length;
        Breadth = breadth;
    }
 
    public double Length { get; set;}
    public double Breadth { get; set;}
 
    public override double GetArea() => Length * Length;
    public override double GetCircumference() => 2 * (Length + Breadth);
 
     public override void Display()
    {
        Console.WriteLine($"Displaying results for rectangle [{Length}x{Breadth}]");
        Console.WriteLine($"Area : {this.GetArea()} square unit \n");   
        Console.WriteLine($"Circumference : {this.GetCircumference()} unit \n");
    }
 
    public double GetDiagonal() => Math.Sqrt(Length * Length + Breadth * Breadth);
 
}
 
public class Square : Rectangle
{
    public Square(double side) : base(side, side)
    {
 
    }
}
 
public class Circle : Shape
{
    public double Radius { get; set; }
 
    public override double GetArea() => Math.PI * Radius * Radius;
    public override double GetCircumference() => 2 * Math.PI * Radius;
}
 
class A
{ }
 
class B : A
{ }
 
class C : B
{ }
 
//you can only inherit one class.
//But you can inherit mutiple interface in same class.
 
class D : IA, IB
{ }
 
interface IA
{ }
interface IB
{ }