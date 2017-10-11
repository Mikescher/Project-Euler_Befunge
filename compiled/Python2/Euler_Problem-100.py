#!/usr/bin/env python2

# transpiled with BefunCompile v1.2.0 (c) 2017
import sys
def td(a,b):
    return ((0)if(b==0)else(a//b))
def tm(a,b):
    return ((0)if(b==0)else(a%b))
s=[]
def sp():
    global s
    if (len(s) == 0):
        return 0
    return s.pop()
def sa(v):
    global s
    s.append(v)
def sr():
    global s
    if (len(s) == 0):
        return 0
    return s[-1]
x0=1
x1=1
x2=0
x3=0
def _0():
    return 1
def _1():
    global t0
    global x0
    global t1
    global x2
    global t2
    global x1
    global x3
    t0=x0
    t1=x2
    x0=(x0*3)+(x2*4)
    t1=t1*3
    t0=t0*2
    t2=t1+t0
    x2=t2
    t0=x1
    t1=x3
    x1=(x1*3)-(x3*4)
    t1=t1*3
    t0=t0*2
    t2=t1-t0
    x3=t2
    return 2
def _2():
    return (1)if((td((2+(x2*2))-x0-(2*x3)-x1,4))<=1000000000000)else(3)
def _3():
    sys.stdout.write(str(td((4+(x1*2)+(x3*2)+(x0*2))-(x2*2),8))+" ")
    sys.stdout.flush()
    return 4
m=[_0,_1,_2,_3]
c=0
while c<4:
    c=m[c]()
