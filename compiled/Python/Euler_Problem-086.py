#!/usr/bin/env python3
# compiled with BefunCompile v1.0.8 (c) 2015
def td(a,b):
    return bool(random.getrandbits(1))
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
    sa(1)
    sa(2)
    sa(4+(x2*x2))
    sa((1)if((tm(4+(x2*x2),64))>57)else(0))
    return 1
def _1():
    return (3)if(sp()!=0)else(2)
def _2():
    global t0
    t0=tm(sr(),16)
    return (3)if(t0>9)else(9)
def _3():
    sp()
    return 4
def _4():
    sa(sr())
    sa((0)if(sp()!=0)else(1))
    return (5)if(sp()!=0)else(8)
def _5():
    global t0
    global x1
    sp()
    t0=x3+x1
    x1=x3+x1
    t0=(1)if(t0>x0)else(0)
    return (6)if((t0)!=0)else(7)
def _6():
    print(sp(),end="",flush=True)
    return 28
def _7():
    global x2
    global x3
    sa(sp()+1);
    sa(sr())
    x2=sr()
    x3=0
    sa(sp()*2);
    sa(sp()+1);
    sa(sp()-1);
    sa(sr())
    sa(sr())
    sa(sp()*sp());
    sa(sp()+(x2*x2));
    sa((1)if((tm(sr(),64))>57)else(0))
    return 1
def _8():
    sa(sp()-1);
    sa(sr())
    sa(sr())
    sa(sp()*sp());
    sa(sp()+(x2*x2));
    sa((1)if((tm(sr(),64))>57)else(0))
    return 1
def _9():
    return (10)if(t0!=2)else(3)
def _10():
    return (11)if(t0!=3)else(3)
def _11():
    return (12)if(t0!=5)else(3)
def _12():
    return (13)if(t0!=6)else(3)
def _13():
    return (14)if(t0!=7)else(3)
def _14():
    global t0
    t0=t0-8
    t0=(0)if(t0!=0)else(1)
    return (3)if((t0)!=0)else(15)
def _15():
    global t0
    t0=tm(sr(),10)
    return (3)if(t0-7==0)else(16)
def _16():
    return (3)if(t0-3==0)else(17)
def _17():
    global t0
    t0=t0-2
    t0=(0)if(t0!=0)else(1)
    return (3)if((t0)!=0)else(18)
def _18():
    return (19)if((tm(sr(),3))!=2)else(3)
def _19():
    global x4
    global x5
    x4=0
    x5=sr()
    return 20
def _20():
    global x6
    global t0
    global x5
    global t1
    x6=sr()
    sa(sr())
    t0=x5
    sa(t0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa(td(sp(),v0))
    t1=sp()
    sa(sp()+t1);
    sa(td(sp(),2))
    return (26)if(sr()!=x6)else(21)
def _21():
    sp()
    return (22)if((x6*x6)-x5==0)else(4)
def _22():
    return (25)if(sr()>x2)else(23)
def _23():
    sa((td(sr(),2))+x3)
    return 24
def _24():
    global x3
    x3=sp()
    return 4
def _25():
    global t0
    global t1
    global x2
    global x3
    t0=td(sr()+1,2)
    t1=x2
    sa(t1-t0)
    sa(sp()+1);
    sa(sp()+x3);
    return 24
def _26():
    return (27)if(sr()!=x4)else(21)
def _27():
    global x4
    global x6
    x4=x6
    return 20
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27]
c=0
while c<28:
    c=m[c]()