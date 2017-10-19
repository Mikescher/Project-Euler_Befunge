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
x0=1000000
x1=0
x2=1
x3=0
x4=35
x5=35
x6=35
def _0():
    global x2
    sa(1)
    sa(2)
    sa(4+(x2*x2))
    sa((1)if(((4+(x2*x2))%64)>57)else(0))
    return 1
def _1():
    return (31)if(sp()!=0)else(2)
def _2():
    sa(sr()%16)

    return (3)if(sr()>9)else(15)
def _3():
    sp();
    return 4
def _4():
    sp();
    sa(0)
    return 5
def _5():
    return (11)if(sp()!=0)else(6)
def _6():
    sa(sr());

    return (10)if(sp()!=0)else(7)
def _7():
    global t0
    global x3
    global x1
    global x0
    t0=x3+x1
    x1=x3+x1
    t0=(1)if(t0>x0)else(0)
    sp();

    return (8)if((t0)!=0)else(9)
def _8():
    print(sp(),end=" ",flush=True)
    return 32
def _9():
    global x2
    global x3
    sa(sp()+1)

    sa(sr());
    x2=sr()
    x3=0
    sa(sp()*2)

    sa(sp()+1)

    sa(sp()-1)

    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa(sp()+(x2*x2))

    sa((1)if((sr()%64)>57)else(0))
    return 1
def _10():
    global x2
    sa(sp()-1)

    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa(sp()+(x2*x2))

    sa((1)if((sr()%64)>57)else(0))
    return 1
def _11():
    global x2
    return (14)if(sr()>x2)else(12)
def _12():
    global x3
    sa((sr()/2)+x3)
    return 13
def _13():
    global x3
    global t0
    x3=sp()
    t0=1
    return 6
def _14():
    global t0
    global t1
    global x2
    global x3
    t0=(sr()+1)/2
    t1=x2
    sa((t1-t0)+1+x3)
    return 13
def _15():
    return (16)if(sr()!=2)else(3)
def _16():
    return (17)if(sr()!=3)else(3)
def _17():
    return (18)if(sr()!=5)else(3)
def _18():
    return (19)if(sr()!=6)else(3)
def _19():
    return (20)if(sr()!=7)else(3)
def _20():
    sa(sp()-8)


    return (21)if(sp()!=0)else(31)
def _21():
    sa(sr()%10)

    return (22)if(sr()!=7)else(3)
def _22():
    return (23)if(sr()!=3)else(3)
def _23():
    sa(sp()-2)


    return (25)if(sp()!=0)else(24)
def _24():
    sa(0)
    return 3
def _25():
    return (26)if((sr()%3)!=2)else(4)
def _26():
    global x4
    global x5
    x4=0
    x5=sr()
    return 27
def _27():
    global x6
    global t0
    global x5
    global t1
    x6=sr()
    t0=x5
    sa(sr());
    sa(t0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa(td(sp(),v0))

    t1=sp()
    sa(sp()+t1)

    sa(sp()/2);


    return (29)if((sr()-x6)!=0)else(28)
def _28():
    global x6
    global x5
    sp();
    sa((0)if((x6*x6)-x5!=0)else(1))
    return 5
def _29():
    global x4
    return (30)if((sr()-x4)!=0)else(28)
def _30():
    global x4
    global x6
    x4=x6
    return 27
def _31():
    global t0
    t0=2
    return 4
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27,_28,_29,_30,_31]
c=0
while c<32:
    c=m[c]()
