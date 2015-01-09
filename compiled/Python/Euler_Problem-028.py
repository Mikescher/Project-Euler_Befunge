# compiled with BefunCompile v1.0.1 (c) 2015
# execute with at least Python3
from random import randint
def rd():
    return bool(random.getrandbits(1))
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
x0=88
def _0():
    global x0
    return (3)if(sp()!=0)else(4)
def _1():
    global x0
    return (5)if(sp()!=0)else(6)
def _2():
    global x0
    x0=1000
    sa(1002001)
    sa((1002001)-(x0))
    sa(((1002001)-(x0))-(x0))
    sa((((1002001)-(x0))-(x0))-(x0))
    sa(((((1002001)-(x0))-(x0))-(x0))-(x0))
    sa((((((1002001)-(x0))-(x0))-(x0))-(x0))-(1))
    return 0
def _3():
    global x0
    x0=(x0)-(2)
    sa(sr())
    sa(x0)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    sa(x0)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    sa(x0)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    sa(x0)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    sa(1)
    v0=sp()
    sa(sp()-v0)
    return 0
def _4():
    global x0
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    return 1
def _5():
    global x0
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+sp());
    return 4
def _6():
    global x0
    sp()
    print(sp(),end="",flush=True)
    return 7
m=[_0,_1,_2,_3,_4,_5,_6]
c=2
while c<7:
    c=m[c]()