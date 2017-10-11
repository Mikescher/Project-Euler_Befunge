#!/usr/bin/env python2

# transpiled with BefunCompile v1.2.0 (c) 2017
import sys
import zlib, base64
_g = ("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"
  + "f/X69J3tvp75ve+Ot/4BlMC3uAsaAAA=")
g = base64.b64decode(_g)[1:]
for i in range(ord(base64.b64decode(_g)[0])):
    g = zlib.decompress(g, 16+zlib.MAX_WBITS)
g=list(map(ord, g))
def gr(x,y):
    if(x>=0 and y>=0 and x<59 and y<113):
        return g[y*59 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<59 and y<113):
        g[y*59 + x]=v;
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
    gw(1,0,5)
    gw(2,0,100)
    return 1
def _1():
    global t0
    gw(gr(1,0),gr(2,0),48)
    t0=gr(1,0)-1
    gw(1,0,gr(1,0)-1)

    return (15)if((t0)!=0)else(2)
def _2():
    global t0
    gw(1,0,5)
    t0=gr(2,0)-1
    gw(2,0,gr(2,0)-1)

    return (15)if((t0)!=0)else(3)
def _3():
    gw(1,0,55)
    gw(2,0,1)
    gw(3,0,0)
    gw(0,0,0)
    return 4
def _4():
    return (8)if(gr(gr(1,0),gr(2,0))-32==0)else(5)
def _5():
    gw(0,0,(gr(gr(1,0),gr(2,0))-48)+gr(0,0))
    gw(2,0,gr(2,0)+1)
    return 6
def _6():
    return (5)if(gr(gr(1,0),gr(2,0))!=32)else(7)
def _7():
    global t0
    t0=gr(0,0)
    gw(gr(1,0),gr(2,0),(tm(gr(0,0),10))+48)
    gw(2,0,1)
    gw(1,0,gr(1,0)-1)
    t0=td(t0,10)
    gw(0,0,t0)
    return 4
def _8():
    gw(1,0,0)
    gw(2,0,101)
    return 9
def _9():
    global t0
    sa(gr(1,0)+1)
    gw(1,0,gr(1,0)+1)
    sa(gr(2,0))
    v0=sp()
    t0=gr(sp(),v0)
    t0=t0-48
    t0=(0)if(t0!=0)else(1)
    return 10
def _10():
    global t0
    return (9)if((t0)!=0)else(11)
def _11():
    gw(0,0,10)
    return 12
def _12():
    global t0
    t0=gr(0,0)
    gw(0,0,gr(0,0)-1)
    t0=(0)if(t0!=0)else(1)

    return (13)if((t0)!=0)else(14)
def _13():
    return 16
def _14():
    sys.stdout.write(chr(gr((9-gr(0,0))+gr(1,0),gr(2,0))))
    sys.stdout.flush()
    return 12
def _15():
    return (3)if(sp()!=0)else(1)
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15]
c=0
while c<16:
    c=m[c]()
