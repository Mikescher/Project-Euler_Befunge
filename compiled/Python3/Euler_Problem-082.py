#!/usr/bin/env python3

# transpiled with BefunCompile v1.2.0 (c) 2017
import gzip, base64
_g = ("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")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<500 and y<180):
        return g[y*500 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<500 and y<180):
        g[y*500 + x]=v;
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
    gw(88,81,(gr(498,79)-48)+(((gr(497,79)-48)+(((gr(496,79)-48)+((gr(495,79)-48)*10))*10))*10))
    gw(88,179,252047376)
    sa(6398)
    return 1
def _1():
    global t0
    global t1
    global t2
    global t3
    global t4
    sa(sr());
    sa(sr());
    sa(sr());
    sa(sr());
    sa(((tm(sr(),80))*5)+103)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),80))

    v0=sp()
    t0=gr(sp(),v0)
    t0=t0-48
    sa(sr());
    sa(((tm(sr(),80))*5)+102)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),80))

    v0=sp()
    t1=gr(sp(),v0)
    t1=t1-48
    sa(sr());
    sa(((tm(sr(),80))*5)+101)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),80))

    v0=sp()
    t2=gr(sp(),v0)
    t2=t2-48
    sa(((tm(sr(),80))*5)+100)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),80))

    v0=sp()
    t3=gr(sp(),v0)
    t3=t3-48
    t3=t3*10
    t4=t2+t3
    t4=t4*10
    t2=t1+t4
    t2=t2*10
    sa(t0+t2)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa((tm(sr(),80))+9)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),80))

    sa(sp()+2);

    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(252047376)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa((tm(sr(),80))+9)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),80))

    sa(sp()+100);

    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());

    return (27)if(sp()!=0)else(2)
def _2():
    gw(9,179,gr(9,81))
    sp();
    sa(78)
    return 3
def _3():
    sa(sr());
    sa(sr());
    sa(9)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+2);

    v0=sp()
    sa(gr(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(9)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+100);

    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());

    return (26)if(sp()!=0)else(4)
def _4():
    gw(2,0,1)
    gw(3,0,0)
    gw(4,0,gr(gr(2,0)+8,gr(3,0)+100))
    sp();
    sa(1)
    return 5
def _5():
    sa(0)
    return 6
def _6():
    sa(gr(3,0))
    gw(5,0,gr(3,0))
    return 7
def _7():
    global t0
    global t1
    t0=gr(4,0)+gr(gr(2,0)+9,gr(5,0)+2)
    t1=gr(4,0)+gr(gr(2,0)+9,gr(5,0)+2)
    gw(4,0,gr(4,0)+gr(gr(2,0)+9,gr(5,0)+2))
    t1=(1)if(t1>gr(gr(2,0)+9,gr(5,0)+100))else(0)

    return (10)if((t1)!=0)else(8)
def _8():
    global t0
    gw(gr(2,0)+9,gr(5,0)+100,t0)
    sa(sp()+1);


    return (9)if(sr()!=80)else(10)
def _9():
    sa(sr());
    gw(5,0,sp())
    return 7
def _10():
    gw(4,0,gr(gr(2,0)+8,gr(3,0)+100))
    sp();
    return 11
def _11():
    sa(gr(3,0))
    gw(5,0,gr(3,0))
    return 12
def _12():
    global t0
    global t1
    t0=gr(4,0)+gr(gr(2,0)+9,gr(5,0)+2)
    t1=gr(4,0)+gr(gr(2,0)+9,gr(5,0)+2)
    gw(4,0,gr(4,0)+gr(gr(2,0)+9,gr(5,0)+2))
    t1=(1)if(t1>gr(gr(2,0)+9,gr(5,0)+100))else(0)

    return (14)if((t1)!=0)else(13)
def _13():
    global t0
    gw(gr(2,0)+9,gr(5,0)+100,t0)
    sa(sp()-1);


    return (25)if((sr()+1)!=0)else(14)
def _14():
    sp();
    sa(sp()+1);


    return (24)if(sr()!=80)else(15)
def _15():
    sp();
    sa(sp()+1);


    return (16)if(sr()!=80)else(17)
def _16():
    sa(sr());
    gw(2,0,sp())
    gw(3,0,0)
    gw(4,0,gr(gr(2,0)+8,gr(3,0)+100))
    return 5
def _17():
    gw(7,0,gr(88,179))
    sp();
    sa(78)
    sa(gr(88,178))
    sa((1)if(gr(88,178)<=gr(7,0))else(0))
    return 18
def _18():
    return (23)if(sp()!=0)else(19)
def _19():
    sp();
    return 20
def _20():
    sa(sr());

    return (22)if(sp()!=0)else(21)
def _21():
    print(gr(7,0),end=" ",flush=True)
    sp();
    return 28
def _22():
    sa(sp()-1);

    sa(sr());
    sa(88)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+100);

    v0=sp()
    sa(gr(sp(),v0))
    sa((1)if(sr()<=gr(7,0))else(0))
    return 18
def _23():
    gw(7,0,sp())
    return 20
def _24():
    sa(sr());
    gw(3,0,sp())
    gw(4,0,gr(gr(2,0)+8,gr(3,0)+100))
    return 6
def _25():
    sa(sr());
    gw(5,0,sp())
    return 12
def _26():
    sa(sp()-1);
    return 3
def _27():
    sa(sp()-1);
    return 1
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27]
c=0
while c<28:
    c=m[c]()
