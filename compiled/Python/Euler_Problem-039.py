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
x0=32
x1=32
x2=32
x3=32
x4=32
x5=32
def _0():
    global x0
    global x1
    global x2
    global x3
    global x4
    global x5
    return (12)if((x2)-(2))else(6)
def _1():
    global x0
    global x1
    global x2
    global x3
    global x4
    global x5
    return (7)if((1)if((x5)>(x0))else(0))else(11)
def _2():
    global x0
    global x1
    global x2
    global x3
    global x4
    global x5
    return (10)if((x3)-(x4))else(9)
def _3():
    global x0
    global x1
    global x2
    global x3
    global x4
    global x5
    return (5)if(tm((x3)*((x3)-((2)*(x2))),((x3)-(x2))*(2)))else(13)
def _4():
    global x0
    global x1
    global x2
    global x3
    global x4
    global x5
    x0=0
    x1=0
    x3=6
    x4=1000
    x5=0
    x2=td(x3,3)
    return 5
def _5():
    global x0
    global x1
    global x2
    global x3
    global x4
    global x5
    sa(x2)
    return 0
def _6():
    global x0
    global x1
    global x2
    global x3
    global x4
    global x5
    sp()
    sa(x5)
    return 1
def _7():
    global x0
    global x1
    global x2
    global x3
    global x4
    global x5
    x0=sp()
    x1=x3
    return 8
def _8():
    global x0
    global x1
    global x2
    global x3
    global x4
    global x5
    sa(x3)
    return 2
def _9():
    global x0
    global x1
    global x2
    global x3
    global x4
    global x5
    sp()
    print(x1,end="",flush=True)
    return 14
def _10():
    global x0
    global x1
    global x2
    global x3
    global x4
    global x5
    sa(2)
    sa(sp()+sp());
    x3=sp()
    x5=0
    x2=td(x3,3)
    return 5
def _11():
    global x0
    global x1
    global x2
    global x3
    global x4
    global x5
    sp()
    return 8
def _12():
    global x0
    global x1
    global x2
    global x3
    global x4
    global x5
    sa(1)
    v0=sp()
    sa(sp()-v0)
    x2=sp()
    return 3
def _13():
    global x0
    global x1
    global x2
    global x3
    global x4
    global x5
    x5=(x5)+(1)
    return 5
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13]
c=4
while c<14:
    c=m[c]()