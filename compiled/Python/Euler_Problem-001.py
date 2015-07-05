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
def _0():
    sa(1)
    sa(2)
    sa(2)
    return 1
def _1():
    sa(sr())
    sa((td(sr(),5))*5)
    v0=sp()
    sa(sp()-v0)
    sa((0)if(sp()!=0)else(1))
    return (2)if(sp()!=0)else(3)
def _2():
    sa(sr())
    return 3
def _3():
    return (5)if(sr()-1000==0)else(4)
def _4():
    sp()
    sa(sp()+1);
    sa(sr())
    sa(sr())
    sa((td(sr(),3))*3)
    v0=sp()
    sa(sp()-v0)
    sa((0)if(sp()!=0)else(1))
    return (2)if(sp()!=0)else(1)
def _5():
    sp()
    sp()
    sp()
    return 6
def _6():
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return (7)if(sr()-1==0)else(8)
def _7():
    sp()
    print(sp(),end="",flush=True)
    return 9
def _8():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 6
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8]
c=0
while c<9:
    c=m[c]()