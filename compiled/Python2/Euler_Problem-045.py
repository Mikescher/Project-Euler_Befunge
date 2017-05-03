#!/usr/bin/env python2

# transpiled with BefunCompile v1.1.0 (c) 2015
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
x0=1152921504606846976
x1=991873
x2=0
def _0():
    sa(144)
    sa(991873)
    return 1
def _1():
    global x0
    sa(x0)
    sa((1)if(x0>x1)else(0))
    return 2
def _2():
    return (12)if(sp()!=0)else(3)
def _3():
    sa(sr());

    return (9)if(sp()!=0)else(4)
def _4():
    sp();
    sa(sp()-(x2*x2));


    return (5)if((tm(x2,6))-5==0)else(8)
def _5():
    sa((0)if(sp()!=0)else(1))

    return (7)if(sp()!=0)else(6)
def _6():
    global x2
    global t0
    global x1
    x2=0
    sa(sp()+1);

    sa(sr());
    t0=(sr()*2)-1
    sa(sp()*t0);

    sa(sp()*24);

    sa(sp()+1);

    x1=sr()
    return 1
def _7():
    global t0
    global t1
    t0=(sr()*2)-1
    sa(sp()*t0);

    t1=sp()
    sys.stdout.write(str(t1))
    sys.stdout.flush()
    return 13
def _8():
    global x2
    global t0
    global x1
    x2=0
    sp();
    sa(sp()+1);

    sa(sr());
    t0=(sr()*2)-1
    sa(sp()*t0);

    sa(sp()*24);

    sa(sp()+1);

    x1=sr()
    return 1
def _9():
    return (11)if((sr()+x2)<=x1)else(10)
def _10():
    global x2
    x2=td(x2,2)
    sa(td(sp(),4))

    sa(sr());

    return (9)if(sp()!=0)else(4)
def _11():
    global t0
    global t1
    global x1
    global t2
    global x2
    t0=sr()+x2
    t1=x1
    t2=t1-t0
    x1=t2
    t0=(sr()*2)+x2
    x2=t0
    x2=td(x2,2)
    sa(td(sp(),4))
    return 3
def _12():
    sa(td(sp(),4))

    sa((1)if(sr()>x1)else(0))
    return 2
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12]
c=0
while c<13:
    c=m[c]()
