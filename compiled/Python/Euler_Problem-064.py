#!/usr/bin/env python3
# compiled with BefunCompile v1.0.5 (c) 2015
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
x0=10000
x1=35
x2=35
x3=9
x4=35
x5=35
x6=0
x7=1
def _0():
    sa(0)
    sa(10000)
    sa(0)
    return 1
def _1():
    global x0
    global x4
    global x1
    sa(x0)
    x4=0
    x1=sr()
    return 2
def _2():
    global x2
    global x1
    x2=sr()
    sa(sr())
    sa(x1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa(td(sp(),v0))
    sa(sp()+sp());
    sa(td(sp(),2))
    return (15)if(sr()!=x2)else(3)
def _3():
    global x2
    sp()
    sa(x2)
    return (12)if((x2*x2)!=x0)else(4)
def _4():
    sa(0)
    return 5
def _5():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    return (11)if(sp()!=0)else(6)
def _6():
    sp()
    sa(tm(sp(),2))
    return (8)if(sp()!=0)else(7)
def _7():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+1);
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 8
def _8():
    return (10)if(sr()!=2)else(9)
def _9():
    sp()
    print(sp(),end="",flush=True)
    return 17
def _10():
    global x3
    global x0
    global x6
    global x7
    x3=9
    sa(sp()-1);
    sa(sr())
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    x0=sp()
    x6=0
    x7=1
    return 1
def _11():
    sp()
    sa(sp()+1);
    return 5
def _12():
    global x5
    global x6
    global x7
    global x6
    x5=sr()
    sa(sp()+x6);
    sa(td(sp(),x7))
    sa((sr()*x7)-x6)
    x6=sp()
    return 13
def _13():
    return (14)if(((x7-1)+x3)!=0)else(4)
def _14():
    global x7
    global x3
    global x6
    x7=td(x0-(x6*x6),x7)
    x3=0
    sa(td(x5+x6,x7))
    x6=((td(x5+x6,x7))*x7)-x6
    return 13
def _15():
    return (16)if(sr()!=x4)else(3)
def _16():
    global x4
    global x2
    x4=x2
    return 2
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16]
c=0
while c<17:
    c=m[c]()