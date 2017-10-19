#!/usr/bin/env python3

# transpiled with BefunCompile v1.3.0 (c) 2017
def td(a,b):
    return ((0)if(b==0)else(a//b))
def tm(a,b):
    return ((0)if(b==0)else(a%b))
x0=1
x1=1
x2=0
x3=0
def _0():
    return 1
def _1():
    global t0
    global x2
    global x0
    global x3
    global x1
    t0=(x2*3)+(x0*2)
    x0=(x0*3)+(x2*4)
    x2=t0
    t0=(x3*3)-(x1*2)
    x1=(x1*3)-(x3*4)
    x3=t0
    return 2
def _2():
    global x2
    global x0
    global x3
    global x1
    return (3)if((((2+(x2*2))-x0-(2*x3)-x1)/4)>1000000000000)else(1)
def _3():
    global x1
    global x3
    global x0
    global x2
    print(((4+(x1*2)+(x3*2)+(x0*2))-(x2*2))/8,end=" ",flush=True)
    return 4
m=[_0,_1,_2,_3]
c=0
while c<4:
    c=m[c]()
