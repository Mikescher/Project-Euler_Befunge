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
x0=10000000000
x1=32
x2=32
def _0():
    sa(0)
    sa(1000)
    sa(1000)
    return 1
def _1():
    return (3)if(sp()!=0)else(2)
def _2():
    sp();
    sys.stdout.write(str(sp())+" ")
    sys.stdout.flush()
    return 7
def _3():
    global x2
    global x1
    x2=sr()
    sa(sr());
    x1=sr()
    return 4
def _4():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()-1)

    sa(sr());

    return (6)if(sp()!=0)else(5)
def _5():
    global x1
    global x0
    global x2
    sp();
    sp();
    sa(sp()+x1)

    sa(tm(sp(),x0))

    sa(x2-1)
    sa(x2-1)
    return 1
def _6():
    global t0
    global x1
    global x0
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    t0=tm(sr()*x1,x0)
    x1=t0
    return 4
m=[_0,_1,_2,_3,_4,_5,_6]
c=0
while c<7:
    c=m[c]()
