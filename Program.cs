﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcionTorreHanoi
{
    class Proyecto1
    {
        static void torresHanoi(int n, int o, int d, int aux){
            if (n > 0){
                torresHanoi(n-1, o, aux, d);
                Console.Write("nSe Mueve anillo desde Torre " + o + " Hasta Torre " + d);
                torreshanoi(n-1, aux, d, o);
            }
        }
