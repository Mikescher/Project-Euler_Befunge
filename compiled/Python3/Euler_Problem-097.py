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
def _0():
    global t0
    t0=56866
    sa(7830455)
    return 1
def _1():
    global t0
    t0=t0*2
    t0=tm(t0,10000000000)
    sa(sr());

    return (3)if(sp()!=0)else(2)
def _2():
    global t0
    sp();
    t0=t0+1
    t0=tm(t0,10000000000)
    print(t0,end=" ",flush=True)
    return 4
def _3():
    sa(sp()-1);
    return 1
m=[_0,_1,_2,_3]
c=0
while c<4:
    c=m[c]()
