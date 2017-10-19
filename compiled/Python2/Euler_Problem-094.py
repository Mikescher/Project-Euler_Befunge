#!/usr/bin/env python2

# transpiled with BefunCompile v1.3.0 (c) 2017
import sys
def td(a,b):
    return ((0)if(b==0)else(a//b))
def tm(a,b):
    return ((0)if(b==0)else(a%b))
x0=0
x1=1000000000
x2=2
x3=1
def _0():
    return 1
def _1():
    global x1
    global x2
    return (3)if(x1>(x2*2))else(2)
def _2():
    global x0
    sys.stdout.write(str(x0)+" ")
    sys.stdout.flush()
    return 4
def _3():
    global x0
    global x2
    global x3
    global t0
    x0=(((1)if(x2>2)else(0))*((0)if(((2*x2)%3)-1!=0)else(1))*((0)if(((x2-2)*x3)%3!=0)else(1))*((x2*2)-2))+x0
    x0=(((0)if(((x2*2)%3)-2!=0)else(1))*((0)if(((x2+2)*x3)%3!=0)else(1))*(2+(2*x2)))+x0
    t0=x2+(x3*2)
    x2=(x2*2)+(x3*3)
    x3=t0
    return 1
m=[_0,_1,_2,_3]
c=0
while c<4:
    c=m[c]()
