#!/usr/bin/env python2

# transpiled with BefunCompile v1.3.0 (c) 2017
import sys
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
x0=0
x1=1000000
x2=0
x3=1
x4=1
x5=63
x6=63
x7=63
x8=63
def _0():
    sa(1)
    sa(0)
    return 1
def _1():
    return (5)if(sp()!=0)else(2)
def _2():
    global x5
    global t0
    global x6
    x5=sr()
    t0=(sr()*3)/7
    x6=t0
    t0=t0*7
    t0=t0-(x5*3)

    return (3)if(t0>0)else(8)
def _3():
    global x7
    global t0
    global x8
    global x5
    global x4
    global x3
    x7=t0
    x8=x5*7

    return (4)if((x4*x8)>(x3*x7))else(5)
def _4():
    global x4
    global x7
    global x3
    global x8
    global x0
    global x6
    global x2
    global x5
    x4=x7
    x3=x8
    x0=x6
    x2=x5
    return 5
def _5():
    global x1
    return (7)if((sr()-x1)!=0)else(6)
def _6():
    global x0
    global x2
    sys.stdout.write(str(x0)+" ")
    sys.stdout.flush()

    sys.stdout.write(" /")
    sys.stdout.flush()

    sys.stdout.write(chr(10))
    sys.stdout.flush()

    sys.stdout.write(str(x2)+" ")
    sys.stdout.flush()

    sp();
    return 9
def _7():
    sa(sp()+1)

    sa((0)if((sr()*3)%7!=0)else(1))
    return 1
def _8():
    global t0
    t0=t0*-1
    return 3
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8]
c=0
while c<9:
    c=m[c]()
