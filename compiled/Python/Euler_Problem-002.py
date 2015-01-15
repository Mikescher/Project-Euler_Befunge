# compiled with BefunCompile v1.0.3 (c) 2015
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
x0=62
x1=118
x2=118
def _0():
    global x0
    global x1
    global x2
    return (4)if(sp()!=0)else(5)
def _1():
    global x0
    global x1
    global x2
    return (7)if(sp()!=0)else(6)
def _2():
    global x0
    global x1
    global x2
    x1=2
    x0=1
    x2=2
    return 3
def _3():
    global x0
    global x1
    global x2
    sa(x0)
    sa(x1)
    x0=x1
    sa(sp()+sp());
    sa(sr())
    x1=sp()
    sa(sr())
    sa(10240000)
    v0=sp()
    sa((1)if(sp()>v0)else(0))
    return 0
def _4():
    global x0
    global x1
    global x2
    print(x2,end="",flush=True)
    sp()
    return 8
def _5():
    global x0
    global x1
    global x2
    sa(sr())
    sa(sr())
    sa(2)
    v0=sp()
    sa(td(sp(),v0))
    sa(2)
    sa(sp()*sp());
    v0=sp()
    sa(sp()-v0)
    return 1
def _6():
    global x0
    global x1
    global x2
    sa(x2)
    sa(sp()+sp());
    x2=sp()
    return 3
def _7():
    global x0
    global x1
    global x2
    sp()
    return 3
m=[_0,_1,_2,_3,_4,_5,_6,_7]
c=2
while c<8:
    c=m[c]()