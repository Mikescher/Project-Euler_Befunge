#!/usr/bin/env python3

# transpiled with BefunCompile v1.3.0 (c) 2017
import gzip, base64
_g = ("AR+LCAAAAAAABAC9jrFOxDAQRH9lsUODZdh1YomsrBV/ACWFlaNzu5WrfPzt5XQ6BFKUAjHVeLTzPB0+TQDg/0YAG+0f1KmSUmIOZK8aWioHWvibMyuOit/atRk2UFlS"
  + "1ZROfY9HdyvXwx/nhu2xug934/Owx5Ob4U5dUGUWdugqKgV27y6uwtgsiev68GVDS9zl3cVaxw6KGRUnIxXF6siVJYgnGHwBTtTiWp+P8RKRCkzYrnMSYHvK2ALnHB4t"
  + "6TKYwx7ejvFkSbjGVxvHkRpOl6kvIYPPan9MoUj2Q/ZlOYbbiDJio8gjKvjlNG/p8f5FZx340XggAwAA")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<80 and y<10):
        return g[y*80 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<80 and y<10):
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
    gw(2,1,1)
    gw(2,0,1)
    gw(3,0,1)
    gw(9,0,48)
    sa(0)
    sa(1)
    sa(1)
    sa(10)
    sa(-69)
    return 1
def _1():
    return (18)if(sp()!=0)else(2)
def _2():
    sa(49)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(0)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    return 3
def _3():
    gw(4,0,79)
    gw(5,0,0)
    return 4
def _4():
    global t0
    t0=(((gr(gr(4,0),0)-48)*gr(2,0))+gr(5,0))/10
    gw(gr(4,0),0,((((gr(gr(4,0),0)-48)*gr(2,0))+gr(5,0))%10)+48)
    gw(5,0,t0)
    t0=gr(4,0)-9
    gw(4,0,gr(4,0)-1)
    return 5
def _5():
    global t0
    return (4)if((t0)!=0)else(6)
def _6():
    global t0
    t0=gr(3,0)-1
    gw(3,0,gr(3,0)-1)

    return (3)if((t0)!=0)else(7)
def _7():
    sa(9)
    sa(gr(9,0)-48)
    return 8
def _8():
    return (9)if(sp()!=0)else(17)
def _9():
    global t0
    t0=80
    sa(t0)
    t0=0
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa(sp()-v0)


    return (14)if((sr()-gr(2,1))!=0)else(10)
def _10():
    global t0
    t0=10
    sp();
    sa(t0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa(sp()-v0)

    sa(sr());

    return (12)if(sp()!=0)else(11)
def _11():
    sp();
    sp();
    print(sp(),end=" ",flush=True)
    return 19
def _12():
    gw(2,2,sp())
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+gr(2,2))

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+1)

    sa(sr());
    sa(sr());
    gw(2,1,sp())
    gw(2,0,1)
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 13
def _13():
    gw(3,0,sp())
    gw(9,0,48)
    sa(10)
    sa(-69)
    return 1
def _14():
    sa((1)if(sp()>gr(2,1))else(0))


    return (15)if(sp()!=0)else(16)
def _15():
    sp();
    sa(10)
    sa(0)
    return 10
def _16():
    sa(sp()+1)

    sa(sr());
    sa(gr(2,1))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    gw(2,0,sp())
    return 13
def _17():
    sa(sp()+1)

    sa(sr());
    sa(0)
    v0=sp()
    sa(gr(sp(),v0))
    sa(sp()-48)
    return 8
def _18():
    sa(sr());
    sa(48)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(0)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sp()+1)

    sa(sr()-79)
    return 1
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18]
c=0
while c<19:
    c=m[c]()
