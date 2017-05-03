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
x0=10000000000
x1=32
x2=32
def _0():
    sa(0)
    sa(1000)
    return 1
def _1():
    global x2
    global x1
    x2=sr()
    sa(sr());
    x1=sr()
    return 2
def _2():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()-1);

    sa(sr());

    return (5)if(sp()!=0)else(3)
def _3():
    global x1
    global x0
    sp();
    sp();
    sa(sp()+x1);

    sa(tm(sp(),x0))

    sa(x2-1)

    return (1)if(x2!=1)else(4)
def _4():
    sp();
    sys.stdout.write(str(sp()))
    sys.stdout.flush()
    return 6
def _5():
    global t0
    global x1
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    t0=tm(sr()*x1,x0)
    x1=t0
    return 2
m=[_0,_1,_2,_3,_4,_5]
c=0
while c<6:
    c=m[c]()
