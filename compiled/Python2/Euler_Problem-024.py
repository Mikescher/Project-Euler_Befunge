#!/usr/bin/env python2

# transpiled with BefunCompile v1.2.0 (c) 2017
import sys
import zlib, base64
_g = ("AR+LCAAAAAAABACdUDGOAyEM/AqBrVgRMbtc7oKQdQ+xNlesREuFUvD4mCVpI+WmsEdG4xlcPZY1fF2+f67qY5De911bi/q5VtWC5VoAl/4hfgWoNKxHTU/SN9LgxHBc"
  + "j2lBmJEREi3IEXOj1plninDRbLeJLB89NhGuKApBirAckC2Q/07t6Ty9CTVhk9acvmuVfeTESOI7cnX89nTvUI93wsw9CsZwk4M5+cDSj2Y7CxlrBs7Fs3ix016LHxmn"
  + "DJSZlBHDbYgfFCr43OgBAAA=")
g = base64.b64decode(_g)[1:]
for i in range(ord(base64.b64decode(_g)[0])):
    g = zlib.decompress(g, 16+zlib.MAX_WBITS)
g=list(map(ord, g))
def gr(x,y):
    if(x>=0 and y>=0 and x<61 and y<8):
        return g[y*61 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<61 and y<8):
        g[y*61 + x]=v;
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
    gw(1,1,999999)
    gw(2,1,9)
    return 1
def _1():
    global t0
    t0=gr(2,1)

    return (3)if((gr(2,1)+1)!=0)else(2)
def _2():
    return 23
def _3():
    global t0
    return (11)if((t0)!=0)else(4)
def _4():
    sa(1)
    return 5
def _5():
    sa(1)
    sa(gr(1,0)-120)
    return 6
def _6():
    return (10)if(sp()!=0)else(7)
def _7():
    sa(sp()+1);

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr());

    return (9)if(sp()!=0)else(8)
def _8():
    global t0
    sp();
    sa(sp()-1);

    sa(sr());
    sa(0)
    v0=sp()
    t0=gr(sp(),v0)
    t0=t0-48
    sa(120)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(0)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sys.stdout.write(str(t0)+" ")
    sys.stdout.flush()

    gw(1,1,gr(1,1)-(gr(3,1)*(gr(4,1)-1)))
    gw(2,1,gr(2,1)-1)
    return 1
def _9():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr());
    sa(0)
    v0=sp()
    sa(gr(sp(),v0))
    sa(sp()-120);
    return 6
def _10():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()-1);

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 7
def _11():
    sa(0)
    sa(gr(2,1))
    sa(gr(2,1)-1)
    sa(gr(2,1)-1)
    return 12
def _12():
    return (22)if(sp()!=0)else(13)
def _13():
    sp();
    return 14
def _14():
    sa(sp()*sp());

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr());
    return 15
def _15():
    return (14)if(sp()!=0)else(16)
def _16():
    sp();
    sa(sr());

    return (17)if(sp()!=0)else(21)
def _17():
    gw(3,1,sp())
    gw(4,1,1)
    return 18
def _18():
    return (20)if((gr(3,1)*gr(4,1))<=gr(1,1))else(19)
def _19():
    sa(gr(4,1))
    return 5
def _20():
    gw(4,1,gr(4,1)+1)
    return 18
def _21():
    gw(3,1,1)
    gw(4,1,1)
    sp();
    return 18
def _22():
    sa(sr()-1)
    sa(sr());
    return 12
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22]
c=0
while c<23:
    c=m[c]()
