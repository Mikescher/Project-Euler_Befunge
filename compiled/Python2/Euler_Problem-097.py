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
def _0():
    sa(56866)
    sa(7830456)
    sa(7830456)
    return 1
def _1():
    return (3)if(sp()!=0)else(2)
def _2():
    sp();
    sa(sp()+1)

    sa(sp()%10000000000);

    sys.stdout.write(str(sp())+" ")
    sys.stdout.flush()
    return 4
def _3():
    sa(sp()-1)

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()*2)

    sa(sp()%10000000000);

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr());
    return 1
m=[_0,_1,_2,_3]
c=0
while c<4:
    c=m[c]()
