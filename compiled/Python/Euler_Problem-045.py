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
    return (17)if(sp()!=0)else(8)
def _1():
    global x0
    global x1
    global x2
    return (9)if(sp()!=0)else(11)
def _2():
    global x0
    global x1
    global x2
    return (16)if(sp()!=0)else(10)
def _3():
    global x0
    global x1
    global x2
    return (9)if(sp()!=0)else(11)
def _4():
    global x0
    global x1
    global x2
    return (13)if(sp()!=0)else(12)
def _5():
    global x0
    global x1
    global x2
    return (15)if(sp()!=0)else(14)
def _6():
    global x0
    global x1
    global x2
    x0=1152921504606846976
    x2=0
    x1=991873
    sa(144)
    sa(991873)
    return 7
def _7():
    global x0
    global x1
    global x2
    sa(x0)
    sa((1)if((x0)>(x1))else(0))
    return 0
def _8():
    global x0
    global x1
    global x2
    sa(sr())
    return 1
def _9():
    global x0
    global x1
    global x2
    sa(sr())
    sa(x2)
    sa(sp()+sp());
    sa(x1)
    v0=sp()
    sa((1)if(sp()>v0)else(0))
    sa((0)if(sp()!=0)else(1))
    return 2
def _10():
    global x0
    global x1
    global x2
    x2=td(x2,2)
    sa(4)
    v0=sp()
    sa(td(sp(),v0))
    sa(sr())
    return 3
def _11():
    global x0
    global x1
    global x2
    sp()
    sa((x2)*(x2))
    v0=sp()
    sa(sp()-v0)
    sa((0)if(((tm(x2,6))-(5))!=0)else(1))
    return 4
def _12():
    global x0
    global x1
    global x2
    x2=0
    sp()
    sa(1)
    sa(sp()+sp());
    sa(sr())
    sa(sr())
    sa(2)
    sa(sp()*sp());
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sp()*sp());
    sa(24)
    sa(sp()*sp());
    sa(1)
    sa(sp()+sp());
    sa(sr())
    x1=sp()
    return 7
def _13():
    global x0
    global x1
    global x2
    sa((0)if(sp()!=0)else(1))
    return 5
def _14():
    global x0
    global x1
    global x2
    x2=0
    sa(1)
    sa(sp()+sp());
    sa(sr())
    sa(sr())
    sa(2)
    sa(sp()*sp());
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sp()*sp());
    sa(24)
    sa(sp()*sp());
    sa(1)
    sa(sp()+sp());
    sa(sr())
    x1=sp()
    return 7
def _15():
    global x0
    global x1
    global x2
    sa(sr())
    sa(2)
    sa(sp()*sp());
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sp()*sp());
    print(sp(),end="",flush=True)
    return 18
def _16():
    global x0
    global x1
    global x2
    sa(sr())
    sa(x2)
    sa(sp()+sp());
    sa(x1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa(sp()-v0)
    x1=sp()
    sa(sr())
    sa(2)
    sa(sp()*sp());
    sa(x2)
    sa(sp()+sp());
    x2=sp()
    x2=td(x2,2)
    sa(4)
    v0=sp()
    sa(td(sp(),v0))
    return 8
def _17():
    global x0
    global x1
    global x2
    sa(4)
    v0=sp()
    sa(td(sp(),v0))
    sa(sr())
    sa(x1)
    v0=sp()
    sa((1)if(sp()>v0)else(0))
    return 0
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17]
c=6
while c<18:
    c=m[c]()