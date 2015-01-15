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
x0=34
x1=100
x2=34
x3=53
def _0():
    global x0
    global x1
    global x2
    global x3
    return (8)if(sp()!=0)else(14)
def _1():
    global x0
    global x1
    global x2
    global x3
    return (9)if(sp()!=0)else(10)
def _2():
    global x0
    global x1
    global x2
    global x3
    return (7)if(sp()!=0)else(12)
def _3():
    global x0
    global x1
    global x2
    global x3
    return (6)if(sp()!=0)else(13)
def _4():
    global x0
    global x1
    global x2
    global x3
    return (16)if(sp()!=0)else(15)
def _5():
    global x0
    global x1
    global x2
    global x3
    x0=1000
    x1=2
    return 6
def _6():
    global x0
    global x1
    global x2
    global x3
    x2=1
    return 7
def _7():
    global x0
    global x1
    global x2
    global x3
    sa(((x2)*(x2))+((x1)*(x1)))
    x3=((x2)*(x2))+((x1)*(x1))
    sa(0)
    sa((0)-(x3))
    return 0
def _8():
    global x0
    global x1
    global x2
    global x3
    sa(1)
    sa(sp()+sp());
    sa(sr())
    sa(x0)
    v0=sp()
    sa(sp()-v0)
    return 1
def _9():
    global x0
    global x1
    global x2
    global x3
    sa(sr())
    sa(sr())
    sa(sp()*sp());
    sa(x3)
    v0=sp()
    sa(sp()-v0)
    return 0
def _10():
    global x0
    global x1
    global x2
    global x3
    sp()
    sp()
    return 11
def _11():
    global x0
    global x1
    global x2
    global x3
    sa((x2)+(1))
    x2=(x2)+(1)
    sa(x1)
    v0=sp()
    sa(sp()-v0)
    return 2
def _12():
    global x0
    global x1
    global x2
    global x3
    sa((x1)+(1))
    x1=(x1)+(1)
    sa(x0)
    v0=sp()
    sa(sp()-v0)
    return 3
def _13():
    global x0
    global x1
    global x2
    global x3
    return 17
def _14():
    global x0
    global x1
    global x2
    global x3
    sa(sr())
    x3=sp()
    sa((x2)+(x1))
    sa(sp()+sp());
    sa(x0)
    v0=sp()
    sa(sp()-v0)
    return 4
def _15():
    global x0
    global x1
    global x2
    global x3
    sa(x2)
    print(x2,end="",flush=True)
    print(chr(32),end="",flush=True)
    sa(x1)
    print(x1,end="",flush=True)
    print(chr(32),end="",flush=True)
    sa(x3)
    print(x3,end="",flush=True)
    print(chr(61),end="",flush=True)
    sa(sp()*sp());
    sa(sp()*sp());
    print(sp(),end="",flush=True)
    return 17
def _16():
    global x0
    global x1
    global x2
    global x3
    sp()
    return 11
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16]
c=5
while c<17:
    c=m[c]()