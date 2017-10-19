#!/usr/bin/env python2

# transpiled with BefunCompile v1.3.0 (c) 2017
import sys
import zlib, base64
_g = ("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")
g = base64.b64decode(_g)[1:]
for i in range(ord(base64.b64decode(_g)[0])):
    g = zlib.decompress(g, 16+zlib.MAX_WBITS)
g=list(map(ord, g))
def gr(x,y):
    if(x>=0 and y>=0 and x<1000 and y<1018):
        return g[y*1000 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<1000 and y<1018):
        g[y*1000 + x]=v;
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
    global t0
    gw(5,0,1)
    t0=gr(5,0)
    gw(5,0,gr(5,0)+gr(5,0))
    gw(0,1,t0)
    sa(1)
    return 1
def _1():
    return (2)if(sr()!=62)else(3)
def _2():
    sa(sr());
    sa(gr(5,0))
    gw(5,0,gr(5,0)+gr(5,0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sp()+1)
    return 1
def _3():
    gw(2,0,8)
    gw(1,0,1000)
    gw(3,0,8000)
    gw(4,0,0)
    sp();
    sa(2)
    sa(gr(tm(2,gr(1,0)),(td(2,gr(1,0)))+2)-32)
    return 4
def _4():
    return (24)if(sp()!=0)else(5)
def _5():
    sa(sp()+1)

    sa(sr());
    sa(sr());

    return (23)if((sr()-gr(3,0))!=0)else(6)
def _6():
    gw(2,0,999)
    sp();
    sp();
    sp();
    sa((999*gr(1,0))-1)
    sa(0)
    sa((999*gr(1,0))-1)
    sa((999*gr(1,0))-1)
    gw(3,0,999*gr(1,0))
    gw(8,0,909)
    gw(5,0,0)
    return 7
def _7():
    sa(tm(sp(),gr(1,0)))

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(1,0)))

    sa(sp()+3)

    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sp()-1)


    return (8)if(sr()!=-1)else(9)
def _8():
    sa(sr());
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr());
    return 7
def _9():
    gw(9,0,50000000)
    gw(6,0,gr(0,2)*gr(0,2))
    sp();
    sa(0)
    return 10
def _10():
    sa(0)
    sa((1)if(0<gr(8,0))else(0))
    return 11
def _11():
    return (15)if(sp()!=0)else(12)
def _12():
    sp();
    sa(sp()+1)


    return (13)if((sr()-gr(8,0))!=0)else(14)
def _13():
    global t0
    sa(sr());
    sa(2)
    v0=sp()
    sa(gr(sp(),v0))
    sa(sr());
    sa(sp()*sp());

    t0=sp()
    gw(6,0,t0)
    return 10
def _14():
    sys.stdout.write(str(gr(5,0))+" ")
    sys.stdout.flush()

    sp();
    return 28
def _15():
    global t0
    sa(sr());
    sa(2)
    v0=sp()
    sa(gr(sp(),v0))
    sa(sr());
    sa(sr());
    sa(sp()*sp());

    t0=sp()
    sa(sp()*t0)

    sa(sp()+gr(6,0))

    sa(sr());
    gw(7,0,sp())
    sa((1)if(sp()>gr(9,0))else(0))


    return (12)if(sp()!=0)else(16)
def _16():
    sa(0)
    sa((1)if(0<gr(8,0))else(0))
    return 17
def _17():
    return (18)if(sp()!=0)else(22)
def _18():
    sa(sr());
    sa(2)
    v0=sp()
    sa(gr(sp(),v0))
    sa(sr());
    sa(sp()*sp());

    sa(sr());
    sa(sp()*sp());

    sa(sp()+gr(7,0))


    return (22)if(sr()>gr(9,0))else(19)
def _19():
    global t0
    global t1
    global t2
    sa(sr());
    sa(sr());
    sa(sr()/60)
    sa(tm(sr(),gr(1,0)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(1,0)))

    sa(sp()+3)

    v0=sp()
    t0=gr(sp(),v0)
    sa(sp()%60);

    sa(sp()+1)

    sa(1)
    v0=sp()
    t1=gr(sp(),v0)
    t2=tm(t0,t1)
    sa(sp()%60);

    sa(1)
    v0=sp()
    t0=gr(sp(),v0)
    t1=td(t2,t0)

    return (21)if((t1)!=0)else(20)
def _20():
    global t0
    global t1
    sa(sr());
    sa(sr()/60)
    sa(tm(sr(),gr(1,0)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(1,0)))

    sa(sp()+3)

    v0=sp()
    t0=gr(sp(),v0)
    sa(sp()%60);

    sa(1)
    v0=sp()
    t1=gr(sp(),v0)
    sa(t0+t1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()/60);

    sa(tm(sr(),gr(1,0)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(1,0)))

    sa(sp()+3)

    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    gw(5,0,gr(5,0)+1)
    sa(0)
    return 21
def _21():
    sp();
    sa(sp()+1)

    sa((1)if(sr()<gr(8,0))else(0))
    return 17
def _22():
    sp();
    sp();
    sa(sp()+1)

    sa((1)if(sr()<gr(8,0))else(0))
    return 11
def _23():
    sa(tm(sp(),gr(1,0)))

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(1,0)))

    sa(sp()+2)

    v0=sp()
    sa(gr(sp(),v0))
    sa(sp()-32)
    return 4
def _24():
    sa(sr());
    sa(88)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(tm(sr(),gr(1,0)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(1,0)))

    sa(sp()+2)

    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());
    sa(gr(4,0))
    sa(gr(4,0))
    gw(4,0,gr(4,0)+1)
    sa(tm(sp(),gr(1,0)))

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(1,0)))

    sa(sp()+2)

    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());
    sa(sr());
    sa(sr());
    gw(5,0,sp())
    sa(sp()+sp());
    return 25
def _25():
    return (26)if(sr()<gr(3,0))else(27)
def _26():
    sa(sr());
    sa(32)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(tm(sr(),gr(1,0)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(1,0)))

    sa(sp()+2)

    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sp()+gr(5,0))
    return 25
def _27():
    sp();
    return 5
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27]
c=0
while c<28:
    c=m[c]()
