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
def _0():
    return (6)if(sp()!=0)else(7)
def _1():
    return (16)if(sp()!=0)else(8)
def _2():
    return (11)if(sp()!=0)else(10)
def _3():
    return (12)if(sp()!=0)else(9)
def _4():
    return (15)if(sp()!=0)else(14)
def _5():
    sa(0)
    sa(1)
    sa(1)
    sa(0)
    sa(59049)
    sa(59049)
    return 0
def _6():
    sa(10)
    v0=sp()
    sa(td(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(1)
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    return 0
def _7():
    sp()
    v0=sp()
    sa(sp()-v0)
    return 1
def _8():
    sa(59049)
    sa(sp()*sp());
    return 9
def _9():
    sa(sr())
    sa(sr())
    sa(sr())
    sa(10)
    v0=sp()
    sa(tm(sp(),v0))
    sa(sr())
    sa(sr())
    sa(sp()*sp());
    sa(sr())
    sa(sp()*sp());
    sa(sp()*sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(10)
    v0=sp()
    sa(td(sp(),v0))
    sa(sr())
    sa(10)
    v0=sp()
    sa(tm(sp(),v0))
    sa(sr())
    sa(sr())
    sa(sp()*sp());
    sa(sr())
    sa(sp()*sp());
    sa(sp()*sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(10)
    v0=sp()
    sa(td(sp(),v0))
    sa(sr())
    sa(10)
    v0=sp()
    sa(tm(sp(),v0))
    sa(sr())
    sa(sr())
    sa(sp()*sp());
    sa(sr())
    sa(sp()*sp());
    sa(sp()*sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(10)
    v0=sp()
    sa(td(sp(),v0))
    sa(sr())
    sa(10)
    v0=sp()
    sa(tm(sp(),v0))
    sa(sr())
    sa(sr())
    sa(sp()*sp());
    sa(sr())
    sa(sp()*sp());
    sa(sp()*sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(10)
    v0=sp()
    sa(td(sp(),v0))
    sa(sr())
    sa(10)
    v0=sp()
    sa(tm(sp(),v0))
    sa(sr())
    sa(sr())
    sa(sp()*sp());
    sa(sr())
    sa(sp()*sp());
    sa(sp()*sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(10)
    v0=sp()
    sa(td(sp(),v0))
    sa(sr())
    sa(10)
    v0=sp()
    sa(tm(sp(),v0))
    sa(sr())
    sa(sr())
    sa(sp()*sp());
    sa(sr())
    sa(sp()*sp());
    sa(sp()*sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(10)
    v0=sp()
    sa(td(sp(),v0))
    sa(10)
    v0=sp()
    sa(tm(sp(),v0))
    sa(sr())
    sa(sr())
    sa(sp()*sp());
    sa(sr())
    sa(sp()*sp());
    sa(sp()*sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    v0=sp()
    sa(sp()-v0)
    return 2
def _10():
    sa(sr())
    return 11
def _11():
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    sa((0)if(sp()!=0)else(1))
    return 3
def _12():
    sp()
    sp()
    return 13
def _13():
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    return 4
def _14():
    sp()
    print(sp(),end="",flush=True)
    return 17
def _15():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+sp());
    return 13
def _16():
    sa(1)
    sa(sp()+sp());
    sa(sr())
    sa(sr())
    sa(59049)
    sa(sp()*sp());
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    return 0
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16]
c=5
while c<17:
    c=m[c]()