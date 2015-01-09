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
x0=32
x1=32
x2=32
def _0():
    global x0
    global x1
    global x2
    return (6)if(sp()!=0)else(13)
def _1():
    global x0
    global x1
    global x2
    return (9)if(sp()!=0)else(8)
def _2():
    global x0
    global x1
    global x2
    return (12)if(sp()!=0)else(10)
def _3():
    global x0
    global x1
    global x2
    return (12)if(sp()!=0)else(11)
def _4():
    global x0
    global x1
    global x2
    return (12)if(sp()!=0)else(11)
def _5():
    global x0
    global x1
    global x2
    x0=1
    sa(0)
    sa(1)
    sa(10)
    sa(100)
    sa(1000)
    sa(10000)
    sa(100000)
    sa(1000000)
    sa(1000000)
    return 0
def _6():
    global x0
    global x1
    global x2
    x1=1
    x2=1
    return 7
def _7():
    global x0
    global x1
    global x2
    sa(sr())
    sa((x1)*((9)*(x2)))
    v0=sp()
    sa((1)if(sp()>v0)else(0))
    sa((0)if(sp()!=0)else(1))
    return 1
def _8():
    global x0
    global x1
    global x2
    sa((x1)*((9)*(x2)))
    x1=(x1)+(1)
    x2=(x2)*(10)
    v0=sp()
    sa(sp()-v0)
    return 7
def _9():
    global x0
    global x1
    global x2
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    sa(x1)
    v0=sp()
    sa(td(sp(),v0))
    sa(x2)
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(x1)
    v0=sp()
    sa(tm(sp(),v0))
    sa(x1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa(sp()-v0)
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    return 2
def _10():
    global x0
    global x1
    global x2
    sa(sr())
    return 4
def _11():
    global x0
    global x1
    global x2
    sp()
    sa(10)
    v0=sp()
    sa(tm(sp(),v0))
    sa(x0)
    sa(sp()*sp());
    x0=sp()
    sa(sr())
    return 0
def _12():
    global x0
    global x1
    global x2
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(10)
    v0=sp()
    sa(td(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    return 3
def _13():
    global x0
    global x1
    global x2
    sp()
    print(x0,end="",flush=True)
    return 14
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13]
c=5
while c<14:
    c=m[c]()