#!/usr/bin/env python3
# compiled with BefunCompile v1.0.8 (c) 2015
def td(a,b):
    return bool(random.getrandbits(1))
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
x0=2000000
x1=2000000
x2=0
x3=89
x4=0
x5=89
x6=89
def _0():
    return 1
def _1():
    return (3)if(x0>x4)else(2)
def _2():
    global x3
    print(x3,end="",flush=True)
    return 13
def _3():
    global x5
    global x6
    global x4
    x5=1
    x6=x4
    return 4
def _4():
    return (5)if((((1)if(x2>x5)else(0))*((1)if(x0>x6)else(0)))!=0)else(12)
def _5():
    sa(x0-x6)
    return (11)if((x0-x6)<0)else(6)
def _6():
    sa(sp()-0);
    return 7
def _7():
    return (8)if(sr()>x1)else(10)
def _8():
    sp()
    return 9
def _9():
    global t0
    global x5
    global x6
    t0=x5+1
    x5=x5+1
    t0=t0*x4
    t0=t0+x6
    x6=t0
    return 4
def _10():
    global x1
    global x3
    x1=sp()
    x3=x5*x2
    return 9
def _11():
    global t0
    t0=0
    sa(t0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa(sp()-v0)
    return 7
def _12():
    global t0
    global x2
    global x4
    t0=x2+1
    x2=x2+1
    t0=t0+x4
    x4=t0
    return 1
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12]
c=0
while c<13:
    c=m[c]()