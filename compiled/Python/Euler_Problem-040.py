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
x0=32
x1=32
x2=1
def _0():
    sa(0)
    sa(1)
    sa(10)
    sa(100)
    sa(1000)
    sa(10000)
    sa(100000)
    sa(1000000)
    return 1
def _1():
    global x0
    global x1
    x0=1
    x1=1
    return 2
def _2():
    return (3)if(sr()<=(x0*9*x1))else(9)
def _3():
    global t0
    global x0
    global t1
    sa(sp()-1);
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
    sa(sp()-1);
    sa(sr())
    return (8)if(sp()!=0)else(4)
def _4():
    sa(sr())
    return 5
def _5():
    return (8)if(sp()!=0)else(6)
def _6():
    global t0
    global x2
    sp()
    t0=tm(t0,10)
    t0=t0*x2
    x2=t0
    sa(sr())
    return (1)if(sp()!=0)else(7)
def _7():
    global x2
    print(x2,end="",flush=True)
    sp()
    return 10
def _8():
    global t0
    t0=td(t0,10)
    sa(sp()-1);
    sa(sr())
    return 5
def _9():
    global t0
    global x0
    global x1
    t0=x0*9*x1
    x0=x0+1
    x1=x1*10
    sa(sp()-t0);
    return 2
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9]
c=0
while c<10:
    c=m[c]()