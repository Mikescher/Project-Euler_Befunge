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
def _0():
    sa(0)
    sa(10000)
    sa(10000)
    sa(0)
    sa(10000)
    sa(0)
    return 1
def _1():
    return (3)if(sp()!=0)else(2)
def _2():
    global t0
    global x1
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()*10)

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    t0=sr()%10
    x1=t0
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+x1)

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()/10);

    sa(sr());
    sa((0)if(sp()!=0)else(1))
    return 1
def _3():
    sp();
    sa(sp()+sp());

    sa(24)
    sa(0)
    return 4
def _4():
    return (5)if(sp()!=0)else(9)
def _5():
    sp();
    sp();
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+1)

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 6
def _6():
    sa(sp()-1)

    sa(sr());

    return (8)if(sp()!=0)else(7)
def _7():
    sp();
    sys.stdout.write(str(sp())+" ")
    sys.stdout.flush()
    return 15
def _8():
    sa(sr());
    sa(sr());
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr());
    sa((0)if(sp()!=0)else(1))
    return 1
def _9():
    global t0
    t0=0
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr());
    sa(sr());
    return 10
def _10():
    sa(sr());

    return (14)if(sp()!=0)else(11)
def _11():
    global x0
    global t0
    global t1
    x0=t0
    sp();
    sa(sp()-t0)

    t1=sp()

    return (12)if((t1)!=0)else(13)
def _12():
    global x0
    sa(sr());
    sp();
    sa(sp()+x0)

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()-1)

    sa(sr());
    sa((0)if(sp()!=0)else(1))
    return 4
def _13():
    sp();
    sp();
    return 6
def _14():
    global t0
    global t1
    global x1
    t0=t0*10
    t1=sr()%10
    x1=t1
    t0=t0+x1
    sa(sp()/10);
    return 10
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14]
c=0
while c<15:
    c=m[c]()
