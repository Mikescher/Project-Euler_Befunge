#!/usr/bin/env python2

# transpiled with BefunCompile v1.1.0 (c) 2015
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
x0=2
x1=0
x2=1000000000
x3=1
def _0():
    return 1
def _1():
    return (3)if(x2>(x0*2))else(2)
def _2():
    global x1
    sys.stdout.write(str(x1))
    sys.stdout.flush()
    return 4
def _3():
    global x1
    global t0
    global x0
    global x3
    x1=(((1)if(x0>2)else(0))*((0)if((tm(2*x0,3))-1!=0)else(1))*((0)if(tm((x0-2)*x3,3)!=0)else(1))*((x0*2)-2))+x1
    x1=(((0)if((tm(x0*2,3))-2!=0)else(1))*((0)if(tm((x0+2)*x3,3)!=0)else(1))*(2+(2*x0)))+x1
    t0=x0+(x3*2)
    x0=(x0*2)+(x3*3)
    x3=t0
    return 1
m=[_0,_1,_2,_3]
c=0
while c<4:
    c=m[c]()
