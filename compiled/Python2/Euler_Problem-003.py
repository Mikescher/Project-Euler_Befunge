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
x0=775146
x1=600851475143
x2=55
x3=57
def _0():
    return 1
def _1():
    global t0
    global x1
    global t1
    global x0
    global t2
    t0=x1
    t1=x0-1
    x0=x0-1
    t2=tm(t0,t1)
    return 2
def _2():
    global t2
    return (1)if((t2)!=0)else(3)
def _3():
    global t0
    global x0
    global x3
    global x2
    t0=x0
    x3=x0
    t0=t0-1
    x2=t0
    return 4
def _4():
    return (1)if(tm(x3,x2)==0)else(5)
def _5():
    global t0
    global x2
    t0=x2
    x2=x2-1
    t0=t0-2

    return (4)if((t0)!=0)else(6)
def _6():
    global x3
    sys.stdout.write(str(x3))
    sys.stdout.flush()
    return 7
m=[_0,_1,_2,_3,_4,_5,_6]
c=0
while c<7:
    c=m[c]()
