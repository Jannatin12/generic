using System;
using System.Collections;
using System.Collections.Generic;
using tpmodul5_1302213051;

public class Program
{
    public static void Main(string[] args)
    {
        //Generic Method
        /*HaloGeneric hay = new HaloGeneric();
        hay.SapaUser("Jannah");*/

        //Generic Class
        DataGeneric<string> datgen = new DataGeneric<string>("1302213051");
        datgen.PrintData();

    }
}
