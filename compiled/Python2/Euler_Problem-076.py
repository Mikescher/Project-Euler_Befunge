#!/usr/bin/env python2

# transpiled with BefunCompile v1.3.0 (c) 2017
import sys
import zlib, base64
_g = ("Ah+LCAAAAAAABACT7+ZgAAEWhre3HLMPOQi0PdxvZLqX92LstCUbPD5c2mz7TcAk47DTRokjz76XnzlZNVGhq/377rObftueqa2e6B+pd9Ro9snjif/v5vV/+rc7m3/S"
  + "/Gdn1/2duD0oz6c+++BkS7FalwIiwbsHNiZ7f21e2S2V9fXk1I+ldXVrJ0XsCHme+Kb+QtYnU851n0N59Ewj92+bd27q4U7TZ/o3s2R1nauLpdrSF8/1vpb9ZdYy7olT"
  + "f/k5F7WuTSsKua2XeSLbelVp3dZX9f8YrET1bz7QZmAAAOh0xyzxAAAA")
g = base64.b64decode(_g)[1:]
for i in range(ord(base64.b64decode(_g)[0])):
    g = zlib.decompress(g, 16+zlib.MAX_WBITS)
g=list(map(ord, g))
def gr(x,y):
    if(x>=0 and y>=0 and x<104 and y<108):
        return g[y*104 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<104 and y<108):
        g[y*104 + x]=v;
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
    gw(3,0,100)
    sa(1)
    sa((1)if(1>gr(3,0))else(0))
    return 1
def _1():
    return (9)if(sp()!=0)else(2)
def _2():
    sa(sr());
    gw(5,0,sp())
    gw(6,0,0)
    sa(1)
    sa(1-gr(5,0))
    return 3
def _3():
    return (4)if(sp()!=0)else(8)
def _4():
    global t0
    global t1
    t0=gr(5,0)
    sa(sr());
    sa(sr());
    sa(sr());
    sa(sr());
    sa(t0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa(sp()-v0)

    t1=sp()
    sa((1)if(sp()>t1)else(0))

    t0=sp()

    return (7)if((t0)!=0)else(5)
def _5():
    sa(sr()+3)
    return 6
def _6():
    global t0
    t0=gr(5,0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(t0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa(sp()-v0)

    sa(sp()+3)

    v0=sp()
    sa(gr(sp(),v0))
    sa(sp()+gr(6,0))

    sa(sr());
    gw(6,0,sp())
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+3)

    sa(gr(5,0)+3)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sp()+1)

    sa(sr()-gr(5,0))
    return 3
def _7():
    global t0
    t0=gr(5,0)
    sa(sr());
    sa(t0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa(sp()-v0)

    sa(sp()+3)
    return 6
def _8():
    sp();
    sa(sr());
    sa(gr(6,0)+1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+3)

    sa(sr());
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sp()+1)

    sa((1)if(sr()>gr(3,0))else(0))
    return 1
def _9():
    global t0
    sa(sp()+1)

    sa(sr()+1)
    v0=sp()
    t0=gr(sp(),v0)
    sys.stdout.write(str(t0)+" ")
    sys.stdout.flush()
    return 10
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9]
c=0
while c<10:
    c=m[c]()
