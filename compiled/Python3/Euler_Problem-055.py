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
x0=32
x1=32
def _0():
    sa(0)
    sa(10000)
    sa(10000)
    sa(0)
    sa(10000)
    return 1
def _1():
    global t0
    global x1
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()*10);

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    t0=tm(sr(),10)
    x1=t0
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+x1);

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),10))

    sa(sr());
    sa((0)if(sp()!=0)else(1))
    return 2
def _2():
    return (3)if(sp()!=0)else(1)
def _3():
    sp();
    sa(sp()+sp());

    sa(24)
    return 4
def _4():
    global t0
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr());
    sa(sr());
    t0=0
    return 5
def _5():
    sa(sr());
    sa((0)if(sp()!=0)else(1))

    return (6)if(sp()!=0)else(13)
def _6():
    global x0
    global t0
    global t1
    sp();
    x0=t0
    sa(sp()-t0);

    t1=sp()

    return (7)if((t1)!=0)else(12)
def _7():
    global x0
    sa(sr());
    sp();
    sa(sp()+x0);

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()-1);

    sa(sr());
    sa((0)if(sp()!=0)else(1))

    return (8)if(sp()!=0)else(4)
def _8():
    sp();
    sp();
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+1);

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 9
def _9():
    sa(sp()-1);

    sa(sr());
    sa((0)if(sp()!=0)else(1))

    return (10)if(sp()!=0)else(11)
def _10():
    sp();
    print(sp(),end="",flush=True)
    return 14
def _11():
    sa(sr());
    sa(sr());
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr());
    sa((0)if(sp()!=0)else(1))
    return 2
def _12():
    sp();
    sp();
    return 9
def _13():
    global t0
    global t1
    global x1
    t0=t0*10
    t1=tm(sr(),10)
    x1=t1
    t0=t0+x1
    sa(td(sp(),10))
    return 5
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13]
c=0
while c<14:
    c=m[c]()
