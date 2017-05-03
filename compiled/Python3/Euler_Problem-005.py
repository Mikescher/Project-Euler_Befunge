#!/usr/bin/env python3

# transpiled with BefunCompile v1.1.0 (c) 2015
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
x0=20
x1=1
x2=1
x3=48
x4=48
x5=112
def _0():
    return 1
def _1():
    global x1
    global t0
    global x0
    global t1
    global x2
    global t2
    x1=x1*x2
    t0=x0
    t1=x2+1
    x2=x2+1
    t2=(1)if(t0>t1)else(0)

    return (3)if((t2)!=0)else(2)
def _2():
    global x1
    print(x1,end="",flush=True)
    return 10
def _3():
    global x3
    x3=1
    return 4
def _4():
    global t0
    global x3
    t0=x3
    x3=x3+1
    t0=(1)if(t0>x0)else(0)

    return (1)if((t0)!=0)else(5)
def _5():
    return (4)if(tm(x1,x3)!=0)else(6)
def _6():
    global x4
    global x5
    x4=td(x1,x3)
    x5=1
    return 7
def _7():
    global t0
    global x2
    global t1
    global x5
    global t2
    t0=x2
    t1=x5+1
    x5=x5+1
    t2=(1)if(t0>t1)else(0)

    return (9)if((t2)!=0)else(8)
def _8():
    global x1
    x1=td(x1,x3)
    return 5
def _9():
    return (7)if(tm(x4,x5)==0)else(4)
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9]
c=0
while c<10:
    c=m[c]()
