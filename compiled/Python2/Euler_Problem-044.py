#!/usr/bin/env python2

# transpiled with BefunCompile v1.2.0 (c) 2017
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
x0=1073741824
x1=2
x2=37
x3=37
x4=37
x5=5
x6=37
def _0():
    sa(2)
    sa(5)
    return 1
def _1():
    sa(x1-1)
    sa(x1-1)
    return 2
def _2():
    return (4)if(sp()!=0)else(3)
def _3():
    global x1
    global t0
    global x5
    sp();
    sp();
    sa(sp()+1);

    sa(sr());
    x1=sr()
    t0=(sr()*3)-1
    sa(sp()*t0);

    sa(td(sp(),2))

    x5=sr()
    return 1
def _4():
    global x2
    global t0
    global t1
    global x3
    global x6
    global x4
    global x0
    x2=sr()
    t0=(sr()*3)-1
    sa(sp()*t0);

    t1=sp()
    t1=td(t1,2)
    x3=t1
    x6=0
    sa(sp()-t1);

    sa(sp()*24);

    sa(sp()+1);

    x4=sr()
    sa(x0)
    sa((1)if(x0>x4)else(0))
    return 5
def _5():
    return (25)if(sp()!=0)else(6)
def _6():
    sa(sr());
    return 7
def _7():
    return (22)if(sp()!=0)else(8)
def _8():
    global t0
    global x6
    sp();
    sa(sp()-(x6*x6));

    t0=x6

    return (17)if(sp()!=0)else(9)
def _9():
    global t0
    t0=tm(t0,6)
    t0=t0-5
    t0=(0)if(t0!=0)else(1)

    return (10)if((t0)!=0)else(17)
def _10():
    global t0
    global x6
    global x4
    global x0
    sa(((x3+x5)*24)+1)
    t0=((x3+x5)*24)+1
    x6=0
    x4=t0
    sa(x0)
    sa((1)if(x0>x4)else(0))
    return 11
def _11():
    return (21)if(sp()!=0)else(12)
def _12():
    sa(sr());
    return 13
def _13():
    return (18)if(sp()!=0)else(14)
def _14():
    global t0
    global x6
    sp();
    sa(sp()-(x6*x6));

    t0=x6

    return (17)if(sp()!=0)else(15)
def _15():
    global t0
    t0=tm(t0,6)
    t0=t0-5

    return (17)if((t0)!=0)else(16)
def _16():
    sys.stdout.write(str(x5-x3)+" ")
    sys.stdout.flush()

    sp();
    return 26
def _17():
    global x5
    sa(x5)
    sa(x2-1)
    sa(x2-1)
    return 2
def _18():
    return (20)if((sr()+x6)<=x4)else(19)
def _19():
    global x6
    x6=td(x6,2)
    sa(td(sp(),4))

    sa(sr());
    return 13
def _20():
    global t0
    global t1
    global x4
    global t2
    global x6
    t0=sr()+x6
    t1=x4
    t2=t1-t0
    x4=t2
    t0=(sr()*2)+x6
    x6=t0
    x6=td(x6,2)
    sa(td(sp(),4))
    return 12
def _21():
    sa(td(sp(),4))

    sa((1)if(sr()>x4)else(0))
    return 11
def _22():
    return (24)if((sr()+x6)<=x4)else(23)
def _23():
    global x6
    x6=td(x6,2)
    sa(td(sp(),4))

    sa(sr());
    return 7
def _24():
    global t0
    global t1
    global x4
    global t2
    global x6
    t0=sr()+x6
    t1=x4
    t2=t1-t0
    x4=t2
    t0=(sr()*2)+x6
    x6=t0
    x6=td(x6,2)
    sa(td(sp(),4))
    return 6
def _25():
    sa(td(sp(),4))

    sa((1)if(sr()>x4)else(0))
    return 5
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25]
c=0
while c<26:
    c=m[c]()
