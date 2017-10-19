#!/usr/bin/env python2

# transpiled with BefunCompile v1.3.0 (c) 2017
import sys
def td(a,b):
    return ((0)if(b==0)else(a//b))
def tm(a,b):
    return ((0)if(b==0)else(a%b))
x0=0
x1=0
x2=32
x3=6
x4=1000
x5=0
def _0():
    global x2
    global x3
    global t0
    x2=x3/3
    t0=0
    return 1
def _1():
    global t0
    global x2
    t0=x2

    return (2)if(x2!=2)else(4)
def _2():
    global t0
    global x2
    global x3
    t0=t0-1
    x2=t0

    return (1)if((tm(x3*(x3-(2*x2)),(x3-x2)*2))!=0)else(3)
def _3():
    global x5
    x5=x5+1
    return 1
def _4():
    global t0
    global x5
    global x0
    t0=x5

    return (8)if(x5>x0)else(5)
def _5():
    global t0
    global x3
    global x4
    t0=x3

    return (7)if((x3-x4)!=0)else(6)
def _6():
    global x1
    sys.stdout.write(str(x1)+" ")
    sys.stdout.flush()
    return 9
def _7():
    global t0
    global x3
    global x5
    global x2
    t0=t0+2
    x3=t0
    x5=0
    x2=x3/3
    t0=3
    return 1
def _8():
    global x0
    global t0
    global x1
    global x3
    x0=t0
    x1=x3
    return 5
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8]
c=0
while c<9:
    c=m[c]()
