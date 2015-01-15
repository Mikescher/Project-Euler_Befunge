# compiled with BefunCompile v1.0.2 (c) 2015
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
x0=52
x1=53
x2=42
x3=48
x4=48
x5=112
def _0():
    global x0
    global x1
    global x2
    global x3
    global x4
    global x5
    return (7)if(sp()!=0)else(12)
def _1():
    global x0
    global x1
    global x2
    global x3
    global x4
    global x5
    return (6)if(sp()!=0)else(3)
def _2():
    global x0
    global x1
    global x2
    global x3
    global x4
    global x5
    return (4)if(sp()!=0)else(11)
def _3():
    global x0
    global x1
    global x2
    global x3
    global x4
    global x5
    return (8)if(tm(x1,x3))else(9)
def _4():
    global x0
    global x1
    global x2
    global x3
    global x4
    global x5
    return (10)if((0)if((tm(x4,x5))!=0)else(1))else(8)
def _5():
    global x0
    global x1
    global x2
    global x3
    global x4
    global x5
    x0=20
    x1=1
    x2=1
    return 6
def _6():
    global x0
    global x1
    global x2
    global x3
    global x4
    global x5
    x1=(x1)*(x2)
    sa(x0)
    sa((x2)+(1))
    x2=(x2)+(1)
    v0=sp()
    sa((1)if(sp()>v0)else(0))
    return 0
def _7():
    global x0
    global x1
    global x2
    global x3
    global x4
    global x5
    x3=1
    return 8
def _8():
    global x0
    global x1
    global x2
    global x3
    global x4
    global x5
    sa(x3)
    x3=(x3)+(1)
    sa(x0)
    v0=sp()
    sa((1)if(sp()>v0)else(0))
    return 1
def _9():
    global x0
    global x1
    global x2
    global x3
    global x4
    global x5
    x4=td(x1,x3)
    x5=1
    return 10
def _10():
    global x0
    global x1
    global x2
    global x3
    global x4
    global x5
    sa(x2)
    sa((x5)+(1))
    x5=(x5)+(1)
    v0=sp()
    sa((1)if(sp()>v0)else(0))
    return 2
def _11():
    global x0
    global x1
    global x2
    global x3
    global x4
    global x5
    x1=td(x1,x3)
    return 3
def _12():
    global x0
    global x1
    global x2
    global x3
    global x4
    global x5
    print(x1,end="",flush=True)
    return 13
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12]
c=5
while c<13:
    c=m[c]()