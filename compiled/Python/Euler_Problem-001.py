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
    return (12)if(sp()!=0)else(5)
def _1():
    return (8)if(sp()!=0)else(7)
def _2():
    return (11)if(sp()!=0)else(10)
def _3():
    return (12)if(sp()!=0)else(6)
def _4():
    sa(1)
    sa(2)
    sa(2)
    sa(0)
    return 0
def _5():
    sa(sr())
    sa(sr())
    sa(5)
    v0=sp()
    sa(td(sp(),v0))
    sa(5)
    sa(sp()*sp());
    v0=sp()
    sa(sp()-v0)
    sa((0)if(sp()!=0)else(1))
    return 3
def _6():
    sa(sr())
    sa(1000)
    v0=sp()
    sa(sp()-v0)
    sa((0)if(sp()!=0)else(1))
    return 1
def _7():
    sp()
    sa(1)
    sa(sp()+sp());
    sa(sr())
    sa(sr())
    sa(sr())
    sa(3)
    v0=sp()
    sa(td(sp(),v0))
    sa(3)
    sa(sp()*sp());
    v0=sp()
    sa(sp()-v0)
    sa((0)if(sp()!=0)else(1))
    return 0
def _8():
    sp()
    sp()
    sp()
    return 9
def _9():
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa((0)if(sp()!=0)else(1))
    return 2
def _10():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 9
def _11():
    sp()
    print(sp(),end="",flush=True)
    return 13
def _12():
    sa(sr())
    return 6
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12]
c=4
while c<13:
    c=m[c]()