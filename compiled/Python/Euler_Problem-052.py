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
x0=88
x1=88
x2=88
x3=88
x4=88
def _0():
    global x0
    global x1
    global x2
    global x3
    global x4
    return (17)if(sp()!=0)else(6)
def _1():
    global x0
    global x1
    global x2
    global x3
    global x4
    return (10)if(sp()!=0)else(9)
def _2():
    global x0
    global x1
    global x2
    global x3
    global x4
    return (16)if(sp()!=0)else(15)
def _3():
    global x0
    global x1
    global x2
    global x3
    global x4
    return (13)if(sp()!=0)else(12)
def _4():
    global x0
    global x1
    global x2
    global x3
    global x4
    return (14)if((x4)-(x1))else(11)
def _5():
    global x0
    global x1
    global x2
    global x3
    global x4
    x0=10
    x3=1
    x1=1
    sa(10)
    sa(1)
    sa(1)
    sa(1)
    sa(1)
    return 0
def _6():
    global x0
    global x1
    global x2
    global x3
    global x4
    x2=2
    sp()
    sa(sr())
    sa(x2)
    return 7
def _7():
    global x0
    global x1
    global x2
    global x3
    global x4
    x4=1
    sa(sp()*sp());
    sa(10)
    sa(sp()*sp());
    return 8
def _8():
    global x0
    global x1
    global x2
    global x3
    global x4
    sa(10)
    v0=sp()
    sa(td(sp(),v0))
    sa(sr())
    sa((0)if(sp()!=0)else(1))
    return 1
def _9():
    global x0
    global x1
    global x2
    global x3
    global x4
    sa(sr())
    sa(10)
    v0=sp()
    sa(tm(sp(),v0))
    sa(2)
    sa(sp()+sp());
    sa(x4)
    sa(sp()*sp());
    x4=sp()
    return 8
def _10():
    global x0
    global x1
    global x2
    global x3
    global x4
    sp()
    return 4
def _11():
    global x0
    global x1
    global x2
    global x3
    global x4
    sa((x2)+(1))
    x2=(x2)+(1)
    sa(7)
    v0=sp()
    sa(sp()-v0)
    return 3
def _12():
    global x0
    global x1
    global x2
    global x3
    global x4
    print(sp(),end="",flush=True)
    sp()
    sp()
    return 18
def _13():
    global x0
    global x1
    global x2
    global x3
    global x4
    sa(sr())
    sa(x2)
    return 7
def _14():
    global x0
    global x1
    global x2
    global x3
    global x4
    sp()
    sa(1)
    sa(sp()+sp());
    sa(sr())
    sa(x3)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa((1)if(sp()>v0)else(0))
    sa((0)if(sp()!=0)else(1))
    return 2
def _15():
    global x0
    global x1
    global x2
    global x3
    global x4
    x1=1
    sa(sr())
    sa(sr())
    sa(10)
    sa(sp()*sp());
    sa(10)
    v0=sp()
    sa(td(sp(),v0))
    sa(sr())
    return 0
def _16():
    global x0
    global x1
    global x2
    global x3
    global x4
    sp()
    sa(10)
    sa(sp()*sp());
    sa(sr())
    x0=sp()
    sa(sr())
    sa(6)
    v0=sp()
    sa(td(sp(),v0))
    x3=sp()
    x1=1
    sa(sr())
    sa(10)
    v0=sp()
    sa(td(sp(),v0))
    sa(sr())
    sa(sr())
    sa(10)
    sa(sp()*sp());
    sa(10)
    v0=sp()
    sa(td(sp(),v0))
    sa(sr())
    return 0
def _17():
    global x0
    global x1
    global x2
    global x3
    global x4
    sa(sr())
    sa(10)
    v0=sp()
    sa(tm(sp(),v0))
    sa(2)
    sa(sp()+sp());
    sa(x1)
    sa(sp()*sp());
    x1=sp()
    sa(10)
    v0=sp()
    sa(td(sp(),v0))
    sa(sr())
    return 0
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17]
c=5
while c<18:
    c=m[c]()