#!/usr/bin/env python3

# transpiled with BefunCompile v1.3.0 (c) 2017
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
x0=9990
def _0():
    global x0
    sa(0)
    sa(0)
    sa(999)
    sa(9+x0)
    sa(99)
    sa(99)
    return 1
def _1():
    return (2)if(sp()!=0)else(3)
def _2():
    global x0
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()*10)

    x0=sp()
    sa((sr()%10)+x0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()/10);

    sa(sr());
    return 1
def _3():
    global x0
    x0=0
    sp();
    sa(sr());
    sa(sr());
    return 4
def _4():
    global t0
    global x0
    t0=(sr()%2)+x0
    sa(sp()/2);

    sa(sr());

    return (25)if(sp()!=0)else(5)
def _5():
    global t0
    global t1
    sp();
    sa(sp()-t0)

    t1=sp()

    return (6)if((t1)!=0)else(24)
def _6():
    sp();
    return 7
def _7():
    sa(sp()-1)

    sa(sr());

    return (8)if(sp()!=0)else(9)
def _8():
    global t0
    global x0
    sa(sr());
    t0=sr()*10
    x0=t0
    sa((sr()%10)+x0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()/10);

    sa(sr());
    return 1
def _9():
    global x0
    x0=990
    sa(999)
    sa(9+x0)
    sa(99)
    sa(99)
    return 10
def _10():
    return (11)if(sp()!=0)else(12)
def _11():
    global x0
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()*10)

    x0=sp()
    sa((sr()%10)+x0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()/10);

    sa(sr());
    return 10
def _12():
    global x0
    x0=0
    sp();
    sa(sr());
    sa(sr());
    return 13
def _13():
    global t0
    global x0
    t0=(sr()%2)+x0
    sa(sp()/2);

    sa(sr());

    return (23)if(sp()!=0)else(14)
def _14():
    global t0
    global t1
    sp();
    sa(sp()-t0)

    t1=sp()

    return (15)if((t1)!=0)else(22)
def _15():
    sp();
    return 16
def _16():
    sa(sp()-1)

    sa(sr());

    return (17)if(sp()!=0)else(18)
def _17():
    global t0
    global x0
    sa(sr());
    t0=(sr()/10)*10
    x0=t0
    sa((sr()%10)+x0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()/10);

    sa(sr());
    return 10
def _18():
    print(" =",end="",flush=True)
    return 19
def _19():
    global t0
    sa(sp()+sp());

    t0=sp()
    sa(sr());

    return (20)if(sp()!=0)else(21)
def _20():
    global t0
    sa(sp()+t0)
    return 19
def _21():
    global t0
    global t1
    sa(t0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+sp());

    t1=sp()
    print(t1,end=" ",flush=True)
    return 26
def _22():
    sa(sr());
    print(sp(),end=" ",flush=True)
    print(chr(10),end="",flush=True)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 16
def _23():
    global t0
    global x0
    t0=t0*2
    x0=t0
    return 13
def _24():
    sa(sr());
    print(sp(),end=" ",flush=True)
    print(chr(10),end="",flush=True)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 7
def _25():
    global t0
    global x0
    t0=t0*2
    x0=t0
    return 4
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25]
c=0
while c<26:
    c=m[c]()
