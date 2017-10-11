#!/usr/bin/env python2

# transpiled with BefunCompile v1.2.0 (c) 2017
import sys
import zlib, base64
_g = ("AR+LCAAAAAAABACtkbEKwyAQhl9FNC6RNKdBSI8gnQrtE2QQU+jg6uQU8uzV0rRTBou3nAf63fdjnOeZsCpFKqJyVUTVKbMf6JNGQpaY4Y/2rHEqRUVBbxudbCJ9HxvU"
  + "WvC12Ep2CBbplfK4zyt2kpBiqxVDnzhWaDJdTl42TDXFkI9VI8exVQEUBAnBwACBbncqsh6+bbWwqfVegm8VeJHj9/GIp2RIH5Czud3pp8tTQxtgEB4G5ELrtPjI3KU7"
  + "i2MPLw0jjqk0/pHyBanoFos5AwAA")
g = base64.b64decode(_g)[1:]
for i in range(ord(base64.b64decode(_g)[0])):
    g = zlib.decompress(g, 16+zlib.MAX_WBITS)
g=list(map(ord, g))
def gr(x,y):
    if(x>=0 and y>=0 and x<75 and y<11):
        return g[y*75 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<75 and y<11):
        g[y*75 + x]=v;
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
    gw(63,2,0)
    sa(99)
    sa(99)
    sa(99)
    return 1
def _1():
    sa(197)
    return 2
def _2():
    sa(sr());
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa((tm(sr(),70))+5)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),70))

    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());

    return (18)if(sp()!=0)else(3)
def _3():
    gw(64,2,1)
    gw(2,0,0)
    sp();
    gw(1,0,sp())
    return 4
def _4():
    gw(3,0,0)
    sa(199)
    sa(199)
    sa((gr(64,2)*gr(1,0))+gr(2,0))
    gw(2,0,td((gr(64,2)*gr(1,0))+gr(2,0),10))
    return 5
def _5():
    global t0
    sa(tm(sp(),10))

    t0=sr()+gr(3,0)
    gw(3,0,t0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa((tm(sr(),70))+5)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),70))

    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());

    return (17)if(sp()!=0)else(6)
def _6():
    sp();

    return (16)if(gr(3,0)>gr(2,1))else(7)
def _7():
    sa(sp()-1);

    sa(sr());

    return (4)if(sp()!=0)else(8)
def _8():
    sp();
    return 9
def _9():
    sa(sp()-1);

    sa(sr());
    return 10
def _10():
    return (12)if(sp()!=0)else(11)
def _11():
    sys.stdout.write(str(gr(2,1))+" ")
    sys.stdout.flush()

    sp();
    return 19
def _12():
    return (14)if(tm(sr(),10)!=0)else(13)
def _13():
    sa(sp()-1);

    sa(sr());
    return 10
def _14():
    return (15)if(sr()>45)else(9)
def _15():
    gw(63,2,0)
    sa(sr());
    sa(99)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 1
def _16():
    gw(2,1,gr(3,0))
    return 7
def _17():
    global t0
    sa(sp()-1);

    sa(sr());
    sa(sr());
    sa((tm(sr(),70))+5)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),70))

    v0=sp()
    sa(gr(sp(),v0))
    sa(sp()*gr(1,0));

    sa(sp()+gr(2,0));

    t0=td(sr(),10)
    gw(2,0,t0)
    return 5
def _18():
    sa(sp()-1);
    return 2
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18]
c=0
while c<19:
    c=m[c]()
