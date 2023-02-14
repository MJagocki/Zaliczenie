using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Prostokat : Figura
{
    private int a;
    public int A { get => a; set => a = value; }
    private int b;
    public int B { get => b; set => b = value; }

    public Prostokat(string name , int a , int b):base(name)
    {
      
        this.a = a;
        this.b = b;
    }
    public string WypiszDane()
    {
        string output = $"Figura {this.name}, długość {this.a}, wyskość {this.b}"; 
        return output;
    }


}

