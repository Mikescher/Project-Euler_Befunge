#!/usr/bin/env python3
# compiled with BefunCompile v1.0.6 (c) 2015
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
x0=1000
x1=2
x2=34
x3=53
def _0():
    return 1
def _1():
    global x2
    x2=1
    return 2
def _2():
    global x3
    sa((x2*x2)+(x1*x1))
    x3=(x2*x2)+(x1*x1)
    sa(0)
    sa(0-x3)
    return 3
def _3():
    return (10)if(sp()!=0)else(4)
def _4():
    global x3
    global x0
    x3=sr()
    sa(sp()+x2+x1);
    sa(sp()-x0);
    return (5)if(sp()!=0)else(9)
def _5():
    sp()
    return 6
def _6():
    global x2
    global x1
    sa(x2+1)
    x2=x2+1
    sa(sp()-x1);
    return (2)if(sp()!=0)else(7)
def _7():
    global x1
    global x0
    sa(x1+1)
    x1=x1+1
    sa(sp()-x0);
    return (1)if(sp()!=0)else(8)
def _8():
    return 13
def _9():
    global x2
    global x2
    global x1
    global x1
    global x3
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
    return 13
def _10():
    sa(sp()+1);
    return (12)if(sr()!=x0)else(11)
def _11():
    sp()
    sp()
    return 6
def _12():
    global x3
    sa(sr())
    sa(sr())
    sa(sp()*sp());
    sa(sp()-x3);
    return 3
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12]
c=0
while c<13:
    c=m[c]()