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
x0=118
x1=32
def _0():
    global x0
    global x1
    return (14)if(sp()!=0)else(5)
def _1():
    global x0
    global x1
    return (7)if(sp()!=0)else(8)
def _2():
    global x0
    global x1
    return (13)if(sp()!=0)else(9)
def _3():
    global x0
    global x1
    return (12)if(sp()!=0)else(11)
def _4():
    global x0
    global x1
    x0=0
    sa(4)
    sa(1)
    sa(4)
    sa(0)
    return 0
def _5():
    global x0
    global x1
    sa(2)
    v0=sp()
    sa(td(sp(),v0))
    return 6
def _6():
    global x0
    global x1
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
    sa(1)
    v0=sp()
    sa(sp()-v0)
    return 1
def _7():
    global x0
    global x1
    sa(1)
    v0=sp()
    sa(td(sp(),v0))
    sa(sr())
    sa(2)
    v0=sp()
    sa(tm(sp(),v0))
    return 0
def _8():
    global x0
    global x1
    sp()
    sa(sr())
    sa(x0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa((1)if(sp()>v0)else(0))
    return 2
def _9():
    global x0
    global x1
    x0=sp()
    sa(sr())
    x1=sp()
    return 10
def _10():
    global x0
    global x1
    sa(sr())
    sa(1000000)
    v0=sp()
    sa((1)if(sp()>v0)else(0))
    sa((0)if(sp()!=0)else(1))
    return 3
def _11():
    global x0
    global x1
    print(x1,end="",flush=True)
    sa(x0)
    sa(58)
    print(chr(32),end="",flush=True)
    print(chr(sp()),end="",flush=True)
    print(sp(),end="",flush=True)
    return 15
def _12():
    global x0
    global x1
    sa(1)
    sa(sp()+sp());
    sa(sr())
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    sa(2)
    v0=sp()
    sa(tm(sp(),v0))
    return 0
def _13():
    global x0
    global x1
    sp()
    return 10
def _14():
    global x0
    global x1
    sa(3)
    sa(sp()*sp());
    sa(1)
    sa(sp()+sp());
    return 6
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14]
c=4
while c<15:
    c=m[c]()