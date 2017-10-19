#!/usr/bin/env python3

# transpiled with BefunCompile v1.3.0 (c) 2017
def td(a,b):
    return ((0)if(b==0)else(a//b))
def tm(a,b):
    return ((0)if(b==0)else(a%b))
x0=20
x1=1
x2=1
x3=48
x4=112
x5=48
def _0():
    return 1
def _1():
    global x1
    global x2
    global t0
    global x0
    x1=x1*x2
    t0=(1)if(x0>(x2+1))else(0)
    x2=x2+1

    return (3)if((t0)!=0)else(2)
def _2():
    global x1
    print(x1,end=" ",flush=True)
    return 10
def _3():
    global x3
    x3=1
    return 4
def _4():
    global t0
    global x3
    global x0
    t0=x3
    x3=x3+1
    t0=(1)if(t0>x0)else(0)

    return (1)if((t0)!=0)else(5)
def _5():
    global x1
    global x3
    return (4)if((tm(x1,x3))!=0)else(6)
def _6():
    global x5
    global x1
    global x3
    global x4
    x5=td(x1,x3)
    x4=1
    return 7
def _7():
    global t0
    global x2
    global x4
    t0=(1)if(x2>(x4+1))else(0)
    x4=x4+1

    return (9)if((t0)!=0)else(8)
def _8():
    global x1
    global x3
    x1=td(x1,x3)
    return 5
def _9():
    global x5
    global x4
    return (4)if((tm(x5,x4))!=0)else(7)
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9]
c=0
while c<10:
    c=m[c]()
