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
x0=32
x1=32
x2=1
def _0():
    global t0
    t0=1
    sa(0)
    sa(1)
    sa(10)
    sa(100)
    sa(1000)
    sa(10000)
    sa(100000)
    sa(1000000)
    sa(1000000)
    return 1
def _1():
    return (3)if(sp()!=0)else(2)
def _2():
    global x2
    sys.stdout.write(str(x2)+" ")
    sys.stdout.flush()

    sp();
    return 11
def _3():
    global x0
    global x1
    x0=1
    x1=1
    return 4
def _4():
    global x0
    global x1
    return (10)if(sr()>(x0*9*x1))else(5)
def _5():
    global t0
    global x0
    global x1
    global t1
    sa(sp()-1)

    t0=(td(sr(),x0))+x1
    sa(tm(sp(),x0))

    t1=x0
    sa(t1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa(sp()-v0)

    sa(sp()-1)

    sa(sr());

    return (9)if(sp()!=0)else(6)
def _6():
    sa(sr());
    return 7
def _7():
    return (9)if(sp()!=0)else(8)
def _8():
    global t0
    global x2
    t0=t0%10
    t0=t0*x2
    x2=t0
    sp();
    sa(sr());
    return 1
def _9():
    global t0
    t0=t0/10
    sa(sp()-1)

    sa(sr());
    return 7
def _10():
    global x0
    global x1
    sa(sp()-(x0*9*x1))

    x0=x0+1
    x1=x1*10
    return 4
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10]
c=0
while c<11:
    c=m[c]()
