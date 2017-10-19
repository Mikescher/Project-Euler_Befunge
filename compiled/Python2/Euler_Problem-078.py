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
    if(x>=0 and y>=0 and x<251 and y<256):
        return g[y*251 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<251 and y<256):
        g[y*251 + x]=v;
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
    gw(2,0,1000000)
    gw(1,0,250)
    gw(1,1,1)
    gw(4,0,1)
    sa(1)
    return 1
def _1():
    gw(5,0,0)
    gw(6,0,0)
    sa(0)
    sa(1)
    sa((1)if(1>gr(4,0))else(0))
    return 2
def _2():
    return (3)if(sp()!=0)else(6)
def _3():
    global t0
    t0=tm(gr(5,0),gr(2,0))
    sp();
    sp();

    return (5)if((tm(gr(5,0),gr(2,0)))!=0)else(4)
def _4():
    sys.stdout.write(str(sp())+" ")
    sys.stdout.flush()
    return 7
def _5():
    global t0
    gw((tm(gr(4,0),gr(1,0)))+1,(td(gr(4,0),gr(1,0)))+1,t0)
    sa(sp()+1)

    sa(sr());
    gw(4,0,sp())
    return 1
def _6():
    global t0
    global t1
    global t2
    t0=gr(4,0)
    sa(t0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa(sp()-v0)

    sa((tm(sr(),gr(1,0)))+1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(1,0)))

    sa(sp()+1)

    v0=sp()
    t0=gr(sp(),v0)
    t0=t0*((((gr(6,0)/2)%2)*2)-1)
    t1=gr(5,0)
    t2=t1-t0
    gw(5,0,t2)
    sa(sp()+1)

    sa(sr());
    gw(6,0,sp())
    sa(sr());
    sa((sr()/2)+1)
    sa(sr());
    sa(sp()*sp());

    t0=sp()
    t0=t0*3
    t1=(sr()/2)+1
    sa(sp()%2);

    sa(sp()*2)

    sa(sp()-1)

    sa(t1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()*sp());

    t2=sp()
    sa((t0+t2)/2)
    sa((1)if(sr()>gr(4,0))else(0))
    return 2
m=[_0,_1,_2,_3,_4,_5,_6]
c=0
while c<7:
    c=m[c]()
