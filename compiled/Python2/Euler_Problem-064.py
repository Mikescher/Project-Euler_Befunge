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
x0=10000
x1=35
x2=35
x3=9
x4=35
x5=35
x6=35
x7=35
def _0():
    sa(0)
    sa(10000)
    sa(0)
    return 1
def _1():
    global x1
    global t0
    global x6
    global x0
    global t2
    global x2
    global x7
    global x4
    x1=0
    t0=1
    x6=1
    sa(x0)
    sa(x0)
    t0=x0
    t2=x0
    x2=0
    x7=t0
    x4=t2
    return 2
def _2():
    global t0
    global x7
    global t1
    global x4
    t0=x7
    sa(t0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa(td(sp(),v0))

    t1=sp()
    sa(sp()+t1)

    sa(sp()/2);


    return (15)if((sr()-x4)!=0)else(3)
def _3():
    global x4
    global x0
    sp();
    sa(x4)

    return (12)if(((x4*x4)-x0)!=0)else(4)
def _4():
    sa(0)
    return 5
def _5():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr());

    return (11)if(sp()!=0)else(6)
def _6():
    sp();
    sa(sp()%2);


    return (8)if(sp()!=0)else(7)
def _7():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+1)

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 8
def _8():
    return (10)if(sr()!=2)else(9)
def _9():
    sp();
    sys.stdout.write(str(sp())+" ")
    sys.stdout.flush()
    return 17
def _10():
    global x3
    global x0
    x3=9
    sa(sp()-1)

    sa(sr());
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    x0=sp()
    return 1
def _11():
    sp();
    sa(sp()+1)
    return 5
def _12():
    global x5
    global x1
    global x6
    x5=sr()
    sa(sp()+x1)

    sa(td(sp(),x6))

    x1=(sr()*x6)-x1
    return 13
def _13():
    global x6
    global x3
    return (14)if(((x6-1)+x3)!=0)else(4)
def _14():
    global x6
    global x0
    global x1
    global x3
    global x5
    x6=td(x0-(x1*x1),x6)
    x3=0
    sa(td(x5+x1,x6))
    x1=((td(x5+x1,x6))*x6)-x1
    return 13
def _15():
    global x2
    return (16)if((sr()-x2)!=0)else(3)
def _16():
    global x2
    global x4
    x2=x4
    x4=sr()
    sa(sr());
    return 2
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16]
c=0
while c<17:
    c=m[c]()
