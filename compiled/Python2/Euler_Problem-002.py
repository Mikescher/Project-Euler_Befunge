#!/usr/bin/env python2

# transpiled with BefunCompile v1.3.0 (c) 2017
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
x1=2
x2=2
def _0():
    sa(0)
    return 1
def _1():
    global x0
    global x1
    global t0
    sp();
    sa(x0+x1)
    t0=x0+x1
    x0=x1
    x1=t0

    return (4)if(sr()>10240000)else(2)
def _2():
    global t0
    global t1
    sa(sr());
    t0=(sr()/2)*2
    sa(sp()-t0)

    t1=sp()

    return (1)if((t1)!=0)else(3)
def _3():
    global x2
    sa(sp()+x2)

    x2=sp()
    sa(0)
    return 1
def _4():
    global x2
    sys.stdout.write(str(x2)+" ")
    sys.stdout.flush()

    sp();
    return 5
m=[_0,_1,_2,_3,_4]
c=0
while c<5:
    c=m[c]()
