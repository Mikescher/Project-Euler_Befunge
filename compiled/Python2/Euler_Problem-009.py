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
    global x2
    global x1
    global x3
    sa((x2*x2)+(x1*x1))
    x3=(x2*x2)+(x1*x1)
    sa(0)
    sa(0-x3)
    return 3
def _3():
    return (4)if(sp()!=0)else(10)
def _4():
    global x0
    sa(sp()+1)


    return (9)if((sr()-x0)!=0)else(5)
def _5():
    sp();
    sp();
    return 6
def _6():
    global t0
    global x2
    global x1
    t0=x2+1
    x2=x2+1
    t0=t0-x1

    return (2)if((t0)!=0)else(7)
def _7():
    global t0
    global x1
    global x0
    t0=x1+1
    x1=x1+1
    t0=t0-x0

    return (1)if((t0)!=0)else(8)
def _8():
    return 13
def _9():
    global x3
    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa(sp()-x3)
    return 3
def _10():
    global x3
    global x2
    global x1
    global x0
    x3=sr()
    sa(sp()+x2+x1)

    sa(sp()-x0)


    return (11)if(sp()!=0)else(12)
def _11():
    sp();
    return 6
def _12():
    global x2
    global x1
    global x3
    sys.stdout.write(str(x2)+" ")
    sys.stdout.flush()

    sys.stdout.write(chr(32))
    sys.stdout.flush()

    sys.stdout.write(str(x1)+" ")
    sys.stdout.flush()

    sys.stdout.write(chr(32))
    sys.stdout.flush()

    sys.stdout.write(str(x3)+" ")
    sys.stdout.flush()

    sys.stdout.write(chr(61))
    sys.stdout.flush()

    sys.stdout.write(str(x2*x1*x3)+" ")
    sys.stdout.flush()
    return 13
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12]
c=0
while c<13:
    c=m[c]()
