#!/usr/bin/env python2

# transpiled with BefunCompile v1.2.0 (c) 2017
import sys
import zlib, base64
_g = ("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")
g = base64.b64decode(_g)[1:]
for i in range(ord(base64.b64decode(_g)[0])):
    g = zlib.decompress(g, 16+zlib.MAX_WBITS)
g=list(map(ord, g))
def gr(x,y):
    if(x>=0 and y>=0 and x<73 and y<1009):
        return g[y*73 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<73 and y<1009):
        g[y*73 + x]=v;
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
    gw(9,2,0)
    gw(9,0,1)
    gw(22,0,5)
    gw(24,0,10)
    gw(12,0,50)
    gw(3,0,100)
    gw(4,0,500)
    gw(13,0,1000)
    gw(10,1,gr(10,1)-48)
    sa(9)
    return 1
def _1():
    sa(sr());
    sa(sr());
    sa(1)
    v0=sp()
    sa(gr(sp(),v0))
    sa(sp()-48);

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sp()-1);

    sa(sr());
    return 2
def _2():
    return (1)if(sp()!=0)else(3)
def _3():
    gw(1,2,9)
    sp();
    sa(9)
    return 4
def _4():
    sa(0)
    sa(gr(0,gr(1,2))-32)
    return 5
def _5():
    return (13)if(sp()!=0)else(6)
def _6():
    sa(sr());
    gw(3,2,sp())
    sa(sp()-1);

    sa(sr());
    sa(gr(1,2))
    v0=sp()
    sa(gr(sp(),v0))
    sa(sp()-64);

    sa(0)
    v0=sp()
    sa(gr(sp(),v0))
    sa(sr());
    gw(4,2,sp())
    gw(2,2,sp())
    sa(sr());
    return 7
def _7():
    return (8)if(sp()!=0)else(11)
def _8():
    sa(sp()-1);

    sa(sr());
    sa(gr(1,2))
    v0=sp()
    sa(gr(sp(),v0))
    sa(sp()-64);

    sa(0)
    v0=sp()
    sa(gr(sp(),v0))
    sa(sr());

    return (9)if(sr()<gr(4,2))else(10)
def _9():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()*-1);

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 10
def _10():
    gw(4,2,sp())
    sa(sp()+gr(2,2));

    gw(2,2,sp())
    sa(sr());
    return 7
def _11():
    gw(9,2,(gr(3,2)-((td(gr(2,2),1000))+gr((td(tm(gr(2,2),1000),100))+1,1)+gr((tm(gr(2,2),10))+1,1)+gr((td(tm(gr(2,2),100),10))+1,1)))+gr(9,2))
    sp();
    sa(sp()+1);

    sa(sr());
    gw(1,2,sp())

    return (4)if(sr()!=1009)else(12)
def _12():
    sys.stdout.write(str(gr(9,2))+" ")
    sys.stdout.flush()

    sp();
    return 14
def _13():
    sa(sp()+1);

    sa(sr());
    sa(gr(1,2))
    v0=sp()
    sa(gr(sp(),v0))
    sa(sp()-32);
    return 5
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13]
c=0
while c<14:
    c=m[c]()
