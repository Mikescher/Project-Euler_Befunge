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
x0=50
x1=0
x2=50
x3=88
x4=88
def _0():
    return 1
def _1():
    global x3
    global x0
    global x4
    x3=x0
    x4=x3+1
    return 2
def _2():
    return (7)if(((1)if((x3*(x4-x3))>(x2*x2))else(0))+((1)if(x4>x0)else(0))==0)else(3)
def _3():
    global t0
    global x3
    t0=x3-1
    x3=x3-1
    t0=(0)if(t0!=0)else(1)

    return (4)if((t0)!=0)else(6)
def _4():
    global t0
    global x2
    t0=x2-1
    x2=x2-1

    return (1)if((t0)!=0)else(5)
def _5():
    sys.stdout.write(str(x1+(3*x0*x0)))
    sys.stdout.flush()
    return 8
def _6():
    global x4
    x4=x3+1
    return 2
def _7():
    global x1
    global x4
    x1=x1+(((0)if(tm((x3-x4)*x3,x2)!=0)else(1))*2)
    x4=x4+1
    return 2
m=[_0,_1,_2,_3,_4,_5,_6,_7]
c=0
while c<8:
    c=m[c]()
