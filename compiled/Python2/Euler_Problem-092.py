#!/usr/bin/env python2

# transpiled with BefunCompile v1.1.0 (c) 2015
import sys
import zlib, base64
_g = ("AR+LCAAAAAAABADtkbFuxCAMhl/FASKdQGkMEbrGilC3vkCHq4SSbqxMTNd3r7ksvUo5tRJjPWAJ7N/fbwooBW8gQbYJ2KOh3uXSVq81379eA712UX5Rk62eJ/EuIKPx"
  + "3oJaDksDiFfxrGlyWXy600lorZ3L6DDjhJkL7EAYiav62UROY6bu+hfWzGrGUkJ3JrWsd9PrfoqEYz4IziUKzJc+ZNnoO0iiTq4bsdGhq292uHFVzUrNFs4xeUyRDtYW"
  + "MAby3vSkIxBLKGVtCRMmawDYfvCYlcNE14qfR54azdxz+kkcpt3xOvLGE3qT0S8Q1AvA7nhvKJYIBvvgQ26xbiu74IMXhBKShCcJSkK9vWtdQONDrS/WbUIrAAUAAA==")
g = base64.b64decode(_g)[1:]
for i in range(ord(base64.b64decode(_g)[0])):
    g = zlib.decompress(g, 16+zlib.MAX_WBITS)
g=list(map(ord, g))
def gr(x,y):
    if(x>=0 and y>=0 and x<80 and y<16):
        return g[y*80 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<80 and y<16):
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
    gw(3,2,568)
    gw(2,2,10000000)
    gw(2,0,0)
    gw(3,0,0)
    gw(79,7,0)
    sa(566)
    return 1
def _1():
    sa(sr());
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa((tm(sr(),71))+9)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),71))

    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());
    sa((0)if(sp()!=0)else(1))

    return (2)if(sp()!=0)else(20)
def _2():
    gw(10,0,1)
    gw(27,1,89)
    sp();
    sa(gr(2,2))
    sa(gr(2,2))
    sa((1)if(gr(2,2)>gr(3,2))else(0))
    return 3
def _3():
    return (6)if(sp()!=0)else(4)
def _4():
    sa(sr());
    sa((tm(sr(),71))+9)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),71))

    v0=sp()
    sa(gr(sp(),v0))
    sa(sr());
    sa((0)if(sp()!=0)else(1))

    return (5)if(sp()!=0)else(11)
def _5():
    sp();
    sa(sr());
    sa(7)
    sa(gr(2,0))
    gw(2,0,gr(2,0)+1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    return 6
def _6():
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(tm(sr(),10))
    sa(sr());
    sa(sp()*sp());

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr());
    return 7
def _7():
    return (10)if(sp()!=0)else(8)
def _8():
    sp();
    sp();
    return 9
def _9():
    sa((1)if(sr()>gr(3,2))else(0))
    return 3
def _10():
    gw(5,0,sp())
    sa(sp()+sp());

    sa((tm(td(gr(5,0),10),10))*(tm(td(gr(5,0),10),10)))
    sa(td(gr(5,0),10))
    sa(td(gr(5,0),10))
    return 7
def _11():
    return (12)if(sr()-89==0)else(18)
def _12():
    gw(3,0,gr(3,0)+1)
    return 13
def _13():
    gw(5,0,sp())
    sp();
    sa(gr(2,0))

    return (16)if((gr(2,0))!=0)else(14)
def _14():
    sp();
    sa(sp()-1);

    sa(sr());
    sa(sr());

    return (9)if(sp()!=0)else(15)
def _15():
    sys.stdout.write(str(gr(3,0)))
    sys.stdout.flush()

    sp();
    sp();
    return 21
def _16():
    sa(sp()-1);

    sa(sr());
    gw(2,0,sp())
    sa(7)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa(gr(sp(),v0))
    sa(gr(5,0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa((tm(sr(),71))+9)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),71))

    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(gr(2,0))
    return 17
def _17():
    return (16)if((gr(2,0))!=0)else(14)
def _18():
    return (19)if(sr()!=1)else(13)
def _19():
    sp();
    return 6
def _20():
    sa(sp()-1);
    return 1
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20]
c=0
while c<21:
    c=m[c]()
