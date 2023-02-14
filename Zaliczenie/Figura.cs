using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Figura
{
    protected string name;
    public string Name { get => name; set => name = value; }

    public Figura(string name)
    {
        this.name = name;
    }

    public string WypiszDane()
    {
        return this.name;
    }
    

}

