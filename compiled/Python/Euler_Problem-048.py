# compiled with BefunCompile v1.0.2 (c) 2015
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
x0=32
x1=32
x2=32
def _0():
    global x0
    global x1
    global x2
    return (4)if(sp()!=0)else(3)
def _1():
    global x0
    global x1
    global x2
    return (6)if(sp()!=0)else(7)
def _2():
    global x0
    global x1
    global x2
    x0=10000000000
    sa(0)
    sa(1000)
    sa(1000)
    return 0
def _3():
    global x0
    global x1
    global x2
    sp()
    print(sp(),end="",flush=True)
    return 8
def _4():
    global x0
    global x1
    global x2
    sa(sr())
    x2=sp()
    sa(sr())
    sa(sr())
    return 5
def _5():
    global x0
    global x1
    global x2
    x1=sp()
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    return 1
def _6():
    global x0
    global x1
    global x2
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    sa(x1)
    sa(sp()*sp());
    sa(x0)
    v0=sp()
    sa(tm(sp(),v0))
    return 5
def _7():
    global x0
    global x1
    global x2
    sp()
    sp()
    sa(x1)
    sa(sp()+sp());
    sa(x0)
    v0=sp()
    sa(tm(sp(),v0))
    sa((x2)-(1))
    sa((x2)-(1))
    return 0
m=[_0,_1,_2,_3,_4,_5,_6,_7]
c=2
while c<8:
    c=m[c]()