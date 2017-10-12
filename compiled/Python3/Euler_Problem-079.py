#!/usr/bin/env python3

# transpiled with BefunCompile v1.2.0 (c) 2017
import gzip, base64
_g = ("AR+LCAAAAAAABAC1Uctu4zAM/BWmzl6iGiWlmnrAEPYz9hA4R1110ikfX1JKnaLppQGWhkVqwOGQVIMnzewGjiJwQCD5OYq3crcInq3gsXtH4ZHHATxJnuaKZ+GRYMQ4"
  + "eMTgHT3wvBNcch0N33+twxFs1Fqjn8c+A7igGhbszXvBRi2pEfFHXhDc9Rl0Ftx1XcCB2dB7/c57dp/Tbr/jPav3b7f/qPek5WUxOdE5tZwkfCPjsGr05/3EbIzFihYL"
  + "ClzKC77MacHK3JR7TTPVFRoV9FiNOj3Y3uNlxDziFfpQ+Qjen7ZsFixkqpDFsRytrffOvoQVvizjep4p9apLLy3KK10PiiqrQjSGGSqu4OW7WTN5guMEOEHsZ9VgzUmH"
  + "9GXaLpAilkQmbqJW9/0oOh+mdkmp50bp9czLCMrpIMyU2kg2gJ+8rfY2zlDQ6prGrYhbWDZa+j3dZmSwD+9yxHzT43AyDbI+g70/g2yct7vep/09XrbpMBeMydCrLHGr"
  + "XqUqcpqFWAo6Wdv6AUItDRCYBAAA")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<56 and y<21):
        return g[y*56 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<56 and y<21):
        g[y*56 + x]=v;
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
    gw(10,10,1)
    sa(9)
    return 1
def _1():
    sa(sr());
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr());
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sp()-1);

    sa(sr());
    return 2
def _2():
    return (1)if(sp()!=0)else(3)
def _3():
    gw(3,0,5)
    gw(2,0,48)
    sp();
    sa(49)
    return 4
def _4():
    sa(0)
    sa(gr(gr(2,0),gr(3,0))-48)
    gw(5,0,gr(gr(2,0),gr(3,0))-48)
    sa(sp()+12);

    sa(7)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(0)
    sa(gr(gr(2,0)+1,gr(3,0))-48)
    gw(6,0,gr(gr(2,0)+1,gr(3,0))-48)
    sa(sp()+12);

    sa(7)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(0)
    sa(gr(gr(2,0)+2,gr(3,0))-48)
    gw(7,0,gr(gr(2,0)+2,gr(3,0))-48)
    sa(sp()+12);

    sa(7)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    gw(gr(5,0)+1,gr(6,0)+1,2)
    gw(gr(5,0)+1,gr(7,0)+1,2)
    gw(gr(6,0)+1,gr(7,0)+1,2)
    gw(gr(7,0)+1,gr(5,0)+1,0)
    gw(gr(7,0)+1,gr(6,0)+1,0)
    gw(gr(6,0)+1,gr(5,0)+1,0)
    sa(sr()-1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)

    return (18)if(sp()!=0)else(5)
def _5():
    gw(9,0,0)
    sp();
    sa(9)
    sa(gr(21,7))
    return 6
def _6():
    return (7)if(sp()!=0)else(17)
def _7():
    sa(sr()-1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa((0)if(sp()!=0)else(1))

    return (9)if(sp()!=0)else(8)
def _8():
    sa(sr()+12)
    sa(7)
    v0=sp()
    sa(gr(sp(),v0))
    return 6
def _9():
    sa(sp()+1);
    return 10
def _10():
    return (13)if(sr()-gr(9,0)==0)else(11)
def _11():
    global t0
    global t1
    sa(sr());
    sa(sr());
    sa(sr()+12)
    sa(9)
    v0=sp()
    sa(gr(sp(),v0))
    sa(sp()+1);

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+11);

    sa(9)
    v0=sp()
    sa(gr(sp(),v0))
    sa(sp()+1);

    v0=sp()
    t0=gr(sp(),v0)
    sa(sp()*t0);

    t1=sp()
    t1=(0)if(t1!=0)else(1)

    return (9)if((t1)!=0)else(12)
def _12():
    global t0
    sa(sr());
    sa(sr());
    sa(sr()+12)
    sa(9)
    v0=sp()
    t0=gr(sp(),v0)
    gw(2,0,t0)
    sa(sp()+11);

    sa(9)
    v0=sp()
    sa(gr(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+12);

    sa(9)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sp()-1);

    sa(sr());
    sa(gr(2,0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+12);

    sa(9)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    return 10
def _13():
    print(chr(gr(12,9)+48),end="",flush=True)
    sp();
    sa(1)
    sa((0)if(1-gr(9,0)!=0)else(1))
    return 14
def _14():
    return (15)if(sp()!=0)else(16)
def _15():
    sp();
    return 19
def _16():
    global t0
    sa(sr()+12)
    sa(9)
    v0=sp()
    t0=gr(sp(),v0)
    t0=t0+48
    print(chr(t0),end="",flush=True)
    sa(sp()+1);

    sa((0)if(sr()-gr(9,0)!=0)else(1))
    return 14
def _17():
    sa(sr());
    sa(gr(9,0))
    gw(9,0,gr(9,0)+1)
    sa(sp()+12);

    sa(9)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    return 7
def _18():
    global t0
    t0=(td(sr(),10))+1
    gw(3,0,t0)
    t0=((tm(sr(),10))*4)+12
    gw(2,0,t0)
    return 4
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18]
c=0
while c<19:
    c=m[c]()
