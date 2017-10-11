#!/usr/bin/env python3

# transpiled with BefunCompile v1.2.0 (c) 2017
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
x0=4818
def _0():
    sa(1488)
    sa(1800)
    sa(1800)
    return 1
def _1():
    return (15)if((((tm(x0,10))+2)*((tm(td(x0,10),10))+2)*((tm(td(td(x0,10),10),10))+2)*((td(td(td(x0,10),10),10))+2))!=(((tm(x0+3330,10))+2)*((tm(td(x0+3330,10),10))+2)*((tm(td(td(x0+3330,10),10),10))+2)*((td(td(td(x0+3330,10),10),10))+2)))else(2)
def _2():
    global t0
    v0=sp()
    sa(sp()-v0)

    t0=sp()
    t0=(0)if(t0!=0)else(1)

    return (3)if((t0)!=0)else(15)
def _3():
    sa(sr());
    return 4
def _4():
    return (14)if(sr()>9999)else(5)
def _5():
    sa(sr());

    return (6)if(tm(sr(),2)==0)else(7)
def _6():
    global t0
    global t1
    global t2
    global t3
    global x0
    sp();
    sp();
    sa(sp()+1);

    sa(sr());
    sa(sr());
    t0=(tm(sr(),10))+2
    sa(td(sp(),10))

    t1=(tm(sr(),10))+2
    sa(td(sp(),10))

    t2=(tm(sr(),10))+2
    sa(td(sp(),10))

    sa(sp()+2);

    sa(t2)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()*sp());

    t3=sp()
    t2=t1*t3
    sa(t0*t2)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+3330);

    x0=sp()
    sa(sr());
    return 1
def _7():
    return (6)if(tm(sr(),3)==0)else(8)
def _8():
    global x0
    x0=sp()
    sa(7)
    sa((0)if(tm(x0,7)!=0)else(1))
    return 9
def _9():
    return (6)if(sp()!=0)else(10)
def _10():
    return (13)if(sr()>(td(x0,2)))else(11)
def _11():
    global t0
    global t1
    global x0
    global t2
    t0=sr()-2
    t1=x0
    t2=tm(t1,t0)

    return (12)if((t2)!=0)else(6)
def _12():
    global t0
    global x0
    sa(sp()+6);

    sa(sr());
    t0=x0
    sa(t0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa(tm(sp(),v0))

    sa((0)if(sp()!=0)else(1))
    return 9
def _13():
    sp();
    sa(sp()+3330);
    return 4
def _14():
    sp();
    sa(sr());
    print(sp(),end=" ",flush=True)
    print(chr(32),end="",flush=True)
    sa(sp()+3330);

    sa(sr());
    print(sp(),end=" ",flush=True)
    print(chr(32),end="",flush=True)
    sa(sp()+3330);

    print(sp(),end=" ",flush=True)
    return 16
def _15():
    global t0
    global t1
    global t2
    global t3
    global x0
    sp();
    sp();
    sa(sp()+1);

    sa(sr());
    sa(sr());
    t0=(tm(sr(),10))+2
    sa(td(sp(),10))

    t1=(tm(sr(),10))+2
    sa(td(sp(),10))

    t2=(tm(sr(),10))+2
    sa(td(sp(),10))

    sa(sp()+2);

    sa(t2)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()*sp());

    t3=sp()
    t2=t1*t3
    sa(t0*t2)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+3330);

    x0=sp()
    sa(sr());
    return 1
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15]
c=0
while c<16:
    c=m[c]()
