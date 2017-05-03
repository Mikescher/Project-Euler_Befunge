#!/usr/bin/env python2

# transpiled with BefunCompile v1.1.0 (c) 2015
import sys
import zlib, base64
_g = ("AR+LCAAAAAAABADNUjFuwzAM/ApLKUsIJRTtDBEMolNXfyBwhg5aNXny40s3TlI0bge1BXqDcKQE8njiCN57MLjfAfwV/rG+8SETYldZS/EFNR0JGU9cFiIlTbXa8BUL"
  + "t1wE+2gMe0ZL+1p9H5T6eO/yvOtGlmBiC2duUhY75zBzKhZ3XzuiKYZmk56mC6dmL1tzlDRvqeVM6XCgjVWihrMUC/btbExYd0RvTqkEN5zjwhnKenvs0brZXvjV6wnU"
  + "gSNwEVwCF4yIg+HbPdL3B+vzfu6ip3E+LuNXQHlZGMnmUbDp1WpFoJ988HAlIZ5tlOplNrwBk9ih3GAEAAA=")
g = base64.b64decode(_g)[1:]
for i in range(ord(base64.b64decode(_g)[0])):
    g = zlib.decompress(g, 16+zlib.MAX_WBITS)
g=list(map(ord, g))
def gr(x,y):
    if(x>=0 and y>=0 and x<80 and y<14):
        return g[y*80 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<80 and y<14):
        g[y*80 + x]=v;
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
    gw(79,0,48)
    gw(79,2,48)
    sa(69)
    return 1
def _1():
    sa(sr()+9)
    sa(48)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(0)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr()+9)
    sa(48)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(2)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());

    return (23)if(sp()!=0)else(2)
def _2():
    gw(79,0,48)
    gw(79,2,49)
    gw(4,0,0)
    sp();
    sa(99)
    return 3
def _3():
    sa(tm(sr()-1,3))
    sa(sr());
    sa((0)if(sp()!=0)else(1))

    return (22)if(sp()!=0)else(4)
def _4():
    sa(sp()-2);


    return (21)if(sp()!=0)else(5)
def _5():
    gw(2,0,1)
    gw(3,0,79)
    return 6
def _6():
    sa(79)
    sa(gr(79,0)-48)
    return 7
def _7():
    global t0
    global t1
    t0=gr(gr(3,0),2)
    gw(gr(3,0),0,gr(gr(3,0),2))
    t0=t0-48
    t0=t0*gr(2,0)
    sa(sp()+t0);

    t1=sp()
    t1=t1+gr(4,0)
    t0=(tm(t1,10))+48
    gw(gr(3,0),2,t0)
    t1=td(t1,10)
    gw(4,0,t1)

    return (20)if(sr()!=9)else(8)
def _8():
    sp();
    sa(sp()-1);


    return (9)if((sr()+1)!=0)else(11)
def _9():
    sa(sr());

    return (3)if(sp()!=0)else(10)
def _10():
    gw(2,0,2)
    gw(3,0,79)
    return 6
def _11():
    sp();
    sa(0)
    sa(70)
    sa(gr(79,2)-48)
    sa(gr(79,2)-48)
    return 12
def _12():
    return (13)if(sp()!=0)else(19)
def _13():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 14
def _14():
    sa(sr());
    sa((0)if(sp()!=0)else(1))

    return (15)if(sp()!=0)else(18)
def _15():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr());
    sa((0)if(sp()!=0)else(1))

    return (17)if(sp()!=0)else(16)
def _16():
    sa(sp()+sp());
    return 15
def _17():
    global t0
    sa(sp()+sp());

    t0=sp()
    sys.stdout.write(str(t0))
    sys.stdout.flush()
    return 24
def _18():
    sa(sp()-1);

    sa(sr()+9)
    sa(2)
    v0=sp()
    sa(gr(sp(),v0))
    sa(sp()-48);

    sa(sr());
    return 12
def _19():
    return (18)if(sp()!=0)else(14)
def _20():
    sa(sp()-1);

    sa(sr());
    gw(3,0,sp())
    sa(sr());
    sa(0)
    v0=sp()
    sa(gr(sp(),v0))
    sa(sp()-48);
    return 7
def _21():
    global t0
    t0=(td(sr()+1,3))*2
    gw(2,0,t0)
    gw(3,0,79)
    return 6
def _22():
    gw(2,0,1)
    gw(3,0,79)
    sp();
    return 6
def _23():
    sa(sp()-1);
    return 1
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23]
c=0
while c<24:
    c=m[c]()
