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
x0=10
x1=1
x2=88
x3=1
x4=88
def _0():
    sa(10)
    sa(1)
    sa(1)
    sa(1)
    return 1
def _1():
    global t0
    global x1
    t0=((tm(sr(),10))+2)*x1
    x1=t0
    sa(td(sp(),10))

    sa(sr());
    return 2
def _2():
    return (1)if(sp()!=0)else(3)
def _3():
    global x2
    x2=2
    sp();
    sa(sr());
    sa(x2)
    return 4
def _4():
    global x4
    x4=1
    sa(sp()*sp());

    sa(sp()*10);
    return 5
def _5():
    sa(td(sp(),10))

    sa(sr());
    sa((0)if(sp()!=0)else(1))

    return (6)if(sp()!=0)else(13)
def _6():
    sp();

    return (10)if(x4!=x1)else(7)
def _7():
    global t0
    global x2
    t0=x2+1
    x2=x2+1
    t0=t0-7

    return (8)if((t0)!=0)else(9)
def _8():
    global x2
    sa(sr());
    sa(x2)
    return 4
def _9():
    sys.stdout.write(str(sp())+" ")
    sys.stdout.flush()

    sp();
    sp();
    return 14
def _10():
    sp();
    sa(sp()+1);


    return (11)if(sr()>=x3)else(12)
def _11():
    global x0
    global t0
    global x3
    global x1
    sp();
    sa(sp()*10);

    x0=sr()
    t0=td(sr(),6)
    x3=t0
    x1=1
    sa(td(sr(),10))
    sa(sr());
    sa(td(sr()*10,10))
    sa(sr());
    return 2
def _12():
    global x1
    x1=1
    sa(sr());
    sa(td(sr()*10,10))
    sa(sr());
    return 2
def _13():
    global t0
    global x4
    t0=((tm(sr(),10))+2)*x4
    x4=t0
    return 5
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13]
c=0
while c<14:
    c=m[c]()
