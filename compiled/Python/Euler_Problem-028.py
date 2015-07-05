#!/usr/bin/env python3
# compiled with BefunCompile v1.0.6 (c) 2015
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
x0=1000
def _0():
    sa(1002001)
    sa(1002001-x0)
    sa(1002001-x0-x0)
    sa(1002001-x0-x0-x0)
    sa(1002001-x0-x0-x0-x0)
    sa(1002001-x0-x0-x0-x0-1)
    return 1
def _1():
    return (5)if(sp()!=0)else(2)
def _2():
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    return (4)if(sp()!=0)else(3)
def _3():
    sp()
    print(sp(),end="",flush=True)
    return 6
def _4():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+sp());
    return 2
def _5():
    global x0
    x0=x0-2
    sa(sr()-x0)
    sa(sr()-x0)
    sa(sr()-x0)
    sa(sr()-x0)
    sa(sr()-1)
    return 1
m=[_0,_1,_2,_3,_4,_5]
c=0
while c<6:
    c=m[c]()