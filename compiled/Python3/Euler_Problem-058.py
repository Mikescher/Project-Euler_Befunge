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
x0=2
x1=1
x2=0
x3=35
x4=35
x5=35
x6=35
x7=35
x8=35
x9=35
def _0():
    sa(3)
    sa(3)
    sa(0)
    return 1
def _1():
    return (2)if(sp()!=0)else(8)
def _2():
    sp();
    return 3
def _3():
    global t0
    global x1
    global x2
    t0=x1+1
    x1=x1+1
    t0=(1)if(t0<(x2*10))else(0)

    return (4)if((t0)!=0)else(7)
def _4():
    global x0
    global x1
    sa(sp()+x0)


    return (5)if((x1%4)!=0)else(6)
def _5():
    sa(sr());
    sa((1)if(sr()<2)else(0))
    return 1
def _6():
    global x0
    x0=x0+2
    sa(sr());
    sa((1)if(sr()<2)else(0))
    return 1
def _7():
    global x1
    print((((x1-2)/4)*2)+3,end=" ",flush=True)
    sp();
    return 36
def _8():
    return (10)if(sr()!=2)else(9)
def _9():
    global x2
    sp();
    x2=x2+1
    return 3
def _10():
    return (11)if((sr()%2)!=0)else(2)
def _11():
    return (9)if(sr()<9)else(12)
def _12():
    return (13)if((sr()%3)!=0)else(2)
def _13():
    return (14)if((sr()%5)!=0)else(2)
def _14():
    global x4
    x4=1
    sa(-2)
    return 15
def _15():
    return (16)if(sp()!=0)else(9)
def _16():
    global t0
    global x4
    global x3
    global t1
    t0=x4+1
    x4=x4+1
    sa(sr());
    x3=sr()
    t1=0
    sa(sp()-1)
    return 17
def _17():
    return (18)if((sr()%2)!=0)else(35)
def _18():
    global x5
    global t1
    global x7
    global x3
    global x6
    global x8
    global t0
    global x9
    x5=t1
    x7=x3
    x6=sp()
    x8=t0
    x9=1
    sa(0)
    sa(x6)
    sa(x6)
    return 19
def _19():
    return (34)if(sp()!=0)else(20)
def _20():
    sp();
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 21
def _21():
    sa(sr());

    return (22)if(sp()!=0)else(25)
def _22():
    global x7
    global t0
    global x9
    global t1
    global x6
    global t2
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr());
    sa(sp()*sp());

    sa(tm(sp(),x7))

    t0=x9/2
    x9=x9/2
    t1=x6
    t2=td(t1,t0)
    t2=t2%2

    return (24)if((t2)!=0)else(23)
def _23():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()-1)
    return 21
def _24():
    global x8
    global x7
    sa(sp()*x8)

    sa(tm(sp(),x7))
    return 23
def _25():
    global x5
    sp();
    sa(x5)
    sa(x5)
    return 26
def _26():
    return (27)if(sp()!=0)else(33)
def _27():
    global t0
    global x3
    global t1
    global t2
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr());
    sa(sr());
    sa(sr());
    sa(sp()*sp());

    t0=sp()
    t0=tm(t0,x3)
    t0=t0-1
    t0=(0)if(t0!=0)else(1)
    t1=(1)if(sr()-1!=0)else(0)
    sa(sp()-x3)

    sa(sp()+1)

    sa((0)if(sp()!=0)else(1))
    sa((0)if(sp()!=0)else(1))
    sa(t1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+sp());

    t2=sp()
    t1=t0+t2
    t1=t1-3

    return (32)if((t1)!=0)else(28)
def _28():
    global x4
    sp();
    sp();
    sa(x4)
    sa(1)
    return 29
def _29():
    return (30)if(sp()!=0)else(31)
def _30():
    sp();
    sp();
    return 3
def _31():
    sa(sp()-3)
    return 15
def _32():
    global x3
    sa(sr());
    sa(sp()*sp());

    sa(tm(sp(),x3))

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()-1)

    sa(sr());
    return 26
def _33():
    global x4
    sp();
    sa(sp()-1)

    sa((0)if(sp()!=0)else(1))
    sa((0)if(sp()!=0)else(1))
    sa(x4)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 29
def _34():
    global x9
    x9=x9*2
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+1)

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()/2);

    sa(sr());
    return 19
def _35():
    global t1
    t1=t1+1
    sa(sp()/2);
    return 17
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27,_28,_29,_30,_31,_32,_33,_34,_35]
c=0
while c<36:
    c=m[c]()
