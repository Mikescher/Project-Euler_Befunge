#!/usr/bin/env python3

# transpiled with BefunCompile v1.2.0 (c) 2017
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
    return 1
def _1():
    global t0
    global x0
    global t1
    global x1
    t0=x0
    t1=x1
    x0=x1
    sa(t0+t1)
    x1=sr()

    return (5)if(sr()>10240000)else(2)
def _2():
    global t0
    global t1
    sa(sr());
    t0=(td(sr(),2))*2
    sa(sp()-t0);

    t1=sp()

    return (3)if((t1)!=0)else(4)
def _3():
    sp();
    return 1
def _4():
    global x2
    sa(sp()+x2);

    x2=sp()
    return 1
def _5():
    global x2
    print(x2,end=" ",flush=True)
    sp();
    return 6
m=[_0,_1,_2,_3,_4,_5]
c=0
while c<6:
    c=m[c]()
