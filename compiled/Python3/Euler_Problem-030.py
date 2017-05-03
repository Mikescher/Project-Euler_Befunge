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
def _0():
    sa(0)
    sa(1)
    sa(1)
    sa(0)
    sa(5904)
    return 1
def _1():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+1);

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr());
    return 2
def _2():
    return (13)if(sp()!=0)else(3)
def _3():
    global t0
    sp();
    v0=sp()
    sa(sp()-v0)

    t0=sp()

    return (12)if((t0)!=0)else(4)
def _4():
    sa(sp()*59049);
    return 5
def _5():
    global t0
    global t1
    global t2
    global t3
    global t4
    global t5
    global t6
    global t7
    sa(sr());
    sa(sr());
    sa(tm(sr(),10))
    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa(sr());
    sa(sp()*sp());

    t0=sp()
    sa(sp()*t0);

    t1=sp()
    sa(td(sp(),10))

    sa(tm(sr(),10))
    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa(sr());
    sa(sp()*sp());

    t0=sp()
    sa(sp()*t0);

    t2=sp()
    sa(td(sp(),10))

    sa(tm(sr(),10))
    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa(sr());
    sa(sp()*sp());

    t0=sp()
    sa(sp()*t0);

    t3=sp()
    sa(td(sp(),10))

    sa(tm(sr(),10))
    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa(sr());
    sa(sp()*sp());

    t0=sp()
    sa(sp()*t0);

    t4=sp()
    sa(td(sp(),10))

    sa(tm(sr(),10))
    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa(sr());
    sa(sp()*sp());

    t0=sp()
    sa(sp()*t0);

    t5=sp()
    sa(td(sp(),10))

    sa(tm(sr(),10))
    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa(sr());
    sa(sp()*sp());

    t0=sp()
    sa(sp()*t0);

    t6=sp()
    sa(td(sp(),10))

    sa(tm(sp(),10))

    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa(sr());
    sa(sp()*sp());

    t0=sp()
    sa(sp()*t0);

    t7=sp()
    t0=t7+t6
    t6=t5+t0
    t0=t4+t6
    t4=t3+t0
    t0=t2+t4
    t2=t1+t0
    sa(sp()-t2);

    t0=sp()

    return (6)if((t0)!=0)else(11)
def _6():
    sa(sp()-1);

    sa(sr());
    sa((0)if(sp()!=0)else(1))

    return (7)if(sp()!=0)else(5)
def _7():
    sp();
    sp();
    return 8
def _8():
    sa(sp()+sp());

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr());

    return (9)if(sp()!=0)else(10)
def _9():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+sp());
    return 8
def _10():
    sp();
    print(sp(),end="",flush=True)
    return 14
def _11():
    sa(sr());
    return 6
def _12():
    sa(sp()+1);

    sa(sr());
    sa(sr()*59049)
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr());
    return 2
def _13():
    sa(td(sp(),10))
    return 1
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13]
c=0
while c<14:
    c=m[c]()
