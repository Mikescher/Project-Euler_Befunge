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
x0=57
x1=56
x2=55
x3=57
def _0():
    global x0
    global x1
    global x2
    global x3
    return (4)if(sp()!=0)else(5)
def _1():
    global x0
    global x1
    global x2
    global x3
    return (2)if(sp()!=0)else(7)
def _2():
    global x0
    global x1
    global x2
    global x3
    return (4)if((0)if((tm(x3,x2))!=0)else(1))else(6)
def _3():
    global x0
    global x1
    global x2
    global x3
    x0=775146
    x1=600851475143
    return 4
def _4():
    global x0
    global x1
    global x2
    global x3
    sa(x1)
    sa((x0)-(1))
    x0=(x0)-(1)
    v0=sp()
    sa(tm(sp(),v0))
    return 0
def _5():
    global x0
    global x1
    global x2
    global x3
    sa(x0)
    x3=x0
    sa(1)
    v0=sp()
    sa(sp()-v0)
    x2=sp()
    return 2
def _6():
    global x0
    global x1
    global x2
    global x3
    sa(x2)
    x2=(x2)-(1)
    sa(2)
    v0=sp()
    sa(sp()-v0)
    return 1
def _7():
    global x0
    global x1
    global x2
    global x3
    print(x3,end="",flush=True)
    return 8
m=[_0,_1,_2,_3,_4,_5,_6,_7]
c=3
while c<8:
    c=m[c]()