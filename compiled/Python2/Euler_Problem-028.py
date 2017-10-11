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
x0=1000
def _0():
    sa(1002001)
    sa(1002001-x0)
    sa(1002001-x0-x0)
    sa(1002001-x0-x0-x0)
    sa(1002001-x0-x0-x0-x0)
    sa(1002001-x0-x0-x0-x0-1)
    return 1
def _1():
    return (5)if(sp()!=0)else(2)
def _2():
    global t0
    sa(sp()+sp());

    t0=sp()
    sa(sr());

    return (4)if(sp()!=0)else(3)
def _3():
    global t0
    sp();
    sys.stdout.write(str(t0)+" ")
    sys.stdout.flush()
    return 6
def _4():
    global t0
    sa(sp()+t0);
    return 2
def _5():
    global x0
    x0=x0-2
    sa(sr()-x0)
    sa(sr()-x0)
    sa(sr()-x0)
    sa(sr()-x0)
    sa(sr()-1)
    return 1
m=[_0,_1,_2,_3,_4,_5]
c=0
while c<6:
    c=m[c]()
